using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Entidades
{ 
    public class E_Pago
        {
            public int IdPago { get; set; }
            public int NCliente { get; set; }
            public float Monto { get; set; }
            public DateTime Fecha { get; set; }
            public string? FormaPago { get; set; }
            public int CantidadCuotas { get; set; }
        }
}
