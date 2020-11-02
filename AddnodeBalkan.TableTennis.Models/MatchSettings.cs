using AddnodeBalkan.TableTennis.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddnodeBalkan.TableTennis.Models
{
    public class MatchSettings
    {
        public int Id { get; set; }
        public MatchType MatchType { get; set; }
        public int Sets { get; set; }
        public int Points { get; set; }
    }
}
