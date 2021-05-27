using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu_Unity2._0
{
    public class Atelier:Batiment
    {
        const int BANK_START = 10;
        const int LVL_MAX_ATELIER = 3;
        private int storageMp;
        private int incomeMp;

        public Atelier( )
        {
            
            base.NomBatiment = "Atelier";
            base.LvlMax = LVL_MAX_ATELIER;
            PopBatiment();
            PrixUp();
        }
        

        public int StorageMp { get => storageMp; set => storageMp = value; }
        public int IncomeMp { get => incomeMp; set => incomeMp = value; }

        

        public override int MonterDeNiveau()
        {
            this.LvlBatiment++;
            PopBatiment();
            
            this.StorageMp = this.StorageMp * 40 / 100;
            return this.PrixAmilioration;
        }


        public override string ToString()
        {
            return this.NomBatiment+" de niveau "+this.LvlBatiment + " Habité par " + this.NbBilly + " " + this.PrixAmilioration +"\n".ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is Atelier atelier &&
                   base.Equals(obj) &&
                   NomBatiment == atelier.NomBatiment &&
                   LvlBatiment == atelier.LvlBatiment &&
                   PrixAmilioration == atelier.PrixAmilioration &&
                   LvlMax == atelier.LvlMax &&
                   StorageMp == atelier.StorageMp &&
                   IncomeMp == atelier.IncomeMp;
        }

        public override int GetHashCode()
        {
            int hashCode = 775740021;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(NomBatiment);
            hashCode = hashCode * -1521134295 + LvlBatiment.GetHashCode();
            hashCode = hashCode * -1521134295 + PrixAmilioration.GetHashCode();
            hashCode = hashCode * -1521134295 + LvlMax.GetHashCode();
            hashCode = hashCode * -1521134295 + StorageMp.GetHashCode();
            hashCode = hashCode * -1521134295 + IncomeMp.GetHashCode();
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
