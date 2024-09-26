using System;
using System.Collections.Generic;

namespace CodeReviewApp.Src.Infraestructure.Context;

public partial class Empleado
{
    public int IdEmpleado { get; set; }

    public string? NombreEmpleado { get; set; }

    public string? PaternoEmpleado { get; set; }

    public string? MaternoEmpleado { get; set; }

    public DateTime? CrearEmpleado { get; set; }

    public DateTime? ActualizarEmpleado { get; set; }

    public DateTime? InactivarEmpleado { get; set; }

    public virtual ICollection<Cuenta> Cuenta { get; set; } = new List<Cuenta>();
}
