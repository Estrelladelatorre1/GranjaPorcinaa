using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GranjaPorcinaa.Models
{
    internal class Cerditos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int NumCorral { get; set; }
        public int Peso { get; set; }
        [Column(TypeName = "Date")]
        public DateTime DateIngreso { get; set; } 
        [Column(TypeName = "Date")]
        public DateTime DateNacimiento { get; set; }


    }
}

