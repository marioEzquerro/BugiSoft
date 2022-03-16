using AutoMapper;

public class JuegoProfile : Profile
{
    public JuegoProfile()
    {
        CreateMap<JuegoDTO, JuegoEntity>();
        CreateMap<JuegoEntity, JuegoDTO>();
    }
}
