namespace Balon_de_Oro_Argentino_2017
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreJugador = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lstJugadores = new System.Windows.Forms.ListBox();
            this.txtGanador = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Balon de Oro Argentino 2017";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNombreJugador
            // 
            this.txtNombreJugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreJugador.Location = new System.Drawing.Point(356, 179);
            this.txtNombreJugador.Name = "txtNombreJugador";
            this.txtNombreJugador.Size = new System.Drawing.Size(161, 22);
            this.txtNombreJugador.TabIndex = 1;
            this.txtNombreJugador.Text = "Nombre del Jugador";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(367, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "Votar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button2.Location = new System.Drawing.Point(591, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 47);
            this.button2.TabIndex = 3;
            this.button2.Text = "MostrarGanador";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lstJugadores
            // 
            this.lstJugadores.AccessibleName = "da";
            this.lstJugadores.FormattingEnabled = true;
            this.lstJugadores.Items.AddRange(new object[] {
            "LISTA DE JUGADORES NOMINADOS:           ",
            "                                                                                 " +
                "                                   ",
            "Darío Benedetto (Boca Juniors)",
            "",
            "Lautaro Martínez (Racing Club)",
            "",
            "Ignacio Scocco (River Plate)",
            "",
            "Fernando Belluschi (San Lorenzo)",
            "",
            "Maximiliano Meza (Independiente)"});
            this.lstJugadores.Location = new System.Drawing.Point(12, 97);
            this.lstJugadores.Name = "lstJugadores";
            this.lstJugadores.Size = new System.Drawing.Size(329, 173);
            this.lstJugadores.TabIndex = 4;
            this.lstJugadores.SelectedIndexChanged += new System.EventHandler(this.lstJugadores_SelectedIndexChanged);
            // 
            // txtGanador
            // 
            this.txtGanador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGanador.ForeColor = System.Drawing.Color.Black;
            this.txtGanador.Location = new System.Drawing.Point(597, 179);
            this.txtGanador.Name = "txtGanador";
            this.txtGanador.Size = new System.Drawing.Size(141, 22);
            this.txtGanador.TabIndex = 6;
            this.txtGanador.Text = "Ganador";
            this.txtGanador.TextChanged += new System.EventHandler(this.txtGanador_TextChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Balon_de_Oro_Argentino_2017.Properties.Resources.DA;
            this.pictureBox4.Location = new System.Drawing.Point(74, -11);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(156, 102);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Balon_de_Oro_Argentino_2017.Properties.Resources.e9268b5216807bc94418d7ebe3487f07a031f5bc;
            this.pictureBox3.Location = new System.Drawing.Point(591, -2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(114, 76);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Balon_de_Oro_Argentino_2017.Properties.Resources.balon_de_oro_2021_1199mc93ccyp21f9h4db74nz8m__1_;
            this.pictureBox2.Location = new System.Drawing.Point(591, 96);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(147, 69);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Balon_de_Oro_Argentino_2017.Properties.Resources._145787589fc1a27;
            this.pictureBox1.Location = new System.Drawing.Point(367, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtGanador);
            this.Controls.Add(this.lstJugadores);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNombreJugador);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreJugador;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox lstJugadores;
        private System.Windows.Forms.TextBox txtGanador;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

