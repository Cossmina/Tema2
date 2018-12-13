using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2tr
{
    public enum Persoana
    {
        male,
        female
    }

    class Program
    {
        static void Main(string[] args)
        {
            char? gen;
            DateTime now = DateTime.Now;

            Console.WriteLine("Introduceti data la care v-ati nascut(mm/dd/yyyy)");
            DateTime dataNasterii = DateTime.Parse(Console.ReadLine());
            //Calculul varstei
            TimeSpan varstaInZile = now - dataNasterii;
            int varsta = varstaInZile.Days / 365;
            Console.WriteLine("Varsta dumneavoastra este:" + " " + varsta);
            
            Console.WriteLine("Introduceti genul (male - m, female - f)");
            gen = char.Parse(Console.ReadLine());

            if (gen == 'f'& varsta<63)
            {
                Console.WriteLine(Persoana.female + " " + "at" + " " + varsta);
            }
            else if (gen == 'f' & varsta>=63)
            {
                Console.WriteLine(Persoana.female +" " + "retired");
            }

            else if (gen == 'm'& varsta<65)
            {
                Console.WriteLine(Persoana.male +" "+ "at" +" "+ varsta);
            }
            else if(gen == 'm' & varsta >= 65)
            {
                Console.WriteLine(Persoana.male + " " + "retired");
            }

            else
                Console.WriteLine("Nu ati introdus un gen valid");

            Console.ReadKey();

        }
    }
}
