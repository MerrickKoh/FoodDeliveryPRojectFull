using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryPRojectFull.Shared.Domains
{
    public class Events: BaseDomainModel
    {
        public String Name { get; set; }
        public Boolean IsEvent { get; set; }
    }
}
