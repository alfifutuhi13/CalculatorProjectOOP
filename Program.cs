using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 4;
            int y = 2;
            Console.WriteLine("angka1 = {0}\nangka2 = {1}\n", x, y);

            
            Pertambahan a1 = new Pertambahan(x, y);
            Console.WriteLine("{0} + {1} = {2}", a1.A, a1.B, a1.Proccess()); //a1.A dan a1.B menunjukkan enkapsulasi, krn nilai A dan B bisa didapat                                                                 tapi tidak bisa di set
            a1.Display(); //Method Display hanya ada di abstract, tapi bisa dipanggil langsung. 

            Console.WriteLine("");

            Pengurangan a2 = new Pengurangan(x,y);
            Console.WriteLine("{0} - {1} = {2}", a2.A, a2.B, a2.Proccess());
            a2.Display(); // = a1.Display

            Console.WriteLine("");

            Perkalian a3 = new Perkalian(x, y);
            Console.WriteLine("{0} x {1} = {2}", a3.A, a3.B, a3.Proccess());
            a3.Display();

            Console.WriteLine("");

            Pembagian a4 = new Pembagian(x, y);
            Console.WriteLine("{0} / {1} = {2}", a4.A, a4.B, a4.Proccess());
            a4.Display();

            Console.WriteLine("");

        }
        abstract class DemoAbstract
        {
            public void Display()
            {
                Console.WriteLine("Perhitungan Selesai");
            }

            public abstract int Proccess();
        }
        class Pertambahan : DemoAbstract
        {
            public Pertambahan(int a, int b)
            {
                A = a;
                B = b;
            }

            public int A { get; private set; }
            public int B { get; private set; }

            public override int Proccess()
            {
                return A + B;
            }
        }
        class Pengurangan : DemoAbstract 
        {
            public Pengurangan(int a, int b)
            {
                A = a;
                B = b;
            }

            public int A { get; private set; }
            public int B { get; private set; }

            public override int Proccess()
            {
                return A - B;
            }
        }
        class Perkalian : DemoAbstract 
        {
            public Perkalian(int a, int b)
            {
                A = a;
                B = b;
            }

            public int A { get; private set; }
            public int B { get; private set; }

            public override int Proccess()
            {
                return A * B;
            }
        }
        class Pembagian : DemoAbstract 
        {
            public Pembagian(int a, int b)
            {
                A = a;
                B = b;
            }

            public int A { get; private set; }
            public int B { get; private set; }

            public override int Proccess()
            {
                return A / B;
            }
        }
    }
}
