namespace Polymorphism;

public class Dikdortgen : Sekil
{
    public double Y { get; set; }
    public override double AlanHesapla()
    {
        return X * Y;
    }

    public override double CevreHesapla()
    {
        return 2 * (X + Y);
    }
}