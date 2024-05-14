using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Entidad;
using Logica;

namespace Presentacion
{
    public partial class RecomendacionNutricional : Form
    {
        public serviceDeportista service;
        public ServicePlantilla servicePlantilla;
        public List<Plantilla> plantillas;
        public List<Deportista> deportistas;
        public RecomendacionNutricional()
        {
            service = new serviceDeportista();
            servicePlantilla = new ServicePlantilla();
            InitializeComponent();
            deportistas = new List<Deportista>();
            plantillas = new List<Plantilla>();

        }

        private void LlenarCombobox(List<Plantilla> plantillas)
        {

            comboBoxDieta.Items.Clear();
            foreach (var item in plantillas)
            {
                comboBoxDieta.Items.Add(item.NombrePlantilla);
            }
            comboBoxDieta.Refresh();
        }

        private void MostrarPlantillas()
        {
            ConsultarRespuestaPlantilla respuesta = new ConsultarRespuestaPlantilla();
            comboBoxDieta.DataSource = null;
            respuesta = servicePlantilla.ConsultarPlantilla();
            plantillas = respuesta.Plantillas.ToList();
            if (!respuesta.Error)
            {
                LlenarCombobox(plantillas);

            }
            else
            {
                MessageBox.Show(respuesta.Mensaje, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void botonGuardarRecomendacion_Click(object sender, EventArgs e)
        {
            if(textIdentificacionRecomendacion.Text.Equals("") || TextRecomendacionNutricional.Text.Equals("") || TextRecomendacionAlimentario.Text.Equals("") || comboBoxDieta.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Los campos estan Vacios", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                Dieta dieta = MapearRecomendacion();
                string mensaje = service.GuardarDieta(dieta);
                MessageBox.Show(mensaje, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textIdentificacionRecomendacion.Text = "";
                textNombrePaciente.Text = "";
                TextRecomendacionAlimentario.Text = "";
                TextRecomendacionNutricional.Text = "";
                comboBoxDieta.Text = null;
            }
        }

        private Dieta MapearRecomendacion()
        {
            Dieta dieta = new Dieta();
            dieta.identificacion = textIdentificacionRecomendacion.Text;
            dieta.RecomendacionAlimentaria = TextRecomendacionAlimentario.Text;
            dieta.RecomendacionNutriccional = TextRecomendacionNutricional.Text;
            dieta.DiasAplicados = ListasDiasSemana.Text;
            dieta.plantillas = comboBoxDieta.Text;
            return dieta;

        }

        private void textIdentificacionRecomendacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void botonBuscarPaciente_Click(object sender, EventArgs e)
        {
            if (textIdentificacionRecomendacion.Text.Equals(""))
            {
                MessageBox.Show("Campo de Identificacion Vacio","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                MostrarDatosPorIdentificacion();
            }
            
        }

        private void textPorcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void ContenedorRecomendacioNutricional_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textPesoActual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255) || (e.KeyChar == 47))
            {
                MessageBox.Show("Solo se permiten Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void MostrarDatosPorIdentificacion()
        {
            ConsultarClienteRespuesta respuesta = new ConsultarClienteRespuesta();
            string identificacion = textIdentificacionRecomendacion.Text;
            respuesta = service.BuscarPorId(identificacion);
            deportistas = respuesta.Deportistas.ToList();
            if (!respuesta.Error)
            {
                llenartabla(deportistas);
            }
            else
            {
                MessageBox.Show("Error al consultar");
            }

        }


        private void llenartabla(List<Deportista> deportistas)
        {

            foreach (var item in deportistas)
            {
                textNombrePaciente.Text = $"{item.Nombre}  {item.Apellidó}";
            }

        }

        private void comboBoxDieta_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBoxDieta_Click(object sender, EventArgs e)
        {
            MostrarPlantillas();
        }
    }
}
