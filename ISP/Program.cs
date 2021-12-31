using System;

namespace ISP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ISP - Interface Segregation Principle" + "\n");

            Console.WriteLine("No debemos tener intefaces muy grandes de tal forma que no obliguemos a los objetos que la implementan a implementar metodos que no necesiten." + "\n");

            Console.WriteLine("SimplePrinter");
            SimplePrinter simple = new SimplePrinter();
            simple.Print("imprimo");
            simple.Scan("escaneo");

            Console.WriteLine();

            Console.WriteLine("HPLaserJetPrinter");
            HPLaserJetPrinter hplaser = new HPLaserJetPrinter();
            hplaser.Print("imprimo");
            hplaser.Print("escaneo");
            hplaser.Fax("tambien tengo fax");
            
        }
    }
}
