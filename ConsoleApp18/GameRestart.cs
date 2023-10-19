using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    partial class Program
    {
        private static void GameRestart()
        {
            ///Поменять значение gameRestart на противоположное
            Console.WriteLine("Хотите начать заново? ");
            string otvet = Console.ReadLine();
            if(otvet == "да") 
            {
                gameRunning = true;
                Console.Clear();
                graphics.Clear(Color.Black);
                Main(null);
            }

        }
    }
}
