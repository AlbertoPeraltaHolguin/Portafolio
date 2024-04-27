namespace Juego_V01
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
            this.JUGADOR = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUsar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtDefensa = new System.Windows.Forms.TextBox();
            this.TxtAtaque = new System.Windows.Forms.TextBox();
            this.TxtVida = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHuir = new System.Windows.Forms.Button();
            this.btnAtacar = new System.Windows.Forms.Button();
            this.btnAdentrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.EGrande = new System.Windows.Forms.Button();
            this.EMedio = new System.Windows.Forms.Button();
            this.EChico = new System.Windows.Forms.Button();
            this.JUGADOR.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // JUGADOR
            // 
            this.JUGADOR.BackColor = System.Drawing.Color.DarkGray;
            this.JUGADOR.Controls.Add(this.panel1);
            this.JUGADOR.Controls.Add(this.TxtDefensa);
            this.JUGADOR.Controls.Add(this.TxtAtaque);
            this.JUGADOR.Controls.Add(this.TxtVida);
            this.JUGADOR.Controls.Add(this.button1);
            this.JUGADOR.Controls.Add(this.label3);
            this.JUGADOR.Controls.Add(this.label2);
            this.JUGADOR.Controls.Add(this.label1);
            this.JUGADOR.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JUGADOR.Location = new System.Drawing.Point(14, 17);
            this.JUGADOR.Name = "JUGADOR";
            this.JUGADOR.Size = new System.Drawing.Size(372, 415);
            this.JUGADOR.TabIndex = 0;
            this.JUGADOR.TabStop = false;
            this.JUGADOR.Text = "JUGADOR";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnUsar);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(6, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 209);
            this.panel1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "label5";
            // 
            // btnUsar
            // 
            this.btnUsar.BackColor = System.Drawing.Color.DarkGray;
            this.btnUsar.Location = new System.Drawing.Point(185, 31);
            this.btnUsar.Name = "btnUsar";
            this.btnUsar.Size = new System.Drawing.Size(110, 45);
            this.btnUsar.TabIndex = 11;
            this.btnUsar.Text = "USAR";
            this.btnUsar.UseVisualStyleBackColor = false;
            this.btnUsar.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(7, 31);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(172, 165);
            this.listBox1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "ITEMS:";
            // 
            // TxtDefensa
            // 
            this.TxtDefensa.Enabled = false;
            this.TxtDefensa.Location = new System.Drawing.Point(96, 122);
            this.TxtDefensa.Name = "TxtDefensa";
            this.TxtDefensa.Size = new System.Drawing.Size(140, 30);
            this.TxtDefensa.TabIndex = 6;
            // 
            // TxtAtaque
            // 
            this.TxtAtaque.Enabled = false;
            this.TxtAtaque.Location = new System.Drawing.Point(96, 82);
            this.TxtAtaque.Name = "TxtAtaque";
            this.TxtAtaque.Size = new System.Drawing.Size(140, 30);
            this.TxtAtaque.TabIndex = 5;
            // 
            // TxtVida
            // 
            this.TxtVida.Enabled = false;
            this.TxtVida.Location = new System.Drawing.Point(96, 46);
            this.TxtVida.Name = "TxtVida";
            this.TxtVida.Size = new System.Drawing.Size(140, 30);
            this.TxtVida.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Image = global::Juego_V01.Properties.Resources.caballero__1_;
            this.button1.Location = new System.Drawing.Point(255, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 164);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "DEFENSA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "ATAQUE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "VIDA:";
            // 
            // btnHuir
            // 
            this.btnHuir.BackColor = System.Drawing.Color.DarkGray;
            this.btnHuir.Location = new System.Drawing.Point(392, 17);
            this.btnHuir.Name = "btnHuir";
            this.btnHuir.Size = new System.Drawing.Size(110, 45);
            this.btnHuir.TabIndex = 13;
            this.btnHuir.Text = "HUIR";
            this.btnHuir.UseVisualStyleBackColor = false;
            this.btnHuir.Visible = false;
            this.btnHuir.Click += new System.EventHandler(this.btnHuir_Click);
            // 
            // btnAtacar
            // 
            this.btnAtacar.BackColor = System.Drawing.Color.DarkGray;
            this.btnAtacar.Location = new System.Drawing.Point(508, 17);
            this.btnAtacar.Name = "btnAtacar";
            this.btnAtacar.Size = new System.Drawing.Size(110, 45);
            this.btnAtacar.TabIndex = 14;
            this.btnAtacar.Text = "ATACAR";
            this.btnAtacar.UseVisualStyleBackColor = false;
            this.btnAtacar.Visible = false;
            this.btnAtacar.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnAdentrar
            // 
            this.btnAdentrar.BackColor = System.Drawing.Color.DarkGray;
            this.btnAdentrar.Location = new System.Drawing.Point(624, 17);
            this.btnAdentrar.Name = "btnAdentrar";
            this.btnAdentrar.Size = new System.Drawing.Size(110, 45);
            this.btnAdentrar.TabIndex = 15;
            this.btnAdentrar.Text = "ADENTRAR";
            this.btnAdentrar.UseVisualStyleBackColor = false;
            this.btnAdentrar.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.EGrande);
            this.panel2.Controls.Add(this.EMedio);
            this.panel2.Controls.Add(this.EChico);
            this.panel2.Location = new System.Drawing.Point(398, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(419, 350);
            this.panel2.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = ".";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Esperando....";
            // 
            // EGrande
            // 
            this.EGrande.Image = global::Juego_V01.Properties.Resources.golem;
            this.EGrande.Location = new System.Drawing.Point(289, 173);
            this.EGrande.Name = "EGrande";
            this.EGrande.Size = new System.Drawing.Size(111, 164);
            this.EGrande.TabIndex = 11;
            this.EGrande.UseVisualStyleBackColor = true;
            this.EGrande.Visible = false;
            // 
            // EMedio
            // 
            this.EMedio.Image = global::Juego_V01.Properties.Resources.esqueleto;
            this.EMedio.Location = new System.Drawing.Point(155, 173);
            this.EMedio.Name = "EMedio";
            this.EMedio.Size = new System.Drawing.Size(111, 164);
            this.EMedio.TabIndex = 10;
            this.EMedio.UseVisualStyleBackColor = true;
            this.EMedio.Visible = false;
            // 
            // EChico
            // 
            this.EChico.Image = global::Juego_V01.Properties.Resources.slime;
            this.EChico.Location = new System.Drawing.Point(14, 173);
            this.EChico.Name = "EChico";
            this.EChico.Size = new System.Drawing.Size(111, 164);
            this.EChico.TabIndex = 9;
            this.EChico.UseVisualStyleBackColor = true;
            this.EChico.Visible = false;
            this.EChico.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(835, 467);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnAdentrar);
            this.Controls.Add(this.btnAtacar);
            this.Controls.Add(this.btnHuir);
            this.Controls.Add(this.JUGADOR);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.JUGADOR.ResumeLayout(false);
            this.JUGADOR.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox JUGADOR;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUsar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtDefensa;
        private System.Windows.Forms.TextBox TxtAtaque;
        private System.Windows.Forms.TextBox TxtVida;
        private System.Windows.Forms.Button btnHuir;
        private System.Windows.Forms.Button btnAtacar;
        private System.Windows.Forms.Button btnAdentrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button EChico;
        private System.Windows.Forms.Button EGrande;
        private System.Windows.Forms.Button EMedio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

