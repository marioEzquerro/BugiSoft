using System.Collections.Generic;
using Microsoft.AspNetCore.JsonPatch;
/// <summary>
/// This Interface is for the faltas service
/// </summary>
public interface IFaltasService
{
    public IEnumerable<FaltasDTO> GetAll();

}