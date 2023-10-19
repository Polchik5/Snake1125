using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    partial class Program
    {
        private static void RemoveDecreaseSnake()
        {
            //int[] last = { snake.Last()[0], snake.Last()[1] };
            //snake.Remove(last);
            if(snake.Count == 1)
            {
                GameOver();
            }
            var index = snake.Count - 1;
            snake.RemoveAt(index);

        }
    }
}
