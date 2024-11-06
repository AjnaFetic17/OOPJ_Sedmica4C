internal class Program
{
    class BankovniRacun
    {
       private  double stanjeRacuna,limit;
            public BankovniRacun( double stanjeRacuna, double limit)
        {
            this.stanjeRacuna = stanjeRacuna;
            this.limit = limit;
            
        }
        public void IzvrsiTransakciju(int novac)
        {
            if (novac<0 && stanjeRacuna+novac < limit) 
            {
                Console.WriteLine("iznos je veci od limita");

            }
            else
            {
                stanjeRacuna += novac;
                Console.WriteLine($"Uspjesno ste skinuli {novac}.Novo stanje racuna je {stanjeRacuna}");
            }
        }
        public void IspisStanjaRacuna()
        {
            Console.WriteLine("Stanje racuna je {0}",stanjeRacuna);
        }
    }
    private static void Main(string[] args)
    {
        //Kreirati klasu BankovniRacun koja ima privatne atributre (double) stanjeNaRacunu i limit
        //implementirati metodu IzvrsiTransakciju() koja omogucava povlacenje novca samo ako stanje nije manje od limita
        //Implementirati metodu IspisStanjaRacuna()
        //-200 limit
        // 300 stanje
        //-500 depozit/povlacenje
        BankovniRacun bankovni = new BankovniRacun(100, -200);
        bankovni.IzvrsiTransakciju(20);
        bankovni.IspisStanjaRacuna();
        bankovni.IzvrsiTransakciju(-300);
        bankovni.IspisStanjaRacuna();
        bankovni.IzvrsiTransakciju(-200);
        bankovni.IspisStanjaRacuna();
    }
}