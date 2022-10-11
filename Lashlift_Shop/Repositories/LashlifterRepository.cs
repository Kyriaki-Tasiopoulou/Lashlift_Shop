using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lashlift_Shop
{
    public class LashlifterRepository : Repository<Lashlifter>, ILashlifterRepository
    {
        public LashlifterRepository(DbContext context) : base(context)
        {
        }

        public IEnumerable<Lashlifter> GetLashliftersWithGirls()
        {
            return _context.Set<Lashlifter>().Include("Girls");
        }

        public IEnumerable<Lashlifter> GetRichLashlifters()
        {
            return _context.Set<Lashlifter>().Where(lashlifter => lashlifter.Salary > 1000);
        }
    }
}
