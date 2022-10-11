using System.Collections.Generic;

namespace Lashlift_Shop
{
    public interface IViewTables
    {
        void PrintGirls(IEnumerable<Girl> girls);
        void PrintLashLifters(IEnumerable<Lashlifter> lashlifters);
        void PrintLashLiftersWithGirls(IEnumerable<Lashlifter> lashlifters);
    }
}