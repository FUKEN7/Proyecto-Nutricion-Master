
namespace Presentacion
{
    partial class Consultar
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.dgvConsultaDatosPersonales = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nutrisoftDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nutrisoftDataSet = new Presentacion.NutrisoftDataSet();
            this.buttonBuscarDeportista = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textNombrePaciente = new System.Windows.Forms.TextBox();
            this.Identificacion = new System.Windows.Forms.Label();
            this.TextboxIdentificacion = new System.Windows.Forms.TextBox();
            this.PanelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaDatosPersonales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nutrisoftDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nutrisoftDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.PanelPrincipal.Controls.Add(this.buttonEliminar);
            this.PanelPrincipal.Controls.Add(this.buttonEditar);
            this.PanelPrincipal.Controls.Add(this.dgvConsultaDatosPersonales);
            this.PanelPrincipal.Controls.Add(this.buttonBuscarDeportista);
            this.PanelPrincipal.Controls.Add(this.label2);
            this.PanelPrincipal.Controls.Add(this.label1);
            this.PanelPrincipal.Controls.Add(this.textNombrePaciente);
            this.PanelPrincipal.Controls.Add(this.Identificacion);
            this.PanelPrincipal.Controls.Add(this.TextboxIdentificacion);
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(1067, 594);
            this.PanelPrincipal.TabIndex = 0;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.buttonEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonEliminar.FlatAppearance.BorderSize = 0;
            this.buttonEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.buttonEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.ForeColor = System.Drawing.Color.White;
            this.buttonEliminar.Image = global::Presentacion.Properties.Resources.basura;
            this.buttonEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEliminar.Location = new System.Drawing.Point(826, 71);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(104, 44);
            this.buttonEliminar.TabIndex = 10;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.buttonEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonEditar.FlatAppearance.BorderSize = 0;
            this.buttonEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.buttonEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.buttonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditar.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditar.ForeColor = System.Drawing.Color.White;
            this.buttonEditar.Image = global::Presentacion.Properties.Resources.editar;
            this.buttonEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEditar.Location = new System.Drawing.Point(723, 76);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(97, 39);
            this.buttonEditar.TabIndex = 9;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvConsultaDatosPersonales
            // 
            this.dgvConsultaDatosPersonales.AllowUserToAddRows = false;
            this.dgvConsultaDatosPersonales.AllowUserToDeleteRows = false;
            this.dgvConsultaDatosPersonales.AutoGenerateColumns = false;
            this.dgvConsultaDatosPersonales.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.dgvConsultaDatosPersonales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvConsultaDatosPersonales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultaDatosPersonales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConsultaDatosPersonales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaDatosPersonales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvConsultaDatosPersonales.DataSource = this.nutrisoftDataSetBindingSource;
            this.dgvConsultaDatosPersonales.EnableHeadersVisualStyles = false;
            this.dgvConsultaDatosPersonales.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.dgvConsultaDatosPersonales.Location = new System.Drawing.Point(12, 142);
            this.dgvConsultaDatosPersonales.Name = "dgvConsultaDatosPersonales";
            this.dgvConsultaDatosPersonales.ReadOnly = true;
            this.dgvConsultaDatosPersonales.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultaDatosPersonales.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvConsultaDatosPersonales.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumAquamarine;
            this.dgvConsultaDatosPersonales.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvConsultaDatosPersonales.Size = new System.Drawing.Size(1034, 440);
            this.dgvConsultaDatosPersonales.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Identificacion";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 130;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 250;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Edad";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 80;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Sexo";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 80;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Telefono";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 120;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Deporte";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 150;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Correo";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 200;
            // 
            // nutrisoftDataSetBindingSource
            // 
            this.nutrisoftDataSetBindingSource.DataSource = this.nutrisoftDataSet;
            this.nutrisoftDataSetBindingSource.Position = 0;
            // 
            // nutrisoftDataSet
            // 
            this.nutrisoftDataSet.DataSetName = "NutrisoftDataSet";
            this.nutrisoftDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonBuscarDeportista
            // 
            this.buttonBuscarDeportista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.buttonBuscarDeportista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBuscarDeportista.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonBuscarDeportista.FlatAppearance.BorderSize = 0;
            this.buttonBuscarDeportista.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.buttonBuscarDeportista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.buttonBuscarDeportista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarDeportista.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarDeportista.ForeColor = System.Drawing.Color.White;
            this.buttonBuscarDeportista.Image = global::Presentacion.Properties.Resources.consulta_de_busqueda;
            this.buttonBuscarDeportista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBuscarDeportista.Location = new System.Drawing.Point(594, 76);
            this.buttonBuscarDeportista.Name = "buttonBuscarDeportista";
            this.buttonBuscarDeportista.Size = new System.Drawing.Size(107, 39);
            this.buttonBuscarDeportista.TabIndex = 7;
            this.buttonBuscarDeportista.Text = "Buscar";
            this.buttonBuscarDeportista.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBuscarDeportista.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBuscarDeportista.UseVisualStyleBackColor = false;
            this.buttonBuscarDeportista.Click += new System.EventHandler(this.buttonBuscarDeportista_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(266, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "CONSULTA DEPORTISTA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(440, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre Paciente";
            // 
            // textNombrePaciente
            // 
            this.textNombrePaciente.Location = new System.Drawing.Point(431, 95);
            this.textNombrePaciente.MaxLength = 50;
            this.textNombrePaciente.Name = "textNombrePaciente";
            this.textNombrePaciente.Size = new System.Drawing.Size(140, 20);
            this.textNombrePaciente.TabIndex = 4;
            this.textNombrePaciente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNombrePaciente_KeyPress);
            // 
            // Identificacion
            // 
            this.Identificacion.AutoSize = true;
            this.Identificacion.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Identificacion.ForeColor = System.Drawing.Color.White;
            this.Identificacion.Location = new System.Drawing.Point(246, 72);
            this.Identificacion.Name = "Identificacion";
            this.Identificacion.Size = new System.Drawing.Size(100, 20);
            this.Identificacion.TabIndex = 1;
            this.Identificacion.Text = "Identificacion";
            // 
            // TextboxIdentificacion
            // 
            this.TextboxIdentificacion.Location = new System.Drawing.Point(247, 95);
            this.TextboxIdentificacion.MaxLength = 10;
            this.TextboxIdentificacion.Name = "TextboxIdentificacion";
            this.TextboxIdentificacion.Size = new System.Drawing.Size(100, 20);
            this.TextboxIdentificacion.TabIndex = 0;
            this.TextboxIdentificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextboxIdentificacion_KeyPress);
            // 
            // Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 594);
            this.Controls.Add(this.PanelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Consultar";
            this.Text = "Consultar";
            this.PanelPrincipal.ResumeLayout(false);
            this.PanelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaDatosPersonales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nutrisoftDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nutrisoftDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.Label Identificacion;
        private System.Windows.Forms.TextBox TextboxIdentificacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNombrePaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBuscarDeportista;
        private System.Windows.Forms.DataGridView dgvConsultaDatosPersonales;
        private System.Windows.Forms.BindingSource nutrisoftDataSetBindingSource;
        private NutrisoftDataSet nutrisoftDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonEliminar;
    }
}