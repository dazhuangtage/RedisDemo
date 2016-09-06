using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RedisDemo
{
    public class RedisHelp
    {
        public string Host { get; set; }
        public int Prot { get; set; }
        public string Password { get; set; }
        public string ConnectionStr
        {
            get
            {
                return Host + ":" + Prot;
            }
        }

        public RedisHelp(string host, int prot, string password = "")
        {
            this.Host = host;
            this.Prot = prot;
            this.Password = password;
        }

        public RedisClient Connection()
        {
            RedisClient Client = new RedisClient(new RedisEndpoint() { Host = Host, Port = this.Prot, Password = this.Password });
            return Client;
        }
    }
}
