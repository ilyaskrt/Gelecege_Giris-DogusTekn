using IdeaApi.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace IdeaApi.Db
{
    public class MyFavoriteIdeaDbContext
    : DbContext
    {
        public MyFavoriteIdeaDbContext(DbContextOptions<MyFavoriteIdeaDbContext> options)
        : base(options)
        {
        }
        public DbSet<Idea> Ideas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Idea>().HasData(new Idea
            {
                IdeaId = 1,
                Owner = "Feyza",
                AddedDate = DateTime.Now,
                Description = "Corona'yı aşı olmadan ilaçla atlatabilsek ne güzel olurdu.",
                Like = 1
            });

            modelBuilder.Entity<Idea>().HasData(new Idea
            {
                IdeaId = 2,
                Owner = "Remzi",
                AddedDate = DateTime.Now,
                Description = "Aşı olmak istemeyenlerin aşısını olabilsek.",
                Like = 1
            });
        }
    }
}