using TP1Posgrado.ModeloDatos;
using System;

namespace TP1Posgrado.Presentacion
{
    public partial class FrmHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EntidadesDataDataContext db = new EntidadesDataDataContext();
            GridPRODUCTO.DataSource = db.Producto;
            GridPRODUCTO.DataBind();
        }
    }
}