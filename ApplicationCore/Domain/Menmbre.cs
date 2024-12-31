using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
    public class Menmbre

    {
        public string matricule { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public virtual IList<Tache> Taches { get; set; }



    }
}
