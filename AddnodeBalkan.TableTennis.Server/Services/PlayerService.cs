using AddnodeBalkan.TableTennis.Data.Repository;
using AddnodeBalkan.TableTennis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddnodeBalkan.TableTennis.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly PlayerRepository db;

        public PlayerService()
        {
            db = new PlayerRepository();
        }

        public void AddPlayer(Player player)
        {
            try
            {
                db.Add(player);
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public void DeletePlayer(int playerId)
        {
            try
            {
                var playerToRemove = db.Get().FirstOrDefault();
                if(playerToRemove != null)
                {
                    db.Delete(playerToRemove);
                }
                
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Player> GetAllPlayers()
        {
            try
            {
                return db.Get();
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public void UpdatePlayer(Player player)
        {
            try
            {
                db.Update(player);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
