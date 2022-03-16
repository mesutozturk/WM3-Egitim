namespace Polymorphism;

public abstract class Sekil
{
    public double X { get; set; }

    public virtual double AlanHesapla()
    {
        return X * X;
    }

    public abstract double CevreHesapla();
}