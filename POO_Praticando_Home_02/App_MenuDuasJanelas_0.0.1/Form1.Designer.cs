namespace App_MenuDuasJanelas_0._0._1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelSenha = new System.Windows.Forms.Label();
            this.buttonEntrar = new System.Windows.Forms.Button();
            this.labelTelaDeLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(207, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 339);
            this.label1.TabIndex = 0;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.textBoxEmail.Location = new System.Drawing.Point(221, 144);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(336, 32);
            this.textBoxEmail.TabIndex = 1;
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.textBoxSenha.Location = new System.Drawing.Point(221, 249);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(336, 32);
            this.textBoxSenha.TabIndex = 2;
            // 
            // labelEmail
            // 
            this.labelEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEmail.BackColor = System.Drawing.SystemColors.Control;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelEmail.Location = new System.Drawing.Point(216, 115);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(353, 26);
            this.labelEmail.TabIndex = 3;
            this.labelEmail.Text = "E-MAIL:";
            this.labelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSenha
            // 
            this.labelSenha.BackColor = System.Drawing.SystemColors.Control;
            this.labelSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelSenha.Location = new System.Drawing.Point(216, 220);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(353, 23);
            this.labelSenha.TabIndex = 4;
            this.labelSenha.Text = "SENHA:";
            this.labelSenha.Click += new System.EventHandler(this.label3_Click);
            // 
            // buttonEntrar
            // 
            this.buttonEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonEntrar.Location = new System.Drawing.Point(339, 328);
            this.buttonEntrar.Name = "buttonEntrar";
            this.buttonEntrar.Size = new System.Drawing.Size(98, 32);
            this.buttonEntrar.TabIndex = 5;
            this.buttonEntrar.Text = "ENTRAR";
            this.buttonEntrar.UseVisualStyleBackColor = true;
            // 
            // labelTelaDeLogin
            // 
            this.labelTelaDeLogin.BackColor = System.Drawing.SystemColors.Control;
            this.labelTelaDeLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelTelaDeLogin.Location = new System.Drawing.Point(212, 56);
            this.labelTelaDeLogin.Name = "labelTelaDeLogin";
            this.labelTelaDeLogin.Size = new System.Drawing.Size(357, 32);
            this.labelTelaDeLogin.TabIndex = 6;
            this.labelTelaDeLogin.Text = "TELA DE LOGIN";
            this.labelTelaDeLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTelaDeLogin);
            this.Controls.Add(this.buttonEntrar);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.Button buttonEntrar;
        private System.Windows.Forms.Label labelTelaDeLogin;
    }
}

