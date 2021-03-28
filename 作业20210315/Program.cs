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
            int i;
            string x1,y1;
            int x, y;
            string z;
            z = Convert.ToString(Console.ReadLine());
            if(z=="+"||z=="-")
            {
                Console.WriteLine("请选择：1.正常加减法，2.重构方法");
                i = Convert.ToInt32(Console.ReadLine());
                if (i == 1) { 
                    x = Convert.ToInt32(Console.ReadLine());
                    y = Convert.ToInt32(Console.ReadLine()); 
                    Counter.counter(x,y,z);
                    Counter.judge(x, y);
                }
                if (i == 2)
                {
                    x1 = Convert.ToString(Console.ReadLine());
                    y1 = Convert.ToString(Console.ReadLine());
                    Counter.counter1(x1, y1, z);
                }
            }
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            Counter.counter(x, y, z);
            Counter.judge(x, y);
            
          
            
            Console.ReadKey();
        }
        
    }
}
