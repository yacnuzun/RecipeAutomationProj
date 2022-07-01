using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Specification:IEntity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public List<SpecificationMaterial>? SpecificationMaterial { get; set; }
        public string? Image { get; set; }
        public string Description { get; set; }
        public DateTime DateTime { get; set; }
        public int ViewCount { get; set; }
    }
}
