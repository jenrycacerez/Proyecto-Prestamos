using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrestamosProyect.Models
{
    public class Personas
    {
        [Key]

        public int PersonaId { get; set; }

        [Required(ErrorMessage = "Es obligatorio Introducir el nombre ")]
        public string Nombres { get; set; }

        [Phone(ErrorMessage = "El teléfono debe ser de la siguente forma: 000-000-0000")]
        [Required(ErrorMessage = "Es obligatorio Introducir el Telefono ")]

        public string Telefono { get; set; }

        [Required(ErrorMessage = "Es obligatorio Introducir la Cedula ")]

        public string Cedula { get; set; }

        [Required(ErrorMessage = "Es obligatorio Introducir La Direccion ")]

        public string Direccion { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir una fecha")]
        public DateTime FechaNacimiento { get; set; }

        public double Balance { get; set; }

    }
}
