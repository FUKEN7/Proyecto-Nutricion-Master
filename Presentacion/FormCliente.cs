using Entidad.Cache;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
            llenarPerfil();
        }
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void FormCliente_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Agregar datos del usuario
        private void buttonAgregarData_Click(object sender, EventArgs e)
        {
        }

        private void llenarPerfil()
        {
            labelNombre.Text = UserLoginCache.FirstName+" "+ UserLoginCache.LastName;
            labelEmail.Text = UserLoginCache.Email;
        }

        private void panelbarraTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void labelNombre_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void labelEmail_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void buttonLogoup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void abrirFormatoHija(object FormatoHija)
        {
            if (panelContainer.Controls.Count > 0)
                panelContainer.Controls.RemoveAt(0);

            Form formatohija = FormatoHija as Form;
            formatohija.TopLevel = false;
            formatohija.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(formatohija);
            panelContainer.Tag = formatohija;
            formatohija.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
