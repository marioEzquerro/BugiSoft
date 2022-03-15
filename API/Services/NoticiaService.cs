using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;

public class NoticiaService : INoticiaService
{
    private readonly BugisoftContext _context;
    private readonly IMapper _mapper;

    public NoticiaService(BugisoftContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public NoticiaDTO Add(NoticiaDTO Noticia)
    {
        var _mappedNoticia = _mapper.Map<NoticiaEntity>(Noticia);
        var entityAdded = _context.Noticias.Add(_mappedNoticia);
        _context.SaveChanges();
        return _mapper.Map<NoticiaDTO>(entityAdded);
    }

    public void Delete(int guid)
    {
        NoticiaEntity Noticia = _context.Noticias.FirstOrDefault(x => x.Id == guid);

        if (Noticia == null)
            throw new ApplicationException($"Bokk with id {guid} not found");

        _context.Noticias.Remove(Noticia);
        _context.SaveChanges();
    }

    public IEnumerable<NoticiaDTO> GetAll()
    {
        return _mapper.Map<IEnumerable<NoticiaDTO>>(_context.Noticias.Select(x => x));
    }

    public NoticiaDTO GetByID(int guid)
    {
        return _mapper.Map<NoticiaDTO>(_context.Noticias.FirstOrDefault(x => x.Id == guid));
    }

    public NoticiaDTO Modify(NoticiaDTO Noticia, int guid)
    {
        var _mappedNoticia = _mapper.Map<NoticiaEntity>(Noticia);
        _mappedNoticia.Id = guid;

        NoticiaEntity modifiedNoticia = _context.Noticias.FirstOrDefault(x => x.Id == guid);

        if (modifiedNoticia == null)
            return null;

        _context.Entry(modifiedNoticia).CurrentValues.SetValues(_mappedNoticia);

        _context.SaveChanges();

        return _mapper.Map<NoticiaDTO>(_mappedNoticia);
    }

}