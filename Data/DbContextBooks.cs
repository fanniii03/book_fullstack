using books_backend.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;


namespace books_backend.Data
{
    public class DbContextBooks :DbContext
    {
        public DbSet<Books> Book { get; set; }
        public DbContextBooks(DbContextOptions<DbContextBooks> options) :base (options)
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string connString = (@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=cardb;Integrated Security=True;MultipleActiveResultSets=true");
            optionsBuilder.UseSqlServer(connString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Books>().HasData(new Books { Id = "1", Title = "ABC", Author = "Kinga", Year = 2017 , Actions="action"}, new Books { Id = "2", Title = "CBA", Author = "Lilla", Year = 2018, Actions = "funny" });
            base.OnModelCreating(modelBuilder);
        }
    }
}
