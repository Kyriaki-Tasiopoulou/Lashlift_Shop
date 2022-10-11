using Lashlift_Shop.Controllers;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lashlift_Shop
{
    public class Application : IApplication
    {
        private readonly IViewMainMenu _mainMenu;
        private readonly ILashlifterController _lashlifterController;
        private readonly IGirlController _girlController;

        public Application(IViewMainMenu mainMenu, ILashlifterController lashlifterController, IGirlController girlController)
        {
            _mainMenu = mainMenu;
            _lashlifterController = lashlifterController;
            _girlController = girlController;
        }

        public void Run()
        {
            string input;
            do
            {
                _mainMenu.PrintMainMenu();
                input = Console.ReadLine();
                Console.Clear();
                switch (input)
                {
                    case "1": _lashlifterController.ReadAllLashlifters(); break;
                    case "2": _lashlifterController.ReadLashliftersWithGirls(); break;
                    case "3": _lashlifterController.ReadRichLashlifters(); break;
                    case "4": _girlController.ReadAllGirls(); break;
                    case "5": _lashlifterController.CreateLashlifter(); break;
                    case "6": _girlController.CreateGirl(); break;
                    case "7": _lashlifterController.UpdateLashlifter(); break;
                    case "8": _girlController.UpdateGirl(); break;
                    case "9": _lashlifterController.DeleteLashlifter(); break;
                    case "10": _girlController.DeleteGirl(); break;
                    default:
                        break;
                }

            } while (input != "E");



        }
    }
}
