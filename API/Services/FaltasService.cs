using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;

public class FaltasService : IFaltasService
{
    private readonly LibraryContext _context;
    private readonly IMapper _mapper;

    public FaltasService(LibraryContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public IEnumerable<FaltasDTO> GetAll()
    {
        return _mapper.Map<IEnumerable<FaltasDTO>>(_context.Faltas.Select(x => x));
    }
}