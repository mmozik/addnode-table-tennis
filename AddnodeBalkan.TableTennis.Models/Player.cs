using AddnodeBalkan.TableTennis.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddnodeBalkan.TableTennis.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // foreign key relation
        public virtual Team Team { get; set; }
    }
}