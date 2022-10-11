using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lashlift_Shop
{
    public class ViewCreateLashlifter
    {
        public Lashlifter CreateNewLashlifter()
        {
            Console.WriteLine("Enter Lashlifters Name");
            string inputName = Console.ReadLine();
            Console.WriteLine("Enter Lashlufters Salary");
            string inputSalary = Console.ReadLine();
            int.TryParse(inputSalary, out int salary);

            Lashlifter lashlifter = new Lashlifter()
            {
                Name = inputName,
                Salary = salary
            };
            return lashlifter;
        }
    }
}
