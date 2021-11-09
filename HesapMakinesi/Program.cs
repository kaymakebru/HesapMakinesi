using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            double sayi1, sayi2, sonuc = 0;
            Console.Write("1.sayıyı giriniz: ");
            sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2.sayıyı giriniz: ");
            sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Yapılması istenen işlemi seçiniz(Toplama: +, Çıkarma: -, Çarpma: *, Bölme: /): ");
            char islem = Convert.ToChar(Console.ReadLine());
            switch (islem)
            {
                case '+':
                    sonuc = sayi1 + sayi2;
                    Console.WriteLine("Toplama işleminin sonucu: " + sonuc);
                    break;
                case '-':
                    sonuc = sayi1 - sayi2;
                    Console.WriteLine("Çıkarma işleminin sonucu: " + sonuc);
                    break;
                case '*':
                    sonuc = sayi1 * sayi2;
                    Console.WriteLine("Çarpma işleminin sonucu: " + sonuc);
                    break;
                case '/':
                    sonuc = sayi1 / sayi2;
                    Console.WriteLine("Bölme işleminin sonucu: " + sonuc);
                    break;
                default:
                    Console.WriteLine("Hatalı seçim yaptınız!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
