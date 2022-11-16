using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalerieSoft.Models
{
    public class Paiement
    {
        public string Code { get; set; }
        public DateTime DatePaie { get; set; }
        public float MontantPaie { get; set; }
    }
}
