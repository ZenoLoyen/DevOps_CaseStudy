using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Case_Study_Forms_App
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnJobs_Click(object sender, EventArgs e)
        {
            Indeed form1 = new Indeed();
            form1.Show();
        }

        private void btnCar_Click(object sender, EventArgs e)
        {
            Cars form3 = new Cars();
            form3.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnYoutube_Click(object sender, EventArgs e)
        {
            YouTube form2 = new YouTube();
            form2.Show();
        }
    }
}
