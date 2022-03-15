/// <summary>
/// DTO of the Juego
/// </summary>
public class JuegoDTO
{
    public JuegoDTO()
    {

    }


    public int Id { get; set; }
    public string nombre { get; set; }
    public string descripcion { get; set; }
    public DateTime fecha_lanzamiento { get; set; }
    public string genero { get; set; }
    public string imagen { get; set; }
}