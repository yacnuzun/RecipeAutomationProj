using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Material:IEntity
    {
        public int Id { get; set; }
        public string MaterialName { get; set; }
    }
}
