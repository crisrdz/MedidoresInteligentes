using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresInteligentesModel.DTO
{
    public class Lectura
    {
        private Medidor medidor;
        private DateTime fechaLectura;
        private double consumo;

        public Medidor Medidor { get => medidor; set => medidor = value; }
        public DateTime FechaLectura { get => fechaLectura; set => fechaLectura = value; }
        public double Consumo { get => consumo; set => consumo = value; }
        
    }
}
