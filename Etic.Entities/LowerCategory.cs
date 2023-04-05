using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IconEtic.Core;

namespace Etic.Entities
{
    public class LowerCategory : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Sort { get; set; }
        public string? IconName { get; set; }
        public string? Link { get; set; }
        public int? ParentId { get; set; }
    }
}
