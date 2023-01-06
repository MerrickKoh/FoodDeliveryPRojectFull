using System;
namespace FoodDeliveryPRojectFull.Shared.Domains
{
    public class payment:BaseDomainModel
    {
       public string svc { get; set; }
       public string CardNo { get; set; }
       public DateTime expire { get; set; }
    }
}