using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int sayi1 = 10;
        int sayi2 = 5;

        // Method: toplama ve çıkarma sonuçlarını out parametreyle al
        int carpim;
        Hesapla(sayi1, sayi2, out int toplam, out int fark, out carpim);

        Console.WriteLine($"Toplam: {toplam}");
        Console.WriteLine($"Fark: {fark}");
        Console.WriteLine($"Çarpım: {carpim}");

        // Method: ref ile değer değiştir (değişkeni yerinde günceller)
        Console.WriteLine($"Sayi1 ilk değeri: {sayi1}");
        Arttir(ref sayi1);
        Console.WriteLine($"Sayi1 arttırıldıktan sonra: {sayi1}");

        // Method Overloading örnekleri:
        Yazdir("Merhaba dünya!");
        Yazdir(42);
        Yazdir("Bahattin", 2025);
        Console.WriteLine("Toplam (Sum ile): " + Topla(1, 2, 3, 4, 5));
        Console.WriteLine("Toplam (boş liste): " + Topla());
        Console.WriteLine("Toplam (tek sayı): " + Topla(42));
    }

    // --------- METHOD TANIMLARI ---------

    // out parametreli method
    static void Hesapla(int a, int b, out int toplam, out int fark, out int carpim)
    {
        toplam = a + b;
        fark = a - b;
        carpim = a * b;
    }

    // ref parametreli method
    static void Arttir(ref int x)
    {
        x += 1;
    }

    // ---------- METHOD OVERLOADING ----------

    static void Yazdir(string mesaj)
    {
        Console.WriteLine("Metin: " + mesaj);
    }

    static void Yazdir(int sayi)
    {
        Console.WriteLine("Sayı: " + sayi);
    }

    static void Yazdir(string ad, int yil)
    {
        Console.WriteLine($"{ad}, {yil} yılında kayıtlı.");
    }
    static int Topla(params int[] sayilar)
    {
        return sayilar.Sum(); // dizi elemanlarını toplar
    }
}

