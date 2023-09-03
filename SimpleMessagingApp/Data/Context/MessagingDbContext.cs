using Microsoft.EntityFrameworkCore;
using SimpleMessagingApp.Data.Entity;
using Message = SimpleMessagingApp.Data.Entity.Message;

namespace SimpleMessagingApp.Data.Context
{
    public class MessagingDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //connection string
                optionsBuilder.UseSqlServer("");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Nickname);
                entity.Property(e => e.Nickname).IsRequired();
            });

            modelBuilder.Entity<Server>(entity =>
            {
                entity.HasKey(e => e.Nickname);
                entity.Property(e => e.Nickname).IsRequired();
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.HasKey(e => e.MessageId);
                entity.Property(e => e.Content).IsRequired();
                entity.Property(e => e.MessageId)
                .ValueGeneratedOnAdd();
                entity.Property(e => e.InsertDateTime).IsRequired();
                entity.HasOne(e => e.SenderUser)
                      .WithMany(u => u.SentMessages)
                      .HasForeignKey(e => e.SenderUserName)
                      .OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(e => e.RecipientUser)
                      .WithMany(u => u.ReceivedMessages)
                      .HasForeignKey(e => e.RecipientUserName)
                      .OnDelete(DeleteBehavior.Restrict);
            });
        }
    }
}