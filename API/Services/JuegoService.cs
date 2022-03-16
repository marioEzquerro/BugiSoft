using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;

public class JuegoService : IJuegoService
{
    private readonly BugisoftContext _context;
    private readonly IMapper _mapper;

    public JuegoService(BugisoftContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public JuegoDTO Add(JuegoDTO Juego)
    {
        var _mappedJuego = _mapper.Map<JuegoEntity>(Juego);
        var entityAdded = _context.Juegos.Add(_mappedJuego);
        _context.SaveChanges();
        return _mapper.Map<JuegoDTO>(entityAdded);
    }

    public void Delete(int guid)
    {
        JuegoEntity Juego = _context.Juegos.FirstOrDefault(x => x.Id == guid);

        if (Juego == null)
            throw new ApplicationException($"Bokk with id {guid} not found");

        _context.Juegos.Remove(Juego);
        _context.SaveChanges();
    }

    public IEnumerable<JuegoDTO> GetAll()
    {
        return _mapper.Map<IEnumerable<JuegoDTO>>(_context.Juegos.Select(x => x));
    }

    public JuegoDTO GetByID(int guid)
    {
        return _mapper.Map<JuegoDTO>(_context.Juegos.FirstOrDefault(x => x.Id == guid));
    }

    public JuegoDTO Modify(JuegoDTO Juego, int guid)
    {
        var _mappedJuego = _mapper.Map<JuegoEntity>(Juego);
        _mappedJuego.Id = guid;

        JuegoEntity modifiedJuego = _context.Juegos.FirstOrDefault(x => x.Id == guid);

        if (modifiedJuego == null)
            return null;

        _context.Entry(modifiedJuego).CurrentValues.SetValues(_mappedJuego);

        _context.SaveChanges();

        return _mapper.Map<JuegoDTO>(_mappedJuego);
    }

}