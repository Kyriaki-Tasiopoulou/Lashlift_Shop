using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lashlift_Shop
{
    public class ViewDeleteGirl
    {
        public int ChooseGirlToDelete(IEnumerable<Girl> girls)
        {
            const int space = -20;
            Console.WriteLine($"{"Girls ID",space}{"Girls Name",space}");

            foreach (var girl in girls)
            {
                Console.WriteLine($"{girl.GirlId,space}{girl.Name,space}");
            }

            Console.WriteLine("Choose by ID the girl to delete");
            string choice = Console.ReadLine();
            return Convert.ToInt32(choice);
        }
    }
}
