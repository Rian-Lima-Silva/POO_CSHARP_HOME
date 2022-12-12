using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestFrmClose
{
    public partial class FrmPrincipal : Form
    {
        Form frmAtivo;
        int Atual = 1;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            FrmPrimeiro frm = new FrmPrimeiro();
            FormShow(frm);
        }


        private void FormShow(Form frm)
        {
            Atual++;
            CloseActiveForm(Atual);
            frmAtivo = frm;
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
           

        }

        private void CloseActiveForm(int atual)
        {
           if (frmAtivo != null)
                frmAtivo.Visible = false;
            
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Atual.ToString(),"Tela Principal") ;
            FrmSegundo frm = new FrmSegundo();
            FormShow(frm);
        }

        private void FrmPrincipal_ControlRemoved(object sender, ControlEventArgs e)
        {

        }

        private void panel1_ControlRemoved(object sender, ControlEventArgs e)
        {
            this.Dispose();
        }
    }
    
}
