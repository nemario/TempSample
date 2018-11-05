using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using BoardChitless.Shared.DataContracts;

namespace BoardChitless.ResourceAccess.SQLAccessor_BoardChitless
{
    public class Db : DbContext
    {
        public DbSet<GameFamily> GameFamilies { get; set; }
        public DbSet<rawStorage> rawStorage { get; set; }

        public DbSet<RawGame> RawGames { get; set; }

        public Db()
            : base("Db")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            Database.SetInitializer<Db>(null);
        }

    }
}
