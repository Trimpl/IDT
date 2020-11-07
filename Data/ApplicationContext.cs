using Microsoft.EntityFrameworkCore;
using IDT.Models;

namespace IDT.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Actions> Actions { get; set; }
        public DbSet<Actors> Actors { get; set; }
        public DbSet<Additions> Additions { get; set; }
        public DbSet<Templates> Templates { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=IDT;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actors>().HasData(
                new Actors[]
                {
                    new Actors { Id=1, Actor="developers"},
                    new Actors { Id=2, Actor="men"},
                    new Actors { Id=3, Actor="devOps"},
                    new Actors { Id=4, Actor="data scientists"},
                    new Actors { Id=5, Actor="business analysts"},
                    new Actors { Id=6, Actor="cloud сomputing experts"},
                    new Actors { Id=7, Actor="data engineers"},
                    new Actors { Id=8, Actor="fullstack-developers"},
                    new Actors { Id=9, Actor="IoT specialists"},
                    new Actors { Id=10, Actor="network administrators"},
                    new Actors { Id=11, Actor="information security specialists"},
                    new Actors { Id=12, Actor="HR managers"},
                    new Actors { Id=13, Actor="sales managers"},
                    new Actors { Id=14, Actor="account managers"},
                    new Actors { Id=15, Actor="project managers"},
                    new Actors { Id=16, Actor="copywriters"},
                    new Actors { Id=17, Actor="game writers"},
                    new Actors { Id=18, Actor="3D Modelers"},
                    new Actors { Id=19, Actor="animators"},
                    new Actors { Id=20, Actor="art directors"}
                });
            modelBuilder.Entity<Actions>().HasData(
                new Actions[]
                {
                    new Actions { Id=1, Action="create"},
                    new Actions { Id=2, Action="make"},
                    new Actions { Id=3, Action="produce"},
                    new Actions { Id=4, Action="invent"},
                    new Actions { Id=5, Action="construct"},
                    new Actions { Id=6, Action="defile"},
                    new Actions { Id=7, Action="collaborate with"},
                    new Actions { Id=8, Action="calculate"},
                    new Actions { Id=9, Action="build"},
                    new Actions { Id=10, Action="watch"},
                    new Actions { Id=11, Action="count"},
                    new Actions { Id=12, Action="predict"},
                    new Actions { Id=13, Action="distribute"},
                    new Actions { Id=14, Action="collect"},
                    new Actions { Id=15, Action="spam"},
                    new Actions { Id=16, Action="hack"},
                    new Actions { Id=17, Action="breack"},
                    new Actions { Id=18, Action="fix"},
                    new Actions { Id=19, Action="clear"},
                    new Actions { Id=20, Action="write down"}
                });
            modelBuilder.Entity<Additions>().HasData(
                new Additions[]
                {
                    new Additions { Id=1, Addition="big data analytics"},
                    new Additions { Id=2, Addition="calculations for the construction of an intergalactic ship"},
                    new Additions { Id=3, Addition="puppy registration database"},
                    new Additions { Id=4, Addition="skyscrapers"},
                    new Additions { Id=5, Addition="warehouses with Formula 1 cars"},
                    new Additions { Id=6, Addition="artificial intelligence robots"},
                    new Additions { Id=7, Addition="digital twin"},
                    new Additions { Id=8, Addition="virtual reality wars"},
                    new Additions { Id=9, Addition="distributed data chain"},
                    new Additions { Id=10, Addition="adaptive security architecture"},
                    new Additions { Id=11, Addition="deadly virus distribution maps"},
                    new Additions { Id=12, Addition="route for pizza delivery men"},
                    new Additions { Id=13, Addition="circuits for electronic boards"},
                    new Additions { Id=14, Addition="discounts on aliexpress"},
                    new Additions { Id=15, Addition="fun days on vacation"},
                    new Additions { Id=16, Addition="invisible force that cleans the house"},
                    new Additions { Id=17, Addition="mining of endless energy"},
                    new Additions { Id=18, Addition="birthday scenarios"},
                    new Additions { Id=19, Addition="potatoes in the village"},
                    new Additions { Id=20, Addition="works of art"}
                });
            modelBuilder.Entity<Templates>().HasData(
                new Templates[]
                {
                    new Templates { Id=1, Template="Implement application using {techStack} allowing {actor} {action} {addition}."},
                    new Templates { Id=2, Template="Using {techStack} implement an application allowing {actor} {action} {addition}."},
                    new Templates { Id=3, Template="With the help of {techStack} implement an application allowing {actor} {action} {addition}."}
                });
        }
    }
}
