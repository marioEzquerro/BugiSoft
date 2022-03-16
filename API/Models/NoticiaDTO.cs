/// <summary>
/// Info of the Noticia
/// </summary>
public class NoticiaDTO
{
    public NoticiaDTO()
    {

    }

    public int Id { get; set; }
    public string nombre { get; set; }
    public string descripcion_corta { get; set; }
    public string descripcion { get; set; }
    public string img { get; set; }
    public DateTime fecha { get; set; }
}