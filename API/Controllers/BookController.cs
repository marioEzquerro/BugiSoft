using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class BooksController : ControllerBase
{
    private readonly ILogger<BooksController> _logger;
    private readonly IBookService _bookService;

    public BooksController(ILogger<BooksController> logger, IBookService bookService)
    {
        _logger = logger;
        _bookService = bookService;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BookDTO))]
    public ActionResult<BookDTO> Get()
    {
        return Ok(_bookService.GetAll());
    }

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



    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BookDTO))]
    public ActionResult<BookDTO> Post([FromBody] BaseBookDTO baseBook)
    {

        return Ok(_bookService.Add(baseBook));
    }

    [HttpPut("{Id}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BookDTO))]
    public ActionResult<BookDTO> Put([FromBody] BaseBookDTO baseBook, int Id)
    {

        return Ok(_bookService.Modify(baseBook, Id));
    }

}
