using Microsoft.AspNetCore.Mvc;
using Shared.Models;
using Shared.Services;

namespace FastForwardSC.API.Controllers.v1
{
    [ApiController]
    [Route("api/v1/[controller]/")]
    public class StoreController : ControllerBase
    {
        private readonly IStoreService storeService;
        private readonly ILogger<StoreController> _logger;

        public StoreController(
            IStoreService storeService,
            ILogger<StoreController> logger)
        {
            this.storeService = storeService;
            _logger = logger;
        }

        [HttpGet("store/{storeId}")]
        public async Task<ActionResult<StoreDto>> SearchStoreAsync(string storeId)
        {
            var Store = await this.storeService.SearchStore(Guid.Parse(storeId));
            if (Store == null)
            {
                return NotFound();
            }
            return this.Ok(storeId);
        }

        [HttpPost("store")]
        public async Task<ActionResult<StoreDto>> CreateStoreAsync(StoreDto store)
        {
            try
            {
                var createdStore = await this.storeService.CreateStore(store);
                return this.Ok(createdStore);
            }catch(Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest("There was an issue creating a new Store.");
            }
        }

        [HttpPut("store/{storeId}")]
        public async Task<ActionResult<StoreDto>> UpdateStoreAsync(string storeId, StoreDto store)
        {
            try
            {
                store.StoreId = Guid.Parse(storeId);
                var updatedStore = await this.storeService.UpdateStore(store);
                return this.Ok(updatedStore);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest($"There was an issue updating Store with id {storeId}");
            }
        }

        [HttpDelete("store/{storeId}")]
        public async Task<ActionResult> RemoveStoreAsync(string storeId)
        {
            await this.storeService.RemoveStore(Guid.Parse(storeId));
            return this.Ok("Removed Successfully");
        }
    }
}