using SegundoParcial.UI.Consulta;
using SegundoParcial.UI.Registro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoParcial
{
    public partial class ManForm : Form
    {
        public ManForm()
        {
            InitializeComponent();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rVendedor rVendedor = new rVendedor();
            rVendedor.Show();
            rVendedor.MdiParent = this;
        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cVendedor cVendedor = new cVendedor();
            cVendedor.Show();
            cVendedor.MdiParent = this;
        }
    }
}
