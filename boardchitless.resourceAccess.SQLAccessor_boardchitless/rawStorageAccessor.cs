using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BoardChitless.Shared.ApiServiceBase;
using LinqKit;
using BoardChitless.Shared.Contracts;
using BoardChitless.Shared.DataContracts;
using BoardChitless.ResourceAccess.SQLAccessor_BoardChitless;

namespace BoardChitless.ResourceAccess.SQLAccessor_BoardChitless
{
    public class rawStorageAccessor : ApiServiceBase, IRawStorageAccessor
    {

        public rawStorage Create(rawStorage entity)
        {
            entity.dateAdded = DateTime.UtcNow;
            entity.dateLastUpdated = DateTime.UtcNow;

            using (var db = new Db())
            {
                db.Set<rawStorage>().Add(entity);
                db.SaveChanges();
            }

            return entity;
        }

        public rawStorage Find(long IId)
        {
            using (var db = new Db())
            {
                return db.Set<rawStorage>().Find(IId);
            }
        }

        public rawStorage UpdateOrCreate(rawStorage entity)
        {
            SetupUpdateOrCreate(entity);

            rawStorage existing;

            using (var db = new Db())
            {
                existing = db.Set<rawStorage>().Find(entity.rawStorageID);
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

        public void SetupUpdateOrCreate(rawStorage entity)
        {
            //Logger.Log(string.Format(Properties.Resources.Accessors_Updating, typeof(ReportRecord).Name, entity.Id), TraceEventType.Verbose);
        }

    }
}
