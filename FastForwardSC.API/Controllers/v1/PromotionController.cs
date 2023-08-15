using Microsoft.AspNetCore.Mvc;
using Shared.Models;
using Shared.Services;

namespace FastForwardSC.API.Controllers.v1
{
    [ApiController]
    [Route("api/v1/[controller]/")]
    public class PromotionController : ControllerBase
    {
        private readonly IPromotionService promotionService;
        private readonly ILogger<PromotionController> _logger;

        public PromotionController(
            IPromotionService promotionService,
            ILogger<PromotionController> logger)
        {
            this.promotionService = promotionService;
            _logger = logger;
        }

        [HttpGet("promotion/{promotionId}")]
        public async Task<ActionResult<PromotionDto>> SearchPromotionAsync(string promotionId)
        {
            var promotion = await this.promotionService.SearchPromotion(Guid.Parse(promotionId));
            if (promotion == null)
            {
                return NotFound();
            }
            return this.Ok(promotionId);
        }

        [HttpPost("promotion")]
        public async Task<ActionResult<PromotionDto>> CreatePromotionAsync(PromotionDto promotion)
        {
            try
            {
                var createdPromotion = await this.promotionService.CreatePromotion(promotion);
                return this.Ok(createdPromotion);
            }catch(Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest("There was an issue creating a new Promotion.");
            }
        }

        [HttpPut("promotion/{promotionId}")]
        public async Task<ActionResult<PromotionDto>> UpdatePromotionAsync(string promotionId, PromotionDto promotion)
        {
            try
            {
                promotion.PromotionId = Guid.Parse(promotionId);
                var updatedPromotion = await this.promotionService.UpdatePromotion(promotion);
                return this.Ok(updatedPromotion);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest($"There was an issue updating Promotion with id {promotionId}");
            }
        }

        [HttpDelete("promotion/{promotionId}")]
        public async Task<ActionResult> RemovePromotionAsync(string promotionId)
        {
            await this.promotionService.RemovePromotion(Guid.Parse(promotionId));
            return this.Ok("Removed Successfully");
        }
    }
}