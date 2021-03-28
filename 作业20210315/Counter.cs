using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 作业20210315
{
    class Counter
    {
        
            public static void counter(int x, int y, string z)
            {
               /* try//系统会提示错误才行，嵌套if语句，没有其他符号只是条件为假 ，所以应该把if放外面
                {
                    if (z == "+") { Console.WriteLine("结果为：", x + y); }//记得要用占位符
                    if (z == "-") { Console.WriteLine("结果为：", x - y); }
                    if (z == "*") { Console.WriteLine("结果为：", x * y); }
                    if (z == "/") { Console.WriteLine("结果为：", x / y); }
                }
                catch
                {
                    Console.WriteLine("错啦！符号不是加减乘除或者被除数为0！");
                }*/
                if(z == "+") { Console.WriteLine("结果为：{0}", x + y); }
                else if(z == "-") { Console.WriteLine("结果为：{0}", x - y); }
                else if(z == "*") { Console.WriteLine("结果为：{0}", x * y); }
                else if(z == "/") {
                    try
                    {
                        Console.WriteLine("结果为：{0}", x / y);

                    }
                    catch 
                    {
                        Console.WriteLine("错啦！被除数为0！");
                    }

                }
                else{
                    Console.WriteLine("错啦！只支持加减乘除的运算！");
                }

            }
            public static void judge(int x, int y) 
            {
                Console.WriteLine("两数是否相等结果：{0}",x.Equals(y));
            
            }
    }
}
