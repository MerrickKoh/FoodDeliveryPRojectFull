using System.Collections.Generic;

namespace FoodDeliveryPRojectFull.Shared.Domains
{
    public class Customer : BaseDomainModel
    {
        public string Contact { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public virtual Payment Payment { get; set; }
        public virtual List<Orders> Orders { get; set; }

    }
}