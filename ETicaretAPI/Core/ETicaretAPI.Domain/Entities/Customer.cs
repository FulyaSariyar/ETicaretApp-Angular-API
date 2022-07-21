using ETicaretAPI.Domain.Entities.Common;

namespace ETicaretAPI.Domain.Entities
{
    public class Customer :BaseEntity 
    {
        public int Name { get; set; }
        public ICollection <Order> Orders { get; set; }

    }
}
