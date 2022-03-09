/// <summary>
/// Base DTO of the book, used in creation
/// </summary>
public class BaseBookVersionDTO
{
    public decimal Precio { get; set; }
    public int IdBook { get; set; }

    public int IdEditorial { get; set; }
}