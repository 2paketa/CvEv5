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

            
            var targetPath = @"C:\Users\m.prekas\CvEv5\Test.csv";
            StreamWriter sw = new StreamWriter(targetPath);


            using (sw)
            {
                sw.Write(mainbody.getDomains(domains));
            }
            // Console.WriteLine(mainbody.getDomains(domains));
        }
    }
}
