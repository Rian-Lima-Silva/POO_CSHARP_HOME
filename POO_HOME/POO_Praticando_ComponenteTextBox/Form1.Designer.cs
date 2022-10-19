namespace POO_Praticando_ComponenteTextBox
{
    partial class Form_Principal
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.textBoxLista = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox.Location = new System.Drawing.Point(12, 46);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(414, 30);
            this.textBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite o seu Texto:";
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonAdicionar.Location = new System.Drawing.Point(432, 46);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(100, 30);
            this.buttonAdicionar.TabIndex = 3;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonLimpar.Location = new System.Drawing.Point(12, 534);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(520, 50);
            this.buttonLimpar.TabIndex = 4;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // textBoxLista
            // 
            this.textBoxLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxLista.Location = new System.Drawing.Point(12, 101);
            this.textBoxLista.Multiline = true;
            this.textBoxLista.Name = "textBoxLista";
            this.textBoxLista.Size = new System.Drawing.Size(520, 412);
            this.textBoxLista.TabIndex = 5;
            // 
            // Form_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(544, 603);
            this.Controls.Add(this.textBoxLista);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox);
            this.MaximizeBox = false;
            this.Name = "Form_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Componentes - TextBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.TextBox textBoxLista;
    }
}

