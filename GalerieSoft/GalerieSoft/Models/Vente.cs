using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalerieSoft.Models
{
    public class Vente
    {
        public string Code { get; set; }
        public DateTime DateVente { get; set; }
        public string NomClient { get; set; }
        public string NumClient { get; set; }
        public float PrixTotal { get; set; }
        public float TotalPaie { get; set; }
        public float RestePaie { get; set; }
        public int Situation { get; set; }
    }
}
