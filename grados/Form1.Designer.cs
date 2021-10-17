namespace grados
{
    partial class Form1
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
            this.conectar = new System.Windows.Forms.Button();
            this.desconectar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.enviar = new System.Windows.Forms.Button();
            this.FahCel = new System.Windows.Forms.RadioButton();
            this.CelFah = new System.Windows.Forms.RadioButton();
            this.grados = new System.Windows.Forms.Label();
            this.gradosBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // conectar
            // 
            this.conectar.Location = new System.Drawing.Point(32, 12);
            this.conectar.Name = "conectar";
            this.conectar.Size = new System.Drawing.Size(80, 23);
            this.conectar.TabIndex = 2;
            this.conectar.Text = "Conectar";
            this.conectar.UseVisualStyleBackColor = true;
            this.conectar.Click += new System.EventHandler(this.conectar_Click);
            // 
            // desconectar
            // 
            this.desconectar.Location = new System.Drawing.Point(32, 273);
            this.desconectar.Name = "desconectar";
            this.desconectar.Size = new System.Drawing.Size(80, 23);
            this.desconectar.TabIndex = 5;
            this.desconectar.Text = "Desconectar";
            this.desconectar.UseVisualStyleBackColor = true;
            this.desconectar.Click += new System.EventHandler(this.desconectar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.gradosBox);
            this.groupBox1.Controls.Add(this.enviar);
            this.groupBox1.Controls.Add(this.FahCel);
            this.groupBox1.Controls.Add(this.CelFah);
            this.groupBox1.Controls.Add(this.grados);
            this.groupBox1.Location = new System.Drawing.Point(32, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 186);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Petición";
            // 
            // enviar
            // 
            this.enviar.Location = new System.Drawing.Point(157, 141);
            this.enviar.Name = "enviar";
            this.enviar.Size = new System.Drawing.Size(75, 23);
            this.enviar.TabIndex = 9;
            this.enviar.Text = "Enviar";
            this.enviar.UseVisualStyleBackColor = true;
            this.enviar.Click += new System.EventHandler(this.enviar_Click);
            // 
            // FahCel
            // 
            this.FahCel.AutoSize = true;
            this.FahCel.Location = new System.Drawing.Point(38, 102);
            this.FahCel.Name = "FahCel";
            this.FahCel.Size = new System.Drawing.Size(151, 17);
            this.FahCel.TabIndex = 5;
            this.FahCel.TabStop = true;
            this.FahCel.Text = "Pasar Fahrenheit a Celcius";
            this.FahCel.UseVisualStyleBackColor = true;
            // 
            // CelFah
            // 
            this.CelFah.AutoSize = true;
            this.CelFah.Location = new System.Drawing.Point(38, 70);
            this.CelFah.Name = "CelFah";
            this.CelFah.Size = new System.Drawing.Size(151, 17);
            this.CelFah.TabIndex = 4;
            this.CelFah.TabStop = true;
            this.CelFah.Text = "Pasar Celcius a Fahrenheit";
            this.CelFah.UseVisualStyleBackColor = true;
            // 
            // grados
            // 
            this.grados.AutoSize = true;
            this.grados.Location = new System.Drawing.Point(35, 32);
            this.grados.Name = "grados";
            this.grados.Size = new System.Drawing.Size(82, 13);
            this.grados.TabIndex = 1;
            this.grados.Text = "Grados a pasar:";
            // 
            // gradosBox
            // 
            this.gradosBox.Location = new System.Drawing.Point(123, 29);
            this.gradosBox.Name = "gradosBox";
            this.gradosBox.Size = new System.Drawing.Size(100, 20);
            this.gradosBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 307);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.desconectar);
            this.Controls.Add(this.conectar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button conectar;
        private System.Windows.Forms.Button desconectar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button enviar;
        private System.Windows.Forms.RadioButton FahCel;
        private System.Windows.Forms.RadioButton CelFah;
        private System.Windows.Forms.Label grados;
        private System.Windows.Forms.TextBox gradosBox;
    }
}

