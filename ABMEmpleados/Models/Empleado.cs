using System;
using System.Collections.Generic;

namespace ABMEmpleados.Models
{
    public partial class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public string Cargo { get; set; } = null!;
        public DateTime FechaContratacion { get; set; }
        public decimal Salario { get; set; }
    }
}
