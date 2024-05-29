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
    public partial class Form2 : Form
    {
        private Form1 form1;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;

            string asientos = "";
            foreach (string asiento in Variables.seleccion.Asientos)
            {
                asientos += " / " + asiento;
            }
            lbl_titulo.Text = "TITULO: " + Variables.seleccion.Titulo;  
            lbl_formato.Text = "FORMATO: " + Variables.seleccion.Formato;
            lbl_sala.Text = "SALA: " + Variables.seleccion.Sala;
            lbl_horario.Text = "HORARIO: " + Variables.seleccion.Horario;
            lbl_asientos.Text = "ASIENTOS: " + asientos;
            lbl_total.Text = "TOTAL: $" + (Variables.seleccion.Asientos.Count * 1700).ToString();

            pb_selection_img.ImageLocation = Variables.seleccion.Imagen.ToString();
            pb_selection_img.SizeMode = PictureBoxSizeMode.StretchImage;
            try
            {
                pb_selection_img.Load(Variables.seleccion.Imagen);
            } catch{ }
            Variables.datosUsuario.Tarjeta = txt_tarjeta.Text;
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
            Variables.datosUsuario.Nombre = txt_name.Text;
        }
        private void txt_lastname_TextChanged(object sender, EventArgs e)
        {
            Variables.datosUsuario.Apellido = txt_lastname.Text;
        }
        private void txt_phone_TextChanged(object sender, EventArgs e)
        {
           Variables.datosUsuario.Telefono = txt_phone.Text;
        }
        private void txt_dni_TextChanged(object sender, EventArgs e)
        {
            Variables.datosUsuario.DNI = txt_dni.Text;
        }
        private void txt_email_TextChanged(object sender, EventArgs e)
        {
            Variables.datosUsuario.Email = txt_email.Text;
        }
        private void txt_tarjeta_TextChanged(object sender, EventArgs e)
        {
            Variables.datosUsuario.Tarjeta = txt_tarjeta.Text;
        }
        private void btn_back_first_Click(object sender, EventArgs e)
        {
            form1.ShowForm1();
        }
        private void btn_finish_Click(object sender, EventArgs e)
        {
            if (Validaciones.Complete(Variables.datosUsuario) != true) MessageBox.Show("Todos los campos son obligatorios");
            else if (Validaciones.NameLastName(Variables.datosUsuario.Nombre) != true) MessageBox.Show("El nombre es obligatorio");
            else if (Validaciones.NameLastName(Variables.datosUsuario.Apellido) != true) MessageBox.Show("El apellido es obligatorio");
            else if (Validaciones.Phone(Variables.datosUsuario.Telefono) != true) MessageBox.Show("Debes ingresar un telefono válido");
            else if (Validaciones.Dni(Variables.datosUsuario.DNI) != true) MessageBox.Show("Debes ingresar un DNI válido");
            else if (Validaciones.Email(Variables.datosUsuario.Email) != true) MessageBox.Show("Debes ingresar un Email válido");
            else if (Validaciones.CreditCard(Variables.datosUsuario.Tarjeta) != true) MessageBox.Show("Debes ingresar una tarjeta válida");
            else {
                Form3 form3 = new Form3(this.form1); // Pasar la referencia de Form1
                form3.TopLevel = false;
                form3.FormBorderStyle = FormBorderStyle.None;
                form3.Dock = DockStyle.Fill;

                this.form1.pnl_first.Controls.Clear();
                this.form1.pnl_first.Controls.Add(form3);
                this.form1.pnl_first.Tag = form3;
                form3.Show();

                this.Close();
            }
        }
    }
}
