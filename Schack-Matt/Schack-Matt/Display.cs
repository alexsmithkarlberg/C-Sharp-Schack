using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schack_Matt
{
    class Display
    {
        // Not Finished!
        private void ChoosePieceColorMenu()
        {
            Console.WriteLine("What color would you like?");
            Console.WriteLine("[1] White");
            Console.WriteLine("[2] Black");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }
    }
}