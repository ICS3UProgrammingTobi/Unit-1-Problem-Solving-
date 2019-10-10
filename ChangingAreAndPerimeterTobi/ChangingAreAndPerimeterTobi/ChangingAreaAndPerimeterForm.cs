/*
 * Created by: Tobi Adebayo
 * Created on: 10-10-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #9 - Name of Program
 * This program calculates the area and perimeter of a quadrilateral
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

namespace ChangingAreAndPerimeterTobi
{
    public partial class frmChangingAreaAndPerimeter : Form
    {
        public frmChangingAreaAndPerimeter()
        {
            InitializeComponent();
            //Hide the perimeter and answer labels and answers 
            this.lblPerimeter.Hide();
            this.lblPerimterAnswer.Hide();
            this.lblArea.Hide();
            this.lblAreaAnswer.Hide();
        }

        private void MniExit_Click(object sender, EventArgs e)
        {
            //This closes the application
            this.Close();
        }

        private void Lbl_Click(object sender, EventArgs e)
        {

        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            //This show's the perimeter and answer labels when the user clicks on the calculate button
            this.lblArea.Show();
            this.lblAreaAnswer.Show();
            this.lblPerimeter.Show();
            this.lblPerimterAnswer.Show();

            //declair local variables
            double length, width, area, perimeter;

            //convert the string from each text box to a double
            length = double.Parse(txtLength.Text);
            width = double.Parse(txtLength.Text);

            //Calculate the area and the perimeter
            area = length * width;
            perimeter = 2 * length + 2 * width;

            // Insert the area and perimeter
            this.lblAreaAnswer.Text = Convert.ToString(area) + "Squared meters";
            this.lblPerimterAnswer.Text=Convert.ToString(perimeter)+"Meters";




        }

        private void LblPerimterAnswer_Click(object sender, EventArgs e)
        {

        }
    }
}
