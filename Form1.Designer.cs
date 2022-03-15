namespace Repaso2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosAlquilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clientesToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxplaca = new System.Windows.Forms.TextBox();
            this.textBoxmarca = new System.Windows.Forms.TextBox();
            this.textBoxmodelo = new System.Windows.Forms.TextBox();
            this.textBoxcolor = new System.Windows.Forms.TextBox();
            this.textBoxprecio = new System.Windows.Forms.TextBox();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.datosClienteToolStripMenuItem,
            this.datosAlquilerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(604, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.clientesToolStripMenuItem.Text = "Resumen Alquiler";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // datosClienteToolStripMenuItem
            // 
            this.datosClienteToolStripMenuItem.Name = "datosClienteToolStripMenuItem";
            this.datosClienteToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.datosClienteToolStripMenuItem.Text = "Cliente";
            this.datosClienteToolStripMenuItem.Click += new System.EventHandler(this.datosClienteToolStripMenuItem_Click);
            // 
            // datosAlquilerToolStripMenuItem
            // 
            this.datosAlquilerToolStripMenuItem.Name = "datosAlquilerToolStripMenuItem";
            this.datosAlquilerToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.datosAlquilerToolStripMenuItem.Text = "Alquiler";
            this.datosAlquilerToolStripMenuItem.Click += new System.EventHandler(this.datosAlquilerToolStripMenuItem_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(117, 26);
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.clientesToolStripMenuItem1.Text = "Clientes";
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem2});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(117, 26);
            // 
            // clientesToolStripMenuItem2
            // 
            this.clientesToolStripMenuItem2.Name = "clientesToolStripMenuItem2";
            this.clientesToolStripMenuItem2.Size = new System.Drawing.Size(116, 22);
            this.clientesToolStripMenuItem2.Text = "Clientes";
            // 
            // textBoxplaca
            // 
            this.textBoxplaca.Location = new System.Drawing.Point(144, 62);
            this.textBoxplaca.Name = "textBoxplaca";
            this.textBoxplaca.Size = new System.Drawing.Size(100, 23);
            this.textBoxplaca.TabIndex = 3;
            // 
            // textBoxmarca
            // 
            this.textBoxmarca.Location = new System.Drawing.Point(144, 109);
            this.textBoxmarca.Name = "textBoxmarca";
            this.textBoxmarca.Size = new System.Drawing.Size(100, 23);
            this.textBoxmarca.TabIndex = 4;
            // 
            // textBoxmodelo
            // 
            this.textBoxmodelo.Location = new System.Drawing.Point(144, 158);
            this.textBoxmodelo.Name = "textBoxmodelo";
            this.textBoxmodelo.Size = new System.Drawing.Size(100, 23);
            this.textBoxmodelo.TabIndex = 5;
            // 
            // textBoxcolor
            // 
            this.textBoxcolor.Location = new System.Drawing.Point(144, 202);
            this.textBoxcolor.Name = "textBoxcolor";
            this.textBoxcolor.Size = new System.Drawing.Size(100, 23);
            this.textBoxcolor.TabIndex = 6;
            // 
            // textBoxprecio
            // 
            this.textBoxprecio.Location = new System.Drawing.Point(144, 244);
            this.textBoxprecio.Name = "textBoxprecio";
            this.textBoxprecio.Size = new System.Drawing.Size(100, 23);
            this.textBoxprecio.TabIndex = 7;
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.BackColor = System.Drawing.Color.Tomato;
            this.buttonIngresar.Font = new System.Drawing.Font("SansSerif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonIngresar.ForeColor = System.Drawing.Color.White;
            this.buttonIngresar.Location = new System.Drawing.Point(144, 285);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(100, 30);
            this.buttonIngresar.TabIndex = 8;
            this.buttonIngresar.Text = "Ingresar datos";
            this.buttonIngresar.UseVisualStyleBackColor = false;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SansSerif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(60, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 14);
            this.label1.TabIndex = 9;
            this.label1.Text = "PLACA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SansSerif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(57, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 14);
            this.label2.TabIndex = 10;
            this.label2.Text = "MARCA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SansSerif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(55, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 14);
            this.label3.TabIndex = 11;
            this.label3.Text = "MODELO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SansSerif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(57, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 14);
            this.label4.TabIndex = 12;
            this.label4.Text = "COLOR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SansSerif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 14);
            this.label5.TabIndex = 13;
            this.label5.Text = "PRECIO KILÓMETRO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Repaso2.Properties.Resources.Silverado_Color_Roja_1;
            this.pictureBox1.Location = new System.Drawing.Point(266, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 253);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("SansSerif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(226, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Datos Vehículo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 344);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonIngresar);
            this.Controls.Add(this.textBoxprecio);
            this.Controls.Add(this.textBoxcolor);
            this.Controls.Add(this.textBoxmodelo);
            this.Controls.Add(this.textBoxmarca);
            this.Controls.Add(this.textBoxplaca);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Alquiler de automóviles";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip2;
       private ToolStripMenuItem clientesToolStripMenuItem1;
        private ContextMenuStrip contextMenuStrip3;
        private ToolStripMenuItem clientesToolStripMenuItem2;
        private TextBox textBoxplaca;
        private TextBox textBoxmarca;
        private TextBox textBoxmodelo;
        private TextBox textBoxcolor;
        private TextBox textBoxprecio;
        private Button buttonIngresar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
        private ToolStripMenuItem datosClienteToolStripMenuItem;
        private ToolStripMenuItem datosAlquilerToolStripMenuItem;
        private Label label6;
    }
}