using Domain.Entities.Base;
using Domain.Enums;

namespace Domain.Entities
{
    public class User : EntityBase<Guid>
    {
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public TypeUser TypeUser { get; set; }
    }
}
