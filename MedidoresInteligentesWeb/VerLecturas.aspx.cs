using MedidoresInteligentesModel.DAL;
using MedidoresInteligentesModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MedidoresInteligentesWeb
{
    public partial class VerLecturas : System.Web.UI.Page
    {
        private ILecturasDAL lecturasDAL = LecturasDALObjetos.GetInstancia();
        private IMedidoresDAL medidoresDAL = MedidoresDALObjetos.GetInstancia();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                List<Medidor> medidores = medidoresDAL.ObtenerMedidores();
                this.medidorDdl.DataSource = medidores;
                this.medidorDdl.DataTextField = "Nombre";
                this.medidorDdl.DataValueField = "Id";
                this.medidorDdl.DataBind();

                this.medidorDdl.Items.Insert(0, new ListItem("Todos", "0"));
                int valor = Convert.ToInt32(this.medidorDdl.SelectedValue);
                cargarGrilla(valor);
            }
        }

        private void cargarGrilla(int valor)
        {
            if(valor == 0)
            {
                List<Lectura> lecturas = lecturasDAL.ObtenerLecturas();
                this.grillaLecturas.DataSource = lecturas;
                this.grillaLecturas.DataBind();
            }
            else
            {
                List<Medidor> medidores = medidoresDAL.ObtenerMedidores();
                List<Lectura> lecturas = lecturasDAL.ObtenerLecturas();

                Medidor medidor = medidores.Find(m => m.Id == valor);
                lecturas = lecturas.FindAll(l => l.Medidor == medidor);

                this.grillaLecturas.DataSource = lecturas;
                this.grillaLecturas.DataBind();
            }
            
        }

        protected void medidorDdl_SelectedIndexChanged(object sender, EventArgs e)
        {
            int valor = Convert.ToInt32(this.medidorDdl.SelectedValue);
            cargarGrilla(valor);
        }
    }
}