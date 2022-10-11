using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lashlift_Shop
{
    public class ViewCreateGirl : IViewCreateGirl
    {
        public Girl CreateNewGirl()
        {
            Console.WriteLine("Enter Girls Name");
            string inputName = Console.ReadLine();
            Console.WriteLine("Enter Girls Age");
            string inputAge = Console.ReadLine();
            int.TryParse(inputAge, out int age);

            Girl girl = new Girl()
            {
                Name = inputName,
                Age = age
            };

            return girl;
        }
    }
}
