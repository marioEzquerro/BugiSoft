using System.Collections.Generic;
using Microsoft.AspNetCore.JsonPatch;

public interface IBookService
{
    public IEnumerable<BookDTO> GetAll();

    public BookDTO GetByID(int guid);

    public BookDTO Add(BaseBookDTO guid);

    public void Delete(int guid);

    public BookDTO Modify(BaseBookDTO book, int guid);
}