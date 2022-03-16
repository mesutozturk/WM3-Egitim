namespace Polymorphism;

public class Konum
{
    
    public int Adres { get; set; }

    public static bool operator ==(Konum a, Konum b)
    {
        return a.Adres == b.Adres;
    }
    public static bool operator !=(Konum a, Konum b)
    {
        return a.Adres != b.Adres;
    }
    public override bool Equals(object? obj)
    {
        Console.WriteLine();
        return this.Adres == (obj as Konum).Adres;
    }
    
}