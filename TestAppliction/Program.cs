using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAppliction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("进入方法!");
            var result=Calculator.AddAsync(1, 2);
            Console.WriteLine("即将输出结果");
            Console.WriteLine(result.Result);
            Console.WriteLine("结果输出完毕");
            Console.ReadKey();
        }
    }
}
