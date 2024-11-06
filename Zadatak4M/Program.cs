internal class Program
{
    class Matematika
    {
        public int PrebrojCifre(int a)
        {
            int br = 0;
            while (a != 0)
            {
                a /= 10;
                br++;
            }
            return br;
        }
    }
    private static void Main(string[] args)
    {
            //Klasa Matematika ima metodu PrebrojCifre() koja prima broj i vraca broj cifara u tom broju
            int a = 123456;
            Matematika matematika = new Matematika();
            int cifre = matematika.PrebrojCifre(a);
            Console.WriteLine(cifre);

    }
}