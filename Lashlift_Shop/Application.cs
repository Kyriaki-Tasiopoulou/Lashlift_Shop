using Lashlift_Shop.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lashlift_Shop
{
    public class Application
    {
        public void Run()
        {
            ViewMainMenu mainMenu = new ViewMainMenu();
            LashlifterController lashlifterController = new LashlifterController();
            GirlController girlController = new GirlController();
            string input;
            do
            {

                mainMenu.PrintMainMenu();
                input = Console.ReadLine();
                Console.Clear();
                switch (input)
                {
                    case "1": lashlifterController.ReadAllLashlifters(); break;
                    case "2": lashlifterController.ReadLashliftersWithGirls(); break;
                    case "3": lashlifterController.ReadRichLashlifters(); break;
                    case "4": girlController.ReadAllGirls(); break;
                    case "5": lashlifterController.CreateLashlifter(); break;
                    case "6": girlController.CreateGirl(); break;
                    case "7": lashlifterController.UpdateLashlifter(); break;
                    case "8": girlController.UpdateGirl(); break;
                    case "9": lashlifterController.DeleteLashlifter(); break;
                    case "10": girlController.DeleteGirl(); break;
                    default:
                        break;
                }

            } while (input != "E");



        }
    }
}
