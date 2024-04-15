public class Rettangolo : IFormaGeometrica
{
    public double Base { get; set; }
    public double Altezza { get; set; }
    
    public double calcoloArea()
    {
        return Base * Altezza;
    }

    public double calcolaPerimetro()
    {
        return 2 * (Base + Altezza);
    }
}
