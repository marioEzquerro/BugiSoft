using System.Data.Entity;

public class LibraryContext : DbContext
{
    public LibraryContext(string connectionString) : base(connectionString)
    { }
    public DbSet<BookEntity> Books { get; set; }
    public DbSet<FaltasEntity> Faltas { get; set; }


    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
