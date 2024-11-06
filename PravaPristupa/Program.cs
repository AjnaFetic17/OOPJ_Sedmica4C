internal class Program
{
    class Primjer
    {
        private string ime;
        public int godine;
        protected string zanimanje;
        public Primjer(string ime)
        {
            this.ime = ime;
        }

    }

    class Racun
    {
        private string brojRacuna;
        private decimal stanje;

        public Racun(string brojRacuna, decimal stanje)
        {
            this.brojRacuna = brojRacuna;
            this.stanje = stanje;
        }
        public Racun()
        {
            //ctor
        }
        public void PrikazStanje()
        {
            Console.WriteLine("Stanje Vaseg racuna je {0}", stanje);
        }

        public void Uplati(decimal iznos)
        {
            if (iznos > 0)
            {
                stanje += iznos;
                Console.WriteLine("Uspjesno ste uplatili {0}", iznos);
            }
            else
            {
                Console.WriteLine("Nije moguce izvrsiti transakciju.");
            }
        }
    }

    private static void Main(string[] args)
    {
        //Kreirati Klasu Racun
        //privatne clanove brojRacuna(string) i stanje(decimal)
        //javnu metodu PrikazStanje() koja ispisuje stanje racuna
        //javnu metodu Uplati(decimal iznos) koja dodaje iznos na stanje 
        //osigurati da unos bude pozitivan
        Racun racun = new Racun("1255685", 500.00m);
        racun.PrikazStanje();
        racun.Uplati(-20);
        racun.Uplati(150);
        racun.PrikazStanje();
    }
}