using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAppliction
{
     internal class Calculator
    {
        public static async Task<int> AddAsync(int a, int b) {
            ItemAddSchemaGetRequest req = new ItemAddSchemaGetRequest();
            Console.WriteLine("开始计算");
            int val=await Task.Run(()=> Add(a,b));
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("计算完毕");
            return val;
        }

        public static int Add(int a, int b) {
            return a + b;
        }
    }
}
