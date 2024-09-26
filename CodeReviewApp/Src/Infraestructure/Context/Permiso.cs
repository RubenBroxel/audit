using System;
using System.Collections.Generic;

namespace CodeReviewApp.Src.Infraestructure.Context;

public partial class Permiso
{
    public int IdPermiso { get; set; }

    public string? NombrePermiso { get; set; }

    public string? DescripcionPermiso { get; set; }

    public byte? ActivoPermiso { get; set; }

    public DateTime? CrearPermiso { get; set; }

    public DateTime? ActualizarPermiso { get; set; }

    public DateTime? InactivarPermisos { get; set; }
}
