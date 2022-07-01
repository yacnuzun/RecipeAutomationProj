using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class SpecificationMaterial:IEntity
    {
        public int Id { get; set; }
        public int MaterialId { get; set; }
        public int SpecificationId { get; set; }
        public int Slug { get; set; }
        public string Gauger { get; set; }
    }
}
