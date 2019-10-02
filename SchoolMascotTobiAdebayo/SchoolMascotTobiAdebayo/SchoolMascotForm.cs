/*
 * Created by: Tobi Adebayo
 * Created on: 27-09-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #7 - Name of Program
 * This program  assign's a string literal to a label
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

namespace SchoolMascotTobiAdebayo
{
    public partial class SchoolMascotForm : Form
    {
        public SchoolMascotForm()
        {
            InitializeComponent();
        }

        private void ImmaculataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblSchoolName.Text = "Immaculata";
            lblSchoolMascot.Text = "Saints";
        }

        private void StJoesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblSchoolName.Text = "St. Joe's";
            lblSchoolMascot.Text = "Jaguars";
        }

        private void MotherTersaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblSchoolName.Text = "Mother Teresa";
            lblSchoolMascot.Text = "Titans";
        }

        private void StMarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblSchoolName.Text = "St. Marks";
            lblSchoolMascot.Text = "Lions";
        }

        private void GrbSchool_Enter(object sender, EventArgs e)
        {

        }

        private void MniSchools_Click(object sender, EventArgs e)
        {

        }
    }
}
