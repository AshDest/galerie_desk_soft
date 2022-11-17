using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalerieSoft.Models
{
    public class Approvisionnements
    {
        public string Code { get; set; }
        public DateTime DateApprov { get; set; }
        public string Produit { get; set; }
        public int Qte { get; set; }
        public float Pu { get; set; }
        public float Pt { get; set; }
    }
}
