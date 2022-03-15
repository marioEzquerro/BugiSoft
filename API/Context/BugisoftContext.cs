using System.Data.Entity;

public class BugisoftContext : DbContext
{
    public BugisoftContext(string connectionString) : base(connectionString)
    { }
    public DbSet<JuegoEntity> Juegos { get; set; }
    public DbSet<NoticiaEntity> Noticias { get; set; }


    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
