using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lashlift_Shop
{
    public class ViewTables
    {
        public void PrintLashLifters(IEnumerable<Lashlifter> lashlifters)
        {
            Console.WriteLine("--------------------------------------ALL LASHLIFTERS-----------------------------------------");
            const int space = -20;
            Console.WriteLine($"{"Lashlifters Name",space}{"Lashlifters Salary",space}");

            foreach (var lashlifter in lashlifters)
            {
                Console.WriteLine($"{lashlifter.Name,space}{lashlifter.Salary,space}");
            }
        }

        public void PrintGirls(IEnumerable<Girl> girls)
        {
            Console.WriteLine("--------------------------------------ALL GIRLS-----------------------------------------");
            const int space = -20;
            Console.WriteLine($"{"Girls Name",space}{"Girls Age",space}");

            foreach (var girl in girls)
            {
                Console.WriteLine($"{girl.Name,space}{girl.Age,space}");
            }
        }

        public void PrintLashLiftersWithGirls(IEnumerable<Lashlifter> lashlifters)
        {
            Console.WriteLine("--------------------------------------ALL LASHLIFTERS-----------------------------------------");

            foreach (var lashlifter in lashlifters)
            {
                Console.WriteLine($"Lashlifter: {lashlifter.Name} has the following girls:");
                foreach (var girl in lashlifter.Girls)
                {
                    Console.WriteLine(girl.Name);
                }
            }
        }
    }
}
