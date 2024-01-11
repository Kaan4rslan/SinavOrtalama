using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_sinav_Ortalama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ilk notunuzu giriniz");
            Double n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ikinci notunuzu giriniz");
            Double n2 = Convert.ToDouble(Console.ReadLine());

            double ort1 = Ortalama1(n1, n2);

            if (ort1 >= 50)
                Console.WriteLine("Tebrikler gectiniz. Ortalamaniz: " + ort1);

            else if (ort1 < 50)
            { 
                Console.WriteLine("Kaldiniz, Ucuncu notunuzu giriniz.");
               Double n3 = Convert.ToInt32(Console.ReadLine());
                double ort2 = Ortalama2(n1, n2, n3);
                if (ort2 >= 50)
                    Console.WriteLine("Tebrikler gectiniz. Notunuz: " + ort2);
                else if (ort2 < 50)
                    Console.WriteLine("bu dersten kaldiniz.Notunuz: " + ort2);

            }
            Console.ReadKey();
        }

        static Double Ortalama2(double n1, double n2, double n3) 
        {
            Double sonuc2 = (n1 + n2 + n3) / 3;
            return sonuc2;
        }
        static Double Ortalama1(double n1, double n2)
        { 
            double sonuc1 = (n1+n2)/2;
            return sonuc1;

        }
    }
}
