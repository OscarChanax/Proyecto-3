﻿namespace Proyecto_3
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.estadoPanel = new System.Windows.Forms.Panel();
            this.buttonConectar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPuerto = new System.Windows.Forms.ComboBox();
            this.buttonDesconectar = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.trackBarHorizontal = new System.Windows.Forms.TrackBar();
            this.labelValorhorizontal = new System.Windows.Forms.Label();
            this.labelValorvertical = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.trackBarVertical = new System.Windows.Forms.TrackBar();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHorizontal)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVertical)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.estadoPanel);
            this.panelMenu.Controls.Add(this.buttonConectar);
            this.panelMenu.Controls.Add(this.label2);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.comboBoxPuerto);
            this.panelMenu.Controls.Add(this.buttonDesconectar);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 450);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // estadoPanel
            // 
            this.estadoPanel.Location = new System.Drawing.Point(159, 412);
            this.estadoPanel.Name = "estadoPanel";
            this.estadoPanel.Size = new System.Drawing.Size(20, 20);
            this.estadoPanel.TabIndex = 1;
            // 
            // buttonConectar
            // 
            this.buttonConectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(119)))), ((int)(((byte)(0)))));
            this.buttonConectar.FlatAppearance.BorderSize = 0;
            this.buttonConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConectar.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConectar.ForeColor = System.Drawing.Color.White;
            this.buttonConectar.Location = new System.Drawing.Point(34, 227);
            this.buttonConectar.Name = "buttonConectar";
            this.buttonConectar.Size = new System.Drawing.Size(159, 47);
            this.buttonConectar.TabIndex = 4;
            this.buttonConectar.Text = "Conectar";
            this.buttonConectar.UseVisualStyleBackColor = false;
            this.buttonConectar.BackColorChanged += new System.EventHandler(this.buttonConectar_BackColorChanged);
            this.buttonConectar.Click += new System.EventHandler(this.buttonConectar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Upbolters New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(37, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Estado de la conexión:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Upbolters New", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Puerto de comunicación";
            // 
            // comboBoxPuerto
            // 
            this.comboBoxPuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPuerto.FormattingEnabled = true;
            this.comboBoxPuerto.Location = new System.Drawing.Point(53, 184);
            this.comboBoxPuerto.Name = "comboBoxPuerto";
            this.comboBoxPuerto.Size = new System.Drawing.Size(125, 24);
            this.comboBoxPuerto.TabIndex = 2;
            this.comboBoxPuerto.SelectedIndexChanged += new System.EventHandler(this.comboBoxPuerto_SelectedIndexChanged);
            // 
            // buttonDesconectar
            // 
            this.buttonDesconectar.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonDesconectar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonDesconectar.FlatAppearance.BorderSize = 0;
            this.buttonDesconectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDesconectar.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDesconectar.ForeColor = System.Drawing.Color.White;
            this.buttonDesconectar.Location = new System.Drawing.Point(34, 296);
            this.buttonDesconectar.Name = "buttonDesconectar";
            this.buttonDesconectar.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.buttonDesconectar.Size = new System.Drawing.Size(159, 47);
            this.buttonDesconectar.TabIndex = 1;
            this.buttonDesconectar.Text = "Desconectar";
            this.buttonDesconectar.UseVisualStyleBackColor = false;
            this.buttonDesconectar.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitulo.Controls.Add(this.labelTitulo);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(220, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(580, 70);
            this.panelTitulo.TabIndex = 1;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Upbolters New", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.White;
            this.labelTitulo.Location = new System.Drawing.Point(173, 16);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(263, 41);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "PANEL DE CONTROL";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(220, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 10);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(138, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Prender";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(276, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 49);
            this.button2.TabIndex = 1;
            this.button2.Text = "Apagar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // trackBarHorizontal
            // 
            this.trackBarHorizontal.Location = new System.Drawing.Point(25, 296);
            this.trackBarHorizontal.Maximum = 100;
            this.trackBarHorizontal.Name = "trackBarHorizontal";
            this.trackBarHorizontal.Size = new System.Drawing.Size(431, 45);
            this.trackBarHorizontal.TabIndex = 2;
            this.trackBarHorizontal.TickFrequency = 10;
            this.trackBarHorizontal.Scroll += new System.EventHandler(this.trackBarHorizontal_Scroll);
            // 
            // labelValorhorizontal
            // 
            this.labelValorhorizontal.AutoSize = true;
            this.labelValorhorizontal.Font = new System.Drawing.Font("Upbolters New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorhorizontal.ForeColor = System.Drawing.Color.White;
            this.labelValorhorizontal.Location = new System.Drawing.Point(244, 246);
            this.labelValorhorizontal.Name = "labelValorhorizontal";
            this.labelValorhorizontal.Size = new System.Drawing.Size(52, 17);
            this.labelValorhorizontal.TabIndex = 3;
            this.labelValorhorizontal.Text = "Valor: 0";
            this.labelValorhorizontal.Click += new System.EventHandler(this.labelValorhorizontal_Click);
            // 
            // labelValorvertical
            // 
            this.labelValorvertical.AutoSize = true;
            this.labelValorvertical.Font = new System.Drawing.Font("Upbolters New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorvertical.ForeColor = System.Drawing.Color.White;
            this.labelValorvertical.Location = new System.Drawing.Point(419, 147);
            this.labelValorvertical.Name = "labelValorvertical";
            this.labelValorvertical.Size = new System.Drawing.Size(55, 19);
            this.labelValorvertical.TabIndex = 4;
            this.labelValorvertical.Text = "Valor: 0";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel2.Controls.Add(this.labelValorvertical);
            this.panel2.Controls.Add(this.trackBarVertical);
            this.panel2.Controls.Add(this.labelValorhorizontal);
            this.panel2.Controls.Add(this.trackBarHorizontal);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(220, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(580, 370);
            this.panel2.TabIndex = 3;
            // 
            // trackBarVertical
            // 
            this.trackBarVertical.Location = new System.Drawing.Point(494, 18);
            this.trackBarVertical.Maximum = 100;
            this.trackBarVertical.Name = "trackBarVertical";
            this.trackBarVertical.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarVertical.Size = new System.Drawing.Size(45, 313);
            this.trackBarVertical.TabIndex = 2;
            this.trackBarVertical.TickFrequency = 10;
            this.trackBarVertical.Scroll += new System.EventHandler(this.trackBarVertical_Scroll);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.ShowIcon = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Principal_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHorizontal)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVertical)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button buttonDesconectar;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxPuerto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonConectar;
        private System.Windows.Forms.Panel estadoPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TrackBar trackBarHorizontal;
        private System.Windows.Forms.Label labelValorhorizontal;
        private System.Windows.Forms.Label labelValorvertical;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TrackBar trackBarVertical;
    }
}

