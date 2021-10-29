using System;

namespace Sayi_Yazdirma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int baslangic, bitis;

            Console.Write("Başlangıç Değerini Giriniz : ");
            baslangic=Convert.ToInt32(Console.ReadLine());

            Console.Write("Bitiş Değerini Giriniz : ");
            bitis=Convert.ToInt32(Console.ReadLine());

            while (baslangic <= bitis)
            {
                if (baslangic % 2 == 0 && baslangic % 3 == 0)
                {
                    Console.Write("\n" + baslangic.ToString());
                    Console.ReadLine();
                }

                baslangic++;
               
            }
        }
    }
}
