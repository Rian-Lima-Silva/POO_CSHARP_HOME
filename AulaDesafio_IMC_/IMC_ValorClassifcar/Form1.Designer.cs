namespace IMC_ValorClassifcar
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxPeso = new System.Windows.Forms.TextBox();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.labelPeso = new System.Windows.Forms.Label();
            this.labelClassificar = new System.Windows.Forms.Label();
            this.textBoxAltura = new System.Windows.Forms.TextBox();
            this.labelAltura = new System.Windows.Forms.Label();
            this.labelRes = new System.Windows.Forms.Label();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.labelObesidade = new System.Windows.Forms.Label();
            this.labelSobrepeso = new System.Windows.Forms.Label();
            this.labelNormal = new System.Windows.Forms.Label();
            this.label_img_BP = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPeso
            // 
            this.textBoxPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxPeso.Location = new System.Drawing.Point(222, 27);
            this.textBoxPeso.Name = "textBoxPeso";
            this.textBoxPeso.Size = new System.Drawing.Size(136, 34);
            this.textBoxPeso.TabIndex = 0;
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonCalcular.Location = new System.Drawing.Point(222, 125);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(136, 40);
            this.buttonCalcular.TabIndex = 1;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // labelPeso
            // 
            this.labelPeso.AutoSize = true;
            this.labelPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelPeso.Location = new System.Drawing.Point(7, 30);
            this.labelPeso.Name = "labelPeso";
            this.labelPeso.Size = new System.Drawing.Size(209, 29);
            this.labelPeso.TabIndex = 2;
            this.labelPeso.Text = "Digite o seu Peso:";
            // 
            // labelClassificar
            // 
            this.labelClassificar.BackColor = System.Drawing.Color.Transparent;
            this.labelClassificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelClassificar.Location = new System.Drawing.Point(373, 32);
            this.labelClassificar.Name = "labelClassificar";
            this.labelClassificar.Size = new System.Drawing.Size(209, 29);
            this.labelClassificar.TabIndex = 3;
            this.labelClassificar.Text = "Sua Classificação:";
            this.labelClassificar.Click += new System.EventHandler(this.labelClassificar_Click);
            // 
            // textBoxAltura
            // 
            this.textBoxAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxAltura.Location = new System.Drawing.Point(222, 78);
            this.textBoxAltura.Name = "textBoxAltura";
            this.textBoxAltura.Size = new System.Drawing.Size(136, 34);
            this.textBoxAltura.TabIndex = 6;
            // 
            // labelAltura
            // 
            this.labelAltura.AutoSize = true;
            this.labelAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelAltura.Location = new System.Drawing.Point(9, 78);
            this.labelAltura.Name = "labelAltura";
            this.labelAltura.Size = new System.Drawing.Size(212, 29);
            this.labelAltura.TabIndex = 7;
            this.labelAltura.Text = "Digite a sua Altura:";
            // 
            // labelRes
            // 
            this.labelRes.AutoSize = true;
            this.labelRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelRes.Location = new System.Drawing.Point(577, 32);
            this.labelRes.Name = "labelRes";
            this.labelRes.Size = new System.Drawing.Size(157, 29);
            this.labelRes.TabIndex = 8;
            this.labelRes.Text = "------------------";
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonLimpar.Location = new System.Drawing.Point(80, 125);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(136, 40);
            this.buttonLimpar.TabIndex = 9;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // labelObesidade
            // 
            this.labelObesidade.Image = global::IMC_ValorClassifcar.Properties.Resources.Captura_da_Web_20_10_2022_91923_www_bing_com;
            this.labelObesidade.Location = new System.Drawing.Point(579, 27);
            this.labelObesidade.Name = "labelObesidade";
            this.labelObesidade.Size = new System.Drawing.Size(149, 45);
            this.labelObesidade.TabIndex = 13;
            this.labelObesidade.Visible = false;
            // 
            // labelSobrepeso
            // 
            this.labelSobrepeso.Image = ((System.Drawing.Image)(resources.GetObject("labelSobrepeso.Image")));
            this.labelSobrepeso.Location = new System.Drawing.Point(579, 27);
            this.labelSobrepeso.Name = "labelSobrepeso";
            this.labelSobrepeso.Size = new System.Drawing.Size(149, 45);
            this.labelSobrepeso.TabIndex = 12;
            this.labelSobrepeso.Visible = false;
            // 
            // labelNormal
            // 
            this.labelNormal.Image = ((System.Drawing.Image)(resources.GetObject("labelNormal.Image")));
            this.labelNormal.Location = new System.Drawing.Point(579, 27);
            this.labelNormal.Name = "labelNormal";
            this.labelNormal.Size = new System.Drawing.Size(149, 45);
            this.labelNormal.TabIndex = 11;
            this.labelNormal.Visible = false;
            // 
            // label_img_BP
            // 
            this.label_img_BP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_img_BP.Image = ((System.Drawing.Image)(resources.GetObject("label_img_BP.Image")));
            this.label_img_BP.Location = new System.Drawing.Point(579, 27);
            this.label_img_BP.Name = "label_img_BP";
            this.label_img_BP.Size = new System.Drawing.Size(149, 45);
            this.label_img_BP.TabIndex = 10;
            this.label_img_BP.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 232);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(736, 246);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 183);
            this.Controls.Add(this.labelRes);
            this.Controls.Add(this.labelObesidade);
            this.Controls.Add(this.labelSobrepeso);
            this.Controls.Add(this.labelNormal);
            this.Controls.Add(this.label_img_BP);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.labelAltura);
            this.Controls.Add(this.textBoxAltura);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelClassificar);
            this.Controls.Add(this.labelPeso);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.textBoxPeso);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPeso;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Label labelPeso;
        private System.Windows.Forms.Label labelClassificar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxAltura;
        private System.Windows.Forms.Label labelAltura;
        private System.Windows.Forms.Label labelRes;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Label label_img_BP;
        private System.Windows.Forms.Label labelNormal;
        private System.Windows.Forms.Label labelSobrepeso;
        private System.Windows.Forms.Label labelObesidade;
    }
}

