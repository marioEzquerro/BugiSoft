using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class FaltasController : ControllerBase
{
    private readonly ILogger<FaltasController> _logger;
    private readonly IFaltasService _service;

    public FaltasController(ILogger<FaltasController> logger, IFaltasService service)
    {
        _logger = logger;
        _service = service;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BookDTO))]
    public ActionResult<BookDTO> Get()
    {
        return Ok(_service.GetAll());
    }
}
