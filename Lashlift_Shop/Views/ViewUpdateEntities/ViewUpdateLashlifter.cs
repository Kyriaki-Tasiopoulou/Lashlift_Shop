using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lashlift_Shop
{
    public class ViewUpdateLashlifter : IViewUpdateLashlifter
    {
        public int ChooseLashlifterToUpdate(IEnumerable<Lashlifter> lashlifters)
        {
            const int space = -20;
            Console.WriteLine($"{"Lashlifters ID",space}{"Lashlifters Name",space}");

            foreach (var lashlifter in lashlifters)
            {
                Console.WriteLine($"{lashlifter.LashlifterId,space}{lashlifter.Name,space}");
            }

            Console.WriteLine("Choose by ID the lashlifter to update");
            string choice = Console.ReadLine();
            return Convert.ToInt32(choice);
        }
    }
}
