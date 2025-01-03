﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
    public class Sprint
    {
        public int id { get; set; }
        public DateTime dateDebut { get; set; }
        [MaxLength(150)]
        public string description { get; set; }
        public virtual Projet Projet { get; set; }
        public virtual IList<Tache> Taches { get; set; }

    }
}
