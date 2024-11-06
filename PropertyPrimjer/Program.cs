internal class Program
{
    class Osoba
    {
        private string ime;
        private int godine;

        public int Godine
        {
            get { return godine; }
            set { godine = value; }
        }

        public string Zanimanje { get; set; }

        public void PostaviIme(string ime)
        {
            this.ime = ime;
        }

        public string DohvaiIme()
        {
            return this.ime;
        }

    }
    private static void Main(string[] args)
    {
        Osoba osoba = new Osoba();
        osoba.PostaviIme("Neko");
        string ime = osoba.DohvaiIme();
        Console.WriteLine(ime);
        osoba.Godine = 15;
        Console.WriteLine(osoba.Godine);
        osoba.Zanimanje = "neko zanimanje";
        Console.WriteLine(osoba.Zanimanje);
    }
}