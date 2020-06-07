using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PrestamosProyect.Models
{
    public class Prestamos
    {
        [Key]
        public int PrestamoId { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir una fecha")]
        public DateTime Fecha { get; set; }

        public int PersonaId { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir un concepto")]
        public string Concepto { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir un monto")]
        public double Monto { get; set; }

        public double Balance { get; set; }

        [ForeignKey("PersonaId")]
        public virtual Personas Persona { get; set; }
    }
}
