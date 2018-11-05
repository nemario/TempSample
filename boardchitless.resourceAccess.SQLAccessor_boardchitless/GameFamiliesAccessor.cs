using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BoardChitless.Shared.ApiServiceBase;
using LinqKit;
using BoardChitless.Shared.Contracts;
using BoardChitless.Shared.DataContracts;

namespace BoardChitless.ResourceAccess.SQLAccessor_BoardChitless
{
    public class GameFamiliesAccessor : ApiServiceBase, IGameFamiliesAccessor
    {

        public GameFamily Create(GameFamily entity)
        {
            entity.dateAdded = DateTime.UtcNow;
            entity.dateLastUpdated = DateTime.UtcNow;

            using (var db = new Db())
            {
                db.Set<GameFamily>().Add(entity);
                db.SaveChanges();
            }

            return entity;
        }

        public GameFamily Find(long IId)
        {
            using (var db = new Db())
            {
                return db.Set<GameFamily>().Find(IId);
            }
        }

        public GameFamily UpdateOrCreate(GameFamily entity)
        {
            SetupUpdateOrCreate(entity);

            GameFamily existing;

            using (var db = new Db())
            {
                existing = db.Set<GameFamily>().Find(entity.gameFamilyID);
            }

            if (existing == null)
            {
                //-- Insert --
                entity = Create(entity);
                entity.dateAdded = DateTime.UtcNow;
            }
            else
            {
                //-- Update --
                entity.dateLastUpdated = DateTime.UtcNow;

                using (var db = new Db())
                {
                    db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }

            }

            return entity;
        }

        public void SetupUpdateOrCreate(GameFamily entity)
        {
            //Logger.Log(string.Format(Properties.Resources.Accessors_Updating, typeof(ReportRecord).Name, entity.Id), TraceEventType.Verbose);
        }

    }
}
