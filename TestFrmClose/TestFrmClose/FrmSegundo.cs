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
    public partial class FrmSegundo : Form
    {
        public FrmSegundo()
        {
            InitializeComponent();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
