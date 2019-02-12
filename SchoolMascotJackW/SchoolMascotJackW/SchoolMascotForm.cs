using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolMascotJackW
{
    public partial class frmSchoolMascot : Form
    {
        public frmSchoolMascot()
        {
            InitializeComponent();
        }

        private void schoolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void mniImmaculata_Click(object sender, EventArgs e)
        {
            lblSchool.Text = "Immaculata";
            lblMascot.Text = "Saints"
        }

        private void mniMotherTeresa_Click(object sender, EventArgs e)
        {
            lblSchool.Text = "Mother Teresa";
            lblMascot.Text = "Titans"
        }

        private void mniStMark_Click(object sender, EventArgs e)
        {
            lblSchool.Text = "St. Mark"

        }
    }
}
