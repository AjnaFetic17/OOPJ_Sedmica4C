internal class Program
{
    class Matematika
    {
        public int IzracunajKvadrat(int a)
        {
            return a * a;
        }
    }
    private static void Main(string[] args)
    {
        //Napisati klasu Matematika koja ima metodu IzracunajKvadrat()
        //metoda prima broj i vraca njegov kvadrat
        int a = 5;
        Matematika kvadrat = new Matematika();
        int rez = kvadrat.IzracunajKvadrat(a);
        Console.WriteLine(rez);
    }
}