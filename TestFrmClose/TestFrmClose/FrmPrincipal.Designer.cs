
namespace TestFrmClose
{
    partial class FrmPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnProximo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(228, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Formulario Principal";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 520);
            this.panel1.TabIndex = 1;
            this.panel1.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.panel1_ControlRemoved);
            // 
            // btnProximo
            // 
            this.btnProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnProximo.Location = new System.Drawing.Point(757, 637);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(119, 50);
            this.btnProximo.TabIndex = 2;
            this.btnProximo.Text = "&Proximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 700);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.FrmPrincipal_ControlRemoved);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProximo;
    }
}

