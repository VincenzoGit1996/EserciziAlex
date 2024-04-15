/*Definizione dell'interfaccia:

Crea un'interfaccia chiamata IFormaGeometrica.
All'interno dell'interfaccia, dichiara due metodi: CalcolaArea() e CalcolaPerimetro(). Questi metodi dovrebbero restituire valori double.
Implementazione delle classi:

Crea una classe Rettangolo che implementi l'interfaccia IFormaGeometrica.
Aggiungi proprietà per rappresentare la base e l'altezza del rettangolo.
Implementa i metodi CalcolaArea() e CalcolaPerimetro() per il rettangolo.
Crea una classe Cerchio che implementi l'interfaccia IFormaGeometrica.
Aggiungi una proprietà per rappresentare il raggio del cerchio.
Implementa i metodi CalcolaArea() e CalcolaPerimetro() per il cerchio.
Main:

Nel metodo Main, crea istanze di oggetti rettangolo e cerchio.
Chiedi all'utente di inserire le dimensioni del rettangolo e del cerchio.
Chiama i metodi CalcolaArea() e CalcolaPerimetro() per calcolare e visualizzare l'area e il perimetro di ciascuna forma.
Test:

Esegui il programma e verifica che i calcoli dell'area e del perimetro siano corretti per entrambe le forme geometriche.
Questa traccia ti darà una guida per creare un programma che calcola l'area e il perimetro di rettangoli e cerchi utilizzando 
interfacce in C#. Buona codifica!*/
public class Program
{
      static void Main(string[] args)
    {
        string input;
        do
        {
            Console.WriteLine("Cosa vuoi fare?:");
            Console.WriteLine("1. Calcola l'area e il perimetro di un rettangolo");
            Console.WriteLine("2. Calcola l'area e il perimetro di un cerchio");
            Console.WriteLine("3. Esci");
            input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Rettangolo rettangolo = new Rettangolo();

                    Console.Write("Inserisci l'altezza del rettangolo: ");
                    double altezza;
                    while (!double.TryParse(Console.ReadLine(), out altezza))
                    {
                        Console.WriteLine("Inserimento non valido. Riprova.");
                        Console.Write("Inserisci l'altezza del rettangolo: ");
                    }
                    rettangolo.Altezza = altezza;
                    Console.Write("Inserisci la base del rettangolo: ");

                    double baseRettangolo;
                    while (!double.TryParse(Console.ReadLine(), out baseRettangolo))
                    {
                        Console.WriteLine("Inserimento non valido. Riprova.");
                        Console.Write("Inserisci la base del rettangolo: ");
                    }
                    rettangolo.Base = baseRettangolo;

                    Console.WriteLine("Area del rettangolo: " + rettangolo.calcoloArea());
                    Console.WriteLine("Perimetro del rettangolo: " + rettangolo.calcolaPerimetro());
                    break;
                case "2":
                    Cerchio cerchio = new Cerchio();
                    Console.Write("Inserisci il raggio del cerchio: ");
                    double raggio;
                    while (!double.TryParse(Console.ReadLine(), out raggio))
                    {
                        Console.WriteLine("Inserimento non valido. Riprova.");
                        Console.Write("Inserisci il raggio del cerchio: ");
                    }
                    cerchio.Raggio = raggio;
                    Console.WriteLine("Area del cerchio: " + cerchio.calcoloArea());
                    Console.WriteLine("Perimetro del cerchio: " + cerchio.calcolaPerimetro());
                    break;
                case "3":
                    Console.WriteLine("Ciao Cuccioloooo!");
                    return;
                default:
                    Console.WriteLine("Scelta non valida. Riprova.");
                    break;
            }
            Console.WriteLine();
        } while (input != "3");
    }
}
