using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lashlift_Shop
{
    public class LashliftShopContext : DbContext, ILashliftShopContext
    {
        public LashliftShopContext() : base("name=LashliftShop")
        {
            Database.SetInitializer<LashliftShopContext>(new LashliftShopDBInitializer());
        }


        public DbSet<Lashlifter> LashLifters { get; set; }
        public DbSet<Girl> Girls { get; set; }
    }
}
