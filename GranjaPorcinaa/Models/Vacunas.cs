using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GranjaPorcinaa.Models
{
    internal class Vacunas
    {
        public int Id { get; set; }
        public int IdCer { get; set; }
        public string NomVacu { get; set; }
        [Column(TypeName = "Date")]
        public DateTime DateVacuna { get; set; }
        

    }
}
