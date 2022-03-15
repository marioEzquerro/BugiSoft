using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Editorial")]
public class EditorialEntity
{
    public string Nombre { get; set; }
    public int Id { get; set; }

}
