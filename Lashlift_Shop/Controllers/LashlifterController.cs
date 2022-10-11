using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lashlift_Shop.Controllers
{
    public class LashlifterController
    {
        ViewTables viewTables = new ViewTables();
        UnitOfWork unitOfwork = new UnitOfWork(new LashliftShopContext());
        ViewCreateLashlifter viewCreateLashlifter= new ViewCreateLashlifter();

        public void ReadLashliftersWithGirls()
        {
            var lashlifters = unitOfwork.Lashlifters.GetLashliftersWithGirls();
            viewTables.PrintLashLiftersWithGirls(lashlifters);
        }

        public void CreateLashlifter()
        {
            var lashlifter = viewCreateLashlifter.CreateNewLashlifter();
            unitOfwork.Lashlifters.Add(lashlifter);
            unitOfwork.Complete();
        }
    }
}
