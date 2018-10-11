using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PimApp
{
    public partial class Form1 : Form
    {

        int btnNumber;
        //string Pim;
        int btnPimNumber;
       

        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            btnNumber = Convert.ToInt16(lblClicks.Text);
            btnNumber++;
            lblClicks.Text = btnNumber.ToString();
        


        }

      

        private void btnPimButton_Click(object sender, EventArgs e)
        {
            txtPim.Text = "Pim" + txtPim.Text;
            btnPimNumber = Convert.ToInt16(lblPimClick.Text);
            btnPimNumber++;
            lblPimClick.Text = btnPimNumber.ToString();

        }

    }
}
