using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalerieSoft.Models
{
    public class Detailvente:Vente
    {
        public int Id { get; set; }
        public string Produit { get; set; }
        public int Quantite { get; set; }
        public float PrixU { get; set; }
        public float PrixTot { get; set; }
    }
}
