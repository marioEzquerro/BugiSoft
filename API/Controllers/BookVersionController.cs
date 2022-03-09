using System.Collections.Generic;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class BookVersionController : ControllerBase
{
    private readonly ILogger<BookVersionController> _logger;
    private readonly IBookVersionService _bookVersionService;

    /// <summary>
    /// It creates a bookController
    /// </summary>
    /// <param name="logger">used for logging</param>
    /// <param name="bookVersionService">used for dealing with the book data</param>
    public BookVersionController(ILogger<BookVersionController> logger, IBookVersionService bookVersionService)
    {
        _logger = logger;
        _bookVersionService = bookVersionService;
    }

    /// <summary>
    /// Returns all the books
    /// </summary>
    /// <returns>Returns a list of <see cref="BookVersionDTO"/></returns>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<BookVersionDTO>))]
    public ActionResult<IEnumerable<BookVersionDTO>> Get()
    {
        return Ok(_bookVersionService.GetAll());
    }

    /// <summary>
    /// Returns the detail of a book
    /// </summary>
    /// <returns>Returns a <see cref="BookVersionDetailDTO"/></returns>
    [HttpGet("{id}/detail")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BookVersionDetailDTO))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]

    public ActionResult<BookVersionDetailDTO> GetDetail(int Id)
    {
        return Ok(_bookVersionService.GetDetailByID(Id));
    }

    /// <summary>
    /// It returns a book by id 
    /// </summary>
    /// <param name="Id">the id of the book</param>
    /// <returns>Returns a book <see cref="BookVersionDTO"/></returns>
    [HttpGet("{Id}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BookVersionDTO))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<BookVersionDTO> Get(int Id)
    {
        BookVersionDTO result = _bookVersionService.GetByID(Id);

        if (result == null)
            return NotFound();

        return Ok(result);

    }


    /// <summary>
    /// it deletes a book
    /// </summary>
    /// <param name="Id">the id of the book that is going to be delated</param>
    /// <returns>Returns the deleted book <see cref="BookVersionDTO"/></returns>
    [HttpDelete("{Id}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BookVersionDTO))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<BookVersionDTO> Delete(int Id)
    {
        BookVersionDTO result = _bookVersionService.GetByID(Id);

        if (result == null)
            return NotFound();

        _bookVersionService.Delete(Id);

        return Ok(result);

    }


    /// <summary>
    /// It creates a book
    /// </summary>
    /// <param name="baseBook">the created book <see cref="BaseBookVersionDTO"/></param>
    /// <returns>Returns the created book <see cref="BookVersionDTO"/></returns>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BookVersionDTO))]
    public ActionResult<BookVersionDTO> Post([FromBody] BaseBookVersionDTO baseBook)
    {

        return Ok(_bookVersionService.Add(baseBook));
    }

    /// <summary>
    /// it modifies a book
    /// </summary>
    /// <param name="baseBook">the created book <see cref="BaseBookVersionDTO"/></param>
    /// <param name="Id">the id of the modified book</param>
    /// <returns>Returns the modified book <see cref="BookVersionDTO"/><</returns>
    [HttpPut("{Id}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BookVersionDTO))]
    public ActionResult<BookVersionDTO> Put([FromBody] BaseBookVersionDTO baseBook, int Id)
    {

        return Ok(_bookVersionService.Modify(baseBook, Id));
    }

}
