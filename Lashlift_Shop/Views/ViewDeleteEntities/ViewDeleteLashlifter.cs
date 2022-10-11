using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lashlift_Shop
{
    public class ViewDeleteLashlifter
    {
        public int ChooseLashlifterToDelete(IEnumerable<Lashlifter> lashlifters)
        {
            const int space = -20;
            Console.WriteLine($"{"Lashlifters ID",space}{"Lashlifters Name",space}");

            foreach (var lashlifter in lashlifters)
            {
                Console.WriteLine($"{lashlifter.LashlifterId,space}{lashlifter.Name,space}");
            }

            Console.WriteLine("Choose by ID the lashlifter to delete");
            string choice = Console.ReadLine();
            return Convert.ToInt32(choice);
        }
    }
}
