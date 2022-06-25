using MedidoresInteligentesModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresInteligentesModel.DAL
{
    public class LecturasDALObjetos : ILecturasDAL
    {
        //Singleton
        private LecturasDALObjetos()
        {
        }

        private static LecturasDALObjetos instancia;

        public static ILecturasDAL GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new LecturasDALObjetos();
            }

            return instancia;
        }

        private static List<Lectura> lecturas = new List<Lectura>();

        public List<Lectura> ObtenerLecturas()
        {
            return lecturas;
        }

        public void AgregarLectura(Lectura lectura)
        {
            lecturas.Add(lectura);
        }
    }
}
