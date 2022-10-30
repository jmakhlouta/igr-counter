using IgrCounter.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace IgrCounter.Api.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class GoogleController : ControllerBase
{
    private readonly ILogger<GoogleController> _logger;

    public GoogleController(ILogger<GoogleController> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    public RankResponse Rank(RankRequest request)
        => new RankResponse(new Dictionary<string, int>()
        {
            ["efiling%20integration"] = 1,
            ["test"] = 5
        });
}
