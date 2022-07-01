using Core.Entities.Dto;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTO_s
{
    public class SpecificationDetailDto : IDto
    {
        public int SpecificationId { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public List<SpecificationMaterial> MaterialList { get; set; }
        public string Image { get; set; }
        public DateTime DateTime { get; set; }
    }
}
