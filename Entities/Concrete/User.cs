using Core;

namespace Entities.Concrete
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
