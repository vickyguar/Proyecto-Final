using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Proyecto : Form
    {
        List<BLL.BLL_ENT.PROYECTO_ENT> ListaProyectos;
        public Proyecto()
        {
            InitializeComponent();
        }

        private void Proyecto_Load(object sender, EventArgs e)
        {
            CargarListaProyectos();
            ActualizarGrilla();

        }

        private void CargarListaProyectos()
        {
            BLL.BLL_CLASS.PROYECTO_CLASS p = new BLL.BLL_CLASS.PROYECTO_CLASS();
            ListaProyectos = p.BuscarTodos();
        }

        private void ActualizarGrilla()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Titulo");
            dt.Columns.Add("Fecha Inicio");
            dt.Columns.Add("Fecha Fin");
            dt.Columns.Add("Estado");
            // dt.Columns.Add("Deleted");
            foreach (BLL.BLL_ENT.PROYECTO_ENT p in ListaProyectos)
            {
                DataRow dr = dt.NewRow();

                dr["ID"] = p.id.ToString();
                dr["Titulo"] = p.Titulo;
                dr["Fecha Inicio"] = p.FechaInicio.ToString();
                dr["Fecha Fin"] = p.FechaFin.ToString();
                dr["Estado"] = p.Estado.ToString();
                // dr["Deleted"] = p.deleted;
                dt.Rows.Add(dr);
            }
            dgvProyectos.DataSource = dt;

        }
    }
}
