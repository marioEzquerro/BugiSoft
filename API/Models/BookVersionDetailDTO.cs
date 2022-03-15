/// <summary>
/// Base DTO of the book, used in creation
/// </summary>
public class BookVersionDetailDTO
{
    public decimal Precio { get; set; }
    public string NombreEditorial { get; set; }
    public string NombreLibro { get; set; }
    public string ISBN { get; set; }
    public int Paginas { get; set; }
}