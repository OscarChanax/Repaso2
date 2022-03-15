namespace Repaso2
{
    partial class FormIngresoAlquiler
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
            this.textBoxNit = new System.Windows.Forms.TextBox();
            this.textBoxPlaca = new System.Windows.Forms.TextBox();
            this.textBoxKilometros = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePickerAlquiler = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDevolucion = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // textBoxNit
            // 
            this.textBoxNit.Location = new System.Drawing.Point(160, 27);
            this.textBoxNit.Name = "textBoxNit";
            this.textBoxNit.Size = new System.Drawing.Size(210, 23);
            this.textBoxNit.TabIndex = 0;
            // 
            // textBoxPlaca
            // 
            this.textBoxPlaca.Location = new System.Drawing.Point(160, 66);
            this.textBoxPlaca.Name = "textBoxPlaca";
            this.textBoxPlaca.Size = new System.Drawing.Size(210, 23);
            this.textBoxPlaca.TabIndex = 1;
            // 
            // textBoxKilometros
            // 
            this.textBoxKilometros.Location = new System.Drawing.Point(160, 193);
            this.textBoxKilometros.Name = "textBoxKilometros";
            this.textBoxKilometros.Size = new System.Drawing.Size(124, 23);
            this.textBoxKilometros.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SansSerif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(99, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "NIT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SansSerif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(87, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Placa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SansSerif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(26, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fecha de alquiler";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SansSerif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha de devolución";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SansSerif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(58, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kilómetros";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tomato;
            this.button1.Font = new System.Drawing.Font("SansSerif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(160, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 31);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePickerAlquiler
            // 
            this.dateTimePickerAlquiler.Location = new System.Drawing.Point(160, 108);
            this.dateTimePickerAlquiler.Name = "dateTimePickerAlquiler";
            this.dateTimePickerAlquiler.Size = new System.Drawing.Size(210, 23);
            this.dateTimePickerAlquiler.TabIndex = 11;
            // 
            // dateTimePickerDevolucion
            // 
            this.dateTimePickerDevolucion.Location = new System.Drawing.Point(160, 147);
            this.dateTimePickerDevolucion.Name = "dateTimePickerDevolucion";
            this.dateTimePickerDevolucion.Size = new System.Drawing.Size(210, 23);
            this.dateTimePickerDevolucion.TabIndex = 12;
            // 
            // FormIngresoAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 288);
            this.Controls.Add(this.dateTimePickerDevolucion);
            this.Controls.Add(this.dateTimePickerAlquiler);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxKilometros);
            this.Controls.Add(this.textBoxPlaca);
            this.Controls.Add(this.textBoxNit);
            this.Name = "FormIngresoAlquiler";
            this.Text = "Datos alquiler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxNit;
        private TextBox textBoxPlaca;
        private TextBox textBoxKilometros;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private DateTimePicker dateTimePickerAlquiler;
        private DateTimePicker dateTimePickerDevolucion;
    }
}