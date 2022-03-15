using AutoMapper;

public class NoticiaProfile : Profile
{
    public NoticiaProfile()
    {
        CreateMap<NoticiaDTO, NoticiaEntity>();
        CreateMap<NoticiaEntity, NoticiaDTO>();
    }
}
