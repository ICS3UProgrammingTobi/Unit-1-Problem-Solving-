/*
 * Created by: Tobi Adebayo
 * Created on: 11-10-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #10 - TopDownDesignAndFlowChart
 * This program displays the circumference of a circle when given the radius
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

namespace TopDowndesignAndFlowChartTobi
{
    public partial class TopDownDesignAndFlowChartForm : Form
    {
        public TopDownDesignAndFlowChartForm()
        {
            InitializeComponent();
            //Hide the 2 labels
            this.lblCircumferenceIs.Hide();
            this.lblAnswer.Hide();
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblCircumferenceIs_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Display the 2 hidden labels
            this.lblCircumferenceIs.Show();
            this.lblAnswer.Show();

            //declear constant
            const double PI = 3.14;

            //Declear variable
            double radius, circumference;

            //convert circumference to string
            radius = double.Parse(txtRadius.Text);

            //calculate the radius of the circle
            circumference = 2 * 3.4 * radius;
            this.lblAnswer.Text = Convert.ToString(circumference) + "cm";

        }
    }
}
