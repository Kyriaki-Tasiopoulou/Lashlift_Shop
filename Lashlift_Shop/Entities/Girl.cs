using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lashlift_Shop
{
    public class Girl
    {
        public int GirlId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Lashlifter Lashlifter { get; set; }
    }
}
