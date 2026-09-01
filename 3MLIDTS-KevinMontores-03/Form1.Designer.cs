
namespace _3MLIDTS_KevinMontores_03
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
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lbl_celsius = new System.Windows.Forms.Label();
            this.gb_temperaturas = new System.Windows.Forms.GroupBox();
            this.rbKelvin = new System.Windows.Forms.RadioButton();
            this.rbFahrenheit = new System.Windows.Forms.RadioButton();
            this.rbCelsius = new System.Windows.Forms.RadioButton();
            this.lbl_fahrenheit = new System.Windows.Forms.Label();
            this.lbl_kelvin = new System.Windows.Forms.Label();
            this.tbxFahrenheit = new System.Windows.Forms.TextBox();
            this.tbxCelsius = new System.Windows.Forms.TextBox();
            this.tbxKelvin = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.gb_temperaturas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(459, 367);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(111, 53);
            this.btnLimpiar.TabIndex = 0;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lbl_celsius
            // 
            this.lbl_celsius.AutoSize = true;
            this.lbl_celsius.Location = new System.Drawing.Point(91, 40);
            this.lbl_celsius.Name = "lbl_celsius";
            this.lbl_celsius.Size = new System.Drawing.Size(60, 20);
            this.lbl_celsius.TabIndex = 1;
            this.lbl_celsius.Text = "Clesius";
            this.lbl_celsius.Click += new System.EventHandler(this.label1_Click);
            // 
            // gb_temperaturas
            // 
            this.gb_temperaturas.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gb_temperaturas.Controls.Add(this.rbKelvin);
            this.gb_temperaturas.Controls.Add(this.rbFahrenheit);
            this.gb_temperaturas.Controls.Add(this.rbCelsius);
            this.gb_temperaturas.Location = new System.Drawing.Point(92, 220);
            this.gb_temperaturas.Name = "gb_temperaturas";
            this.gb_temperaturas.Size = new System.Drawing.Size(591, 98);
            this.gb_temperaturas.TabIndex = 2;
            this.gb_temperaturas.TabStop = false;
            this.gb_temperaturas.Text = "Temperaturas";
            // 
            // rbKelvin
            // 
            this.rbKelvin.AutoSize = true;
            this.rbKelvin.Location = new System.Drawing.Point(403, 42);
            this.rbKelvin.Name = "rbKelvin";
            this.rbKelvin.Size = new System.Drawing.Size(75, 24);
            this.rbKelvin.TabIndex = 2;
            this.rbKelvin.TabStop = true;
            this.rbKelvin.Text = "Kelvin";
            this.rbKelvin.UseVisualStyleBackColor = true;
            // 
            // rbFahrenheit
            // 
            this.rbFahrenheit.AutoSize = true;
            this.rbFahrenheit.Location = new System.Drawing.Point(208, 42);
            this.rbFahrenheit.Name = "rbFahrenheit";
            this.rbFahrenheit.Size = new System.Drawing.Size(111, 24);
            this.rbFahrenheit.TabIndex = 1;
            this.rbFahrenheit.TabStop = true;
            this.rbFahrenheit.Text = "Fahrenheit";
            this.rbFahrenheit.UseVisualStyleBackColor = true;
            // 
            // rbCelsius
            // 
            this.rbCelsius.AutoSize = true;
            this.rbCelsius.Location = new System.Drawing.Point(26, 42);
            this.rbCelsius.Name = "rbCelsius";
            this.rbCelsius.Size = new System.Drawing.Size(85, 24);
            this.rbCelsius.TabIndex = 0;
            this.rbCelsius.TabStop = true;
            this.rbCelsius.Text = "Celsius";
            this.rbCelsius.UseVisualStyleBackColor = true;
            // 
            // lbl_fahrenheit
            // 
            this.lbl_fahrenheit.AutoSize = true;
            this.lbl_fahrenheit.Location = new System.Drawing.Point(91, 102);
            this.lbl_fahrenheit.Name = "lbl_fahrenheit";
            this.lbl_fahrenheit.Size = new System.Drawing.Size(86, 20);
            this.lbl_fahrenheit.TabIndex = 3;
            this.lbl_fahrenheit.Text = "Fahrenheit";
            // 
            // lbl_kelvin
            // 
            this.lbl_kelvin.AutoSize = true;
            this.lbl_kelvin.Location = new System.Drawing.Point(88, 161);
            this.lbl_kelvin.Name = "lbl_kelvin";
            this.lbl_kelvin.Size = new System.Drawing.Size(50, 20);
            this.lbl_kelvin.TabIndex = 4;
            this.lbl_kelvin.Text = "Kelvin";
            // 
            // tbxFahrenheit
            // 
            this.tbxFahrenheit.Location = new System.Drawing.Point(202, 102);
            this.tbxFahrenheit.Name = "tbxFahrenheit";
            this.tbxFahrenheit.Size = new System.Drawing.Size(100, 26);
            this.tbxFahrenheit.TabIndex = 5;
            // 
            // tbxCelsius
            // 
            this.tbxCelsius.Location = new System.Drawing.Point(202, 40);
            this.tbxCelsius.Name = "tbxCelsius";
            this.tbxCelsius.Size = new System.Drawing.Size(100, 26);
            this.tbxCelsius.TabIndex = 6;
            // 
            // tbxKelvin
            // 
            this.tbxKelvin.Location = new System.Drawing.Point(202, 161);
            this.tbxKelvin.Name = "tbxKelvin";
            this.tbxKelvin.Size = new System.Drawing.Size(100, 26);
            this.tbxKelvin.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(202, 367);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(111, 53);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::_3MLIDTS_KevinMontores_03.Properties.Resources.cover_sp;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.tbxKelvin);
            this.Controls.Add(this.tbxCelsius);
            this.Controls.Add(this.tbxFahrenheit);
            this.Controls.Add(this.lbl_kelvin);
            this.Controls.Add(this.lbl_fahrenheit);
            this.Controls.Add(this.gb_temperaturas);
            this.Controls.Add(this.lbl_celsius);
            this.Controls.Add(this.btnLimpiar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_temperaturas.ResumeLayout(false);
            this.gb_temperaturas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lbl_celsius;
        private System.Windows.Forms.GroupBox gb_temperaturas;
        private System.Windows.Forms.RadioButton rbKelvin;
        private System.Windows.Forms.RadioButton rbFahrenheit;
        private System.Windows.Forms.RadioButton rbCelsius;
        private System.Windows.Forms.Label lbl_fahrenheit;
        private System.Windows.Forms.Label lbl_kelvin;
        private System.Windows.Forms.TextBox tbxFahrenheit;
        private System.Windows.Forms.TextBox tbxCelsius;
        private System.Windows.Forms.TextBox tbxKelvin;
        private System.Windows.Forms.Button btnCalcular;
    }
}

