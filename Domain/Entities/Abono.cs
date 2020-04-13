using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Abono
    {
        public string Cedula { get; set; }
        public double ValorAbonado { get; set; }
        public DateTime FechaAbono { get; set; }
    }
}
