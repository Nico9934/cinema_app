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
    public partial class Form1 : Form
    {
      
        private List<Pelicula> listaPeliculas = Variables.ObtenerPeliculas();

        public Form1()
        {
            InitializeComponent();
            cmb_film.DataSource = listaPeliculas;
            cmb_film.DisplayMember = "Titulo";
            cmb_film.SelectedIndex = 0;
        }
        //public void ShowForm1()
        //{
        //    if (pnl_first.Controls.Count > 0) pnl_first.Controls.Clear();

        //    // Reiniciar el formulario actual (Form1)
        //    Form1 newForm1 = new Form1();
        //    newForm1.TopLevel = false;
        //    newForm1.FormBorderStyle = FormBorderStyle.None;
        //    newForm1.Dock = DockStyle.Fill;
        //    pnl_first.Controls.Add(newForm1);
        //    pnl_first.Tag = newForm1;
        //}

        public void ShowForm1()
        {
            if (pnl_first.Controls.Count > 0)
            {
                foreach (Control control in pnl_first.Controls)
                {
                    control.Dispose();
                }
                pnl_first.Controls.Clear();
            }

            // Crear una nueva instancia del Form1 y configurar adecuadamente
            Form1 newForm1 = new Form1
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            pnl_first.Controls.Add(newForm1.pnl_first);
            pnl_first.Controls.Remove(newForm1.panel1);
            pnl_first.Tag = newForm1;
            
            newForm1.Show();
        }



        private void cmb_film_SelectedIndexChanged(object sender, EventArgs e)
        {           
            if (cmb_film.SelectedItem.ToString() != "")
            {
                Pelicula peliculaSeleccionada = (Pelicula)cmb_film.SelectedItem;
                Variables.seleccion.Titulo = peliculaSeleccionada.Titulo;
                cmb_format.Items.Clear();
                cmb_format.Visible = true;
                lbl_format.Visible = true;

                foreach (string formato in peliculaSeleccionada.Formato)
                {
                    cmb_format.Items.Add(formato);
                }
            }
            else
            {
                cmb_format.Visible = false;
                lbl_format.Visible = false;
            }
        }
        private void cmb_format_SelectedIndexChanged(object sender, EventArgs e)
        {
            Variables.seleccion.Formato = cmb_format.SelectedItem.ToString();
            Pelicula peliculaSeleccionada = (Pelicula)cmb_film.SelectedItem;
            cmb_sala.Items.Clear();

            if (cmb_format.SelectedItem.ToString() != "")
            {
                lbl_sala.Visible = true;
                cmb_sala.Visible = true;
                foreach (string sala in peliculaSeleccionada.Sala)
                {
                    cmb_sala.Items.Add(sala);
                }
            }
            else
            {
                lbl_sala.Visible = false;
                cmb_sala.Visible = false;
            }
           
        }
        private void cmb_sala_SelectedIndexChanged(object sender, EventArgs e)
        {
            Variables.seleccion.Sala = cmb_sala.SelectedItem.ToString();
            Pelicula peliculaSeleccionada = (Pelicula)cmb_film.SelectedItem;
            cmb_hour.Items.Clear();
            if (cmb_sala.SelectedItem.ToString() != "")
            {
                lbl_hour.Visible = true;
                cmb_hour.Visible = true;
                foreach (string horario in peliculaSeleccionada.Horario)
                {
                    cmb_hour.Items.Add(horario);
                }
            }
            else
            {
                lbl_hour.Visible = false;
                cmb_hour.Visible = false;
            }
        }
        private void cmb_hour_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_hour.SelectedItem != null)
            {
                Variables.seleccion.Horario = cmb_hour.SelectedItem.ToString();
            }
            if (cmb_hour.SelectedItem.ToString() != "")
            {
                lbl_asiento.Visible = true;
                btn_asiento.Visible = true;
            }
            else
            {
                lbl_asiento.Visible = false;
                btn_asiento.Visible = false;
            }
        }
        private void btn_asiento_Click(object sender, EventArgs e)
        {
            Asientos asientos_form = new Asientos(this);
            asientos_form.Show();
        }
        private void btn_continue_Click(object sender, EventArgs e)
        {
            if (pnl_first.Controls.Count > 0) pnl_first.Controls.Clear();
       
            var form = Application.OpenForms.OfType<Form2>().FirstOrDefault();
            Form2 second_form = form ?? new Form2(this);
            // Establece el formulario 2 como hijo del panel en Form1
            second_form.TopLevel = false;
            second_form.FormBorderStyle = FormBorderStyle.None;
            second_form.Dock = DockStyle.Fill;
            pnl_first.Controls.Add(second_form);
            pnl_first.Tag = second_form;
            second_form.Show();
        }
    }
}
