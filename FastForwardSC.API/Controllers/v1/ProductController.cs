using Microsoft.AspNetCore.Mvc;
using Shared.Models;
using Shared.Services;

namespace FastForwardSC.API.Controllers.v1
{
    [ApiController]
    [Route("api/v1/[controller]/")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;
        private readonly ILogger<ProductController> _logger;

        public ProductController(
            IProductService productService,
            ILogger<ProductController> logger)
        {
            this.productService = productService;
            _logger = logger;
        }

        [HttpGet("product/{productId}")]
        public async Task<ActionResult<ProductDto>> SearchProductAsync(string productId)
        {
            var Product = await this.productService.SearchProduct(Guid.Parse(productId));
            if (Product == null)
            {
                return NotFound();
            }
            return this.Ok(productId);
        }

        [HttpPost("product")]
        public async Task<ActionResult<ProductDto>> CreateProductAsync(ProductDto product)
        {
            try
            {
                var createdProduct = await this.productService.CreateProduct(product);
                return this.Ok(createdProduct);
            }catch(Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest("There was an issue creating a new Product.");
            }
        }

        [HttpPut("product/{productId}")]
        public async Task<ActionResult<ProductDto>> UpdateProductAsync(string productId, ProductDto product)
        {
            try
            {
                product.ProductId = Guid.Parse(productId);
                var updatedProduct = await this.productService.UpdateProduct(product);
                return this.Ok(updatedProduct);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest($"There was an issue updating Product with id {productId}");
            }
        }

        [HttpDelete("product/{productId}")]
        public async Task<ActionResult> RemoveProductAsync(string productId)
        {
            await this.productService.RemoveProduct(Guid.Parse(productId));
            return this.Ok("Removed Successfully");
        }
    }
}