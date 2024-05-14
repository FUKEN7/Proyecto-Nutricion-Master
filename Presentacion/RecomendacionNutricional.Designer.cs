
namespace Presentacion
{
    partial class RecomendacionNutricional
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ContenedorRecomendacioNutricional = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.ListasDiasSemana = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxDieta = new System.Windows.Forms.ComboBox();
            this.botonBuscarPaciente = new System.Windows.Forms.Button();
            this.textNombrePaciente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textIdentificacionRecomendacion = new System.Windows.Forms.TextBox();
            this.botonGuardarRecomendacion = new System.Windows.Forms.PictureBox();
            this.TextRecomendacionAlimentario = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextRecomendacionNutricional = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ContenedorRecomendacioNutricional.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botonGuardarRecomendacion)).BeginInit();
            this.SuspendLayout();
            // 
            // ContenedorRecomendacioNutricional
            // 
            this.ContenedorRecomendacioNutricional.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.ContenedorRecomendacioNutricional.Controls.Add(this.label8);
            this.ContenedorRecomendacioNutricional.Controls.Add(this.ListasDiasSemana);
            this.ContenedorRecomendacioNutricional.Controls.Add(this.label6);
            this.ContenedorRecomendacioNutricional.Controls.Add(this.comboBoxDieta);
            this.ContenedorRecomendacioNutricional.Controls.Add(this.botonBuscarPaciente);
            this.ContenedorRecomendacioNutricional.Controls.Add(this.textNombrePaciente);
            this.ContenedorRecomendacioNutricional.Controls.Add(this.label4);
            this.ContenedorRecomendacioNutricional.Controls.Add(this.label3);
            this.ContenedorRecomendacioNutricional.Controls.Add(this.textIdentificacionRecomendacion);
            this.ContenedorRecomendacioNutricional.Controls.Add(this.botonGuardarRecomendacion);
            this.ContenedorRecomendacioNutricional.Controls.Add(this.TextRecomendacionAlimentario);
            this.ContenedorRecomendacioNutricional.Controls.Add(this.label2);
            this.ContenedorRecomendacioNutricional.Controls.Add(this.TextRecomendacionNutricional);
            this.ContenedorRecomendacioNutricional.Controls.Add(this.label1);
            this.ContenedorRecomendacioNutricional.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContenedorRecomendacioNutricional.Location = new System.Drawing.Point(0, 0);
            this.ContenedorRecomendacioNutricional.Name = "ContenedorRecomendacioNutricional";
            this.ContenedorRecomendacioNutricional.Size = new System.Drawing.Size(1055, 678);
            this.ContenedorRecomendacioNutricional.TabIndex = 0;
            this.ContenedorRecomendacioNutricional.Paint += new System.Windows.Forms.PaintEventHandler(this.ContenedorRecomendacioNutricional_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Impact", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(353, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(378, 37);
            this.label8.TabIndex = 29;
            this.label8.Text = "RECOMENDACION NUTRICIONAL";
            // 
            // ListasDiasSemana
            // 
            this.ListasDiasSemana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.ListasDiasSemana.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListasDiasSemana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListasDiasSemana.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListasDiasSemana.ForeColor = System.Drawing.Color.White;
            this.ListasDiasSemana.FormattingEnabled = true;
            this.ListasDiasSemana.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes"});
            this.ListasDiasSemana.Location = new System.Drawing.Point(215, 254);
            this.ListasDiasSemana.Name = "ListasDiasSemana";
            this.ListasDiasSemana.Size = new System.Drawing.Size(86, 107);
            this.ListasDiasSemana.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(242, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Dieta";
            // 
            // comboBoxDieta
            // 
            this.comboBoxDieta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxDieta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDieta.FormattingEnabled = true;
            this.comboBoxDieta.Location = new System.Drawing.Point(215, 211);
            this.comboBoxDieta.Name = "comboBoxDieta";
            this.comboBoxDieta.Size = new System.Drawing.Size(95, 21);
            this.comboBoxDieta.TabIndex = 22;
            this.comboBoxDieta.SelectedIndexChanged += new System.EventHandler(this.comboBoxDieta_SelectedIndexChanged);
            this.comboBoxDieta.Click += new System.EventHandler(this.comboBoxDieta_Click);
            // 
            // botonBuscarPaciente
            // 
            this.botonBuscarPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.botonBuscarPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonBuscarPaciente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.botonBuscarPaciente.FlatAppearance.BorderSize = 7;
            this.botonBuscarPaciente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.botonBuscarPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.botonBuscarPaciente.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonBuscarPaciente.ForeColor = System.Drawing.Color.White;
            this.botonBuscarPaciente.Location = new System.Drawing.Point(687, 123);
            this.botonBuscarPaciente.Name = "botonBuscarPaciente";
            this.botonBuscarPaciente.Size = new System.Drawing.Size(76, 31);
            this.botonBuscarPaciente.TabIndex = 9;
            this.botonBuscarPaciente.Text = "Buscar";
            this.botonBuscarPaciente.UseVisualStyleBackColor = false;
            this.botonBuscarPaciente.Click += new System.EventHandler(this.botonBuscarPaciente_Click);
            // 
            // textNombrePaciente
            // 
            this.textNombrePaciente.Enabled = false;
            this.textNombrePaciente.Location = new System.Drawing.Point(440, 131);
            this.textNombrePaciente.Name = "textNombrePaciente";
            this.textNombrePaciente.Size = new System.Drawing.Size(197, 20);
            this.textNombrePaciente.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(504, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Paciente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(226, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Identificacion";
            // 
            // textIdentificacionRecomendacion
            // 
            this.textIdentificacionRecomendacion.Location = new System.Drawing.Point(213, 131);
            this.textIdentificacionRecomendacion.Name = "textIdentificacionRecomendacion";
            this.textIdentificacionRecomendacion.Size = new System.Drawing.Size(123, 20);
            this.textIdentificacionRecomendacion.TabIndex = 5;
            this.textIdentificacionRecomendacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textIdentificacionRecomendacion_KeyPress);
            // 
            // botonGuardarRecomendacion
            // 
            this.botonGuardarRecomendacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonGuardarRecomendacion.Image = global::Presentacion.Properties.Resources.salvar;
            this.botonGuardarRecomendacion.Location = new System.Drawing.Point(831, 440);
            this.botonGuardarRecomendacion.Name = "botonGuardarRecomendacion";
            this.botonGuardarRecomendacion.Size = new System.Drawing.Size(65, 65);
            this.botonGuardarRecomendacion.TabIndex = 4;
            this.botonGuardarRecomendacion.TabStop = false;
            this.botonGuardarRecomendacion.Click += new System.EventHandler(this.botonGuardarRecomendacion_Click);
            // 
            // TextRecomendacionAlimentario
            // 
            this.TextRecomendacionAlimentario.Location = new System.Drawing.Point(397, 397);
            this.TextRecomendacionAlimentario.Name = "TextRecomendacionAlimentario";
            this.TextRecomendacionAlimentario.Size = new System.Drawing.Size(302, 108);
            this.TextRecomendacionAlimentario.TabIndex = 3;
            this.TextRecomendacionAlimentario.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(441, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Recomendacion Alimentaria";
            // 
            // TextRecomendacionNutricional
            // 
            this.TextRecomendacionNutricional.Location = new System.Drawing.Point(397, 229);
            this.TextRecomendacionNutricional.Name = "TextRecomendacionNutricional";
            this.TextRecomendacionNutricional.Size = new System.Drawing.Size(302, 102);
            this.TextRecomendacionNutricional.TabIndex = 1;
            this.TextRecomendacionNutricional.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(441, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recomendacion Nutricional";
            // 
            // RecomendacionNutricional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 678);
            this.Controls.Add(this.ContenedorRecomendacioNutricional);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RecomendacionNutricional";
            this.Text = "RecomendacionNutricional";
            this.ContenedorRecomendacioNutricional.ResumeLayout(false);
            this.ContenedorRecomendacioNutricional.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botonGuardarRecomendacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ContenedorRecomendacioNutricional;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox TextRecomendacionAlimentario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox TextRecomendacionNutricional;
        private System.Windows.Forms.PictureBox botonGuardarRecomendacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textIdentificacionRecomendacion;
        private System.Windows.Forms.TextBox textNombrePaciente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button botonBuscarPaciente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxDieta;
        private System.Windows.Forms.CheckedListBox ListasDiasSemana;
        private System.Windows.Forms.Label label8;
    }
}