using LocalGym.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
namespace LocalGym.Data
{
    public class GymDbContext:DbContext
    { 
        public GymDbContext(DbContextOptions<GymDbContext>options):base (options)
        {

        }
        public DbSet<Member> Members { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Session> Sessions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Member>().HasData(
                new Member
            {
                    MemberId=1,
                FirstName="karpagam",
                LastName="s",
                Email="aaa@gmail.com",
                JoinDate=System.DateTime.Now,

            },
               new Member
               {
                   MemberId = 2,
                   FirstName = "Hanumika",
                   LastName = "g",
                   Email = "aaa@gmail.com",
                   JoinDate = System.DateTime.Now,

               });
        }
    }

}
