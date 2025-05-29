using System;

class Program
{
    static void Main()
    {
        // Kullanıcıdan bir sayı alalım
        Console.Write("Bir sayı girin: ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        // 1. Basit if
        if (sayi > 0)
        {
            Console.WriteLine("Sayı pozitiftir.");
        }

        // 2. if - else
        if (sayi % 2 == 0)
        {
            Console.WriteLine("Sayı çifttir.");
        }
        else
        {
            Console.WriteLine("Sayı tektir.");
        }

        // 3. if - else if - else
        if (sayi < 0)
        {
            Console.WriteLine("Sayı negatiftir.");
        }
        else if (sayi == 0)
        {
            Console.WriteLine("Sayı sıfırdır.");
        }
        else
        {
            Console.WriteLine("Sayı pozitiftir.");
        }

        // 4. switch-case örneği
        Console.Write("Bir gün numarası girin (1-7): ");
        int gun = Convert.ToInt32(Console.ReadLine());

        switch (gun)
        {
            case 1:
                Console.WriteLine("Pazartesi");
                break;
            case 2:
                Console.WriteLine("Salı");
                break;
            case 3:
                Console.WriteLine("Çarşamba");
                break;
            case 4:
                Console.WriteLine("Perşembe");
                break;
            case 5:
                Console.WriteLine("Cuma");
                break;
            case 6:
                Console.WriteLine("Cumartesi");
                break;
            case 7:
                Console.WriteLine("Pazar");
                break;
            default:
                Console.WriteLine("Geçersiz gün numarası!");
                break;
        }
    }
}
