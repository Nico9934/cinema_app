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
        public Form1()
        {
            InitializeComponent();

            List<Pelicula> listaPeliculas = Variables.ObtenerPeliculas();
            cmb_pelicula.DataSource = listaPeliculas;
            cmb_pelicula.DisplayMember = "Titulo";
            cmb_pelicula.SelectedIndex = 0;
            cmb_pelicula.ValueMember = null; // No necesitamos establecer ValueMember si queremos seleccionar el objeto completo

            // Suscribir al evento SelectedIndexChanged del ComboBox principal
            cmb_pelicula.SelectedIndexChanged += cmb_pelicula_SelectedIndexChanged;
        }

        private void cmb_pelicula_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener la película seleccionada
            Pelicula selectedPelicula = (Pelicula)cmb_pelicula.SelectedItem;

            // Verificar si se seleccionó una película válida
            if (selectedPelicula != null)
            {
                // Aquí puedes utilizar el objeto Pelicula completo
                string id = selectedPelicula.Id;
                string titulo = selectedPelicula.Titulo;
                string formato = selectedPelicula.Formato;
                string sala = selectedPelicula.Sala;

                // Por ejemplo, puedes usar estos valores en otro lugar de tu aplicación
                // o realizar otras operaciones con ellos
                MessageBox.Show($"ID: {id}, Título: {titulo}, Formato: {formato}, Sala: {sala}");
            }
        }
    }

}
