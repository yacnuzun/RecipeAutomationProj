using Core;

namespace Entities.Concrete
{
    public class Role : IEntity
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
    }
}
