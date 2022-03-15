using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;

public class BookService : IBookService
{
    private readonly LibraryContext _context;
    private readonly IMapper _mapper;

    public BookService(LibraryContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public BookDTO Add(BaseBookDTO baseBook)
    {
        var _mappedBook = _mapper.Map<BookEntity>(baseBook);
        var entityAdded = _context.Books.Add(_mappedBook);
        _context.SaveChanges();
        return _mapper.Map<BookDTO>(entityAdded);
    }

    public void Delete(int guid)
    {
        BookEntity book = _context.Books.FirstOrDefault(x => x.Id == guid);

        if (book == null)
            throw new ApplicationException($"Bokk with id {guid} not found");

        _context.Books.Remove(book);
        _context.SaveChanges();
    }

    public IEnumerable<BookDTO> GetAll()
    {
        return _mapper.Map<IEnumerable<BookDTO>>(_context.Books.Select(x => x));
    }

    public BookDTO GetByID(int guid)
    {
        return _mapper.Map<BookDTO>(_context.Books.FirstOrDefault(x => x.Id == guid));
    }

    public BookDTO Modify(BaseBookDTO book, int guid)
    {
        var _mappedBook = _mapper.Map<BookEntity>(book);
        _mappedBook.Id = guid;

        BookEntity modifiedBook = _context.Books.FirstOrDefault(x => x.Id == guid);

        if (modifiedBook == null)
            return null;

        _context.Entry(modifiedBook).CurrentValues.SetValues(_mappedBook);

        _context.SaveChanges();

        return _mapper.Map<BookDTO>(_mappedBook);
    }

}