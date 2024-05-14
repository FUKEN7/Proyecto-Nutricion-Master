using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Logica;

namespace Presentacion
{
    public partial class FormEditarDeportistas : Form
    {

        public List<Deportista> deportistas;
        public serviceDeportista service;
        private string id;
        public static int cont = 0;
        public FormEditarDeportistas(string id)
        {
            
            service = new serviceDeportista();
            InitializeComponent();
            deportistas = new List<Deportista>();
            this.id = id;
            MostrarDatosPorIdentificacion();

        }
        private void llenartabla(List<Deportista> deportistas)
        {

            foreach (var item in deportistas)
            {
                textIdentificacion.Text = item.id.ToString();
                textNombre.Text = item.Nombre;
                textApellido.Text = item.Apellidó;
                textBoxCorreo.Text = item.Correo;
                textBoxDeporte.Text = item.Deporte;
                textBoxAlturaRegistar.Text = item.Altura.ToString();
                textTelefono.Text = item.Telefono;
                textBoxPesoRegistar.Text = item.Peso.ToString();
                
            }

        }
        private void MostrarDatosPorIdentificacion()
        {
            ConsultarClienteRespuesta respuesta = new ConsultarClienteRespuesta();
            string identificacion = this.id;
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

        public Deportista MapearDeportista()
        {
            Deportista deportista = new Deportista();
            deportista.TipoId = comboBoxTipoIdentidad.Text;
            deportista.id = textIdentificacion.Text;
            deportista.Nombre = textNombre.Text.ToUpper();
            deportista.Apellidó = textApellido.Text.ToUpper();
            deportista.Fecha_Nacimiento = dateTimeEdad.Value;
            deportista.Sexo = comboSexo.Text;
            deportista.Telefono = textTelefono.Text;
            deportista.Correo = textBoxCorreo.Text;
            deportista.Peso = double.Parse(textBoxPesoRegistar.Text);
            deportista.Altura = double.Parse(textBoxAlturaRegistar.Text);
            deportista.Deporte = textBoxDeporte.Text.ToUpper();
            deportista.TermogenesisActividadFisica = comboBoxTipoEntrenamiento.Text;
            deportista.FechaEgreso = DateTime.Now;
            return deportista;
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void BotonGuardarRegistro_Click(object sender, EventArgs e)
        {
            
        }

        private void FormEditarDeportistas_Load(object sender, EventArgs e)
        {

        }

        private void BotonGuardarRegistro_Click_1(object sender, EventArgs e)
        {
            if (textBoxCorreo.Text.Equals("") || textIdentificacion.Text.Equals("") || textNombre.Text.Equals("") || textApellido.Text.Equals("") || textTelefono.Text.Equals("") || comboSexo.SelectedIndex.Equals(-1) || comboBoxTipoIdentidad.SelectedIndex.Equals(-1) || textBoxPesoRegistar.Text.Equals("") || textBoxAlturaRegistar.Text.Equals("") || textBoxDeporte.Text.Equals("") || comboBoxTipoEntrenamiento.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("ALERTA CAMPOS VACIOS", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            else
            {
                var respuesta = MessageBox.Show("Está seguro de Modificar la información", "Mensaje de modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    Deportista deportista = MapearDeportista();
                    string mensaje = service.EditarDeportista(deportista, this.id);
                    MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void textIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionesNumericasRangoAlto(e, pictureBoxIdentidicacion, textIdentificacion);
        }

        private void textNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionesLetras(e, pictureBoxNombre, textNombre);
        }

        private void textApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
           ValidacionesLetras(e,pictureBoxApellido, textApellido);
        }

        private void textTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionesNumericasRangoAlto(e,pictureBoxTelefono, textTelefono);
        }

        private void textBoxPesoRegistar_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionesNumericasRangoBajo(e,pictureBoxPeso, textBoxPesoRegistar);
        }

        private void textBoxAlturaRegistar_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionesNumericasRangoBajo(e, pictureBoxAltura,textBoxAlturaRegistar);
        }

        private void textBoxDeporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionesLetras(e, pictureBoxDeporte, textBoxDeporte);


        }

        private void ValidacionesNumericasRangoBajo(KeyPressEventArgs e,PictureBox pictureBox,TextBox textBox)
        {
            if (textBox.TextLength >= 6)
            {
                e.Handled= true;
                pictureBox.Image = Properties.Resources.valido__1_;
                if (e.KeyChar==08) { e.Handled = false; }
            }
            else
            {
                if(textBox.TextLength <= 0) { pictureBox.Image = Properties.Resources.boton_x; } else { pictureBox.Image = Properties.Resources.valido__1_; }
                if (char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            
        }

        private void ValidacionesNumericasRangoAlto(KeyPressEventArgs e, PictureBox pictureBox, TextBox textBox)
        {
            if (textBox.TextLength >= 10)
            {
                e.Handled = true;
                pictureBox.Image = Properties.Resources.valido__1_;
                if (e.KeyChar == 08) { e.Handled = false; }
            }
            else
            {
                if (textBox.TextLength <= 5) { pictureBox.Image = Properties.Resources.boton_x; } else { pictureBox.Image = Properties.Resources.valido__1_; }
                if (char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }

        }

        private void ValidacionesLetras(KeyPressEventArgs e, PictureBox pictureBox, TextBox textBox)
        {
            if (textBox.TextLength >= 30)
            {
                e.Handled = true;
                pictureBox.Image = Properties.Resources.valido__1_;
                if (e.KeyChar == 08) { e.Handled = false; }
            }
            else
            {
                if (textBox.TextLength < 6) { pictureBox.Image = Properties.Resources.boton_x; } else { pictureBox.Image = Properties.Resources.valido__1_; }
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }

        }

        private void ValidacionesLetrasConCaracteresExpeciales(KeyPressEventArgs e, PictureBox pictureBox, TextBox textBox)
        {
            if (textBox.TextLength >= 30)
            {
                e.Handled = true;
                pictureBox.Image = Properties.Resources.valido__1_;
                if (e.KeyChar == 08) { e.Handled = false; }
            }
            else
            {
                if (textBox.TextLength < 6) { pictureBox.Image = Properties.Resources.boton_x; } else { pictureBox.Image = Properties.Resources.valido__1_; }
                if (char.IsPunctuation(e.KeyChar) || char.IsLetterOrDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }

        }

        private void textBoxCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionesLetrasConCaracteresExpeciales(e,pictureBoxCorreo,textBoxCorreo);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
