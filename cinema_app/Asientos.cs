using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinema_app
{
    public partial class Asientos : Form
    {
        private Form1 formPrincipal;

        public Asientos(Form1 form)
        {
            InitializeComponent();
            formPrincipal = form;
        }

        private void ObtenerAsientosSeleccionados()
        {
            List<string> asientosSeleccionados = new List<string>();

            foreach (Control control in gb_asientos.Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    asientosSeleccionados.Add(checkBox.Tag.ToString());
                }
            }

            if (asientosSeleccionados.Count > 0)
            {
                Variables.seleccion.Asientos = asientosSeleccionados;
                formPrincipal.btn_continue.Visible = true;
            }
            else
            {
                MessageBox.Show("No hay asientos seleccionados.");
            }
        }

        private void btn_confirm_asientos_Click(object sender, EventArgs e)
        {
            ObtenerAsientosSeleccionados();
            this.Close();
        }
    }
}
