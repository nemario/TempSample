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
    public class RawGamesAccessor : ApiServiceBase, IRawGamesAccessor
    {

        public RawGame Create(RawGame entity)
        {
           
            entity.dateAdded = DateTime.UtcNow;
            entity.dateLastUpdated = DateTime.UtcNow;

            using (var db = new Db())
            {
                db.Set<RawGame>().Add(entity);
                db.SaveChanges();
            }

            return entity;
        }

        public RawGame Find(long IId)
        {

            //using (var db = new Db())
            //{
            //    var rtn = db.bggRawGames.Where(bggRawGame => bggRawGame.bggID == IId).FirstOrDefault();

            //    return rtn;
            //}
            return null;
        }

        public RawGame FindByAPIKey(String key)
        {

            using (var db = new Db())
            {

                var rtn = db.RawGames
                          .Where(g => g.APIID == key)
                          .FirstOrDefault();
                          
                          
                
                //var rtn = db.bggRawGames.SingleOrDefault(bggRawGame => bggRawGame.bggID == key);

                return rtn;
            }
        }

        public RawGame UpdateOrCreate(RawGame entity)
        {
            SetupUpdateOrCreate(entity);

            RawGame existing;

            using (var db = new Db())
            {
                existing = FindByAPIKey(entity.APIID);
                
            }

            if (existing == null)
            {
                //-- Insert --
                entity = Create(entity);
                entity.dateAdded = DateTime.UtcNow;

            }
            else
            {
                existing.TheBlob = entity.TheBlob;
                existing.isAlsoExpansion = entity.isAlsoExpansion;
                existing.lastUpdatedBy = "console-Update";
                existing.dateLastUpdated = DateTime.UtcNow;
                using (var db = new Db())
                {
                    db.Entry(existing).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }

            }

            return entity;
        }

        public void SetupUpdateOrCreate(RawGame entity)
        {
            //Logger.Log(string.Format(Properties.Resources.Accessors_Updating, typeof(ReportRecord).Name, entity.Id), TraceEventType.Verbose);
        }

    }
}
