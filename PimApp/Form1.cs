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
            //Convert the text to a number
			btnNumber = Convert.ToInt16(lblClicks.Text);
			//adds one to the number
            btnNumber++;
			//Convert number to text and place it in the label
            lblClicks.Text = btnNumber.ToString();
        


        }

      

        private void btnPimButton_Click(object sender, EventArgs e)
        {
            //Insert the word Pim plus whatever is already there
            txtPim.Text = "Pim" + txtPim.Text;
            //Convert PimNumber from Text to an integer (a whole number)
            btnPimNumber = Convert.ToInt16(lblPimClick.Text);
            //add 1 to PumNumber
            btnPimNumber++;
            //Make PimCick PimButtonNumber
            lblPimClick.Text = btnPimNumber.ToString();

        }

    }
}
