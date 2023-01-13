using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryPRojectFull.Shared.Domains
{
    public class Food:BaseDomainModel
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int EventsId { get; set; }
        public virtual Events Events { get; set; }
        public int CatergoryId { get; set; }
        public virtual Catergory Catergory { get; set; }


    }
}
