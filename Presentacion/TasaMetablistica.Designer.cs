
namespace Presentacion
{
    partial class TasaMetablistica
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelFondoTasa = new System.Windows.Forms.Panel();
            this.panelCuerpo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxGastoEnergetico = new System.Windows.Forms.TextBox();
            this.dgvTasaMetabolicaBasal = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelIdentificacion = new System.Windows.Forms.Label();
            this.textTasaIdentificacion = new System.Windows.Forms.TextBox();
            this.botonBuscarIdentificacion = new System.Windows.Forms.Button();
            this.PanelFondoTasa.SuspendLayout();
            this.panelCuerpo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasaMetabolicaBasal)).BeginInit();
            this.panelSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelFondoTasa
            // 
            this.PanelFondoTasa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.PanelFondoTasa.Controls.Add(this.panelCuerpo);
            this.PanelFondoTasa.Controls.Add(this.panelSuperior);
            this.PanelFondoTasa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFondoTasa.Location = new System.Drawing.Point(0, 0);
            this.PanelFondoTasa.Name = "PanelFondoTasa";
            this.PanelFondoTasa.Size = new System.Drawing.Size(935, 480);
            this.PanelFondoTasa.TabIndex = 0;
            // 
            // panelCuerpo
            // 
            this.panelCuerpo.Controls.Add(this.label1);
            this.panelCuerpo.Controls.Add(this.textBoxGastoEnergetico);
            this.panelCuerpo.Controls.Add(this.dgvTasaMetabolicaBasal);
            this.panelCuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCuerpo.Location = new System.Drawing.Point(0, 135);
            this.panelCuerpo.Name = "panelCuerpo";
            this.panelCuerpo.Size = new System.Drawing.Size(935, 345);
            this.panelCuerpo.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(407, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Gasto Energetico";
            // 
            // textBoxGastoEnergetico
            // 
            this.textBoxGastoEnergetico.Enabled = false;
            this.textBoxGastoEnergetico.Location = new System.Drawing.Point(399, 292);
            this.textBoxGastoEnergetico.Name = "textBoxGastoEnergetico";
            this.textBoxGastoEnergetico.Size = new System.Drawing.Size(132, 20);
            this.textBoxGastoEnergetico.TabIndex = 18;
            // 
            // dgvTasaMetabolicaBasal
            // 
            this.dgvTasaMetabolicaBasal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTasaMetabolicaBasal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.dgvTasaMetabolicaBasal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTasaMetabolicaBasal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvTasaMetabolicaBasal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTasaMetabolicaBasal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTasaMetabolicaBasal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTasaMetabolicaBasal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTasaMetabolicaBasal.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTasaMetabolicaBasal.EnableHeadersVisualStyles = false;
            this.dgvTasaMetabolicaBasal.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.dgvTasaMetabolicaBasal.Location = new System.Drawing.Point(215, 49);
            this.dgvTasaMetabolicaBasal.Name = "dgvTasaMetabolicaBasal";
            this.dgvTasaMetabolicaBasal.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTasaMetabolicaBasal.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumAquamarine;
            this.dgvTasaMetabolicaBasal.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTasaMetabolicaBasal.Size = new System.Drawing.Size(505, 201);
            this.dgvTasaMetabolicaBasal.TabIndex = 17;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Peso";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Altura";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Edad";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tasa Metabolica Basal";
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // panelSuperior
            // 
            this.panelSuperior.Controls.Add(this.label2);
            this.panelSuperior.Controls.Add(this.LabelIdentificacion);
            this.panelSuperior.Controls.Add(this.textTasaIdentificacion);
            this.panelSuperior.Controls.Add(this.botonBuscarIdentificacion);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(935, 135);
            this.panelSuperior.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(317, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 37);
            this.label2.TabIndex = 17;
            this.label2.Text = "TASA METABOLICA BASAL";
            // 
            // LabelIdentificacion
            // 
            this.LabelIdentificacion.AutoSize = true;
            this.LabelIdentificacion.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelIdentificacion.ForeColor = System.Drawing.Color.White;
            this.LabelIdentificacion.Location = new System.Drawing.Point(308, 87);
            this.LabelIdentificacion.Name = "LabelIdentificacion";
            this.LabelIdentificacion.Size = new System.Drawing.Size(96, 19);
            this.LabelIdentificacion.TabIndex = 16;
            this.LabelIdentificacion.Text = "Identificacion";
            // 
            // textTasaIdentificacion
            // 
            this.textTasaIdentificacion.Location = new System.Drawing.Point(410, 86);
            this.textTasaIdentificacion.Name = "textTasaIdentificacion";
            this.textTasaIdentificacion.Size = new System.Drawing.Size(100, 20);
            this.textTasaIdentificacion.TabIndex = 15;
            // 
            // botonBuscarIdentificacion
            // 
            this.botonBuscarIdentificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.botonBuscarIdentificacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonBuscarIdentificacion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.botonBuscarIdentificacion.FlatAppearance.BorderSize = 7;
            this.botonBuscarIdentificacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.botonBuscarIdentificacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.botonBuscarIdentificacion.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonBuscarIdentificacion.ForeColor = System.Drawing.Color.White;
            this.botonBuscarIdentificacion.Location = new System.Drawing.Point(549, 81);
            this.botonBuscarIdentificacion.Name = "botonBuscarIdentificacion";
            this.botonBuscarIdentificacion.Size = new System.Drawing.Size(75, 29);
            this.botonBuscarIdentificacion.TabIndex = 14;
            this.botonBuscarIdentificacion.Text = "Buscar";
            this.botonBuscarIdentificacion.UseVisualStyleBackColor = false;
            this.botonBuscarIdentificacion.Click += new System.EventHandler(this.botonBuscarIdentificacion_Click_1);
            // 
            // TasaMetablistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 480);
            this.Controls.Add(this.PanelFondoTasa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TasaMetablistica";
            this.Text = "TasaMetablistica";
            this.PanelFondoTasa.ResumeLayout(false);
            this.panelCuerpo.ResumeLayout(false);
            this.panelCuerpo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasaMetabolicaBasal)).EndInit();
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelFondoTasa;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelIdentificacion;
        private System.Windows.Forms.TextBox textTasaIdentificacion;
        private System.Windows.Forms.Button botonBuscarIdentificacion;
        private System.Windows.Forms.Panel panelCuerpo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxGastoEnergetico;
        private System.Windows.Forms.DataGridView dgvTasaMetabolicaBasal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}