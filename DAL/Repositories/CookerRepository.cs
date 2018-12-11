﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  DAL.Entities;

namespace DAL.Repositories
{
    public class CookerRepository : Repository<Cooker>, ICookerRepository
    {
        public CookerRepository(KekContext context) : base(context)
        {
        }
    }
}
