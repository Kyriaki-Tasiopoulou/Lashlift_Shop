using System.Collections.Generic;

namespace Lashlift_Shop
{
    public interface IViewDeleteLashlifter
    {
        int ChooseLashlifterToDelete(IEnumerable<Lashlifter> lashlifters);
    }
}