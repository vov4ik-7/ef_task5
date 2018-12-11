using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL.Repositories
{
    public class SushiRepository : Repository<Sushi>, ISushiRepository
    {
        public SushiRepository(KekContext context) : base(context)
        {
        }
    }
}
