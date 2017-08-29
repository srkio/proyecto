namespace CapaPresentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.nombre = new System.Windows.Forms.TextBox();
            this.ciex = new System.Windows.Forms.TextBox();
            this.apePaterno = new System.Windows.Forms.TextBox();
            this.apeMaterno = new System.Windows.Forms.TextBox();
            this.Genero = new System.Windows.Forms.GroupBox();
            this.femenino = new System.Windows.Forms.RadioButton();
            this.masculino = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listadoAtracador = new System.Windows.Forms.DataGridView();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.listadoDeBandas = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.Genero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoAtracador)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(602, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(602, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(35, 132);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(100, 22);
            this.nombre.TabIndex = 2;
            // 
            // ciex
            // 
            this.ciex.Location = new System.Drawing.Point(35, 68);
            this.ciex.Name = "ciex";
            this.ciex.Size = new System.Drawing.Size(100, 22);
            this.ciex.TabIndex = 3;
            // 
            // apePaterno
            // 
            this.apePaterno.Location = new System.Drawing.Point(192, 68);
            this.apePaterno.Name = "apePaterno";
            this.apePaterno.Size = new System.Drawing.Size(100, 22);
            this.apePaterno.TabIndex = 4;
            // 
            // apeMaterno
            // 
            this.apeMaterno.Location = new System.Drawing.Point(189, 132);
            this.apeMaterno.Name = "apeMaterno";
            this.apeMaterno.Size = new System.Drawing.Size(100, 22);
            this.apeMaterno.TabIndex = 5;
            // 
            // Genero
            // 
            this.Genero.Controls.Add(this.femenino);
            this.Genero.Controls.Add(this.masculino);
            this.Genero.Location = new System.Drawing.Point(407, 48);
            this.Genero.Name = "Genero";
            this.Genero.Size = new System.Drawing.Size(157, 100);
            this.Genero.TabIndex = 6;
            this.Genero.TabStop = false;
            this.Genero.Text = "Genero";
            // 
            // femenino
            // 
            this.femenino.AutoSize = true;
            this.femenino.Location = new System.Drawing.Point(23, 61);
            this.femenino.Name = "femenino";
            this.femenino.Size = new System.Drawing.Size(91, 21);
            this.femenino.TabIndex = 1;
            this.femenino.TabStop = true;
            this.femenino.Text = "Femenino";
            this.femenino.UseVisualStyleBackColor = true;
            // 
            // masculino
            // 
            this.masculino.AutoSize = true;
            this.masculino.Location = new System.Drawing.Point(23, 33);
            this.masculino.Name = "masculino";
            this.masculino.Size = new System.Drawing.Size(92, 21);
            this.masculino.TabIndex = 0;
            this.masculino.TabStop = true;
            this.masculino.Text = "Masculino";
            this.masculino.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "CI Ex";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Apellido Paterno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Apellido Materno";
            // 
            // listadoAtracador
            // 
            this.listadoAtracador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoAtracador.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listadoAtracador.Location = new System.Drawing.Point(0, 318);
            this.listadoAtracador.Name = "listadoAtracador";
            this.listadoAtracador.RowTemplate.Height = 24;
            this.listadoAtracador.Size = new System.Drawing.Size(772, 175);
            this.listadoAtracador.TabIndex = 12;
            // 
            // fecha
            // 
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha.Location = new System.Drawing.Point(35, 197);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(200, 22);
            this.fecha.TabIndex = 13;
            // 
            // listadoDeBandas
            // 
            this.listadoDeBandas.FormattingEnabled = true;
            this.listadoDeBandas.Location = new System.Drawing.Point(349, 197);
            this.listadoDeBandas.Name = "listadoDeBandas";
            this.listadoDeBandas.Size = new System.Drawing.Size(215, 24);
            this.listadoDeBandas.TabIndex = 14;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(602, 186);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 493);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listadoDeBandas);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.listadoAtracador);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Genero);
            this.Controls.Add(this.apeMaterno);
            this.Controls.Add(this.apePaterno);
            this.Controls.Add(this.ciex);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Genero.ResumeLayout(false);
            this.Genero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoAtracador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox ciex;
        private System.Windows.Forms.TextBox apePaterno;
        private System.Windows.Forms.TextBox apeMaterno;
        private System.Windows.Forms.GroupBox Genero;
        private System.Windows.Forms.RadioButton femenino;
        private System.Windows.Forms.RadioButton masculino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView listadoAtracador;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.ComboBox listadoDeBandas;
        private System.Windows.Forms.Button button3;
    }
}

