using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31._10._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Zapisz_do_pliku("3CT-czy działa?");
            string linia = program.Odczytanie_z_pliku();
            Console.WriteLine(linia);
            Console.ReadKey();
        }

        private void Zapisz_do_pliku(string text)
        {
            string path = @".\Plik.txt";
            using (StreamWriter zapis = new StreamWriter(path))
            {
                zapis.Write(text);
            }
        }

        private string Odczytanie_z_pliku()
        {
            string text;

            using (StreamReader odczyt = new StreamReader(@".\Plik.txt"))
            {
                text = odczyt.ReadToEnd();
                return text;
            }


        }
    }
}
