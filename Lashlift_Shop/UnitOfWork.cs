
namespace Lashlift_Shop
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly LashliftShopContext _context;

        public UnitOfWork(LashliftShopContext context)
        {
            _context = context;
            Lashlifters = new LashlifterRepository(_context);
            Girls = new GirlRepository(_context);
        }

        public ILashlifterRepository Lashlifters { get; }
        public IGirlRepository Girls { get; }

        public int Complete()
        {
            return _context.SaveChanges();
        }
    }
}