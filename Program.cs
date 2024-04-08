using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEwAPPForLearning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FullName fullName = new FullName();
            fullName.Name("Nandan");

            Addition addition = new Addition();
            int result = addition.Add(10, 10);
            Console.WriteLine(result);
        }
    }
}
