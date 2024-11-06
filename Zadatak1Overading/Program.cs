internal class Program
{
    private static void Main(string[] args)
    {
        //Klasa Ocjena preopterecuje metodu IzracunajProsjek()
        //jedan oblik metode treba da primi niz ocjena, a drugi da primi 2 ocjene
        Ocjena ocjena = new Ocjena();
        Console.WriteLine(ocjena.IzracunajProsjek(1, 2));
        Console.WriteLine(ocjena.IzracunajProsjek([2, 2, 5, 5, 4]));
    }
}

class Ocjena
{
    public double IzracunajProsjek(int[] ocjene)
    {

        double suma = 0;
        for (int i = 0; i < ocjene.Length; i++)
        {
            suma = suma + ocjene[i];
           
        }
        return  suma / ocjene.Length;
        
    }

    public double IzracunajProsjek(int a, int b)
    {
        int sum = a + b;
        return sum * 1.0 / 2;
    }
}