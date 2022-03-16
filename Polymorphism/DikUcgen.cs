namespace Polymorphism;

public class DikUcgen : Dikdortgen,IHipotenus
{
    public override double AlanHesapla()
    {
        return base.AlanHesapla()/2;
    }

    public override double CevreHesapla()
    {
        return X + Y + this.HipotenusHesapla();
    }

    public double HipotenusHesapla()
    {
        return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
    }
}