using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using RedisTools;
namespace RedisDemo
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        static void Main(string[] args)
        {
            HashOperator hashOperator = new HashOperator();
            hashOperator.Set("test", "name", "大壮他哥");
            Console.WriteLine(hashOperator.Get<string>("test", "name"));
            Console.ReadKey();
        }
    }
}
