using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repositories;

namespace DAL.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        ICookerRepository Cookers { get; }
        IOrderRepository Orders { get; }
        ISushiRepository Sushies { get; }
        int Complete();
    }
}
