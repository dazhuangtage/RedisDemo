using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisDemo
{
    public static class RedisHelp
    {
        public static string ClentIp { get; set; }
        public static int Prot { get; set; }
        public static string Password { get; set; }
        public static string ConnectionStr
        {
            get
            {
                return ClentIp + ":" + Prot;
            }
        }
    }
}
