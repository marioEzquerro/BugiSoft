using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Juego")]
public class JuegoEntity
{

    public int Id { get; set; }
    [MaxLength(50)]
    public string nombre { get; set; }
    public string descripcion { get; set; }

    public DateTime fecha_lanzamiento { get; set; }
    [MaxLength(100)]
    public string genero { get; set; }
    [MaxLength(100)]
    public string plataforma { get; set; }
    [MaxLength(100)]
    public string imagen { get; set; }

}
