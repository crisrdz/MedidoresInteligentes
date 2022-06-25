
using MedidoresInteligentesModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresInteligentesModel.DAL
{
    public class MedidoresDALObjetos : IMedidoresDAL
    {
        //Singleton
        private MedidoresDALObjetos()
        {
        }

        private static MedidoresDALObjetos instancia;

        public static IMedidoresDAL GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new MedidoresDALObjetos();
            }

            return instancia;
        }

        private static List<Medidor> medidores = new List<Medidor>()
        {
            new Medidor()
            {
                Id = 1,
                Nombre = "Alpha",
                Tipo = "A"
            },
            new Medidor()
            {
                Id = 2,
                Nombre = "Beta",
                Tipo = "A"
            },
            new Medidor()
            {
                Id = 3,
                Nombre = "Gamma",
                Tipo = "B"
            },
            new Medidor()
            {
                Id = 4,
                Nombre = "Delta",
                Tipo = "C"
            }
        };

        public List<Medidor> ObtenerMedidores()
        {
            return medidores;

        }

        public void AgregarMedidor(Medidor medidor)
        {
            medidores.Add(medidor);
        }
    }
}
