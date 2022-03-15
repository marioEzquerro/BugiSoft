using AutoMapper;

public class BookProfile : Profile
{
    public BookProfile()
    {
        CreateMap<BookDTO, BookEntity>();
        CreateMap<BookEntity, BookDTO>();
        CreateMap<BaseBookDTO, BookEntity>();
        CreateMap<BookEntity, BaseBookDTO>();
    }
}
