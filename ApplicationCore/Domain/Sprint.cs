using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
    public class Sprint
    {
        public int id { get; set; }
        public DateTime dateDebut { get; set; }
        public string description { get; set; }
    }
}
