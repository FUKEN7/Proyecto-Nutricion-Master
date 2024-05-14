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
    public partial class RegistarPlantilla : Form
    {
        serviceAlimento serviceAlimentos;
        ServicePlantilla servicePlantilla;
        List<Alimento> alimentos;
        List<Plantilla> plantillas;
        public RegistarPlantilla()
        {
            serviceAlimentos = new serviceAlimento();
            servicePlantilla = new ServicePlantilla();
            InitializeComponent();
            alimentos = new List<Alimento>();
            plantillas = new List<Plantilla>();
            MostrarTodos();
        }

        private void LlenarDataGriv(List<Plantilla> plantillas)
        {
            dataGridView1.Rows.Clear();
            foreach (var item in plantillas)
            {
                dataGridView1.Rows.Add(item.NombrePlantilla,item.idAlimento,item.Categoria,item.Porcion);
                
            }
            dataGridView1.Refresh();
        }

        private void MostrarTodos()
        {
            ConsultarRespuestaPlantilla respuesta = new ConsultarRespuestaPlantilla();
            dataGridView1.DataSource = null;
            respuesta = servicePlantilla.Consultar();
            plantillas = respuesta.Plantillas.ToList();
            if (!respuesta.Error)
            {
                LlenarDataGriv(plantillas);
            }
            else
            {
                MessageBox.Show("Error al consular");
            }
            comboBoxCategoria.Enabled = false;
            comboBoxIngrediente.Enabled = false;
            textBoxPorcion.Enabled = false;
        }

        private void LlenarCombobox(List<Alimento> alimentos)
        {
            
            comboBoxIngrediente.Items.Clear();
            foreach (var item in alimentos)
            {
                comboBoxIngrediente.Items.Add(item.NombreAlimento);
            }
            comboBoxIngrediente.Refresh();
        }

        private void MostrarAlimentos()
        {
            ConsultarAlimentoRespuesta respuesta = new ConsultarAlimentoRespuesta();
            comboBoxIngrediente.DataSource = null;
            respuesta = serviceAlimentos.consultarTodo();
            alimentos = respuesta.Alimentos.ToList();
            if (!respuesta.Error)
            {
                LlenarCombobox(alimentos);
                
            }
            else
            {
                MessageBox.Show(respuesta.Mensaje,"Alerta",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }


        private void comboBoxIngrediente_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConsultarAlimentoRespuesta respuesta = serviceAlimentos.FiltrarPorNombre(comboBoxIngrediente.Text);
            List<Alimento> alimentos = respuesta.Alimentos.ToList();
            foreach(var item in alimentos)
            {
                labelTotalCalorias.Text = item.Calorias.ToString();
                labelTotalCarbohidratos.Text = item.Carbohidratos.ToString();
                labelTotalProteinas.Text = item.Proteinas.ToString();
                labelTotalLiquidos.Text = item.Liquidos.ToString();
                comboBoxIngrediente.ValueMember = item.IdAlimentos.ToString();
            }
        }

        private void comboBoxIngrediente_Click(object sender, EventArgs e)
        {
            MostrarAlimentos();
            
        }

        private Plantilla MapearDatosPlantillas()
        {
            Plantilla plantilla = new Plantilla();
            plantilla.NombrePlantilla = textNombrePlantilla.Text;
            return plantilla;
        }

        private Plantilla MapearDatosPlantillaAlimentos()
        {
            Plantilla plantilla = new Plantilla();
            plantilla.NombrePlantilla = comboBoxPlantillaAdd.Text;
            plantilla.idAlimento = comboBoxIngrediente.ValueMember;
            plantilla.Porcion = int.Parse(textBoxPorcion.Text);
            plantilla.Categoria = comboBoxCategoria.Text;
            return plantilla;
        }

        private void botonAgregarListado_Click(object sender, EventArgs e)
        {
            if (textBoxPorcion.Text.Equals("") || comboBoxCategoria.Text.Equals("") || comboBoxIngrediente.Text.Equals("") || comboBoxPlantillaAdd.Text.Equals(""))
            {
                MessageBox.Show("Los campos estan Vacios", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Plantilla plantilla = MapearDatosPlantillaAlimentos();
                string Mensaje = servicePlantilla.AddGuardarPlantilla(plantilla);
                MessageBox.Show(Mensaje, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarTodos();
                vaciarCampos();
            }
        }

        private void vaciarCampos()
        {
            textBoxPorcion.Text = "";
            comboBoxPlantillaAdd.Text = null;
            comboBoxCategoria.Text = null;
            comboBoxIngrediente.Text = null;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BotonGuardarRegistro_Click(object sender, EventArgs e)
        {
            if (textNombrePlantilla.Text.Equals(""))
            {
                MessageBox.Show("Los campos estan Vacios", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Plantilla plantilla = MapearDatosPlantillas();
                string Mensaje = servicePlantilla.Guardar(plantilla);
                MessageBox.Show(Mensaje, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textNombrePlantilla.Text = "";
            }
        }

        private void LlenarCombobox(List<Plantilla> plantillas)
        {

            comboBoxPlantillaAdd.Items.Clear();
            foreach (var item in plantillas)
            {
                comboBoxPlantillaAdd.Items.Add(item.NombrePlantilla);
                
            }
            comboBoxPlantillaAdd.Refresh();
        }

        private void MostrarPlantillasAdd()
        {
            ConsultarRespuestaPlantilla respuesta = new ConsultarRespuestaPlantilla();
            comboBoxPlantillaAdd.DataSource = null;
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

        private void comboBoxPlantillaAdd_Click(object sender, EventArgs e)
        {
            MostrarPlantillasAdd();
        }

        private void comboBoxPlantillaAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxCategoria.Enabled = true;
            comboBoxIngrediente.Enabled = true;
            textBoxPorcion.Enabled = true;
            //colocar selector de valor seleccionado
        }
    }
}
