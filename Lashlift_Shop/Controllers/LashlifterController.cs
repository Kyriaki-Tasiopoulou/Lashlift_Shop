using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lashlift_Shop.Controllers
{
    public class LashlifterController : ILashlifterController
    {
        private readonly IViewTables _viewTables;
        private readonly IViewCreateLashlifter _viewCreateLashlifter;
        private readonly IViewDeleteLashlifter _viewDeleteLashlifter;
        private readonly IViewUpdateLashlifter _viewUpdateLashlifter;
        private readonly IUnitOfWork _unitOfWork;
        public LashlifterController(IViewTables viewTables, IViewCreateLashlifter viewCreateLashlifter, IViewDeleteLashlifter viewDeleteLashlifter, IViewUpdateLashlifter viewUpdateLashlifter, IUnitOfWork unitOfWork)
        {
            _viewTables = viewTables;
            _viewCreateLashlifter = viewCreateLashlifter;
            _viewDeleteLashlifter = viewDeleteLashlifter;
            _viewUpdateLashlifter = viewUpdateLashlifter;
            _unitOfWork = unitOfWork;
        }

        public void ReadLashliftersWithGirls()
        {
            var lashlifters = _unitOfWork.Lashlifters.GetLashliftersWithGirls();
            _viewTables.PrintLashLiftersWithGirls(lashlifters);
        }
        public void ReadAllLashlifters()
        {
            var lashlifters = _unitOfWork.Lashlifters.GetAll();
            _viewTables.PrintLashLifters(lashlifters);
        }
        public void ReadRichLashlifters()
        {
            var lashlifters = _unitOfWork.Lashlifters.GetRichLashlifters();
            _viewTables.PrintLashLifters(lashlifters);
        }
        public void CreateLashlifter()
        {
            var lashlifter = _viewCreateLashlifter.CreateNewLashlifter();
            _unitOfWork.Lashlifters.Add(lashlifter);
            _unitOfWork.Complete();
        }

        public void DeleteLashlifter()
        {
            var lashlifters = _unitOfWork.Lashlifters.GetAll();
            int lashlifterId = _viewDeleteLashlifter.ChooseLashlifterToDelete(lashlifters);
            Lashlifter lashlifterToDelete = _unitOfWork.Lashlifters.Get(lashlifterId);
            var girls = _unitOfWork.Girls.GetAll().Where(x => x.Lashlifter.LashlifterId == lashlifterId);
            foreach (var girl in girls)
            {
                girl.Lashlifter = null;
            }
            _unitOfWork.Lashlifters.Remove(lashlifterToDelete);
            _unitOfWork.Complete();
        }

        public void UpdateLashlifter()
        {
            var lashlifters = _unitOfWork.Lashlifters.GetAll();
            int lashlifterId = _viewUpdateLashlifter.ChooseLashlifterToUpdate(lashlifters);
            Lashlifter lashlifter = _unitOfWork.Lashlifters.Get(lashlifterId);
            Lashlifter newLashlifter = _viewCreateLashlifter.CreateNewLashlifter();
            lashlifter.Name = newLashlifter.Name;
            lashlifter.Salary = newLashlifter.Salary;
            _unitOfWork.Lashlifters.ModifyEntity(lashlifter);
            _unitOfWork.Complete();

        }

    }
}
