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
    public partial class Default : System.Web.UI.Page
    {
        private IMedidoresDAL medidoresDAL = MedidoresDALObjetos.GetInstancia();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ingresarBtn_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                uint id = Convert.ToUInt32(this.idTxt.Text);
                string nombre = this.nombreTxt.Text.Trim();
                string tipo = this.tipoRbl.SelectedItem.Value;

                List<Medidor> medidores = medidoresDAL.ObtenerMedidores();
                bool idValido = true;


                foreach (Medidor medidorLista in medidores)
                {
                    if (medidorLista.Id.Equals(id))
                    {
                        idValido = false;
                    }
                }

                if (idValido)
                {
                    Medidor medidor = new Medidor()
                    {
                        Id = id,
                        Nombre = nombre,
                        Tipo = tipo,
                    };

                    medidoresDAL.AgregarMedidor(medidor);

                    this.mensajesLbl.Text = "Medidor ingresado con éxito";

                    Response.Redirect("VerMedidores.aspx");
                }
                else
                {
                    this.mensajesLbl.Text = "ID Medidor duplicada";
                    this.mensajesLbl.CssClass = "text-danger";
                }
            }
        }

        protected void customID_ServerValidate(object source, ServerValidateEventArgs args)
        {
            try
            {
                uint numero = Convert.ToUInt32(args.Value);
                args.IsValid = true;
            }catch(FormatException ex)
            {
                args.IsValid = false;
            }
        }
    }
}