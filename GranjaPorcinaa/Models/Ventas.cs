using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GranjaPorcinaa.Models
{
    internal class Ventas
    {
        public int Id { get; set; }
        public int Idcer { get; set; }
        public string NomComp { get; set; }
        public int Presio { get; set; }
        [Column(TypeName = "Date")]
        public DateTime DateVenta { get; set; 
        
    }
    }
}
