using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Book_Version")]
public class BookVersionEntity
{
    public decimal Precio { get; set; }
    public int Id { get; set; }

    [Column("id_book")]
    public int IdBook { get; set; }

    [Column("id_editorial")]
    public int IdEditorial { get; set; }

}
