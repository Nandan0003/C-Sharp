using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace NEwAPPForLearning
{
    public class FullName
    {
        public string Name(string Name)
        {
            Console.WriteLine(Name);
            return Name;




        }
    }

    public class NickName : FullName
    {

        public string Name(string Name)
        {
            Console.WriteLine(Name);
            return Name;
        }



    }


    public class Addition
    {

        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
    }

}