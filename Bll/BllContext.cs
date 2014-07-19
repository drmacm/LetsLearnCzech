using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using LetsLearnCzech.DomainModel;

namespace LetsLearnCzech.Bll
{
    public class BllContext : DbContext
    {
        public BllContext()
        {
            var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<SimpleWord>();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Word> Words { get; set; }
    }
}
