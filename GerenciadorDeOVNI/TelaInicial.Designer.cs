namespace GerenciadorDeOVNI
{
    partial class TelaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            this.lblTripulantes = new System.Windows.Forms.Label();
            this.lblAbduzidos = new System.Windows.Forms.Label();
            this.lblPlaneta = new System.Windows.Forms.Label();
            this.txbTipulantes = new System.Windows.Forms.TextBox();
            this.txbAbduzidos = new System.Windows.Forms.TextBox();
            this.cmbPlanta = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTripulantes
            // 
            this.lblTripulantes.AutoSize = true;
            this.lblTripulantes.Location = new System.Drawing.Point(254, 83);
            this.lblTripulantes.Name = "lblTripulantes";
            this.lblTripulantes.Size = new System.Drawing.Size(112, 13);
            this.lblTripulantes.TabIndex = 0;
            this.lblTripulantes.Text = "Máximo de tripulantes:";
            // 
            // lblAbduzidos
            // 
            this.lblAbduzidos.AutoSize = true;
            this.lblAbduzidos.Location = new System.Drawing.Point(253, 140);
            this.lblAbduzidos.Name = "lblAbduzidos";
            this.lblAbduzidos.Size = new System.Drawing.Size(113, 13);
            this.lblAbduzidos.TabIndex = 1;
            this.lblAbduzidos.Text = "Máximo de Abduzidos:";
            // 
            // lblPlaneta
            // 
            this.lblPlaneta.AutoSize = true;
            this.lblPlaneta.Location = new System.Drawing.Point(254, 198);
            this.lblPlaneta.Name = "lblPlaneta";
            this.lblPlaneta.Size = new System.Drawing.Size(97, 13);
            this.lblPlaneta.TabIndex = 2;
            this.lblPlaneta.Text = "Planeta de Origem:";
            // 
            // txbTipulantes
            // 
            this.txbTipulantes.Location = new System.Drawing.Point(392, 80);
            this.txbTipulantes.Name = "txbTipulantes";
            this.txbTipulantes.Size = new System.Drawing.Size(91, 20);
            this.txbTipulantes.TabIndex = 3;
            // 
            // txbAbduzidos
            // 
            this.txbAbduzidos.Location = new System.Drawing.Point(392, 140);
            this.txbAbduzidos.Name = "txbAbduzidos";
            this.txbAbduzidos.Size = new System.Drawing.Size(91, 20);
            this.txbAbduzidos.TabIndex = 4;
            // 
            // cmbPlanta
            // 
            this.cmbPlanta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlanta.FormattingEnabled = true;
            this.cmbPlanta.Location = new System.Drawing.Point(392, 190);
            this.cmbPlanta.Name = "cmbPlanta";
            this.cmbPlanta.Size = new System.Drawing.Size(98, 21);
            this.cmbPlanta.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(244, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 57);
            this.button1.TabIndex = 6;
            this.button1.Text = "Inicial";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "UFO MANAGER 5000";
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbPlanta);
            this.Controls.Add(this.txbAbduzidos);
            this.Controls.Add(this.txbTipulantes);
            this.Controls.Add(this.lblPlaneta);
            this.Controls.Add(this.lblAbduzidos);
            this.Controls.Add(this.lblTripulantes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicializador";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTripulantes;
        private System.Windows.Forms.Label lblAbduzidos;
        private System.Windows.Forms.Label lblPlaneta;
        private System.Windows.Forms.TextBox txbTipulantes;
        private System.Windows.Forms.TextBox txbAbduzidos;
        private System.Windows.Forms.ComboBox cmbPlanta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}