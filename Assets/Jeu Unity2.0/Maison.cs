using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu_Unity2._0
{
    class Maison:Batiment
    {
        const int BANK_START = 10;
        const int LVL_MAX_MAISON = 3;
        private int storagePop;

    

        public Maison()
        {
   
            base.LvlMax = LVL_MAX_MAISON;
            base.NomBatiment = "Maison";
            PopBatiment();
            PrixUp();


        }

        public int StoragePop { get => storagePop; set => storagePop = value; }

        public override bool Equals(object obj)
        {
            return obj is Maison maison &&
                   base.Equals(obj) &&
                   NomBatiment == maison.NomBatiment &&
                   LvlBatiment == maison.LvlBatiment &&
                   PrixAmilioration == maison.PrixAmilioration &&
                   LvlMax == maison.LvlMax &&
                   StoragePop == maison.StoragePop;
        }

        public override int GetHashCode()
        {
            int hashCode = 1489415804;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(NomBatiment);
            hashCode = hashCode * -1521134295 + LvlBatiment.GetHashCode();
            hashCode = hashCode * -1521134295 + PrixAmilioration.GetHashCode();
            hashCode = hashCode * -1521134295 + LvlMax.GetHashCode();
            hashCode = hashCode * -1521134295 + StoragePop.GetHashCode();
            return hashCode;
        }

        public override int MonterDeNiveau()
        {
            this.LvlBatiment++;
            this.StoragePop += BANK_START * 70 / 100;
            PopBatiment();
         
            return this.PrixAmilioration;
        }

      


        public override void PopBatiment()
        {
            this.NbBilly = LvlBatiment*2;
            
        }

        public override string ToString()
        {
            return this.NomBatiment+" de niveau "+this.LvlBatiment+" Habité par "+this.NbBilly + " " + this.PrixAmilioration+"\n".ToString();
        }
        public override void PrixUp()
        {
            this.PrixAmilioration = BANK_START * 60 / 100 * this.LvlBatiment;

        }
    }
}
