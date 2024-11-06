internal class Program
{
    class Kalkulator
    {
        public int dodaj(int a, int b)
        {
            return a + b;
        }
        
        public string dodaj(string a, string b)
        {
            return a +" "+ b;
        }
    }
    private static void Main(string[] args)
    {
        Kalkulator kalkulator = new Kalkulator();
        int broj = kalkulator.dodaj(1,2);
        Console.WriteLine(broj);
        string noviString = kalkulator.dodaj("Prvi", "Drugi");
        Console.WriteLine(noviString);
    }
}