using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class NoticiasController : Controller
{
    private readonly ILogger<NoticiasController> _logger;
    private readonly INoticiaService _NoticiaService;

    /// <summary>
    /// It creates a NoticiaController
    /// </summary>
    /// <param name="logger">used for logging</param>
    /// <param name="NoticiaService">used for dealing with the Noticia data</param>
    public NoticiasController(ILogger<NoticiasController> logger, INoticiaService NoticiaService)
    {
        _logger = logger;
        _NoticiaService = NoticiaService;
    }

    /// <summary>
    /// Returns all the Noticias
    /// </summary>
    /// <returns>Returns a list of <see cref="NoticiaDTO"/></returns>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(NoticiaDTO))]
    public ActionResult<NoticiaDTO> Get()
    {
        return Ok(_NoticiaService.GetAll());
    }

     /// <summary>
    /// Returns the las Noticia
    /// </summary>
    /// <returns>Returns a list of <see cref="NoticiaDTO"/></returns>
    [HttpGet("last")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(NoticiaDTO))]
    public ActionResult<NoticiaDTO> GetLast()
    {
        NoticiaDTO result = _NoticiaService.GetLast();

        if (result == null)
            return NotFound();

        return Ok(result);
    }


    /// <summary>
    /// It returns a Noticia by id 
    /// </summary>
    /// <param name="Id">the id of the Noticia</param>
    /// <returns>Returns a Noticia <see cref="NoticiaDTO"/></returns>
    [HttpGet("{Id}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(NoticiaDTO))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<NoticiaDTO> Get(int Id)
    {
        NoticiaDTO result = _NoticiaService.GetByID(Id);

        if (result == null)
            return NotFound();

        return Ok(result);

    }


    /// <summary>
    /// it deletes a Noticia
    /// </summary>
    /// <param name="Id">the id of the Noticia that is going to be delated</param>
    /// <returns>Returns the deleted Noticia <see cref="NoticiaDTO"/></returns>
    [HttpDelete("{Id}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(NoticiaDTO))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<NoticiaDTO> Delete(int Id)
    {
        NoticiaDTO result = _NoticiaService.GetByID(Id);

        if (result == null)
            return NotFound();

        _NoticiaService.Delete(Id);

        return Ok(result);

    }


    /// <summary>
    /// It creates a Noticia
    /// </summary>
    /// <param name="Noticia">the created Noticia <see cref="NoticiaDTO"/></param>
    /// <returns>Returns the created Noticia <see cref="NoticiaDTO"/></returns>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(NoticiaDTO))]
    public ActionResult<NoticiaDTO> Post([FromBody] NoticiaDTO Noticia)
    {

        return Ok(_NoticiaService.Add(Noticia));
    }

    /// <summary>
    /// it modifies a Noticia
    /// </summary>
    /// <param name="Noticia">the created Noticia <see cref="NoticiaDTO"/></param>
    /// <param name="Id">the id of the modified Noticia</param>
    /// <returns>Returns the modified Noticia <see cref="NoticiaDTO"/><</returns>
    [HttpPut("{Id}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(NoticiaDTO))]
    public ActionResult<NoticiaDTO> Put([FromBody] NoticiaDTO Noticia, int Id)
    {

        return Ok(_NoticiaService.Modify(Noticia, Id));
    }

}