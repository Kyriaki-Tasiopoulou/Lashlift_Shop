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
        ViewCreateLashlifter viewCreateLashlifter = new ViewCreateLashlifter();
        ViewDeleteLashlifter viewDeleteLashlifter = new ViewDeleteLashlifter();
        ViewUpdateLashlifter viewUpdateLashlifter = new ViewUpdateLashlifter();
        public void ReadLashliftersWithGirls()
        {
            var lashlifters = unitOfwork.Lashlifters.GetLashliftersWithGirls();
            viewTables.PrintLashLiftersWithGirls(lashlifters);
        }
        public void ReadAllLashlifters()
        {
            var lashlifters = unitOfwork.Lashlifters.GetAll();
            viewTables.PrintLashLifters(lashlifters);
        }
        public void ReadRichLashlifters()
        {
            var lashlifters = unitOfwork.Lashlifters.GetRichLashlifters();
            viewTables.PrintLashLifters(lashlifters);
        }
        public void CreateLashlifter()
        {
            var lashlifter = viewCreateLashlifter.CreateNewLashlifter();
            unitOfwork.Lashlifters.Add(lashlifter);
            unitOfwork.Complete();
        }

        public void DeleteLashlifter()
        {
            var lashlifters = unitOfwork.Lashlifters.GetAll();
            int lashlifterId = viewDeleteLashlifter.ChooseLashlifterToDelete(lashlifters);
            Lashlifter lashlifterToDelete = unitOfwork.Lashlifters.Get(lashlifterId);
            var girls = unitOfwork.Girls.GetAll().Where(x => x.Lashlifter.LashlifterId == lashlifterId);
            foreach (var girl in girls)
            {
                girl.Lashlifter = null;
            }
            unitOfwork.Lashlifters.Remove(lashlifterToDelete);
            unitOfwork.Complete();
        }

        public void UpdateLashlifter()
        {
            var lashlifters = unitOfwork.Lashlifters.GetAll();
            int lashlifterId = viewUpdateLashlifter.ChooseLashlifterToUpdate(lashlifters);
            Lashlifter lashlifter = unitOfwork.Lashlifters.Get(lashlifterId);
            Lashlifter newLashlifter = viewCreateLashlifter.CreateNewLashlifter();
            lashlifter.Name = newLashlifter.Name;
            lashlifter.Salary = newLashlifter.Salary;
            unitOfwork.Lashlifters.ModifyEntity(lashlifter);
            unitOfwork.Complete();

        }

    }
}
