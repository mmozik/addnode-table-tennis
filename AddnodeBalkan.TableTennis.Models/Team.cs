using AddnodeBalkan.TableTennis.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddnodeBalkan.TableTennis.Models
{
    public class Team
    {
        public Team()
        {
            Players = new HashSet<Player>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Player> Players { get; set; }
        public Score Score { get; set; }

        // foreign key relation
        public virtual Match Match { get; set; }
    }
}
