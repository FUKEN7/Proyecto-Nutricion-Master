using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Logica;

namespace Presentacion
{
    public partial class Consultar : Form
    {
        public readonly serviceDeportista service;
        public List<Deportista> deportistas;
        public Consultar()
        {
            service = new serviceDeportista();
            InitializeComponent();
            deportistas = new List<Deportista>();
            MostrarDeportista();
        }

        private void Llenartable(List<Deportista> deportistas)
        {
            dgvConsultaDatosPersonales.Rows.Clear();
            foreach (var item in deportistas)
            {
                dgvConsultaDatosPersonales.Rows.Add(item.id,$"{item.Nombre} {item.Apellidó }",item.Edad-item.Fecha_Nacimiento.Year,item.Sexo,item.Telefono,item.Deporte,item.Correo);
            }
            dgvConsultaDatosPersonales.Refresh();
        }

        public void MostrarDeportista()
        {
            ConsultarClienteRespuesta respuesta = new ConsultarClienteRespuesta();
            dgvConsultaDatosPersonales.DataSource = null;
            respuesta = service.ConsultarTodos();
            deportistas = respuesta.Deportistas.ToList();
            if (!respuesta.Error)
            {
                Llenartable(deportistas);
            }
            else
            {
                MessageBox.Show("Error al consular");
            }
        }

        private void TextboxIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void MostrarDeportistaPorIdentificacion()
        {
            ConsultarClienteRespuesta respuesta = new ConsultarClienteRespuesta();
            dgvConsultaDatosPersonales.DataSource = null;
            string identificacion = TextboxIdentificacion.Text;
            respuesta = service.BuscarPorId(identificacion);
            deportistas = respuesta.Deportistas.ToList();
            if (!respuesta.Error)
            {
                Llenartable(deportistas);
            }
            else
            {
                MessageBox.Show("Error al consular");
            }
        }

        private void MostrarDeportistaPorNombre()
        {
            
            dgvConsultaDatosPersonales.DataSource = null;
            string nombre = textNombrePaciente.Text;
            ConsultarClienteRespuesta respuesta = new ConsultarClienteRespuesta();
            respuesta = service.BuscarPorNombre(nombre);
            deportistas = respuesta.Deportistas.ToList();
            if (!respuesta.Error)
            {
                Llenartable(deportistas);
            }
            else
            {
                MessageBox.Show("Error al consular");
            }
        }

        private void buttonBuscarDeportista_Click(object sender, EventArgs e)
        {
            if (TextboxIdentificacion.Text.Equals(""))
            {
                MessageBox.Show("El campo de identificacion esta Vacio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MostrarDeportista();
            }
            else
            {
                MostrarDeportistaPorIdentificacion();
            }
            /*
            ConsultarPersonaRespuesta respuesta = new ConsultarPersonaRespuesta();
            dgvConsultaDatosPersonales.DataSource = null;
            respuesta = service.consultarPorIdentificacion(TextboxIdentificacion.Text);
            deportista = respuesta.Deportistas.ToList();
            dgvConsultaDatosPersonales.DataSource = deportista;
            */
        }

        private void dataGridViewConsultarDeportista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textNombrePaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            MostrarDeportistaPorNombre();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TextboxIdentificacion.Text.Equals(""))
            {
                MessageBox.Show("El campo de identificacion esta Vacio", "Mensaje de Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                new FormEditarDeportistas(TextboxIdentificacion.Text).Show();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("Está seguro de Eliminar la información", "Mensaje de Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                string mensaje = service.EliminarDeportista(TextboxIdentificacion.Text);
                MessageBox.Show(mensaje, "Mensaje de Modificación", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            MostrarDeportista();
        }
    }
}
