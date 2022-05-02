using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TortugaLiebre.Models
{
    public class Clasificatorias
    {
        [Display(Name ="#Carrera")]
        public int NumCarrera { get; set; }
        public int Id { get; set; }
        public string Ganador { get; set; }
        [Display(Name ="Fecha de la Carrera")]
        [DataType(DataType.Date)]
        public DateTime FechaCarrera { get; set; }
        public int Apostadores { get; set; }
        [Column(TypeName ="decimal(10,2)")]
        public decimal Ganancias { get; set; }
    }
}
