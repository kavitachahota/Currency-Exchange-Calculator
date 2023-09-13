using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCsFinalProject
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void standardToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmStandardCalculator frmSCalculator = new frmStandardCalculator();
            frmSCalculator.Show();
            IsMdiContainer = true;
            frmSCalculator.MdiParent = this;

        }

        private void scientificToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmScientificCalculator frmSciCalculator = new FrmScientificCalculator();
            frmSciCalculator.Show();
            IsMdiContainer = true;
            frmSciCalculator.MdiParent = this;
        }

        private void userManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserManual frmUserManual = new frmUserManual();
            frmUserManual.Show();
            frmUserManual.MdiParent = this;
        }

        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmAbout frmAbout = new frmAbout();
            frmAbout.Show();
            frmAbout.MdiParent = this;
        }

        private void toolbarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            toolStrip1.Visible = toolbarToolStripMenuItem.Checked ? true : false;
        }

        private void statusBarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            statusStrip1.Visible = statusBarToolStripMenuItem.Checked ? true : false;
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit the program ?", "Exist Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmMain_Load_1(object sender, EventArgs e)
        {
            toolbarToolStripMenuItem.Checked = true;
            statusBarToolStripMenuItem.Checked = true;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmStandardCalculator frmSCalculator = new frmStandardCalculator();
            frmSCalculator.Show();
            IsMdiContainer = true;
            frmSCalculator.MdiParent = this;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FrmScientificCalculator frmSciCalculator = new FrmScientificCalculator();
            frmSciCalculator.Show();
            IsMdiContainer = true;
            frmSciCalculator.MdiParent = this;
        }

        private void programsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
