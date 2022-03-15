using AutoMapper;

public class BookVersionProfile : Profile
{
    public BookVersionProfile()
    {
        CreateMap<BookVersionDTO, BookVersionEntity>();
        CreateMap<BookVersionEntity, BookVersionDTO>();
        CreateMap<BaseBookVersionDTO, BookVersionEntity>();
        CreateMap<BookVersionEntity, BaseBookVersionDTO>();
    }
}
