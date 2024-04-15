public class Cerchio : IFormaGeometrica
{

  public double Raggio { get; set; }
  public double calcoloArea()
  {
    return 3.14 * Raggio * Raggio;
  }

  public double calcolaPerimetro()
  {
    return 2 * 3.14 * Raggio;
  }
}