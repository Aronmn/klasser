using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser
{
    class Program
    {
        static void Main(string[] args)
        {
            //Övning 1

            Bilregistret info = new Bilregistret();

            Console.Write("Ange bilmärke: ");
            info.Marke = Console.ReadLine();
            Console.Write("Ange modell: ");
            info.Modell = Console.ReadLine();
            Console.Write("Ange färg: ");
            info.Farg = Console.ReadLine();
            Console.Write("Ange antal dörrar: ");
            info.Dorrar = Console.ReadLine();
            Console.Write("Ange drivmedel: ");
            info.Drivmedel = Console.ReadLine();

            Console.WriteLine("Din bil är en " + info.Marke +" "+ info.Modell + " som är lackerad i " + info.Farg + " och har " + info.Dorrar + " dörrar. Drivmedlet är " + info.Drivmedel);

            Console.ReadKey();

            //Övning 2


        }
    }
}
