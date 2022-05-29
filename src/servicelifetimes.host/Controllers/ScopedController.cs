using Microsoft.AspNetCore.Mvc;
using servicelifetimes.host.Services;

namespace servicelifetimes.host.Controllers;

[ApiController]
[Route("[controller]")]
public class ScopedController : ControllerBase
{
    private readonly IMySecondLevelService _scopedService;

    public ScopedController(IMySecondLevelService scopedService)
    {
        _scopedService = scopedService;
    }

    [HttpGet(Name = "GetScoped")]
    public IActionResult Get()
    {
        return Ok(_scopedService.WriteToConsole());
    }
}