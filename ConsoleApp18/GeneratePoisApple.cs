using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    partial class Program
    {
        private static void GeneratePoiseApple()
        {
            for (int i = 0; i < 2; i++)
                poisapple[i] = random.Next(0, 40);
            poisapple[0] = poisapple[0] * 10;
            poisapple[1] = poisapple[1] * 10;
            graphics.FillEllipse(System.Drawing.Brushes.Yellow, poisapple[0], poisapple[1], 10, 10);
        }
    }
}
