﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    partial class Program
    {
        private static void DrawBody()
        {
            for(int i = 1; i < snake.Count; i++)
            {
                graphics.FillEllipse(System.Drawing.Brushes.Pink, snake[i][0], snake[i][1], 10, 10);


            }
             
        }
    }
}
