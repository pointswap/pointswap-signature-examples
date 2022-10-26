using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace PointSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            string apiSecret = "NhqPtmdSJYdKjVHjA7PZj4Mge3R5YNiP1e3UZjInClVN65XAbvqqM6A7H5fATj0j";

            string queryString = "timestamp=1578963600000";
            Console.WriteLine("hash the string:");
            Console.WriteLine(queryString);
            Console.WriteLine("and return:");
            Console.WriteLine(Hmac.Sign(queryString, apiSecret));

            queryString = "platform_id=some_platform0&brand_id=1234&brand_member_id=5678&timestamp=1578963600000";
            Console.WriteLine("hash the string:");
            Console.WriteLine(queryString);
            Console.WriteLine("and return:");
            Console.WriteLine(Hmac.Sign(queryString, apiSecret));
        }
     }
}
