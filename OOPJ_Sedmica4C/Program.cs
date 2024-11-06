internal class Program
{
    class Osoba
    {
        private string ime, zvanje;
        private int godine;
        public Osoba(string ime, string zvanje, int godine)
        {
            this.ime = ime;
            this.zvanje = zvanje;
            this.godine = godine;
        }
        public void Pozdrav()
        {
            Console.WriteLine($"Zdravo, moje ime je {ime}, i imam {godine} godina");
        }
    }
    private static void Main(string[] args)
    {
        Osoba osoba1 = new Osoba("Ajna", "Programer", 20);
        osoba1.Pozdrav();
       //klasa osoba s atributima ime, godine i zvanje 
       //preko konstruktora postaviti ime,godine i zvanje
       //metoda za ispis Pozdrav() 
       //"Zdravo, moje ime je ... i imam ... godina+
    }
}