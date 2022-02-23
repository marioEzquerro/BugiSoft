using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Book")]
public class BookEntity
{

    [MaxLength(50)]
    public string ISBN { get; set; }
    [MaxLength(50)]
    public string Name { get; set; }

    public int Pages { get; set; }
    public DateTime? PublishDate { get; set; }
    public int Id { get; set; }

}
