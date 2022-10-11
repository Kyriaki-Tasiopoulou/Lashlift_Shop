using System.Collections.Generic;

namespace Lashlift_Shop
{
    public interface IViewUpdateLashlifter
    {
        int ChooseLashlifterToUpdate(IEnumerable<Lashlifter> lashlifters);
    }
}