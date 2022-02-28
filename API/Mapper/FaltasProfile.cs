using AutoMapper;

public class FaltasProfile : Profile
{
    public FaltasProfile()
    {
        CreateMap<FaltasDTO, FaltasEntity>();
        CreateMap<FaltasEntity, FaltasDTO>();
    }
}
