using System.Collections.Generic;
using Microsoft.AspNetCore.JsonPatch;

/// <summary>
/// This is the service for Juegos
/// </summary>
public interface IJuegoService
{
    public IEnumerable<JuegoDTO> GetAll();

    public JuegoDTO GetByID(int guid);

    public JuegoDTO Add(JuegoDTO guid);

    public void Delete(int guid);

    public JuegoDTO Modify(JuegoDTO Juego, int guid);
}