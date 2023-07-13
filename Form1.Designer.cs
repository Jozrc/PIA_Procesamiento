namespace PIA_Procesamiento
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.imagenOriginal = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.imagenCargada = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.stopButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.playVideo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboFiltrosVideo = new System.Windows.Forms.ComboBox();
            this.botonCargarImagen = new System.Windows.Forms.Button();
            this.botonDescargar = new System.Windows.Forms.Button();
            this.comboFiltro = new System.Windows.Forms.ComboBox();
            this.aceptarFiltro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.camaraVideo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkVideo = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenOriginal)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenCargada)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.RoyalBlue;
            this.groupBox3.Controls.Add(this.imagenOriginal);
            this.groupBox3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(206, 49);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(375, 299);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Imagen original";
            // 
            // imagenOriginal
            // 
            this.imagenOriginal.BackColor = System.Drawing.Color.GhostWhite;
            this.imagenOriginal.Location = new System.Drawing.Point(4, 17);
            this.imagenOriginal.Margin = new System.Windows.Forms.Padding(2);
            this.imagenOriginal.Name = "imagenOriginal";
            this.imagenOriginal.Size = new System.Drawing.Size(357, 276);
            this.imagenOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagenOriginal.TabIndex = 0;
            this.imagenOriginal.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.RoyalBlue;
            this.groupBox4.Controls.Add(this.imagenCargada);
            this.groupBox4.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox4.Location = new System.Drawing.Point(628, 49);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(379, 297);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Imagen con filtro";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // imagenCargada
            // 
            this.imagenCargada.BackColor = System.Drawing.Color.GhostWhite;
            this.imagenCargada.Location = new System.Drawing.Point(4, 17);
            this.imagenCargada.Margin = new System.Windows.Forms.Padding(2);
            this.imagenCargada.Name = "imagenCargada";
            this.imagenCargada.Size = new System.Drawing.Size(360, 276);
            this.imagenCargada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagenCargada.TabIndex = 7;
            this.imagenCargada.TabStop = false;
            this.imagenCargada.Click += new System.EventHandler(this.imagenCargada_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(152, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 36);
            this.panel1.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Vineta BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(399, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 26);
            this.label5.TabIndex = 22;
            this.label5.Text = "Filtros";
            this.label5.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(774, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(815, 4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(861, 4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(25, 25);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 3;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // stopButton
            // 
            this.stopButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stopButton.BackgroundImage")));
            this.stopButton.Location = new System.Drawing.Point(300, 18);
            this.stopButton.Margin = new System.Windows.Forms.Padding(2);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(52, 53);
            this.stopButton.TabIndex = 16;
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pauseButton.BackgroundImage")));
            this.pauseButton.Location = new System.Drawing.Point(527, 18);
            this.pauseButton.Margin = new System.Windows.Forms.Padding(2);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(55, 54);
            this.pauseButton.TabIndex = 15;
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // playVideo
            // 
            this.playVideo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playVideo.BackgroundImage")));
            this.playVideo.Cursor = System.Windows.Forms.Cursors.Default;
            this.playVideo.Location = new System.Drawing.Point(424, 17);
            this.playVideo.Margin = new System.Windows.Forms.Padding(2);
            this.playVideo.Name = "playVideo";
            this.playVideo.Size = new System.Drawing.Size(48, 54);
            this.playVideo.TabIndex = 14;
            this.playVideo.UseVisualStyleBackColor = true;
            this.playVideo.Click += new System.EventHandler(this.playVideo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(382, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Filtro para video";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.playVideo);
            this.groupBox2.Controls.Add(this.comboFiltrosVideo);
            this.groupBox2.Controls.Add(this.pauseButton);
            this.groupBox2.Controls.Add(this.stopButton);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(152, 405);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(895, 149);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // comboFiltrosVideo
            // 
            this.comboFiltrosVideo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboFiltrosVideo.FormattingEnabled = true;
            this.comboFiltrosVideo.Items.AddRange(new object[] {
            "Tonos de gris",
            "Negativo",
            "RGB a BGR",
            "Sepia",
            "Blanco y Negro",
            "Polaroid"});
            this.comboFiltrosVideo.Location = new System.Drawing.Point(380, 117);
            this.comboFiltrosVideo.Margin = new System.Windows.Forms.Padding(2);
            this.comboFiltrosVideo.Name = "comboFiltrosVideo";
            this.comboFiltrosVideo.Size = new System.Drawing.Size(144, 21);
            this.comboFiltrosVideo.TabIndex = 17;
            this.comboFiltrosVideo.SelectedIndexChanged += new System.EventHandler(this.comboFiltrosVideo_SelectedIndexChanged);
            // 
            // botonCargarImagen
            // 
            this.botonCargarImagen.BackColor = System.Drawing.Color.Red;
            this.botonCargarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botonCargarImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCargarImagen.ForeColor = System.Drawing.SystemColors.Control;
            this.botonCargarImagen.Location = new System.Drawing.Point(22, 102);
            this.botonCargarImagen.Margin = new System.Windows.Forms.Padding(2);
            this.botonCargarImagen.Name = "botonCargarImagen";
            this.botonCargarImagen.Size = new System.Drawing.Size(105, 45);
            this.botonCargarImagen.TabIndex = 0;
            this.botonCargarImagen.Text = "Cargar archivo";
            this.botonCargarImagen.UseVisualStyleBackColor = false;
            this.botonCargarImagen.Click += new System.EventHandler(this.botonCargarImagen_Click);
            // 
            // botonDescargar
            // 
            this.botonDescargar.BackColor = System.Drawing.Color.MidnightBlue;
            this.botonDescargar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botonDescargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDescargar.ForeColor = System.Drawing.SystemColors.Control;
            this.botonDescargar.Location = new System.Drawing.Point(22, 405);
            this.botonDescargar.Margin = new System.Windows.Forms.Padding(2);
            this.botonDescargar.Name = "botonDescargar";
            this.botonDescargar.Size = new System.Drawing.Size(105, 54);
            this.botonDescargar.TabIndex = 1;
            this.botonDescargar.Text = "Descargar imagen";
            this.botonDescargar.UseVisualStyleBackColor = false;
            this.botonDescargar.Click += new System.EventHandler(this.boton_descargar_Click);
            // 
            // comboFiltro
            // 
            this.comboFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboFiltro.FormattingEnabled = true;
            this.comboFiltro.Items.AddRange(new object[] {
            "Frio",
            "Pixeleado",
            "Deteccion de bordes",
            "Efecto de viñeta",
            "Gamma",
            "Calido"});
            this.comboFiltro.Location = new System.Drawing.Point(4, 221);
            this.comboFiltro.Margin = new System.Windows.Forms.Padding(2);
            this.comboFiltro.Name = "comboFiltro";
            this.comboFiltro.Size = new System.Drawing.Size(144, 21);
            this.comboFiltro.TabIndex = 2;
            this.comboFiltro.SelectedIndexChanged += new System.EventHandler(this.comboFiltro_SelectedIndexChanged);
            // 
            // aceptarFiltro
            // 
            this.aceptarFiltro.BackColor = System.Drawing.Color.LimeGreen;
            this.aceptarFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.aceptarFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aceptarFiltro.ForeColor = System.Drawing.SystemColors.Control;
            this.aceptarFiltro.Location = new System.Drawing.Point(22, 260);
            this.aceptarFiltro.Margin = new System.Windows.Forms.Padding(2);
            this.aceptarFiltro.Name = "aceptarFiltro";
            this.aceptarFiltro.Size = new System.Drawing.Size(105, 38);
            this.aceptarFiltro.TabIndex = 5;
            this.aceptarFiltro.Text = "Aceptar";
            this.aceptarFiltro.UseVisualStyleBackColor = false;
            this.aceptarFiltro.Click += new System.EventHandler(this.aceptarFiltro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(10, 194);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Filtro de imagen";
            // 
            // camaraVideo
            // 
            this.camaraVideo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.camaraVideo.FormattingEnabled = true;
            this.camaraVideo.Location = new System.Drawing.Point(3, 342);
            this.camaraVideo.Margin = new System.Windows.Forms.Padding(2);
            this.camaraVideo.Name = "camaraVideo";
            this.camaraVideo.Size = new System.Drawing.Size(145, 21);
            this.camaraVideo.TabIndex = 11;
         //   this.camaraVideo.SelectedIndexChanged += new System.EventHandler(this.camaraVideo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(4, 309);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Encender camara";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(22, 49);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 43);
            this.button1.TabIndex = 21;
            this.button1.Text = "Deteccion de caras";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkVideo
            // 
            this.checkVideo.AutoSize = true;
            this.checkVideo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkVideo.ForeColor = System.Drawing.SystemColors.Control;
            this.checkVideo.Location = new System.Drawing.Point(36, 155);
            this.checkVideo.Margin = new System.Windows.Forms.Padding(2);
            this.checkVideo.Name = "checkVideo";
            this.checkVideo.Size = new System.Drawing.Size(72, 24);
            this.checkVideo.TabIndex = 13;
            this.checkVideo.Text = "Video";
            this.checkVideo.UseVisualStyleBackColor = true;
            this.checkVideo.CheckedChanged += new System.EventHandler(this.checkVideo_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Vineta BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(28, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 26);
            this.label4.TabIndex = 22;
            this.label4.Text = "Menu";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.Color.RoyalBlue;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.checkVideo);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.camaraVideo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.aceptarFiltro);
            this.groupBox1.Controls.Add(this.comboFiltro);
            this.groupBox1.Controls.Add(this.botonDescargar);
            this.groupBox1.Controls.Add(this.botonCargarImagen);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(152, 554);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1047, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "ImageProcessor.NET";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagenOriginal)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagenCargada)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox imagenOriginal;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox imagenCargada;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button playVideo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboFiltrosVideo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button botonCargarImagen;
        private System.Windows.Forms.Button botonDescargar;
        private System.Windows.Forms.ComboBox comboFiltro;
        private System.Windows.Forms.Button aceptarFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkVideo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox camaraVideo;
    }
}

