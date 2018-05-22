using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using WpfChat.Common;

namespace WpfChat.Infrastucture.DatabaseContexts
{
    public partial class UserContext : DbContext
    {
        public UserContext()
            : base("name=RabbitMq")
        {
        }

        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
