using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lashlift_Shop
{
    public class GirlRepository : Repository<Girl>, IGirlRepository
    {
        public GirlRepository(DbContext context) : base(context)
        {
        }
    }
}
