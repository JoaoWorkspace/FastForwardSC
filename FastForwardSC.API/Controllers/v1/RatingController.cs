using Microsoft.AspNetCore.Mvc;
using Shared.Models;
using Shared.Services;

namespace FastForwardSC.API.Controllers.v1
{
    [ApiController]
    [Route("api/v1/[controller]/")]
    public class RatingController : ControllerBase
    {
        private readonly IRatingService ratingService;
        private readonly ILogger<RatingController> _logger;

        public RatingController(
            IRatingService ratingService,
            ILogger<RatingController> logger)
        {
            this.ratingService = ratingService;
            _logger = logger;
        }

        [HttpGet("user/{userId}/product/{productId}/rating")]
        public async Task<ActionResult<RatingDto>> SearchRatingAsync(string userId, string productId)
        {
            var rating = await this.ratingService.SearchRating(Guid.Parse(userId), Guid.Parse(productId));
            if (rating == null)
            {
                return NotFound();
            }
            return this.Ok(rating);
        }

        [HttpPost("user/{userId}/product/{productId}/rating")]
        public async Task<ActionResult<RatingDto>> CreateRatingAsync(string userId, string productId, RatingDto rating)
        {
            try
            {
                rating.ProductId = Guid.Parse(productId);
                rating.UserId = Guid.Parse(userId);
                var createdRating = await this.ratingService.CreateRating(rating);
                return this.Ok(createdRating);
            }catch(Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest("There was an issue creating a new Rating.");
            }
        }

        [HttpPut("user/{userId}/product/{productId}/rating")]
        public async Task<ActionResult<RatingDto>> UpdateRatingAsync(string userId, string productId, RatingDto rating)
        {
            try
            {
                rating.UserId = Guid.Parse(userId);
                rating.ProductId = Guid.Parse(productId);
                var updatedRating = await this.ratingService.UpdateRating(rating);
                return this.Ok(updatedRating);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest($"There was an issue updating Rating with userId {userId} and productId {productId}");
            }
        }

        [HttpDelete("user/{userId}/product/{productId}/rating")]
        public async Task<ActionResult> RemoveRatingAsync(string userId, string productId)
        {
            await this.ratingService.RemoveRating(Guid.Parse(userId), Guid.Parse(productId));
            return this.Ok("Removed Successfully");
        }
    }
}