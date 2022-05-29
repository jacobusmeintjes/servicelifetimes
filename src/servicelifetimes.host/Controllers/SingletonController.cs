using Microsoft.AspNetCore.Mvc;
using servicelifetimes.host.Services;

namespace servicelifetimes.host.Controllers;

[ApiController]
[Route("[controller]")]
public class SingletonController : ControllerBase
{
    private readonly IMySingletonService _singletonService;
    
    public SingletonController(IMySingletonService singletonService)
    {
        _singletonService = singletonService;
    }

    [HttpGet(Name = "GetSingleton")]
    public IActionResult Get()
    {
        return Ok(_singletonService.WriteToConsole());
    }
}