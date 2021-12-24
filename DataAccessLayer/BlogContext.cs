using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer
{
    public class BlogContext : DbContext
    {
        public DbSet<About> Abouts { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<User> Users { get; set; }
        public BlogContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connection = "Server=(localdb)\\MSSQLLocalDB;Database=BlogSzg;Trusted_Connection=true;MultipleActiveResultSets=true;";
            optionsBuilder.UseSqlServer(connection);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<About>()
                .HasOne(p => p.Author)
                .WithOne(p => p.About)
                .HasForeignKey<About>(p => p.AuthorId);
        }

    }
}
