using System.Collections.Generic;

namespace Lashlift_Shop
{
    public interface IViewDeleteGirl
    {
        int ChooseGirlToDelete(IEnumerable<Girl> girls);
    }
}