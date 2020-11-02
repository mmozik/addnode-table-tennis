using AddnodeBalkan.TableTennis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddnodeBalkan.TableTennis.Services
{
    public interface IPlayerService
    {
        IEnumerable<Player> GetAllPlayers();
        void AddPlayer(Player player);
        void UpdatePlayer(Player player);
        void DeletePlayer(int playerId);
    }
}
