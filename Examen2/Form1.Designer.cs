namespace Examen2
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
            this.rdbFahrenheit = new System.Windows.Forms.RadioButton();
            this.rdbCelsius = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGrado1 = new System.Windows.Forms.Label();
            this.lblgrado2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbFahrenheit
            // 
            this.rdbFahrenheit.AutoSize = true;
            this.rdbFahrenheit.Checked = true;
            this.rdbFahrenheit.Location = new System.Drawing.Point(116, 38);
            this.rdbFahrenheit.Name = "rdbFahrenheit";
            this.rdbFahrenheit.Size = new System.Drawing.Size(97, 21);
            this.rdbFahrenheit.TabIndex = 0;
            this.rdbFahrenheit.TabStop = true;
            this.rdbFahrenheit.Text = "Fahrenheit";
            this.rdbFahrenheit.UseVisualStyleBackColor = true;
            this.rdbFahrenheit.CheckedChanged += new System.EventHandler(this.rdbFahrenheit_CheckedChanged);
            // 
            // rdbCelsius
            // 
            this.rdbCelsius.AutoSize = true;
            this.rdbCelsius.Location = new System.Drawing.Point(20, 38);
            this.rdbCelsius.Name = "rdbCelsius";
            this.rdbCelsius.Size = new System.Drawing.Size(74, 21);
            this.rdbCelsius.TabIndex = 1;
            this.rdbCelsius.Text = "Celsius";
            this.rdbCelsius.UseVisualStyleBackColor = true;
            this.rdbCelsius.CheckedChanged += new System.EventHandler(this.rdbCelsius_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(97, 141);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Grados";
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(43, 186);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(92, 35);
            this.btnConvertir.TabIndex = 4;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbFahrenheit);
            this.groupBox1.Controls.Add(this.rdbCelsius);
            this.groupBox1.Location = new System.Drawing.Point(23, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 83);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Convertir a";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(242, 143);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 22);
            this.txtResultado.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "=";
            // 
            // lblGrado1
            // 
            this.lblGrado1.AutoSize = true;
            this.lblGrado1.Location = new System.Drawing.Point(94, 121);
            this.lblGrado1.Name = "lblGrado1";
            this.lblGrado1.Size = new System.Drawing.Size(0, 17);
            this.lblGrado1.TabIndex = 8;
            // 
            // lblgrado2
            // 
            this.lblgrado2.AutoSize = true;
            this.lblgrado2.Location = new System.Drawing.Point(239, 121);
            this.lblgrado2.Name = "lblgrado2";
            this.lblgrado2.Size = new System.Drawing.Size(0, 17);
            this.lblgrado2.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblgrado2);
            this.Controls.Add(this.lblGrado1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbFahrenheit;
        private System.Windows.Forms.RadioButton rdbCelsius;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblgrado2;
        private System.Windows.Forms.Label lblGrado1;
    }
}

