using System.Collections.Generic;
using Microsoft.AspNetCore.JsonPatch;

/// <summary>
/// This is the service for books
/// </summary>
public interface IBookVersionService
{
    public IEnumerable<BookVersionDTO> GetAll();

    public BookVersionDTO GetByID(int guid);

    public BookVersionDetailDTO GetDetailByID(int id);
    public BookVersionDTO Add(BaseBookVersionDTO guid);

    public void Delete(int guid);

    public BookVersionDTO Modify(BaseBookVersionDTO book, int guid);
}