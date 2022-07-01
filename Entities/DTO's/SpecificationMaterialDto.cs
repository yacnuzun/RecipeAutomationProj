using Core.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTO_s
{
    public class SpecificationMaterialDto:IDto
    {
        public int SpecificationId { get; set; }
        public string Specification { get; set; }
        public string Material { get; set; }
        public int Slug { get; set; }
        public string Gauger { get; set; }

    }
}
