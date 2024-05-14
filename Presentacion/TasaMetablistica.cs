using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Entidad;

namespace Presentacion
{
    public partial class TasaMetablistica : Form
    {
        serviceDeportista service;
        List<Deportista> deportistas;
        public double GastoEnergetico = 0;

        public TasaMetablistica()
        {
            service = new serviceDeportista();
            InitializeComponent();
            deportistas = new List<Deportista>();
            MostrarDatos();
        }

        private void llenartabla(List<Deportista> deportistas)
        {
            
            dgvTasaMetabolicaBasal.Rows.Clear();
            foreach(var item in deportistas)
            {
                dgvTasaMetabolicaBasal.Rows.Add(item.Peso, item.Altura, item.Edad- item.Fecha_Nacimiento.Year, item.MetabolismoBasal);
                GastoEnergetico = item.CaloriasDiarias;
            }
            dgvTasaMetabolicaBasal.Refresh();
        }

        private void MostrarDatos()
        {
            ConsultarClienteRespuesta respuesta = new ConsultarClienteRespuesta();
            dgvTasaMetabolicaBasal.DataSource = null;
            respuesta = service.ConsultarTodos();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textTasaIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textEntrenamientoFuerza_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TextEntrenamientoAerobicos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void MostrarDatosPorIdentificacion()
        {
            ConsultarClienteRespuesta respuesta = new ConsultarClienteRespuesta();
            dgvTasaMetabolicaBasal.DataSource = null;
            string identificacion = textTasaIdentificacion.Text;
            respuesta = service.BuscarPorId(identificacion);
            deportistas = respuesta.Deportistas.ToList();
            if (!respuesta.Error)
            {
                llenartabla(deportistas);
                textBoxGastoEnergetico.Text = Convert.ToString(GastoEnergetico);
            }
            else
            {
                MessageBox.Show("Error al consultar");
            }

        }

        private void botonBuscarIdentificacion_Click_1(object sender, EventArgs e)
        {
            if (textTasaIdentificacion.Text.Equals(""))
            {
                MessageBox.Show("Los datos estan Vacios");
                MostrarDatos();
            }
            else
            {
                MostrarDatosPorIdentificacion();
            }
        }
    }
}
