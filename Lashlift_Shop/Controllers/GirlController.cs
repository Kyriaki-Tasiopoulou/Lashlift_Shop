using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lashlift_Shop.Controllers
{
    public class GirlController : IGirlController
    {
        private readonly IViewTables _viewTables;
        private readonly IViewCreateGirl _viewCreateGirl;
        private readonly IViewDeleteGirl _viewDeleteGirl;
        private readonly IViewUpdateGirl _viewUpdateGirl;
        private readonly IUnitOfWork _unitOfWork;
        public GirlController(
            IViewTables viewTables, 
            IViewCreateGirl viewCreateGirl, 
            IViewDeleteGirl viewDeleteGirl, 
            IViewUpdateGirl viewUpdateGirl, 
            IUnitOfWork unitOfWork)
        {
            _viewTables = viewTables;
            _viewCreateGirl = viewCreateGirl;
            _viewDeleteGirl = viewDeleteGirl;
            _viewUpdateGirl = viewUpdateGirl;
            _unitOfWork = unitOfWork;           
        }      

        public void ReadAllGirls()
        {
            var girls = _unitOfWork.Girls.GetAll();
            _viewTables.PrintGirls(girls);
        }

        public void CreateGirl()
        {
            var girl = _viewCreateGirl.CreateNewGirl();
            _unitOfWork.Girls.Add(girl);
            _unitOfWork.Complete();
        }
        public void DeleteGirl()
        {
            var girls = _unitOfWork.Girls.GetAll();
            int girlId = _viewDeleteGirl.ChooseGirlToDelete(girls);
            Girl girlToDelete = _unitOfWork.Girls.Get(girlId);
            _unitOfWork.Girls.Remove(girlToDelete);
            _unitOfWork.Complete();
        }
        public void UpdateGirl()
        {
            var girls = _unitOfWork.Girls.GetAll();
            int girlId = _viewUpdateGirl.ChooseGirlToUpdate(girls);
            Girl girlToUpdate = _unitOfWork.Girls.Get(girlId);
            Girl newGirl = _viewCreateGirl.CreateNewGirl();
            girlToUpdate.Name = newGirl.Name;
            girlToUpdate.Age = newGirl.Age;
            _unitOfWork.Girls.ModifyEntity(girlToUpdate);
            _unitOfWork.Complete();
        }
    }
}
