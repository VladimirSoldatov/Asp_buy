using MVC_Begin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Begin
{
    static public class PhonesData
    {
        public static void Initialize(ShopContext context)
        {
            if (!context.Phones.Any())
            {
                context.Phones.AddRange
                    (
                    new Phone { Company = "Samsung", Model = "Galaxy S1", Price = 15000 },
                    new Phone { Company = "Apple", Model = "IPhone 4S", Price = 25000 },
                    new Phone { Company = "Apple", Model = "IPhone 4S", Price = 25000 },
                    new Phone { Company = "Nokia", Model = "3310", Price = 1000 }
                    );
            }
            if (!context.Users.Any())
            {
                context.Users.AddRange
                    (
                    new User { Name = "Leonid", ContactPhone = "+7915857474" },
                    new User { Name = "Alla", ContactPhone = "+7915858471" },
                    new User { Name = "Irina", ContactPhone = "+7928981251" }
                    );
            }
            context.SaveChanges();
        }

    }
}
