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
    public partial class AgregarLectura : System.Web.UI.Page
    {
        IMedidoresDAL medidoresDAL = MedidoresDALObjetos.GetInstancia();
        ILecturasDAL lecturasDAL = LecturasDALObjetos.GetInstancia();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                List<Medidor> medidores = medidoresDAL.ObtenerMedidores();
                this.medidorDdl.DataSource = medidores;
                this.medidorDdl.DataTextField = "Nombre";
                this.medidorDdl.DataValueField = "Id";
                this.medidorDdl.DataBind();

                DateTime ahora = DateTime.Today;

                this.fechaCal.SelectedDate = ahora;
            }
            
        }

        protected void ingresarBtn_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                int medidorValor = Convert.ToInt32(this.medidorDdl.SelectedValue);
                string medidorNombre = this.medidorDdl.SelectedItem.Value;

                DateTime fecha = this.fechaCal.SelectedDate;
                int hora = Convert.ToInt32(this.horaTxt.Text);
                int minutos = Convert.ToInt32(this.minutosTxt.Text);

                int consumo = Convert.ToInt32(this.consumoTxt.Text);
                
                TimeSpan horaTS = new TimeSpan(hora, minutos, 0);
                fecha = fecha + horaTS;

                List<Medidor> medidores = medidoresDAL.ObtenerMedidores();
                Medidor medidor = medidores.Find(m => m.Id == medidorValor);

                Lectura lectura = new Lectura()
                {
                    Medidor = medidor,
                    FechaLectura = fecha,
                    Consumo = consumo
                };

                lecturasDAL.AgregarLectura(lectura);

                this.mensajesLbl.Text = "Lectura ingresada";

                Response.Redirect("VerLecturas.aspx");
            }
        }
    }
}