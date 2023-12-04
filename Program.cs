//soru 1

using System;
using System.Collections;

int n = 7;
ArrayList asal = new ArrayList();
ArrayList asalOlmayan = new ArrayList();
float asalSonuc = 0;
float sonuc = 0;



for (int i = 0; i < n; i++)
{
    int sayi = int.Parse(Console.ReadLine());

    if(sayi < 0 ){
        break;
    }

    if(IsAsal(sayi)){
        asal.Add(sayi);
    }
    else
    {
        asalOlmayan.Add(sayi);
    }
}

asal.Sort();
asalOlmayan.Sort();

foreach (var item in asal)
{
    Console.WriteLine(item);
    asalSonuc += (int)item ;
}

foreach (var item in asalOlmayan)
{
    Console.WriteLine(item);
    sonuc += (int)item;
}

Console.WriteLine("eleman sayısı : "+ asal.Count+" ortalama: "+asalSonuc/asal.Count);
Console.WriteLine("eleman sayısı : "+ asalOlmayan.Count+" ortalama: "+sonuc/asalOlmayan.Count);



static bool IsAsal(int n)
    {
        if (n <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }

        return true;
    }


//soru 2

int[] array = new int[n];
int[] buyuk = new int[3];
int[] kucuk = new int[3];
int toplamBuyuk=0;
int toplamKucuk=0;
int buyukToplamOrt=0;
int kucukToplamOrt=0;
int toplamOrt = kucukToplamOrt + buyukToplamOrt;

for (int i = 0; i < n; i++)
{
    array[i] = int.Parse(Console.ReadLine());
}

Array.Sort(array);

//en büyük 3
for (int i = n-1; i > n-4; i--)
{
    toplamBuyuk += array[i];
}
    buyukToplamOrt += toplamBuyuk/3;

//en küçük 3
for (int i = 0; i < 3; i++)
{
    toplamKucuk += array[i];
}
kucukToplamOrt = toplamKucuk/3;
Console.WriteLine("buyuk ort: "+ buyukToplamOrt+" kucuk ort: "+kucukToplamOrt+" toplam ort: "+ (kucukToplamOrt+buyukToplamOrt));

//3. soru
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Bir cümle giriniz: ");
        string cumle = Console.ReadLine();

        // Sesli harfleri içeren bir liste oluştur
        List<char> sesliHarfler = new List<char>();

        // Cümle içindeki sesli harfleri bul ve listeye ekle
        for (int i = 0; i < cumle.Length; i++)
        {
            char karakter = char.ToLower(cumle[i]);

            if (IsSesliHarf(karakter))
            {
                sesliHarfler.Add(karakter);
            }
        }

        // Sesli harfleri sırala
        sesliHarfler.Sort();

        // Sıralanmış sesli harfleri ekrana yazdır
        Console.WriteLine("Sıralanmış Sesli Harfler:");
        foreach (var harf in sesliHarfler)
        {
            Console.WriteLine(harf);
        }
    }

    static bool IsSesliHarf(char harf)
    {
        // Verilen karakterin sesli harf olup olmadığını kontrol et
        char[] sesliHarfler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
        return sesliHarfler.Contains(harf);
    }
}
