using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;

public class BookVersionService : IBookVersionService
{
    private readonly LibraryContext _context;
    private readonly IMapper _mapper;

    public BookVersionService(LibraryContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public BookVersionDTO Add(BaseBookVersionDTO baseBookVersion)
    {
        var _mappedBookVersion = _mapper.Map<BookVersionEntity>(baseBookVersion);
        var entityAdded = _context.BookVersions.Add(_mappedBookVersion);
        _context.SaveChanges();
        return _mapper.Map<BookVersionDTO>(entityAdded);
    }

    public void Delete(int guid)
    {
        BookVersionEntity BookVersion = _context.BookVersions.FirstOrDefault(x => x.Id == guid);

        if (BookVersion == null)
            throw new ApplicationException($"Bokk with id {guid} not found");

        _context.BookVersions.Remove(BookVersion);
        _context.SaveChanges();
    }

    public IEnumerable<BookVersionDTO> GetAll()
    {
        return _mapper.Map<IEnumerable<BookVersionDTO>>(_context.BookVersions.Select(x => x));
    }

    public BookVersionDTO GetByID(int guid)
    {
        return _mapper.Map<BookVersionDTO>(_context.BookVersions.FirstOrDefault(x => x.Id == guid));
    }

    public BookVersionDetailDTO GetDetailByID(int id)
    {
        return (from bookVersion in _context.BookVersions
                join book in _context.Books on bookVersion.IdBook equals book.Id
                join editorial in _context.Editorials on bookVersion.IdEditorial equals editorial.Id
                where bookVersion.Id == id
                select new BookVersionDetailDTO
                {
                    NombreEditorial = editorial.Nombre,
                    NombreLibro = book.Name,
                    Precio = bookVersion.Precio,
                    ISBN = book.ISBN,
                    Paginas = book.Pages
                }).FirstOrDefault();
    }

    public BookVersionDTO Modify(BaseBookVersionDTO BookVersion, int guid)
    {
        var _mappedBookVersion = _mapper.Map<BookVersionEntity>(BookVersion);
        _mappedBookVersion.Id = guid;

        BookVersionEntity modifiedBookVersion = _context.BookVersions.FirstOrDefault(x => x.Id == guid);

        if (modifiedBookVersion == null)
            return null;

        _context.Entry(modifiedBookVersion).CurrentValues.SetValues(_mappedBookVersion);

        _context.SaveChanges();

        return _mapper.Map<BookVersionDTO>(_mappedBookVersion);
    }

}