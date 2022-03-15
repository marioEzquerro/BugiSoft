using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class BooksController : ControllerBase
{
    private readonly ILogger<BooksController> _logger;
    private readonly IBookService _bookService;

    /// <summary>
    /// It creates a bookController
    /// </summary>
    /// <param name="logger">used for logging</param>
    /// <param name="bookService">used for dealing with the book data</param>
    public BooksController(ILogger<BooksController> logger, IBookService bookService)
    {
        _logger = logger;
        _bookService = bookService;
    }

    /// <summary>
    /// Returns all the books
    /// </summary>
    /// <returns>Returns a list of <see cref="BookDTO"/></returns>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BookDTO))]
    public ActionResult<BookDTO> Get()
    {
        return Ok(_bookService.GetAll());
    }

    /// <summary>
    /// It returns a book by id 
    /// </summary>
    /// <param name="Id">the id of the book</param>
    /// <returns>Returns a book <see cref="BookDTO"/></returns>
    [HttpGet("{Id}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BookDTO))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<BookDTO> Get(int Id)
    {
        BookDTO result = _bookService.GetByID(Id);

        if (result == null)
            return NotFound();

        return Ok(result);

    }


    /// <summary>
    /// it deletes a book
    /// </summary>
    /// <param name="Id">the id of the book that is going to be delated</param>
    /// <returns>Returns the deleted book <see cref="BookDTO"/></returns>
    [HttpDelete("{Id}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BookDTO))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<BookDTO> Delete(int Id)
    {
        BookDTO result = _bookService.GetByID(Id);

        if (result == null)
            return NotFound();

        _bookService.Delete(Id);

        return Ok(result);

    }


    /// <summary>
    /// It creates a book
    /// </summary>
    /// <param name="baseBook">the created book <see cref="BaseBookDTO"/></param>
    /// <returns>Returns the created book <see cref="BookDTO"/></returns>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BookDTO))]
    public ActionResult<BookDTO> Post([FromBody] BaseBookDTO baseBook)
    {

        return Ok(_bookService.Add(baseBook));
    }

    /// <summary>
    /// it modifies a book
    /// </summary>
    /// <param name="baseBook">the created book <see cref="BaseBookDTO"/></param>
    /// <param name="Id">the id of the modified book</param>
    /// <returns>Returns the modified book <see cref="BookDTO"/><</returns>
    [HttpPut("{Id}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BookDTO))]
    public ActionResult<BookDTO> Put([FromBody] BaseBookDTO baseBook, int Id)
    {

        return Ok(_bookService.Modify(baseBook, Id));
    }

}
