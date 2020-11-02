using AddnodeBalkan.TableTennis.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddnodeBalkan.TableTennis.Models
{
    public class Match
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public MatchSettings Settings { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
    }
}
