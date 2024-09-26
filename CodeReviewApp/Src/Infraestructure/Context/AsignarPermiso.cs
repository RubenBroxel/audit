using System;
using System.Collections.Generic;

namespace CodeReviewApp.Src.Infraestructure.Context;

public partial class AsignarPermiso
{
    public int? IdCuenta { get; set; }

    public int? IdPermiso { get; set; }

    public byte? ActivoAsignar { get; set; }

    public DateTime? CrearAsignar { get; set; }

    public DateTime? ActualizarAsignar { get; set; }

    public DateTime? InactivarAsignar { get; set; }

    public virtual Cuenta? IdCuentaNavigation { get; set; }

    public virtual Permiso? IdPermisoNavigation { get; set; }
}
