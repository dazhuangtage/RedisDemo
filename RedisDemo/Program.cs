using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
namespace RedisDemo
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("当前RedisIp:127.0.0.1");
            Console.WriteLine("当前RedisPort:6379");
            Console.WriteLine("当前RedisPwd:freep456187");
            var redis = new RedisHelp("127.0.0.1", 6379,"freep456187");
            using (var client = redis.Connection())
            {
                if (client.HashContainsEntry("url", "baidu.com"))
                    Console.WriteLine("连接存在");
                else
                    Console.WriteLine("连接不存在");
                Console.WriteLine("Url的HASH总数:"+ client.GetHashCount("url"));
                
                //client.Save();//持久化到文件
                Console.WriteLine("打开连接成功......");
            }
        }
    }
}
