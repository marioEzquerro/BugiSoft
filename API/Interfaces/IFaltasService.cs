using System.Collections.Generic;
using Microsoft.AspNetCore.JsonPatch;

public interface IFaltasService
{
    public IEnumerable<FaltasDTO> GetAll();

}