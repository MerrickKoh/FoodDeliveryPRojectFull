using System;
namespace FoodDeliveryPRojectFull.Shared.Domains
{
    public class Payment:BaseDomainModel
    {
       public string Svc { get; set; }
       public string CardNo { get; set; }
       public DateTime Expire { get; set; }
    }
}