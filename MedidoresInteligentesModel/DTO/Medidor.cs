using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresInteligentesModel.DTO
{
    public class Medidor
    {        
        private uint id;
        private string nombre;
        private string tipo;

        public uint Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public string Tipo { get => tipo; set => tipo = value; }
    }
}
