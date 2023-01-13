using System;
using System.Collections.Generic;

namespace FoodDeliveryPRojectFull.Shared.Domains
{
    public class Orders : BaseDomainModel
    {
        public DateTime OrderTime { get; set; }
        public int FoodId { get; set; }
        public virtual List<Food> Food { get; set; }
        public Food Foods { get; set; }
        public virtual Customer Customer{ get; set; }
    }
}