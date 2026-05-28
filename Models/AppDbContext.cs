using Microsoft.EntityFrameworkCore;

namespace QuanLySach.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Sach> Sachs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure table name
            modelBuilder.Entity<Sach>().ToTable("Sach");

            // Seed initial data matching the assignment screenshots (optional but helpful)
            modelBuilder.Entity<Sach>().HasData(
                new Sach { Id = 1, Title = "Lập trình C# cơ bản", Author = "Phạm Hồng Phước", Price = 150000 },
                new Sach { Id = 2, Title = "ASP.NET Core Web API", Author = "Nguyễn Hoàng Anh", Price = 200000 },
                new Sach { Id = 3, Title = "Entity Framework Core", Author = "Trần Minh Đức", Price = 180000 },
                new Sach { Id = 4, Title = "SQL Server từ A đến Z", Author = "Đỗ Văn Hiếu", Price = 220000 },
                new Sach { Id = 5, Title = "HTML, CSS, JavaScript", Author = "Võ Minh Tuấn", Price = 120000 }
            );
        }
    }
}
