using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    partial class Program
    {
        private static void DecreaseScore()
        {
            // уменьшить gameScore на 1
            if(gameScore > 0)
            gameScore--;
            else
                gameScore=0;

        }
    }
}
