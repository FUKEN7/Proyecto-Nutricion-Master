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
    public partial class RegistarIngrediente : Form
    {
        public serviceAlimento serviceAlimento;
        List<Alimento> alimento;
        
        public RegistarIngrediente()
        {
            serviceAlimento = new serviceAlimento();
            InitializeComponent();
            alimento = new List<Alimento>();
            MostarDataAlimentos();
        }

        private void ConsultarData()
        {
            ConsultarAlimentoRespuesta respuesta = new ConsultarAlimentoRespuesta();
            dgvAlimentos.DataSource = null;
            respuesta = serviceAlimento.consultarTodo();
            alimento = respuesta.Alimentos.ToList();
            dgvAlimentos.DataSource = respuesta.Alimentos;
        }

        private Alimento MaperarIdAlimentos()
        {
            Alimento alimento = new Alimento();
            alimento.IdAlimentos = textIdAlimento.Text;
            alimento.NombreAlimento = textAlimento.Text.ToUpper();
            alimento.Calorias = double.Parse(textCalorias.Text);
            alimento.Carbohidratos = double.Parse(textCarbohidratos.Text);
            alimento.Proteinas = double.Parse(textProteinas.Text);
            alimento.Liquidos = double.Parse(textLiquidos.Text);
            return alimento;
        }

        private void LlenarGriv(List<Alimento> alimentos)
        {
            dgvAlimentos.Rows.Clear();
            foreach(var item in alimento)
            {
                dgvAlimentos.Rows.Add(item.IdAlimentos, item.NombreAlimento, item.Calorias, item.Carbohidratos, item.Proteinas, item.Liquidos);
            }
            dgvAlimentos.Refresh();
        }

        private void MostarDataAlimentos()
        {
            ConsultarAlimentoRespuesta respuesta = new ConsultarAlimentoRespuesta();
            dgvAlimentos.DataSource = null;
            respuesta = serviceAlimento.consultarTodo();
            alimento = respuesta.Alimentos.ToList();
            if (!respuesta.Error)
            {
                LlenarGriv(alimento);
            }
            else
            {
                MessageBox.Show(respuesta.Mensaje, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void botonGuardarAlimentos_Click(object sender, EventArgs e)
        {
            if(textAlimento.Text.Equals("") || textCalorias.Text.Equals("") || textCarbohidratos.Text.Equals("") || textLiquidos.Text.Equals("") || textProteinas.Text.Equals(""))
            {
                MessageBox.Show("Los Campos esta Vacios", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Alimento alimento = MaperarIdAlimentos();
                string mensaje = serviceAlimento.Guardar(alimento);
                MessageBox.Show(mensaje, "Mensaje de Guardado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                MostarDataAlimentos();
                textAlimento.Text = "";
                textIdAlimento.Text = "";
                textCalorias.Text = "";
                textCarbohidratos.Text = "";
                textLiquidos.Text = "";
                textProteinas.Text = "";
            }
        }

        private void ValidacionNumerico(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 58 && e.KeyChar <= 255) || (e.KeyChar <= 47 && e.KeyChar >= 45))
            {
                MessageBox.Show("Solo se permiten Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textCalorias_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionNumerico(sender, e);
        }

        private void textCarbohidratos_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionNumerico(sender, e);
        }

        private void textProteinas_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionNumerico(sender, e);
        }

        private void textLiquidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionNumerico(sender, e);
        }

        private void textAlimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten Letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textIdAlimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 58 && e.KeyChar <= 255) || (e.KeyChar == 45 && e.KeyChar == 47))
            {
                MessageBox.Show("Solo se permiten Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
