using Microsoft.AspNetCore.Mvc;
using servicelifetimes.host.Services;

namespace servicelifetimes.host.Controllers;

[ApiController]
[Route("[controller]")]
public class TransientController : ControllerBase
{
    private readonly IMyTransientService _transientService;

    public TransientController(
        IMyTransientService transientService)
    {
        _transientService = transientService;
    }

    [HttpGet(Name = "GetTransient")]
    public IActionResult Get()
    {
        return Ok(_transientService.WriteToConsole());        
    }
}