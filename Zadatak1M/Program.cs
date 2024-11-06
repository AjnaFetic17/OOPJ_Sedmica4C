internal class Program
{
    class Kalkulator
    {
        public int Saberi(int a, int b) { return a+b; }
    }
    private static void Main(string[] args)
    {
        //Napisati klasu Kalkulator i metodu Saberi koja sabira 2 cijela broja
        Kalkulator kalkulator = new Kalkulator();
        int rez = kalkulator.Saberi(4,5);
        Console.WriteLine(rez);
    }
}