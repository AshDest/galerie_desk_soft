using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalerieSoft.Models
{
    public class Produit
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Designation { get; set; }
        public int Typeproduit { get; set; }
        public int Categorieproduit { get; set; }
        public int Quantite { get; set; }
        public float Prix { get; set; }
    }
}
