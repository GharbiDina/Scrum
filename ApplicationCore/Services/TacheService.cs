using AM.ApplicationCore.Interfaces;
using AM.ApplicationCore.Services;
using ApplicationCore.Domain;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class TacheService : Service<Tache>, ITacheService
    {
        public TacheService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
           
        }

        public int DureeMoyenne(DateTime dd, DateTime df)
          { int a = GetAll().Where(h => h.dateFin < DateTime.Now).Count();
              return((int) (GetAll().
                Where(h=>h.dateFin< DateTime.Now).Sum
                  (h => (h.dateFin - h.dateDebut).TotalDays) / a ));
              }
      
        public int nbTache(string matricule)
        {
            return GetAll().
                Where(h=>h.Menmbre.matricule==matricule && h.dateFin<DateTime.Now)
                .Count();
        }

        public IList<Tache> TacheParProjets()
        {
            return (IList<Tache>)GetAll().GroupBy(h => h.Sprint.Projet.Titre).ToList();
        }
    }
}
