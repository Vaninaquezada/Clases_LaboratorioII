namespace FormularioCantina
{
    partial class FrmCantina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCantina));
            this.barra1 = new ControlCantina.Barra();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.txtbMarca = new System.Windows.Forms.TextBox();
            this.nupdoCapacidad = new System.Windows.Forms.NumericUpDown();
            this.lblMarca = new System.Windows.Forms.Label();
            this.rdbtnCerveza = new System.Windows.Forms.RadioButton();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.rdbtnAgua = new System.Windows.Forms.RadioButton();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.lblContenido = new System.Windows.Forms.Label();
            this.lblBotellaTipo = new System.Windows.Forms.Label();
            this.cmbBotellaTipo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupdoCapacidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // barra1
            // 
            this.barra1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("barra1.BackgroundImage")));
            this.barra1.Location = new System.Drawing.Point(39, 27);
            this.barra1.Name = "barra1";
            this.barra1.Size = new System.Drawing.Size(774, 328);
            this.barra1.TabIndex = 0;
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Location = new System.Drawing.Point(283, 428);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(58, 13);
            this.lblCapacidad.TabIndex = 1;
            this.lblCapacidad.Text = "Capacidad";
            // 
            // txtbMarca
            // 
            this.txtbMarca.Location = new System.Drawing.Point(286, 385);
            this.txtbMarca.Name = "txtbMarca";
            this.txtbMarca.Size = new System.Drawing.Size(217, 20);
            this.txtbMarca.TabIndex = 2;
            // 
            // nupdoCapacidad
            // 
            this.nupdoCapacidad.Location = new System.Drawing.Point(286, 444);
            this.nupdoCapacidad.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nupdoCapacidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupdoCapacidad.Name = "nupdoCapacidad";
            this.nupdoCapacidad.Size = new System.Drawing.Size(50, 20);
            this.nupdoCapacidad.TabIndex = 3;
            this.nupdoCapacidad.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(286, 366);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 4;
            this.lblMarca.Text = "Marca";
            // 
            // rdbtnCerveza
            // 
            this.rdbtnCerveza.AutoSize = true;
            this.rdbtnCerveza.Location = new System.Drawing.Point(53, 385);
            this.rdbtnCerveza.Name = "rdbtnCerveza";
            this.rdbtnCerveza.Size = new System.Drawing.Size(64, 17);
            this.rdbtnCerveza.TabIndex = 5;
            this.rdbtnCerveza.TabStop = true;
            this.rdbtnCerveza.Text = "Cerveza";
            this.rdbtnCerveza.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(588, 434);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(126, 36);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // rdbtnAgua
            // 
            this.rdbtnAgua.AutoSize = true;
            this.rdbtnAgua.Location = new System.Drawing.Point(53, 423);
            this.rdbtnAgua.Name = "rdbtnAgua";
            this.rdbtnAgua.Size = new System.Drawing.Size(50, 17);
            this.rdbtnAgua.TabIndex = 7;
            this.rdbtnAgua.TabStop = true;
            this.rdbtnAgua.Text = "Agua";
            this.rdbtnAgua.UseVisualStyleBackColor = true;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(433, 444);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(47, 20);
            this.numericUpDown2.TabIndex = 8;
            this.numericUpDown2.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lblContenido
            // 
            this.lblContenido.AutoSize = true;
            this.lblContenido.Location = new System.Drawing.Point(430, 428);
            this.lblContenido.Name = "lblContenido";
            this.lblContenido.Size = new System.Drawing.Size(55, 13);
            this.lblContenido.TabIndex = 9;
            this.lblContenido.Text = "Contenido";
            // 
            // lblBotellaTipo
            // 
            this.lblBotellaTipo.AutoSize = true;
            this.lblBotellaTipo.Location = new System.Drawing.Point(585, 366);
            this.lblBotellaTipo.Name = "lblBotellaTipo";
            this.lblBotellaTipo.Size = new System.Drawing.Size(63, 13);
            this.lblBotellaTipo.TabIndex = 10;
            this.lblBotellaTipo.Text = "Botella Tipo";
            // 
            // cmbBotellaTipo
            // 
            this.cmbBotellaTipo.FormattingEnabled = true;
            this.cmbBotellaTipo.Location = new System.Drawing.Point(588, 383);
            this.cmbBotellaTipo.Name = "cmbBotellaTipo";
            this.cmbBotellaTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbBotellaTipo.TabIndex = 11;
            // 
            // FrmCantina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 489);
            this.Controls.Add(this.cmbBotellaTipo);
            this.Controls.Add(this.lblBotellaTipo);
            this.Controls.Add(this.lblContenido);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.rdbtnAgua);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.rdbtnCerveza);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.nupdoCapacidad);
            this.Controls.Add(this.txtbMarca);
            this.Controls.Add(this.lblCapacidad);
            this.Controls.Add(this.barra1);
            this.Name = "FrmCantina";
            this.Text = "Alumno: Vanina Quezada";
            this.Load += new System.EventHandler(this.FrmCantina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupdoCapacidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlCantina.Barra barra1;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.TextBox txtbMarca;
        private System.Windows.Forms.NumericUpDown nupdoCapacidad;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.RadioButton rdbtnCerveza;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.RadioButton rdbtnAgua;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label lblContenido;
        private System.Windows.Forms.Label lblBotellaTipo;
        private System.Windows.Forms.ComboBox cmbBotellaTipo;
    }
}