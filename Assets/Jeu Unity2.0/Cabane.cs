using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu_Unity2._0
{
    class Cabane:Batiment
    {
        const int BANK_START = 10;
        const int LVL_MAX_CABANE = 3;
        private int storageFish;
        private int incomeFish;

        public Cabane()
        {

            base.NomBatiment = "Cabane";
            base.LvlMax = LVL_MAX_CABANE;

            PopBatiment();
            PrixUp();
        }

        

        public int StorageFish { get => storageFish; set => storageFish = value; }
        public int IncomeFish { get => incomeFish; set => incomeFish = value; }

       


        public override int MonterDeNiveau()
        {
            this.LvlBatiment++;
            this.StorageFish = this.StorageFish * 40 / 100;
            PopBatiment();
            
            return this.PrixAmilioration;
            
        }

        public override string ToString()
        {
            return  this.NomBatiment + " de niveau " + this.LvlBatiment + " Habité par " + this.NbBilly +" "+this.PrixAmilioration+"\n".ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is Cabane cabane &&
                   base.Equals(obj) &&
                   NomBatiment == cabane.NomBatiment &&
                   LvlBatiment == cabane.LvlBatiment &&
                   PrixAmilioration == cabane.PrixAmilioration &&
                   LvlMax == cabane.LvlMax &&
                   StorageFish == cabane.StorageFish &&
                   IncomeFish == cabane.IncomeFish;
        }

        public override int GetHashCode()
        {
            int hashCode = 751090471;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(NomBatiment);
            hashCode = hashCode * -1521134295 + LvlBatiment.GetHashCode();
            hashCode = hashCode * -1521134295 + PrixAmilioration.GetHashCode();
            hashCode = hashCode * -1521134295 + LvlMax.GetHashCode();
            hashCode = hashCode * -1521134295 + StorageFish.GetHashCode();
            hashCode = hashCode * -1521134295 + IncomeFish.GetHashCode();
            return hashCode;
        }

       

        public override void PopBatiment()
        {
            this.NbBilly = LvlBatiment * 2;
        }
        public override void PrixUp()
        {
            this.PrixAmilioration = BANK_START * 60 / 100 * this.LvlBatiment;

        }
    }
}
