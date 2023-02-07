using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FoodDeliveryPRojectFull.Shared.Domains
{
    public class Delivery : BaseDomainModel
    {
        [Required]
        public int DeliveryID { get; set; }
        public string Status { get; set; } = "Prepearing";
        public string DeliveryName { get; set; } = "Bob";
        [Required]
        public virtual DateTime OrderTime { get; set; }
        public virtual List<Food> Foods { get; set; }
        public Food Food { get; set; }
        [Required]
        public virtual Food FoodId { get; set; }
        [Required]
        public virtual Orders CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }   
}