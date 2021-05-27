using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu_Unity2._0
{
     public abstract class Batiment
    {

        private string nomBatiment;
        private int lvlBatiment;
        private int prixAmilioration;
        private int lvlMax;
        private int nbBilly;

        public Batiment(  int prixAmilioration)
        {
            
            this.LvlBatiment = 1;
            this.PrixAmilioration = prixAmilioration;
            
        }
        
        public Batiment() { }

        public string NomBatiment { get => nomBatiment; set => nomBatiment = value; }
        public int LvlBatiment { get => lvlBatiment; set => lvlBatiment = value; }
        public int PrixAmilioration { get => prixAmilioration; set => prixAmilioration = value; }
        public int LvlMax { get => lvlMax; set => lvlMax = value; }
        public int NbBilly { get => nbBilly; set => nbBilly = value; }

        public override bool Equals(object obj)
        {
            return obj is Batiment batiment &&
                   NomBatiment == batiment.NomBatiment &&
                   LvlBatiment == batiment.LvlBatiment;
        }

        public override int GetHashCode()
        {
            int hashCode = -980639622;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(NomBatiment);
            hashCode = hashCode * -1521134295 + LvlBatiment.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return base.ToString();

        }

        
        public virtual int MonterDeNiveau() { return 0; }
        public virtual void PopBatiment() { }
        public virtual void PrixUp() { }
        
    }
}
