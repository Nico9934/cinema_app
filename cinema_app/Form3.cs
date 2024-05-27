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
    public partial class Form3 : Form
    {

        private Form1 form1;

        public Form3(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            string asientos = "";
            foreach (string asiento in Variables.seleccion.Asientos)
            {
                asientos = asientos + asiento;
            }

            lbl_detail_titulo.Text = lbl_detail_titulo.Text + Variables.seleccion.Titulo;
            lbl_detail_formato.Text = lbl_detail_formato.Text + Variables.seleccion.Formato;
            lbl_detail_sala.Text = lbl_detail_sala.Text + Variables.seleccion.Sala;
            lbl_detail_horario.Text = lbl_detail_horario.Text + Variables.seleccion.Horario;
            lbl_detail_asientos.Text = lbl_detail_asientos.Text + asientos;
            lbl_detail_total.Text = lbl_detail_total.Text + (Variables.seleccion.Asientos.Count * 1700).ToString();


            lbl_detail_nombre.Text = lbl_detail_nombre.Text + Variables.datosUsuario.Nombre;
            lbl_detail_apellido.Text = lbl_detail_apellido.Text + Variables.datosUsuario.Apellido;
            lbl_detail_telefono.Text = lbl_detail_telefono.Text + Variables.datosUsuario.Telefono; 
            lbl_detail_dni.Text = lbl_detail_dni.Text + Variables.datosUsuario.DNI;
            lbl_detail_email.Text = lbl_detail_email.Text + Variables.datosUsuario.Email;
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            form1.ShowForm1();
            this.Close();
        }
    }
}
