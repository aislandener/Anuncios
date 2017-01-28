using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class SMTP
    {
        public string host { set; get; }
        public string user { set; get; }
        public string pass { get; set; }
        public int port { get; set; }
        public bool useSSL{ get; set; }

        public string ToString(int i)
        {
            return "host:" + host + ", user: " + user + ", pass: " + ", port: " + port + ", useSSL: " + useSSL;
        }
    }
}
