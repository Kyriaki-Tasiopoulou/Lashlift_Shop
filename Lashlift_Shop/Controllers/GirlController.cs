using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lashlift_Shop.Controllers
{
    public class GirlController
    {
        ViewTables viewTables = new ViewTables();
        UnitOfWork unitOfwork = new UnitOfWork(new LashliftShopContext());

        public void ReadAllGirls()
        {
            var girls = unitOfwork.Girls.GetAll();
            viewTables.PrintGirls(girls);
        }
    }
}
