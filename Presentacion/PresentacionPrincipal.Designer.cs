
namespace Presentacion
{
    partial class PresentacionPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PresentacionPrincipal));
            this.panelCabeza = new System.Windows.Forms.Panel();
            this.botonRestaurar = new System.Windows.Forms.PictureBox();
            this.botonMinimizar = new System.Windows.Forms.PictureBox();
            this.botonMaximizar = new System.Windows.Forms.PictureBox();
            this.botonCerrar = new System.Windows.Forms.PictureBox();
            this.VentanaMenu = new System.Windows.Forms.Panel();
            this.subMenuDieta = new System.Windows.Forms.Panel();
            this.botonRecomendacionNutricional = new System.Windows.Forms.Button();
            this.botonAsignarDieta = new System.Windows.Forms.Button();
            this.SubMenuConsultar = new System.Windows.Forms.Panel();
            this.subBotonConsultarTasaMetabolicaBasal = new System.Windows.Forms.Button();
            this.subBotonConsultarDatosPacientes = new System.Windows.Forms.Button();
            this.botonConsultar = new System.Windows.Forms.Button();
            this.SubMenuAlimentos = new System.Windows.Forms.Panel();
            this.subBotonRegistarDietas = new System.Windows.Forms.Button();
            this.subBotonRegistarAlimentos = new System.Windows.Forms.Button();
            this.botonAlimentos = new System.Windows.Forms.Button();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.LogoHome = new System.Windows.Forms.PictureBox();
            this.labelCerrarSession = new System.Windows.Forms.Label();
            this.pictureBoxCerrarSession = new System.Windows.Forms.PictureBox();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.panelCabeza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botonRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonCerrar)).BeginInit();
            this.VentanaMenu.SuspendLayout();
            this.subMenuDieta.SuspendLayout();
            this.SubMenuConsultar.SuspendLayout();
            this.SubMenuAlimentos.SuspendLayout();
            this.PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrarSession)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCabeza
            // 
            this.panelCabeza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(133)))));
            this.panelCabeza.Controls.Add(this.botonRestaurar);
            this.panelCabeza.Controls.Add(this.botonMinimizar);
            this.panelCabeza.Controls.Add(this.botonMaximizar);
            this.panelCabeza.Controls.Add(this.botonCerrar);
            this.panelCabeza.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabeza.Location = new System.Drawing.Point(0, 0);
            this.panelCabeza.Name = "panelCabeza";
            this.panelCabeza.Size = new System.Drawing.Size(1226, 35);
            this.panelCabeza.TabIndex = 0;
            this.panelCabeza.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCabeza_MouseDown);
            // 
            // botonRestaurar
            // 
            this.botonRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("botonRestaurar.Image")));
            this.botonRestaurar.Location = new System.Drawing.Point(1167, 3);
            this.botonRestaurar.Name = "botonRestaurar";
            this.botonRestaurar.Size = new System.Drawing.Size(25, 25);
            this.botonRestaurar.TabIndex = 0;
            this.botonRestaurar.TabStop = false;
            this.botonRestaurar.Visible = false;
            this.botonRestaurar.Click += new System.EventHandler(this.botonRestaurar_Click);
            // 
            // botonMinimizar
            // 
            this.botonMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("botonMinimizar.Image")));
            this.botonMinimizar.Location = new System.Drawing.Point(1136, 4);
            this.botonMinimizar.Name = "botonMinimizar";
            this.botonMinimizar.Size = new System.Drawing.Size(25, 25);
            this.botonMinimizar.TabIndex = 0;
            this.botonMinimizar.TabStop = false;
            this.botonMinimizar.Click += new System.EventHandler(this.botonMinimizar_Click);
            // 
            // botonMaximizar
            // 
            this.botonMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("botonMaximizar.Image")));
            this.botonMaximizar.Location = new System.Drawing.Point(1167, 4);
            this.botonMaximizar.Name = "botonMaximizar";
            this.botonMaximizar.Size = new System.Drawing.Size(25, 25);
            this.botonMaximizar.TabIndex = 0;
            this.botonMaximizar.TabStop = false;
            this.botonMaximizar.Click += new System.EventHandler(this.botonMaximizar_Click);
            // 
            // botonCerrar
            // 
            this.botonCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonCerrar.Image = ((System.Drawing.Image)(resources.GetObject("botonCerrar.Image")));
            this.botonCerrar.Location = new System.Drawing.Point(1198, 4);
            this.botonCerrar.Name = "botonCerrar";
            this.botonCerrar.Size = new System.Drawing.Size(25, 25);
            this.botonCerrar.TabIndex = 0;
            this.botonCerrar.TabStop = false;
            this.botonCerrar.Click += new System.EventHandler(this.botonCerrar_Click);
            // 
            // VentanaMenu
            // 
            this.VentanaMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(164)))));
            this.VentanaMenu.Controls.Add(this.subMenuDieta);
            this.VentanaMenu.Controls.Add(this.botonAsignarDieta);
            this.VentanaMenu.Controls.Add(this.SubMenuConsultar);
            this.VentanaMenu.Controls.Add(this.botonConsultar);
            this.VentanaMenu.Controls.Add(this.SubMenuAlimentos);
            this.VentanaMenu.Controls.Add(this.botonAlimentos);
            this.VentanaMenu.Controls.Add(this.PanelLogo);
            this.VentanaMenu.Controls.Add(this.labelCerrarSession);
            this.VentanaMenu.Controls.Add(this.pictureBoxCerrarSession);
            this.VentanaMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.VentanaMenu.Location = new System.Drawing.Point(0, 35);
            this.VentanaMenu.Name = "VentanaMenu";
            this.VentanaMenu.Size = new System.Drawing.Size(200, 679);
            this.VentanaMenu.TabIndex = 1;
            // 
            // subMenuDieta
            // 
            this.subMenuDieta.Controls.Add(this.botonRecomendacionNutricional);
            this.subMenuDieta.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuDieta.Location = new System.Drawing.Point(0, 372);
            this.subMenuDieta.Name = "subMenuDieta";
            this.subMenuDieta.Size = new System.Drawing.Size(200, 38);
            this.subMenuDieta.TabIndex = 15;
            // 
            // botonRecomendacionNutricional
            // 
            this.botonRecomendacionNutricional.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(164)))));
            this.botonRecomendacionNutricional.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonRecomendacionNutricional.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonRecomendacionNutricional.FlatAppearance.BorderSize = 0;
            this.botonRecomendacionNutricional.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(133)))));
            this.botonRecomendacionNutricional.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRecomendacionNutricional.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRecomendacionNutricional.ForeColor = System.Drawing.Color.White;
            this.botonRecomendacionNutricional.Location = new System.Drawing.Point(0, 0);
            this.botonRecomendacionNutricional.Name = "botonRecomendacionNutricional";
            this.botonRecomendacionNutricional.Size = new System.Drawing.Size(200, 35);
            this.botonRecomendacionNutricional.TabIndex = 0;
            this.botonRecomendacionNutricional.Text = "Recomendacion Nutricional";
            this.botonRecomendacionNutricional.UseVisualStyleBackColor = false;
            this.botonRecomendacionNutricional.Click += new System.EventHandler(this.botonRecomendacionNutricional_Click);
            // 
            // botonAsignarDieta
            // 
            this.botonAsignarDieta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonAsignarDieta.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonAsignarDieta.FlatAppearance.BorderSize = 0;
            this.botonAsignarDieta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(133)))));
            this.botonAsignarDieta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonAsignarDieta.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAsignarDieta.ForeColor = System.Drawing.Color.White;
            this.botonAsignarDieta.Location = new System.Drawing.Point(0, 332);
            this.botonAsignarDieta.Name = "botonAsignarDieta";
            this.botonAsignarDieta.Size = new System.Drawing.Size(200, 40);
            this.botonAsignarDieta.TabIndex = 14;
            this.botonAsignarDieta.Text = "Dieta";
            this.botonAsignarDieta.UseVisualStyleBackColor = true;
            this.botonAsignarDieta.Click += new System.EventHandler(this.botonAsignarDieta_Click);
            // 
            // SubMenuConsultar
            // 
            this.SubMenuConsultar.Controls.Add(this.subBotonConsultarTasaMetabolicaBasal);
            this.SubMenuConsultar.Controls.Add(this.subBotonConsultarDatosPacientes);
            this.SubMenuConsultar.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubMenuConsultar.Location = new System.Drawing.Point(0, 252);
            this.SubMenuConsultar.Name = "SubMenuConsultar";
            this.SubMenuConsultar.Size = new System.Drawing.Size(200, 80);
            this.SubMenuConsultar.TabIndex = 13;
            // 
            // subBotonConsultarTasaMetabolicaBasal
            // 
            this.subBotonConsultarTasaMetabolicaBasal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subBotonConsultarTasaMetabolicaBasal.Dock = System.Windows.Forms.DockStyle.Top;
            this.subBotonConsultarTasaMetabolicaBasal.FlatAppearance.BorderSize = 0;
            this.subBotonConsultarTasaMetabolicaBasal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(133)))));
            this.subBotonConsultarTasaMetabolicaBasal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subBotonConsultarTasaMetabolicaBasal.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subBotonConsultarTasaMetabolicaBasal.ForeColor = System.Drawing.Color.White;
            this.subBotonConsultarTasaMetabolicaBasal.Location = new System.Drawing.Point(0, 35);
            this.subBotonConsultarTasaMetabolicaBasal.Name = "subBotonConsultarTasaMetabolicaBasal";
            this.subBotonConsultarTasaMetabolicaBasal.Size = new System.Drawing.Size(200, 35);
            this.subBotonConsultarTasaMetabolicaBasal.TabIndex = 1;
            this.subBotonConsultarTasaMetabolicaBasal.Text = "Tasa Metabolistica Basal";
            this.subBotonConsultarTasaMetabolicaBasal.UseVisualStyleBackColor = true;
            this.subBotonConsultarTasaMetabolicaBasal.Click += new System.EventHandler(this.subBotonConsultarTasaMetabolicaBasal_Click);
            // 
            // subBotonConsultarDatosPacientes
            // 
            this.subBotonConsultarDatosPacientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subBotonConsultarDatosPacientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.subBotonConsultarDatosPacientes.FlatAppearance.BorderSize = 0;
            this.subBotonConsultarDatosPacientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(133)))));
            this.subBotonConsultarDatosPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subBotonConsultarDatosPacientes.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subBotonConsultarDatosPacientes.ForeColor = System.Drawing.Color.White;
            this.subBotonConsultarDatosPacientes.Location = new System.Drawing.Point(0, 0);
            this.subBotonConsultarDatosPacientes.Name = "subBotonConsultarDatosPacientes";
            this.subBotonConsultarDatosPacientes.Size = new System.Drawing.Size(200, 35);
            this.subBotonConsultarDatosPacientes.TabIndex = 0;
            this.subBotonConsultarDatosPacientes.Text = "Datos Personales Pacientes";
            this.subBotonConsultarDatosPacientes.UseVisualStyleBackColor = true;
            this.subBotonConsultarDatosPacientes.Click += new System.EventHandler(this.subBotonConsultarDatosPacientes_Click);
            // 
            // botonConsultar
            // 
            this.botonConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonConsultar.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonConsultar.FlatAppearance.BorderSize = 0;
            this.botonConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(133)))));
            this.botonConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonConsultar.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonConsultar.ForeColor = System.Drawing.Color.White;
            this.botonConsultar.Location = new System.Drawing.Point(0, 212);
            this.botonConsultar.Name = "botonConsultar";
            this.botonConsultar.Size = new System.Drawing.Size(200, 40);
            this.botonConsultar.TabIndex = 12;
            this.botonConsultar.Text = "Consultar";
            this.botonConsultar.UseVisualStyleBackColor = true;
            this.botonConsultar.Click += new System.EventHandler(this.botonConsultar_Click);
            // 
            // SubMenuAlimentos
            // 
            this.SubMenuAlimentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(164)))));
            this.SubMenuAlimentos.Controls.Add(this.subBotonRegistarDietas);
            this.SubMenuAlimentos.Controls.Add(this.subBotonRegistarAlimentos);
            this.SubMenuAlimentos.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubMenuAlimentos.Location = new System.Drawing.Point(0, 140);
            this.SubMenuAlimentos.Name = "SubMenuAlimentos";
            this.SubMenuAlimentos.Size = new System.Drawing.Size(200, 72);
            this.SubMenuAlimentos.TabIndex = 11;
            // 
            // subBotonRegistarDietas
            // 
            this.subBotonRegistarDietas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subBotonRegistarDietas.Dock = System.Windows.Forms.DockStyle.Top;
            this.subBotonRegistarDietas.FlatAppearance.BorderSize = 0;
            this.subBotonRegistarDietas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(133)))));
            this.subBotonRegistarDietas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subBotonRegistarDietas.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subBotonRegistarDietas.ForeColor = System.Drawing.Color.White;
            this.subBotonRegistarDietas.Location = new System.Drawing.Point(0, 35);
            this.subBotonRegistarDietas.Name = "subBotonRegistarDietas";
            this.subBotonRegistarDietas.Size = new System.Drawing.Size(200, 35);
            this.subBotonRegistarDietas.TabIndex = 1;
            this.subBotonRegistarDietas.Text = "Registar Plantillas";
            this.subBotonRegistarDietas.UseVisualStyleBackColor = true;
            this.subBotonRegistarDietas.Click += new System.EventHandler(this.subBotonRegistarDietas_Click);
            // 
            // subBotonRegistarAlimentos
            // 
            this.subBotonRegistarAlimentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subBotonRegistarAlimentos.Dock = System.Windows.Forms.DockStyle.Top;
            this.subBotonRegistarAlimentos.FlatAppearance.BorderSize = 0;
            this.subBotonRegistarAlimentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(133)))));
            this.subBotonRegistarAlimentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subBotonRegistarAlimentos.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subBotonRegistarAlimentos.ForeColor = System.Drawing.Color.White;
            this.subBotonRegistarAlimentos.Location = new System.Drawing.Point(0, 0);
            this.subBotonRegistarAlimentos.Name = "subBotonRegistarAlimentos";
            this.subBotonRegistarAlimentos.Size = new System.Drawing.Size(200, 35);
            this.subBotonRegistarAlimentos.TabIndex = 0;
            this.subBotonRegistarAlimentos.Text = "Registar Ingredientes";
            this.subBotonRegistarAlimentos.UseVisualStyleBackColor = true;
            this.subBotonRegistarAlimentos.Click += new System.EventHandler(this.subBotonRegistarAlimentos_Click);
            // 
            // botonAlimentos
            // 
            this.botonAlimentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonAlimentos.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonAlimentos.FlatAppearance.BorderSize = 0;
            this.botonAlimentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(133)))));
            this.botonAlimentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonAlimentos.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAlimentos.ForeColor = System.Drawing.Color.White;
            this.botonAlimentos.Location = new System.Drawing.Point(0, 100);
            this.botonAlimentos.Name = "botonAlimentos";
            this.botonAlimentos.Size = new System.Drawing.Size(200, 40);
            this.botonAlimentos.TabIndex = 10;
            this.botonAlimentos.Text = "Alimentos";
            this.botonAlimentos.UseVisualStyleBackColor = true;
            this.botonAlimentos.Click += new System.EventHandler(this.botonAlimentos_Click);
            // 
            // PanelLogo
            // 
            this.PanelLogo.Controls.Add(this.LogoHome);
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(200, 100);
            this.PanelLogo.TabIndex = 8;
            // 
            // LogoHome
            // 
            this.LogoHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogoHome.Image = global::Presentacion.Properties.Resources.Logo_NutriSoft;
            this.LogoHome.Location = new System.Drawing.Point(0, 0);
            this.LogoHome.Name = "LogoHome";
            this.LogoHome.Size = new System.Drawing.Size(200, 100);
            this.LogoHome.TabIndex = 1;
            this.LogoHome.TabStop = false;
            this.LogoHome.Click += new System.EventHandler(this.LogoHome_Click);
            // 
            // labelCerrarSession
            // 
            this.labelCerrarSession.AutoSize = true;
            this.labelCerrarSession.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCerrarSession.ForeColor = System.Drawing.Color.White;
            this.labelCerrarSession.Location = new System.Drawing.Point(3, 648);
            this.labelCerrarSession.Name = "labelCerrarSession";
            this.labelCerrarSession.Size = new System.Drawing.Size(73, 22);
            this.labelCerrarSession.TabIndex = 18;
            this.labelCerrarSession.Text = "Logoup";
            this.labelCerrarSession.Click += new System.EventHandler(this.labelCerrarSession_Click);
            // 
            // pictureBoxCerrarSession
            // 
            this.pictureBoxCerrarSession.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxCerrarSession.Image = global::Presentacion.Properties.Resources.cerrar_sesion;
            this.pictureBoxCerrarSession.Location = new System.Drawing.Point(3, 642);
            this.pictureBoxCerrarSession.Name = "pictureBoxCerrarSession";
            this.pictureBoxCerrarSession.Size = new System.Drawing.Size(345, 34);
            this.pictureBoxCerrarSession.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCerrarSession.TabIndex = 17;
            this.pictureBoxCerrarSession.TabStop = false;
            this.pictureBoxCerrarSession.Click += new System.EventHandler(this.pictureBoxCerrarSession_Click);
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(200, 35);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(1026, 679);
            this.PanelContenedor.TabIndex = 2;
            // 
            // PresentacionPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 714);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.VentanaMenu);
            this.Controls.Add(this.panelCabeza);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PresentacionPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PresentacionPrincipal";
            this.panelCabeza.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.botonRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonCerrar)).EndInit();
            this.VentanaMenu.ResumeLayout(false);
            this.VentanaMenu.PerformLayout();
            this.subMenuDieta.ResumeLayout(false);
            this.SubMenuConsultar.ResumeLayout(false);
            this.SubMenuAlimentos.ResumeLayout(false);
            this.PanelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrarSession)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCabeza;
        private System.Windows.Forms.PictureBox botonRestaurar;
        private System.Windows.Forms.PictureBox botonMinimizar;
        private System.Windows.Forms.PictureBox botonMaximizar;
        private System.Windows.Forms.PictureBox botonCerrar;
        private System.Windows.Forms.Panel VentanaMenu;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.PictureBox LogoHome;
        private System.Windows.Forms.Panel SubMenuConsultar;
        private System.Windows.Forms.Button subBotonConsultarTasaMetabolicaBasal;
        private System.Windows.Forms.Button subBotonConsultarDatosPacientes;
        private System.Windows.Forms.Button botonConsultar;
        private System.Windows.Forms.Panel SubMenuAlimentos;
        private System.Windows.Forms.Button subBotonRegistarDietas;
        private System.Windows.Forms.Button subBotonRegistarAlimentos;
        private System.Windows.Forms.Button botonAlimentos;
        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.Panel subMenuDieta;
        private System.Windows.Forms.Button botonRecomendacionNutricional;
        private System.Windows.Forms.Button botonAsignarDieta;
        private System.Windows.Forms.Label labelCerrarSession;
        private System.Windows.Forms.PictureBox pictureBoxCerrarSession;
    }
}