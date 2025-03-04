using System;

class Program
{
    static void Main()
    {
        //  1’den 10’a kadar olan sayıları ekrana yazdıran bir for döngüsü
        Console.WriteLine("1'den 10'a kadar olan sayılar:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        //  Kullanıcıdan alınan bir sayıya kadar olan sayıların toplamını hesaplayan bir program
        Console.Write("Bir sayı girin: ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        int toplam = 0;

        for (int i = 1; i <= sayi; i++)
        {
            toplam += i;
        }

        Console.WriteLine("Toplam: " + toplam);
    }
}
