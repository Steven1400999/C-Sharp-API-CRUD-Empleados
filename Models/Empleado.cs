using System;
using System.Collections.Generic;

namespace WebApiCrud.Models;

public partial class Empleado
{
    public int IdEmpleado { get; set; }

    public string? Nombre { get; set; }

    public string? Correco { get; set; }

    public int? Sueldo { get; set; }
}
