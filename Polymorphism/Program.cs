// See https://aka.ms/new-console-template for more information
using Polymorphism;

int a = 5;
int b = 10;

a=b;
b=20;

Console.WriteLine(a);

Konum k1 = new Konum()
{
    Adres = 5
};

Konum k2 = new Konum()
{
    Adres = 10
};

k1=k2;

k2.Adres=20;

Console.WriteLine(k1.Adres);

if (k1.Equals(k2))
{
    
}

List<Sekil> sekiller = new List<Sekil>();

Sekil kare1 = new Kare(){ X = 10};
Sekil kare2 = new Kare(){ X = 4};
Sekil kare3 = new Kare(){ X = 2};

Sekil d1 = new Dikdortgen() { X = 3, Y = 4 };
Sekil d2 = new Dikdortgen() { X = 6, Y = 8 };
Sekil d3 = new Dikdortgen() { X = 5, Y = 12 };

Sekil u1 = new DikUcgen() { X = 4, Y = 2 };
Sekil u2 = new DikUcgen() { X = 42, Y = 2 };
Sekil u3 = new DikUcgen() { X = 41, Y = 2 };

sekiller.Add(kare1);
sekiller.Add(kare2);
sekiller.Add(kare3);

sekiller.Add(d1);
sekiller.Add(d2);
sekiller.Add(d3);

IHipotenus d4 = new DikUcgen()
{
    X = 3, Y = 4
};
//sekiller.Add(d4);



double alanToplam = 0,cevreToplam=0;
int kareSayisi = 0, dikdortgenSayisi = 0;
foreach (var item in sekiller)
{
    alanToplam += item.AlanHesapla();
    cevreToplam += item.CevreHesapla();
    
    if (item is Kare)
        kareSayisi++;
    else if (item is Dikdortgen dk)
    {
        dikdortgenSayisi++;
    }else if (item is IHipotenus du)
    {
       var hip= du.HipotenusHesapla();
    }
}

Console.WriteLine($"alanların toplamı: {alanToplam}");