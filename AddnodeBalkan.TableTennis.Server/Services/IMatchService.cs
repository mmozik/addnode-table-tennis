using AddnodeBalkan.TableTennis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddnodeBalkan.TableTennis.Services
{
    public interface IMatchService
    {
        IEnumerable<Match> GetMatches();
        void AddMatch(Match match);
        void DeleteMatch(Match match);
        void UpdateMatch(Match match);
    }
}
