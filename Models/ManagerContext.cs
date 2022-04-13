using Microsoft.EntityFrameworkCore;

namespace TheContactManagerApp.Models
{
    public class ManagerContext : DbContext
    {
        public ManagerContext(DbContextOptions<ManagerContext> options)
            : base(options)
        { }
        public DbSet<Manager>? Managers { get; set; }
        public DbSet<Category>? Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Family" },
                new Category { CategoryId = 2, Name = "Friend" },
                new Category { CategoryId = 3, Name = "Work" },
                new Category { CategoryId = 4, Name = "Other" }
            );

            modelBuilder.Entity<Manager>().HasData(
                new Manager
                {
                    ManagerId = 1,
                FirstName = "Jonathan",
                LastName = "Joestar",
                PhoneNum = "777-545-6243",
                Email = "jojo@gmail.com",
                CategoryId = 1
            },
            new Manager
            {
                ManagerId = 2,
                FirstName = "Monkey",
                LastName = "Luffy",
                PhoneNum = "777-310-9976",
                Email = "monkeyDluffy@gmail.com",
                CategoryId = 2
            },
            new Manager
            {
                ManagerId = 3,
                FirstName = "Gon",
                LastName = "Freecss",
                PhoneNum = "777-221-1000",
                Email = "monkeyDluffy@gmail.com",
                CategoryId = 3
            }
          );
        }
    }
}