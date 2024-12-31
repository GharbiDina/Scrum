using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
    public enum EtatTache
    {
        OUVERTE, ENCOUR, FERMER
    }
    public class Tache
    {
        public string Titre { get; set; }
        public EtatTache etatTache { get; set; }
        public DateTime dateDebut { get; set; }
        public DateTime dateFin { get; set; }
        public virtual Sprint Sprint { get; set; }
        public virtual Menmbre Menmbre { get; set; }

    }
}
