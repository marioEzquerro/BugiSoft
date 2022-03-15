using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Noticia")]
public class NoticiaEntity
{
    public int Id { get; set; }
    [MaxLength(50)]
    public string nombre { get; set; }
    [MaxLength(200)]
    public string descripcion_corta { get; set; }
    public string descripcion { get; set; }
    [MaxLength(100)]
    public string img { get; set; }
    public DateTime fecha { get; set; }

}
