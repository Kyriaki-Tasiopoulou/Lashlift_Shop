using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lashlift_Shop
{
    public interface ILashlifterRepository : IRepository<Lashlifter>
    {
        IEnumerable<Lashlifter> GetLashliftersWithGirls();

        IEnumerable<Lashlifter> GetRichLashlifters();
    }
}
