using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu_Unity2._0
{
    public class Hdv : Batiment
    {
        const int LVL_MAX_HDV= 1;

        private int incomeMp;
        private int incomeFish;
        public Hdv( )
        {
            this.IncomeMp = 0;
            this.IncomeFish = 1;
            this.LvlBatiment = 1;
            NomBatiment = "Hotel de ville";
            LvlMax = LVL_MAX_HDV;
            PopBatiment();

        }

        public int IncomeMp { get => incomeMp; set => incomeMp = value; }
        public int IncomeFish { get => incomeFish; set => incomeFish = value; }

        public override bool Equals(object obj)
        {
            return obj is Hdv hdv &&
                   base.Equals(obj) &&
                   NomBatiment == hdv.NomBatiment &&
                   LvlBatiment == hdv.LvlBatiment &&
                   PrixAmilioration == hdv.PrixAmilioration &&
                   LvlMax == hdv.LvlMax;
                   
        }

        public override int GetHashCode()
        {
            int hashCode = 671283103;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(NomBatiment);
            hashCode = hashCode * -1521134295 + LvlBatiment.GetHashCode();
            hashCode = hashCode * -1521134295 + PrixAmilioration.GetHashCode();
            hashCode = hashCode * -1521134295 + LvlMax.GetHashCode();
            return hashCode;
        }

       /* public override void MonterDeNiveau()
        {
            base.MonterDeNiveau();
        }*/

       

        public override void PopBatiment()
        {
            this.NbBilly = LvlBatiment;
        }

        public override string ToString()
        {
            return this.NomBatiment+" de Niveau "+this.LvlBatiment  +" Habité par " + this.NbBilly + " " + this.PrixAmilioration+ "\n".ToString();
        }
    }
}
