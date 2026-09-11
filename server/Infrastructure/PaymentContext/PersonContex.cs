namespace Infrastructure.PaymentContext
{
    using Microsoft.EntityFrameworkCore;
    using Infrastructure.Entities;

    public class PersonContext : DbContext
    {
        public PersonContext(DbContextOptions<PersonContext> options) : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Card> Cards { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Card>()
                .Property(c => c.Balance)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Card>()
                .HasOne(c => c.Person)
                .WithMany(p => p.Cards)
                .HasForeignKey(c => c.PersonId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}