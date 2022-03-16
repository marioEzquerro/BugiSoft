using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class JuegosController : Controller
{
    private readonly ILogger<JuegosController> _logger;
    private readonly IJuegoService _JuegoService;

    /// <summary>
    /// It creates a JuegoController
    /// </summary>
    /// <param name="logger">used for logging</param>
    /// <param name="JuegoService">used for dealing with the Juego data</param>
    public JuegosController(ILogger<JuegosController> logger, IJuegoService JuegoService)
    {
        _logger = logger;
        _JuegoService = JuegoService;
    }

    /// <summary>
    /// Returns all the Juegos
    /// </summary>
    /// <returns>Returns a list of <see cref="JuegoDTO"/></returns>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(JuegoDTO))]
    public ActionResult<JuegoDTO> Get()
    {
        return Ok(_JuegoService.GetAll());
    }

    /// <summary>
    /// It returns a Juego by id 
    /// </summary>
    /// <param name="Id">the id of the Juego</param>
    /// <returns>Returns a Juego <see cref="JuegoDTO"/></returns>
    [HttpGet("{Id}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(JuegoDTO))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<JuegoDTO> Get(int Id)
    {
        JuegoDTO result = _JuegoService.GetByID(Id);

        if (result == null)
            return NotFound();

        return Ok(result);

    }


    /// <summary>
    /// it deletes a Juego
    /// </summary>
    /// <param name="Id">the id of the Juego that is going to be delated</param>
    /// <returns>Returns the deleted Juego <see cref="JuegoDTO"/></returns>
    [HttpDelete("{Id}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(JuegoDTO))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<JuegoDTO> Delete(int Id)
    {
        JuegoDTO result = _JuegoService.GetByID(Id);

        if (result == null)
            return NotFound();

        _JuegoService.Delete(Id);

        return Ok(result);

    }


    /// <summary>
    /// It creates a Juego
    /// </summary>
    /// <param name="Juego">the created Juego <see cref="JuegoDTO"/></param>
    /// <returns>Returns the created Juego <see cref="JuegoDTO"/></returns>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(JuegoDTO))]
    public ActionResult<JuegoDTO> Post([FromBody] JuegoDTO Juego)
    {

        return Ok(_JuegoService.Add(Juego));
    }

    /// <summary>
    /// it modifies a Juego
    /// </summary>
    /// <param name="Juego">the created Juego <see cref="JuegoDTO"/></param>
    /// <param name="Id">the id of the modified Juego</param>
    /// <returns>Returns the modified Juego <see cref="JuegoDTO"/><</returns>
    [HttpPut("{Id}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(JuegoDTO))]
    public ActionResult<JuegoDTO> Put([FromBody] JuegoDTO Juego, int Id)
    {

        return Ok(_JuegoService.Modify(Juego, Id));
    }

}