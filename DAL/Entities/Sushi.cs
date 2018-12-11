using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Sushi
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
