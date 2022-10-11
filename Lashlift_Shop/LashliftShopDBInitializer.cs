using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lashlift_Shop
{
    public class LashliftShopDBInitializer : DropCreateDatabaseAlways<LashliftShopContext>
    {
        protected override void Seed(LashliftShopContext context)
        {
            Lashlifter l1 = new Lashlifter() { Name = "Kiki", Salary = 1000 };
            Lashlifter l2 = new Lashlifter() { Name = "Mary", Salary = 2000 };

            Girl g1 = new Girl() { Name = "Angy", Age = 27 };
            Girl g2 = new Girl() { Name = "Anna", Age = 25 };
            Girl g3 = new Girl() { Name = "Sofia", Age = 26 };
            Girl g4 = new Girl() { Name = "Olga", Age = 20 };


            l1.Girls.Add(g1);
            l1.Girls.Add(g3);
            l2.Girls.Add(g4);
            l2.Girls.Add(g2);

            g1.Lashlifter = l1;
            g2.Lashlifter = l2;
            g3.Lashlifter = l1;
            g4.Lashlifter = l2;

            context.LashLifters.Add(l1);
            context.LashLifters.Add(l2);
            context.Girls.Add(g1);
            context.Girls.Add(g2);
            context.Girls.Add(g3);
            context.Girls.Add(g4);

            context.SaveChanges();


            base.Seed(context);
        }
    }
}
