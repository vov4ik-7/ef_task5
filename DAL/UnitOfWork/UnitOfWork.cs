using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repositories;

namespace DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly KekContext _context;

        public UnitOfWork(KekContext context)
        {
            _context = context;
            Cookers = new CookerRepository(_context);
            Orders = new OrderRepository(_context);
            Sushies = new SushiRepository(_context);
        }

        public ICookerRepository Cookers { get; private set; }
        public IOrderRepository Orders { get; private set; }
        public ISushiRepository Sushies { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
