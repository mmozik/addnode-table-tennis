using AddnodeBalkan.TableTennis.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AddnodeBalkan.TableTennis.Data.Repository
{
    public class MatchRepository : BaseRepository<Match>
    {
        public override void Add(Match match)
        {
            try
            {
                db.Matches.Add(match);
                db.SaveChanges();
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public override void Delete(Match match)
        {
            try
            {
                db.Matches.Remove(match);
                db.SaveChanges();
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public override IEnumerable<Match> Get()
        {
            try
            {
                return db.Matches;
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public override void Update(Match match)
        {
            try
            {
                db.Matches.Update(match);
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
