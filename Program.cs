using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. I am a test.");
            Console.WriteLine("I also contain an extra class because it's fun.");
            Console.WriteLine("What comes between sprucerat and happymoth?");
            string a = Console.ReadLine();
            Console.WriteLine("Excellent.");
            Console.WriteLine("Now. How many gorillas can fit in a lantern?");
            string bstr = Console.ReadLine();
            double b = Convert.ToDouble(bstr);
            Console.WriteLine("Brilliant.");
            Console.WriteLine("Now for the final...");
            Console.WriteLine("On a scale from -i to walnut, how certain are you of your answers?");
            string c = Console.ReadLine();
            Class d = new Class(a, b, c);
            Console.WriteLine("Magnificent.");
            Console.WriteLine("Your answers are:");
            d.Print(d);
            Console.WriteLine("Those are very nice answers!");
            Console.WriteLine("Thank you for using. Press any key to exit.");
            Console.ReadLine();
        }
    }
}
