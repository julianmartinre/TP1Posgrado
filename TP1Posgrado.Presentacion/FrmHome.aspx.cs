using TP1Posgrado.ModeloDatos;
using System;

namespace TP1Posgrado.Presentacion
{
    public partial class FrmHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EntidadesDataDataContext db = new EntidadesDataDataContext();
            GridALUMNO.DataSource = db.Alumno;
            GridALUMNO.DataBind();

            GridALUMNOTELEFONO.DataSource = db.AlumnoTelefono;
            GridALUMNOTELEFONO.DataBind();

            GridALUMNOEMAIL.DataSource = db.AlumnoEmail;
            GridALUMNOEMAIL.DataBind();

            GridMATERIA.DataSource = db.Materia;
            GridMATERIA.DataBind();

            GridCALIFICACION.DataSource = db.Calificacion;
            GridCALIFICACION.DataBind();
        }
    }
}