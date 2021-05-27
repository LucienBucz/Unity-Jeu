using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu_Unity2._0
{
    class Environment
    {
        const int NB_TOUR_FAMINE = 3;
        const int BANK_START = 10;


        private Cabane laCabane;
        private Atelier lAtelier;
        private Maison laMaison;
        private Hdv lhotel;
        private int bankMp;
        private int bankFish;
        private int bankBilly;
        private int nbTurn;
        private int incomeMiam;
        private int famine;
        private bool win;
        private bool lose;
        private int billyMort;

        public Environment(Cabane laCabane, Atelier lAtelier, Hdv lhotel, Maison laMaison)
        {
            InitialiseBank();
            this.laCabane = laCabane;
            this.LaMaison = laMaison;
            this.lAtelier = lAtelier;
            this.lhotel = lhotel;
            this.NbTurn = 1;
            this.BankFish = this.LaCabane.LvlBatiment * this.LaCabane.IncomeFish;
            this.BillyMort = 0;
           
            Population();
            StartFish();


        }
     /*   public Environment(Cabane laCabane, Atelier lAtelier, Hdv lhotel, Maison laMaison):this(laCabane,lAtelier,lhotel,laMaison)
        {
            this.laCabane = laCabane;
            this.LaMaison = laMaison;
            this.lAtelier = lAtelier;
            this.lhotel = lhotel;

        }*/

        internal Cabane LaCabane { get => laCabane; set => laCabane = value; }
        internal Atelier LAtelier { get => lAtelier; set => lAtelier = value; }
        internal Hdv Lhotel { get => lhotel; set => lhotel = value; }
        public int BankMp { get => bankMp; set => bankMp = value; }
        public int BankFish { get => bankFish; set => bankFish = value; }
        internal Maison LaMaison { get => laMaison; set => laMaison = value; }
        public int BankBilly { get => bankBilly; set => bankBilly = value; }
        public int NbTurn { get => nbTurn; set => nbTurn = value; }
        public int Famine { get => famine; set => famine = value; }
        public int IncomeMiam { get => incomeMiam; set => incomeMiam = value; }
        public bool Win { get => win; set => win = value; }
        public bool Lose { get => lose; set => lose = value; }
        public int BillyMort { get => billyMort; set => billyMort = value; }

        public void Population()
        {
            this.BankBilly = this.LaCabane.NbBilly + this.LAtelier.NbBilly + this.Lhotel.NbBilly + this.LaMaison.NbBilly - this.BillyMort;
        }

        public void InitialiseBank()
        {
            this.BankFish = BANK_START;
            this.BankMp = BANK_START;
            
        }

        public bool ConstructibleTier1()
        {
            bool res = true;
            if (this.BankMp <= BANK_START * 40 / 100)
                res = false;


            return res;
        }

        public void ConstructionCabane()
        {
            this.LaCabane.IncomeFish = BANK_START * 30 / 100;
            this.LaCabane.StorageFish = BANK_START * 140 / 100;
            this.laCabane.LvlBatiment = 1;
            this.LaCabane.NbBilly = 2;
            this.LaCabane.PrixUp();
            this.BankMp -= BANK_START * 40 / 100;

        }
        public void ConstructionAtelier()
        {
            this.LAtelier.IncomeMp = BANK_START * 30 / 100;
            this.LAtelier.StorageMp = BANK_START * 140 / 100;
            this.LAtelier.LvlBatiment = 1;
            this.LAtelier.NbBilly = 2;
            this.LAtelier.PrixUp();
            this.BankMp -= BANK_START * 40 / 100;
        }

        public void ConstructionMaison()
        {

            this.LaMaison.StoragePop = BANK_START;
            this.LaMaison.LvlBatiment = 1;
            this.LaMaison.NbBilly = 2;
            this.LaMaison.PrixUp();
            this.BankMp -= BANK_START*40/100;
        }

        public void RecolteMp()
        {
            this.BankMp += this.LAtelier.LvlBatiment * this.LAtelier.IncomeMp+this.Lhotel.IncomeMp;
            
        }

        public int StartFish()
        {
            this.IncomeMiam= this.laCabane.LvlBatiment * this.LaCabane.IncomeFish - this.BankBilly+this.Lhotel.IncomeFish;
            return this.laCabane.LvlBatiment * this.LaCabane.IncomeFish - this.BankBilly + this.Lhotel.IncomeFish;
        }

        public void RecolteFish()
        {
            
         
            
          this.BankFish += StartFish();
          
            
        }

        public void EndTurn()
        {
            
            Population();
            RecolteMp();
            RecolteFish();
            if (this.BankFish < 0)
                this.Famine++;
            /*if (this.Famine >= NB_TOUR_FAMINE)
                billyMort++;*/
            this.NbTurn++;
            this.Lose = this.LoseCondition();
            this.Win = this.WinCondition();

        }

        public bool LoseCondition()
        {
            bool res = false;
            if (this.Famine >= NB_TOUR_FAMINE)
                res = true;
            return res;
        }

        public bool WinCondition()
        {
            bool res = false;
            if (this.LaCabane.LvlBatiment == this.LaCabane.LvlMax &&
               this.LaMaison.LvlBatiment == this.LaMaison.LvlMax &&
               this.LAtelier.LvlBatiment == this.LAtelier.LvlMax &&
               this.Lhotel.LvlBatiment == this.Lhotel.LvlMax &&
               this.LaCabane.IncomeFish >= 0 &&
               !this.LoseCondition())
                res = true;

            return res;
        }

        public override bool Equals(object obj)
        {
            return obj is Environment environment &&
                   EqualityComparer<Cabane>.Default.Equals(LaCabane, environment.LaCabane) &&
                   EqualityComparer<Atelier>.Default.Equals(LAtelier, environment.LAtelier) &&
                   EqualityComparer<Hdv>.Default.Equals(Lhotel, environment.Lhotel) &&
                   BankMp == environment.BankMp &&
                   BankFish == environment.BankFish;
        }

        public override int GetHashCode()
        {
            int hashCode = -1090151475;
            hashCode = hashCode * -1521134295 + EqualityComparer<Cabane>.Default.GetHashCode(LaCabane);
            hashCode = hashCode * -1521134295 + EqualityComparer<Atelier>.Default.GetHashCode(LAtelier);
            hashCode = hashCode * -1521134295 + EqualityComparer<Hdv>.Default.GetHashCode(Lhotel);
            hashCode = hashCode * -1521134295 + BankMp.GetHashCode();
            hashCode = hashCode * -1521134295 + BankFish.GetHashCode();
            return hashCode;
        }

        public  bool EstAmeliorableCabane()
        {
            bool res = true;
            if (this.LaCabane.PrixAmilioration<=this.BankMp)
                res = false;
            return res; 
        }
        public bool EstAmeliorableAtelier()
        {
            bool res = true;
            if (this.LAtelier.PrixAmilioration <= this.BankMp)
                res = false;
            return res;
        }
        public bool EstAmeliorableMaison()
        {
            bool res = true;
            if (this.LaMaison.PrixAmilioration <= this.BankMp)
                res = false;
            return res;
        }
        public override string ToString()
        {
            return "Batiment : \n"+"------------------------------------------------------------------------------------------------------------\n"
                +this.Lhotel.ToString()+this.LaCabane.ToString()+this.lAtelier.ToString()+this.LaMaison.ToString()+ "------------------------------------------------------------------------------------------------------------\n"+
                "Ressources : \n"+ "------------------------------------------------------------------------------------------------------------\n"
                +"Poisson :"+this.BankFish+"("+this.IncomeMiam+")"+"\n"+"Bois :"+this.BankMp+ "(" + this.LAtelier.IncomeMp + ")"+"\n" +"Population :"+this.BankBilly+
                "\n"+"Nombre tour :"+this.NbTurn+
                "\nEn famine :"+this.Famine+
                "\n"+this.Win+
                "\n"+this.Lose
                .ToString();
        }

        public string DétailBatiment()
        {
            return "La Cabane Produit " + this.LaCabane.IncomeFish + " et peut contenir " + this.LaCabane.StorageFish +" Peut être up pour: "+this.LaCabane.PrixAmilioration +"\n" +
                "L'Atelier Produit " + this.LAtelier.IncomeMp + " et peut contenir " + this.LAtelier.StorageMp + " Peut être up pour: " + this.LAtelier.PrixAmilioration + "\n" +
                "La Maison  peut contenir " + this.laMaison.StoragePop + " Peut être up pour: " + this.LaMaison.PrixAmilioration.ToString();




        }
    }
}
