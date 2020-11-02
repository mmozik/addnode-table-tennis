using AddnodeBalkan.TableTennis.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace AddnodeBalkan.TableTennis.Data.Repository
{
    public class PlayerRepository : BaseRepository<Player>
    {
        public override void Add(Player player)
        {
            try
            {
                db.Players.Add(player);
                db.SaveChanges();
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public override void Delete(Player player)
        {
            try
            {
                db.Players.Remove(player);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override IEnumerable<Player> Get()
        {
            try
            {
                return db.Players;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void Update(Player player)
        {
            try
            {
                var existingPlayer = db.Players.Single(p => p.Id == player.Id);
                if(existingPlayer != null)
                {
                    Delete(player);
                    Add(player);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
