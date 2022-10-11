using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lashlift_Shop.Controllers
{
    public class GirlController
    {
        ViewTables viewTables = new ViewTables();
        UnitOfWork unitOfwork = new UnitOfWork(new LashliftShopContext());
        ViewCreateGirl viewCreateGirl = new ViewCreateGirl();
        ViewDeleteGirl viewDeleteGirl = new ViewDeleteGirl();
        ViewUpdateGirl viewUpdateGirl = new ViewUpdateGirl();

        public void ReadAllGirls()
        {
            var girls = unitOfwork.Girls.GetAll();
            viewTables.PrintGirls(girls);
        }

        public void CreateGirl()
        {
            var girl = viewCreateGirl.CreateNewGirl();
            unitOfwork.Girls.Add(girl);
            unitOfwork.Complete();
        }
        public void DeleteGirl()
        {
            var girls = unitOfwork.Girls.GetAll();
            int girlId = viewDeleteGirl.ChooseGirlToDelete(girls);
            Girl girlToDelete = unitOfwork.Girls.Get(girlId);
            unitOfwork.Girls.Remove(girlToDelete);
            unitOfwork.Complete();
        }
        public void UpdateGirl()
        {
            var girls = unitOfwork.Girls.GetAll();
            int girlId = viewUpdateGirl.ChooseGirlToUpdate(girls);
            Girl girlToUpdate = unitOfwork.Girls.Get(girlId);
            Girl newGirl = viewCreateGirl.CreateNewGirl();
            girlToUpdate.Name = newGirl.Name;
            girlToUpdate.Age = newGirl.Age;
            unitOfwork.Girls.ModifyEntity(girlToUpdate);
            unitOfwork.Complete();
        }
    }
}
