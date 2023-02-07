using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FoodDeliveryPRojectFull.Shared.Domains
{
    public class SalesReport : BaseDomainModel/*,IValidatableObject*/
    {
        [Required]
        public int SalesReportID { get; set; }
        [Required]
        public virtual DateTime OrderTime { get; set; }
        public DateTime SaleTime { get; set; } = DateTime.Now;
        [Required]
        public virtual Food FoodId { get; set; }
        public virtual List<Food> Foods { get; set; }
        public Food Food { get; set; }
        [Required]
        public virtual Orders CustomerId { get; set; }
        public virtual Customer Customer{ get; set; }

       /* public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            //throw new NotImplementedException();
            if (OrderTime < DateTime.Today)
            {
                yield return new ValidationResult("Sorry we don't have a time machine to deliver to the time you selected.", new[] { "OrderTime" });
            }
        }*/
    }
}