using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL.Repositories
{
    public interface ICookerRepository : IRepository<Cooker>
    {
        //IQueryable<Cooker> GetAllCookers();
        //Cooker GetCookerById(int id);
    }
}
