using System;
using System.Collections.Generic;

namespace Modelos.Models
{
    public partial class Estudiante
    {
        public int IdEstudiante { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public double? Estatus { get; set; }
        public string Carrera { get; set; }
    }
}
