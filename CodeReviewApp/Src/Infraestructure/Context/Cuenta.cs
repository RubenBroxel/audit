using System;
using System.Collections.Generic;

namespace CodeReviewApp.Src.Infraestructure.Context;

public partial class Cuenta
{
    public int IdCuenta { get; set; }

    public int? IdTipoCuenta { get; set; }

    public int? IdEmpleado { get; set; }

    public string? NombreCuenta { get; set; }

    public string? CorreoCuenta { get; set; }

    public string? ContrasenaCuenta { get; set; }

    public byte? ActivoCuenta { get; set; }

    public DateTime? CrearCuenta { get; set; }

    public DateTime? ActualizarCuenta { get; set; }

    public DateTime? InactivarCuenta { get; set; }

    public virtual Empleado? IdEmpleadoNavigation { get; set; }

    public virtual TipoCuenta? IdTipoCuentaNavigation { get; set; }
}
