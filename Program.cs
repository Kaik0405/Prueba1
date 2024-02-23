using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUnity
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            Console.WriteLine("Hello world1");
            Console.WriteLine("Hello world2");

            Card C1 = new Card(100,"Monarca de las Sombras","Ser divino",10,"Lider");
            C1.getCard();
        }
    }
}
