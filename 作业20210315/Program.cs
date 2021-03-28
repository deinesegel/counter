using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 作业20210315
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            string z;
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            z = Convert.ToString(Console.ReadLine());
            Counter.counter(x,y,z);
            Counter.judge(x, y);
            Console.ReadKey();
        }
        
    }
}
