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
    public partial class VerMedidores : System.Web.UI.Page
    {
        private IMedidoresDAL medidoresDAL = MedidoresDALObjetos.GetInstancia();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<string> tipo = new List<string> {"A", "B", "C"};
                this.tipoMedidorDdl.DataSource = tipo;
                this.tipoMedidorDdl.DataBind();
                this.tipoMedidorDdl.Items.Insert(0, new ListItem("Todos", "0"));
                string valor = this.tipoMedidorDdl.SelectedValue;
                cargarGrilla(valor);
            }
                
        }

        private void cargarGrilla(string valor)
        {
            if (valor.Equals("0"))
            {
                List<Medidor> medidores = medidoresDAL.ObtenerMedidores();
                this.grillaMedidores.DataSource = medidores;
                this.grillaMedidores.DataBind();
            }
            else
            {
                List<Medidor> medidores = medidoresDAL.ObtenerMedidores();

                medidores = medidores.FindAll(m => m.Tipo == valor);

                this.grillaMedidores.DataSource = medidores;
                this.grillaMedidores.DataBind();
            }

        }

        protected void tipoMedidorDdl_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valor = this.tipoMedidorDdl.SelectedValue;
            cargarGrilla(valor);
        }
    }
}