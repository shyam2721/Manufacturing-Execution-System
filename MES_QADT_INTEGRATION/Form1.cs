using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MES_QADT_INTEGRATION
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            Login x = new Login();
            x.ShowDialog();
            this.Visible = true;
        }

        private void qADTRESULTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MES_QADT_RESULT mesqr = new MES_QADT_RESULT();
            mesqr.Parent = pnl_main;
            mesqr.Show();
            mesqr.BringToFront();
        }
    }
}
