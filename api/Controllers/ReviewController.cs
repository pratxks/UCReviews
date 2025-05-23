namespace api.Controllers;

using api.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using api.Models;
using api.ViewModels;
using Microsoft.Extensions.Options;
using api.Settings;
using api.Dto;
using api.Enums;
using System.Security.Claims;

[ApiController]
[Route("[controller]")]
[Authorize]
public class ReviewController : ControllerBase
{
    private readonly IReviewService _service;
    private readonly ILogger<ReviewController> _logger;
    private readonly PaginationSettings _paginationSettings;

    public ReviewController(IReviewService service, ILogger<ReviewController> logger, IOptions<PaginationSettings> paginationSettings)
    {
        _service = service;
        _logger = logger;
        _paginationSettings = paginationSettings.Value;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Review>>> GetReviews([FromQuery] int prev = 0, [FromQuery] int? perPage = null)
    {
        var userId = GetUserIdFromJwt();
        perPage ??= _paginationSettings.DefaultPerPage;
        var reviews = await _service.GetReviews(prev, (int)perPage, userId);
        return reviews.Count() > 0 ? Ok(reviews) : NoContent();
    }

    [HttpGet("Dorm/{dormId}")]
    public async Task<ActionResult<List<ReviewWithUser>>> GetReviewByDormId(int dormId, [FromQuery] int prev = 0, [FromQuery] int? perPage = null)
    {
        var userId = GetUserIdFromJwt();
        perPage ??= _paginationSettings.DefaultPerPage;
        return await _service.GetReviewsByDormId(dormId, prev, (int)perPage, userId);
    }

    [HttpGet("ParkingGarage/{garageId}")]
    public async Task<ActionResult<List<ReviewWithUser>>> GetReviewByParkingGarageId(int garageId, [FromQuery] int prev = 0, [FromQuery] int? perPage = null)
    {
        var userId = GetUserIdFromJwt();
        perPage ??= _paginationSettings.DefaultPerPage;
        return await _service.GetReviewsByParkingGarageId(garageId, prev, (int)perPage, userId);
    }

    [HttpGet("DiningHall/{diningHallId}")]
    public async Task<ActionResult<List<ReviewWithUser>>> GetReviewByDiningHallId(int diningHallId, [FromQuery] int prev = 0, [FromQuery] int? perPage = null)
    {
        var userId = GetUserIdFromJwt();
        perPage ??= _paginationSettings.DefaultPerPage;
        return await _service.GetReviewsByDiningHallId(diningHallId, prev, (int)perPage, userId);
    }

    [HttpGet("Course/{courseId}")]
    public async Task<ActionResult<List<ReviewWithUser>>> GetReviewByCourseId(int courseId, [FromQuery] int prev = 0, [FromQuery] int? perPage = null)
    {
        var userId = GetUserIdFromJwt();
        perPage ??= _paginationSettings.DefaultPerPage;
        return await _service.GetReviewsByCourseId(courseId, prev, (int)perPage, userId);
    }

    [HttpPost]
    public async Task<ActionResult<ReviewWithSummary>> SaveReview(SaveReviewViewModel review)
    {
        if (review.ReviewText.Length <= 1000)
            return await _service.SaveReview(review);
        return Conflict();
    }
    [HttpGet("vote/{reviewId}")]
    public async Task<ActionResult> UpdateVote(int reviewId, [FromQuery(Name = "voteType")] string voteType) 
    {
        var userId = GetUserIdFromJwt();
        VoteType finalVoteType;
        if (voteType == "upvote") {
            finalVoteType = VoteType.Upvote;
        } else if (voteType == "downvote") {
            finalVoteType = VoteType.Downvote;
        } else {
            finalVoteType = VoteType.NoVote;
        }
        Review reviewToVoteOn = await _service.GetReviewById(reviewId);
        Vote vote = new Vote() 
        {
            ReviewId = reviewToVoteOn.Id,
            SelectedVote = finalVoteType,
            UserId = userId
            
        };
        Review review = await _service.SaveVote(vote, userId);

        return Ok(review);
    }
    private int GetUserIdFromJwt()
    {
        if (HttpContext?.User?.Identity?.IsAuthenticated != true)
        {
            return -1;
        }

        var userIdClaim = HttpContext.User.Claims.FirstOrDefault(c => 
            c.Type == ClaimTypes.NameIdentifier || c.Type == "sub")?.Value;

        if (userIdClaim == null)
        {
            return -1;
        }

        if (int.TryParse(userIdClaim, out int userId))
        {
            return userId;
        }
    return 0;
}




}