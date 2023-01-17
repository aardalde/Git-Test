using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_2
{
    class Program
    {
        private int steve;
        public void setSteve(int s)
        {
            steve = s;
        }
        public int getSteve()
        {
            return steve;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world!" + 5);
            Console.ReadKey();
            Console.WriteLine("Setting Steve to 4");
            Program p = new Program();
            p.setSteve(4);
            Console.WriteLine("Steve is: " + p.getSteve());
            Console.ReadKey();
        }
    }
}
