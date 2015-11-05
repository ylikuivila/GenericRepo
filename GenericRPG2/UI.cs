using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRPG2
{
    class UI
    {

        internal void showText(string txt)
        {
            Console.WriteLine(txt);
        }


        internal string getUserInput()
        {
            return Console.ReadLine();
        }

        internal int showMenu()
        {
            Console.WriteLine("'''''''''''''''''''''''''''This is a menu'''''''''''''''''''''''''''''''");
            Console.WriteLine("'''''''''''''''''''''''''''Press 1 to enter the Syntax''''''''''''''''''");
            Console.WriteLine("'''''''''''''''''''''''''''Press 2 to exit the application''''''''''''''");
            Console.WriteLine("'''''''''''''''''''''''''''Press 3 for blue pill''''''''''''''''''''''''");
            Console.WriteLine("'''''''''''''''''''''''''''Press 4 for red pill'''''''''''''''''''''''''");
            Console.WriteLine("''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''");


            return checkInput(Console.ReadLine(), 3);
        }

        private int checkInput(string userInput, int nmbrOfMenuItems)
        {
            int i;

            int.TryParse(userInput, out i);

            if (i > 0 && i <= nmbrOfMenuItems)
            {
                return i;
            }
            else return -1;
        }








    }
}
