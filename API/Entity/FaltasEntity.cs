using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Faltas")]
public class FaltasEntity
{
    public int Number { get; set; }
    public DateTime Date { get; set; }
    public int Id { get; set; }

}
