using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Begin.Models
{
    public class Order
    {
        public int Id { set; get; }
        public int UserId { set; get; }
        public int PhoneId { set; get; }
        public User user { set; get; }
        public Phone phone { set; get; }

    }
}
