using AM.ApplicationCore.Interfaces;
using ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface ITacheService :IService<Tache>
    {
        int nbTache(string matricule);
        int DureeMoyenne(DateTime dd, DateTime df);
        IList<Tache> TacheParProjets();
    }
}
