using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalerieSoft.Models
{
    public class Detailvente
    {
        public int Id { get; set; }
        public string Codevente { get; set; }
        public string Produit { get; set; }
        public int Quantite { get; set; }
        public float PrixUnitaire { get; set; }
        public float PrixTotal { get; set; }
    }
}
