using Entidad;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormRegister : Form
    {
        public readonly ValidacionesPresentacion validaciones;
        public readonly serviceDeportista serviceDeportista;
        public readonly Validacion validacion;
        public FormRegister()
        {
            InitializeComponent();
            validaciones = new ValidacionesPresentacion();
            serviceDeportista = new serviceDeportista();
            validacion = new Validacion();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void textBoxIdentificacion_Enter(object sender, EventArgs e)
        {
            StyleTextBox("Identificacion", 1, textBoxIdentificacion);
        }

        private void textBoxIdentificacion_Leave(object sender, EventArgs e)
        {
            StyleTextBox("Identificacion", 2, textBoxIdentificacion);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormRegister_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelRegisterUser_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBoxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();
        }

        private void textBoxIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            string message = validaciones.validacion(e, 3,labelIdentificacion);
            labelIdentificacion.Text = message;
        }

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            string message = validaciones.validacion(e, 2,labelNombre);
        }

        private void textBoxNombre_Enter(object sender, EventArgs e)
        {
            StyleTextBox("Nombre",1, textBoxNombre);
        }

        private void textBoxNombre_Leave(object sender, EventArgs e)
        {
            StyleTextBox("Nombre", 2,textBoxNombre);
        }

        private void StyleTextBox(string text,int tipo,TextBox textBox)
        {
            if (tipo == 1) {
                if (textBox.Text == text)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.LightGray;
                    if (text.Equals("Password")) { textBox.UseSystemPasswordChar = true; }
                }
            }else if (tipo == 2)
            {
                if (textBox.Text == "")
                {
                    textBox.Text = text;
                    textBox.ForeColor = Color.LightGray;
                    if (text.Equals("Password")) { textBox.UseSystemPasswordChar = false; }
                }
            }
        }

        private void textBoxApellido_Enter(object sender, EventArgs e)
        {
            StyleTextBox("Apellido",1,textBoxApellido);
        }

        private void textBoxApellido_Leave(object sender, EventArgs e)
        {
            StyleTextBox("Apellido", 2, textBoxApellido);
        }

        private void textBoxTelefono_Enter(object sender, EventArgs e)
        {
            StyleTextBox("Telefono", 1, textBoxTelefono);
        }

        private void textBoxTelefono_Leave(object sender, EventArgs e)
        {
            StyleTextBox("Telefono", 2, textBoxTelefono);
        }

        private void textBoxEmial_Enter(object sender, EventArgs e)
        {
            StyleTextBox("Email", 1, textBoxEmial);
        }

        private void textBoxEmial_Leave(object sender, EventArgs e)
        {
            StyleTextBox("Email", 2, textBoxEmial);
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            StyleTextBox("Password", 1, textBoxPassword);
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            StyleTextBox("Password", 2, textBoxPassword);
            
        }

        private void textBoxApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            string message = validaciones.validacion(e, 2,labelApellido);
        }

        private void textBoxTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            string message = validaciones.validacion(e, 3, labelTelefono);
        }

        private Deportista MaperarPerson()
        {
            Deportista deportista = new Deportista();
            deportista.id = textBoxIdentificacion.Text.ToUpper();
            deportista.TipoId = comboBoxTipoIndetificacion.Text.ToUpper();
            deportista.Nombre = textBoxNombre.Text.ToUpper();
            deportista.Apellidó = textBoxApellido.Text.ToUpper();
            deportista.Sexo = comboBoxSexo.Text.ToUpper();
            deportista.Fecha_Nacimiento = DateTime.Parse(dateTimePickerFechaNacimiento.Text);
            deportista.Telefono = textBoxTelefono.Text.ToUpper();
            deportista.Correo = textBoxEmial.Text.ToUpper();
            deportista.Password = textBoxPassword.Text;
            deportista.Peso = double.Parse(textBoxPeso.Text);
            deportista.Altura = double.Parse(textBoxAltura.Text);
            deportista.Deporte = textBoxDeporte.Text.ToUpper();
            deportista.TermogenesisActividadFisica = comboBoxTipoEntrenamiento.Text.ToUpper();
            deportista.FechaEgreso = DateTime.Now;
            return deportista;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GuardarDatos();
        }

        private void GuardarDatos()
        {
            
            if (validacion.next.Equals(true) 
                && validacion.next1.Equals(true) 
                && validacion.next2.Equals(true)
                && validacion.next3.Equals(true)
                && validacion.next4.Equals(true)
                && validacion.next5.Equals(true))
            {
                if (validaciones.ValidacionEmail(textBoxEmial.Text) == false)
                {
                    MessageBox.Show("Error Direccion de correo Invalida", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    if (textBoxIdentificacion.Text.Equals("Identificacion")
                        || textBoxNombre.Text.Equals("Nombre")
                        || textBoxApellido.Text.Equals("Apellido")
                        || textBoxTelefono.Text.Equals("Telefono")
                        || textBoxEmial.Text.Equals("Email")
                        || textBoxPassword.Text.Equals("Password")
                        || comboBoxSexo.SelectedIndex.Equals(-1)
                        || comboBoxTipoIndetificacion.SelectedIndex.Equals(-1))
                    {
                        MessageBox.Show("Error hay campos vacios", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        panelRegistrarUserNext.Visible = true;
                        buttonNext.Visible = false;
                    }
                }
            }
        }

        private void buttonRegistrar_Click_1(object sender, EventArgs e)
        {
            if (textBoxPeso.Text.Equals("Peso")
                || textBoxAltura.Text.Equals("Altura")
                || textBoxDeporte.Text.Equals("Deporte")
                || comboBoxTipoEntrenamiento.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Campos Vacios", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Deportista persona = MaperarPerson();
                var message = serviceDeportista.Guardar(persona);
                if (message == "Paciente Registrado")
                {
                    MessageBox.Show(message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    FormLogin formLogin = new FormLogin();
                    formLogin.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            
        }

        private void LimpiarCampos()
        {
            textBoxIdentificacion.Text = "Identificacion";
            textBoxNombre.Text = "Nombre";
            textBoxApellido.Text = "Apellido";
            textBoxPassword.Text = "Password";
            textBoxAltura.Text = "Altura";
            textBoxTelefono.Text = "Telefono";
            textBoxPeso.Text = "Peso";
            textBoxEmial.Text = "Email";
            textBoxDeporte.Text = "Deporte";
            comboBoxSexo.SelectedIndex = -1;
            comboBoxTipoEntrenamiento.SelectedIndex = -1;
            comboBoxTipoIndetificacion.SelectedIndex = -1;
        }

        private void textBoxPeso_Enter(object sender, EventArgs e)
        {
            StyleTextBox("Peso",1,textBoxPeso);
        }

        private void textBoxPeso_Leave(object sender, EventArgs e)
        {
            StyleTextBox("Peso", 2, textBoxPeso);
        }

        private void textBoxAltura_Enter(object sender, EventArgs e)
        {
            StyleTextBox("Altura", 1, textBoxAltura);
        }

        private void textBoxAltura_Leave(object sender, EventArgs e)
        {
            StyleTextBox("Altura", 2, textBoxAltura);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panelRegistrarUserNext.Visible = false;
            buttonNext.Visible = true;
        }

        private void textBoxIdentificacion_TextChanged(object sender, EventArgs e)
        {
            //changed
            validacion.next = validaciones.RangoCampos(textBoxIdentificacion,"Identificacion",labelIdentificacion,6);
        }

        private void textBoxDeporte_Enter(object sender, EventArgs e)
        {
            StyleTextBox("Deporte", 1, textBoxDeporte);
        }

        private void textBoxDeporte_Leave(object sender, EventArgs e)
        {
            StyleTextBox("Deporte", 2, textBoxDeporte);
        }

        private void textBoxDeporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            string message = validaciones.validacion(e, 3,labelDeporte);
            labelDeporte.Text = message;
        }

        private void textBoxPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            string message = validaciones.validacion(e, 3,labelPeso);
            labelPeso.Text = message;
        }

        private void textBoxAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            string message = validaciones.validacion(e, 3,labelAltura);
            labelAltura.Text = message;
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            validacion.next1 = validaciones.RangoCampos(textBoxNombre, "Nombre", labelNombre, 5);
        }

        private void textBoxApellido_TextChanged(object sender, EventArgs e)
        {
            validacion.next2 = validaciones.RangoCampos(textBoxApellido, "Apellido", labelApellido, 5);
        }

        private void textBoxTelefono_TextChanged(object sender, EventArgs e)
        {
            validacion.next3 = validaciones.RangoCampos(textBoxTelefono, "Telefono", labelTelefono, 8);
        }

        private void textBoxEmial_TextChanged(object sender, EventArgs e)
        {
            validacion.next4 = validaciones.RangoCampos(textBoxEmial, "Email", labelEmail, 5);
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            validacion.next5 = validaciones.RangoCampos(textBoxPassword, "Password", labelPassword, 6);
        }

        private void textBoxPeso_TextChanged(object sender, EventArgs e)
        {
            bool continuar = validaciones.RangoCampos(textBoxPeso, "Peso", labelPeso, 1);
        }

        private void textBoxAltura_TextChanged(object sender, EventArgs e)
        {
            bool continuar = validaciones.RangoCampos(textBoxAltura, "Altura", labelAltura, 1);
        }

        private void textBoxDeporte_TextChanged(object sender, EventArgs e)
        {
            bool continuar = validaciones.RangoCampos(textBoxDeporte, "Deporte", labelDeporte, 4);
        }
    }
}
