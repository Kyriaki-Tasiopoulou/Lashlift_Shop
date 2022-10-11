using Lashlift_Shop.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lashlift_Shop
{
    public class Program
    {
        static void Main(string[] args)
        {
            LashlifterController ctrl = new LashlifterController();

            ctrl.ReadLashliftersWithGirls();

            Console.WriteLine("Hi.");
        }
    }
}
