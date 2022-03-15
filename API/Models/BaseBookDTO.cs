/// <summary>
/// Base DTO of the book, used in creation
/// </summary>
public class BaseBookDTO
{
    public string ISBN { get; set; }
    public string Name { get; set; }
    public int Pages { get; set; }
    public DateTime? PublishDate { get; set; }
}