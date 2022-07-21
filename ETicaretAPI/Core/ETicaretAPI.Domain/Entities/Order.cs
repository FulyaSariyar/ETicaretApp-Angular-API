using ETicaretAPI.Domain.Entities.Common;

namespace ETicaretAPI.Domain.Entities
{
    public class Order : BaseEntity 
    {
        public int CustomerId { get; set; }
        public string  Description { get; set; }
        public string  Address { get; set; }
           
       //n-n ilişki products &  orders
       public ICollection<Product> Products { get; set; }
        //1-n Customer & Order
        public Customer Customer { get; set; }


    }
}
