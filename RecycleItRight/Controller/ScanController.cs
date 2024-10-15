using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecycleItRight.Controller
{
    public class ScanController
    {
        public bool ScanItem(string item)
        {
            Console.WriteLine("--------------------Scanning---------------------");
            Console.WriteLine("Scanning item " + item + "...");
            int random = new Random().Next(0, 2);
            if (random == 0)
            {
                Console.WriteLine("Item detected");
                Console.WriteLine("--------------------Scanning Complete---------------------\n");
                return true;
            }
            else
            {
                Console.WriteLine("Item detetion failed. Please search manully.");
                Console.WriteLine("--------------------Scanning Complete---------------------\n");
                return false;
            }

        }
    }
}
