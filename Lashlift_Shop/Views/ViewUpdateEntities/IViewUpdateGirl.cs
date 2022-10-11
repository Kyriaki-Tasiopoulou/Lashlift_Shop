using System.Collections.Generic;

namespace Lashlift_Shop
{
    public interface IViewUpdateGirl
    {
        int ChooseGirlToUpdate(IEnumerable<Girl> girls);
    }
}