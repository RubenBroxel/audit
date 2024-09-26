using System;
using System.Collections.Generic;

namespace CodeReviewApp.Src.Infraestructure.Context;

public partial class TipoCuenta
{
    public int IdTipoCuenta { get; set; }

    public string? NombreTipoCuenta { get; set; }

    public byte? ActivoTipoCuenta { get; set; }

    public DateTime? CrearTipoCuenta { get; set; }

    public DateTime? ActualizarTipoCuenta { get; set; }

    public DateTime? InactivoTipoCuenta { get; set; }

    public virtual ICollection<Cuenta> Cuenta { get; set; } = new List<Cuenta>();
}
