namespace _01_Klassen_Bil;       //Namespace innebär en ytterligare nivå av organisering av sin kod
                            //Går då att använda klasser i olika projects som har olika namespace och då inte krockar


public class Bil
{
    public string modell;
    public int årsmådell;


}
            //Instansiera object, skapa 


internal class Program
{
    static void Main(string[] args)
    {

        Bil bil1 = new Bil();
        bil1.modell = "Volvo V60";
        bil1.årsmådell = 2023;

        var bil2 = new Bil();
        bil2.modell = "Tesla Model 3";
        bil2.årsmådell = 2025;

        Console.WriteLine($"Bil 1: {bil1.modell}, Årsmodell: {bil1.årsmådell}");
        Console.WriteLine($"Bil 2: {bil2.modell}, Årsmodell: {bil2.årsmådell}");



        Console.WriteLine("\n\nTryck på en tanget för att stränga fönstret...");
        Console.ReadKey(true);
    }
}
