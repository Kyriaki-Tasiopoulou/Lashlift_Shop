using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lashlift_Shop
{
    public class Lashlifter
    {
        public int LashlifterId { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public ICollection<Girl> Girls { get; set; } = new HashSet<Girl>();
    }
}
