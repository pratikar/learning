namespace Chatter.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ChatterModel : DbContext
    {
        public ChatterModel()
            : base("name=Chatter")
        {
        }

        public virtual DbSet<Chat> Chats { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Chat>()
                .Property(e => e.SenderId)
                .IsUnicode(false);

            modelBuilder.Entity<Chat>()
                .Property(e => e.ReceiverId)
                .IsUnicode(false);

            modelBuilder.Entity<Chat>()
                .Property(e => e.ChatContent)
                .IsUnicode(false);
        }
    }
}
