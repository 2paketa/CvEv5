using System;
using System.IO;
using System.Linq;

namespace CvEv5
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var mainbody = new MainBody();

            Console.WriteLine("Insert desired domains");
            var input = Console.ReadLine();
            Console.WriteLine("");
            var domains = input.ToString().Split(", ");
            Console.WriteLine(mainbody.getDomains(domains));
        }
    }
}
