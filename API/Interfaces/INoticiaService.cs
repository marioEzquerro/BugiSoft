using System.Collections.Generic;
using Microsoft.AspNetCore.JsonPatch;

/// <summary>
/// This is the service for Noticias
/// </summary>
public interface INoticiaService
{
    public IEnumerable<NoticiaDTO> GetAll();

    public NoticiaDTO GetByID(int guid);

    public NoticiaDTO Add(NoticiaDTO guid);

    public void Delete(int guid);

    public NoticiaDTO Modify(NoticiaDTO Noticia, int guid);
}