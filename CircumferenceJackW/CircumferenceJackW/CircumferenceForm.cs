/*
 * Created by: Jack Wright
 * Created on: 20-Feb-2019 (Connor's Birthday)
 * Created for: ICS3U Programming
 * Daily Assignment – Day #10 - Name of Program
 * This program...
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircumferenceJackW
{
    public partial class CircumferenceForm : Form
    {
        public CircumferenceForm()
        {
            InitializeComponent();
        }

        double Radius;
        double Circumference;
        const double PI = Math.PI;


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Radius = Convert.ToDouble(txtInput.Text);
            Circumference = Math.Round(PI * Radius * 2 * 100)/100;
            lblAnswer.Text = Convert.ToString("The circumference of this circle is: " + Circumference);
            lblAnswer.Visible = true;

        }

       

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            lblAnswer.Visible = false;
        }

        private void lblAnswer_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
