using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Order
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsTaken { get; set; }

        public bool IsReady { get; set; }

        public DateTime Time { get; set; }

        public int? CookerId { get; set; }
        public Cooker Cooker { get; set; }

        public ICollection<Sushi> Sushies { get; set; }

        public Order()
        {
            Sushies = new HashSet<Sushi>();
        }
    }
}
