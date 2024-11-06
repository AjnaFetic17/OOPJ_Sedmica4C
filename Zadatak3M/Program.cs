internal class Program
{
    class Matematika
    {
        public double IzracunajProsjek(int[] niz)
        {
            double br = 0, suma = 0, prosjek;
            for (int i = 0; i < niz.Length; i++)
            {
                suma = suma + niz[i];
                br++;
            }
            prosjek = suma / br;
            return prosjek;

        }
    }
    private static void Main(string[] args)
    {
        //klasa Matematika ima metodu IzracunajProsjek(), koja prima niz brojeva i vracanjihov prosjek
        //Console.WriteLine("Hello, World!");
        int[] niz = { 1, 2, 3, 4, 5 };
        Matematika M = new Matematika();
          double rez =   M.IzracunajProsjek(niz);
        Console.WriteLine(rez);
        //niz.Length

        
    }
}