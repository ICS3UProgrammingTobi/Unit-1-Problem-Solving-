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
            //Hide the perimeter and answer labels and answers when the user clicks on the calculate button
            this.lblPerimeter.Hide();
            this.lblPerimterAnswer.Hide();
            this.lblWidth.Hide();
            this.lblWidthAnswer.Hide();
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

        }
    }
}
