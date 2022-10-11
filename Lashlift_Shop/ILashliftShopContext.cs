using System.Data.Entity;

namespace Lashlift_Shop
{
    public interface ILashliftShopContext
    {
        DbSet<Girl> Girls { get; set; }
        DbSet<Lashlifter> LashLifters { get; set; }
    }
}