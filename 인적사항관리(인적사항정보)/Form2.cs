using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sample
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

      

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void ultraButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void ultraLabel1_Click(object sender, EventArgs e)
        {
            ultraLabel1.Appearance.TextHAlign = Infragistics.Win.HAlign.Center;
        }

        private void EngName(object sender, EventArgs e)
        {

            if (textBox1.Text == "Eng Name")
            {
                textBox1.Text = "";
            }
        }

        private void EngName1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Eng Name";
            }
        }

        private void ultraFormattedTextEditor5_LinkClicked(object sender, Infragistics.Win.FormattedLinkLabel.LinkClickedEventArgs e)
        {
            ultraFormattedTextEditor5.ForeColor = Color.Black;
        }

        private void ultraFormattedTextEditor17_LinkClicked(object sender, Infragistics.Win.FormattedLinkLabel.LinkClickedEventArgs e)
        {
            ultraFormattedTextEditor17.ForeColor = Color.Black;
        }

        private void ultraButton4_Click(object sender, EventArgs e)
        {
            ultraButton4.HotTrackAppearance.BackColor = Color.LightBlue;
        }

        private void ultraButton3_Click(object sender, EventArgs e)
        {
            ultraButton3.HotTrackAppearance.BackColor = Color.LightBlue;
        }

        private void ultraPanel1_PaintClient(object sender, PaintEventArgs e)
        {
            ultraFormattedTextEditor27.Enabled = false;
        }

        private void ultraFormattedTextEditor18_LinkClicked(object sender, Infragistics.Win.FormattedLinkLabel.LinkClickedEventArgs e)
        {
            ultraFormattedTextEditor18.ForeColor = Color.Black;
          
        }

        private void ultraFormattedTextEditor19_LinkClicked(object sender, Infragistics.Win.FormattedLinkLabel.LinkClickedEventArgs e)
        {
            ultraFormattedTextEditor19.ForeColor = Color.Black;
           
        }

        private void ultraFormattedTextEditor20_LinkClicked(object sender, Infragistics.Win.FormattedLinkLabel.LinkClickedEventArgs e)
        {
            ultraFormattedTextEditor20.ForeColor = Color.Black;
          
        }

        private void ultraFormattedTextEditor21_LinkClicked(object sender, Infragistics.Win.FormattedLinkLabel.LinkClickedEventArgs e)
        {
            ultraFormattedTextEditor21.ForeColor = Color.Black;
            
        }

        private void ultraFormattedTextEditor23_LinkClicked(object sender, Infragistics.Win.FormattedLinkLabel.LinkClickedEventArgs e)
        {
            ultraFormattedTextEditor23.ForeColor = Color.Black;
        }

        private void ultraFormattedTextEditor27_LinkClicked(object sender, Infragistics.Win.FormattedLinkLabel.LinkClickedEventArgs e)
        {
            ultraFormattedTextEditor27.ForeColor = Color.Black;
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            ultraFormattedTextEditor27.Enabled = checkBox12.Checked;
        }
        

        }
    
}
