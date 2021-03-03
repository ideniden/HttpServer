using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HTTPServerLib;
using HttpServer;

namespace HTTPServerLib
{
    class Program
    {
        static void Main(string[] args)
        {
            ExampleServer server = new ExampleServer("0.0.0.0", 4050);
            server.SetRoot(@"C:\Develop\Win32\HttpServer\HTTPServer\HTTPServer\wwwroot");
            server.Logger = new ConsoleLogger();
            server.Start();
        }
    }
}
