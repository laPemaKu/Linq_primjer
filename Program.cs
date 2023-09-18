using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_primjer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> stringList = new List<string>()
            {
                "C# Tutorials",
                "VB .NET Tutorials",
                "Learn C++",
                "HVC Tutorials",
                "Java"
            };
            var result = from s  in stringList
                         where s.Contains("Tutorials")
                         select s;
            foreach(var str in result)
            {
                Console.WriteLine(str);
            }

            Console.ReadKey();
        }
    }
}
