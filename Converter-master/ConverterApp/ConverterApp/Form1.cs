using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConverterApp
// This program was written by Gail Mosdell - Modified and adapted by Sean Danzo :)
// It forms the base of a converter program for the OS-Assessment Two for Cert IV
// Date : February 2017
{
    public partial class frm_Main : Form
    {

        public frm_Main()//initialise the main form that is displayed to the user
        {
            InitializeComponent();
        }

        // Global Variables and Constants
        double dbl_UofM, dbl_Convert;
        double[] UserInput = new double[5];
        string[] ListResults = new string[5];

        public int count = 0;


        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // exit program when clicked ^
        }
        private void button4_Click(object sender, EventArgs e)
        {
            for (int displaycount = 0; displaycount < 5; displaycount++)
            {
                txt_Result.AppendText(ListResults[displaycount] + Environment.NewLine);
            }
        }
        private void btn_CM_to_Inches_Click(object sender, EventArgs e)
        {
            const double CM_TO_INCH = 0.3937;
            //User enters a value that is multiplied by 0.3937
            UserInput[0] = dbl_Convert;
            //Validate user entry and convert to a double
            if (count >= 5)
            {
                MessageBox.Show("You've hit your limit of 5 conversions. \nPlease click on 'Clear Array' and start over.");
            }
            else
            {
                if (!double.TryParse(txt_UnitOfMeasure.Text, out dbl_UofM))
                {
                    MessageBox.Show("A numeric must be entered. Please re-enter the value.");
                    txt_UnitOfMeasure.Clear();
                    txt_UnitOfMeasure.Focus();
                    txt_Convert.Clear();
                    lbl_Convert.Text = "";
                    lbl_Display.Text = "";
                }
                else
                {
                    dbl_Convert = dbl_UofM * CM_TO_INCH;
                    txt_Convert.Text = dbl_Convert.ToString();
                    lbl_Display.Text = txt_UnitOfMeasure.Text + " centimetres equals ";
                    lbl_Convert.Text = " inches.";
                    ListResults[count] = lbl_Display.Text + txt_Convert.Text + lbl_Convert.Text;
                    count++;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const double CELCIUS_TO_FAH = 1.8;
            UserInput[1] = dbl_Convert;
            // validate user entry and convert to a double
            if (count >= 5)
            {
                MessageBox.Show("You've hit your limit of 5 conversions. \nPlease click on 'Clear Array' and start over.");
            }
            else
            {
                if (!double.TryParse(txt_UnitOfMeasure.Text, out dbl_UofM))
                {
                    MessageBox.Show("A numeric must be entered. Please re-enter the value.");
                    txt_UnitOfMeasure.Clear();
                    txt_UnitOfMeasure.Focus();
                    txt_Convert.Clear();
                    lbl_Convert.Text = "";
                    lbl_Display.Text = "";
                }
                else
                {
                    dbl_Convert = (dbl_UofM * CELCIUS_TO_FAH + 32);
                    txt_Convert.Text = dbl_Convert.ToString();
                    lbl_Display.Text = txt_UnitOfMeasure.Text + " celcius equals ";
                    lbl_Convert.Text = " Fahrenheit.";
                    ListResults[count] = lbl_Display.Text + txt_Convert.Text + lbl_Convert.Text;
                    count++;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            const double CM_TO_FEET = 0.0328084;
            UserInput[2] = dbl_Convert;
            // validate user entry and convert to a double
            if (count >= 5)
            {
                MessageBox.Show("You've hit your limit of 5 conversions. \nPlease click on 'Clear Array' and start over.");
            }
            else
            {
                if (!double.TryParse(txt_UnitOfMeasure.Text, out dbl_UofM))
                {
                    MessageBox.Show("A numeric must be entered. Please re-enter the value.");
                    txt_UnitOfMeasure.Clear();
                    txt_UnitOfMeasure.Focus();
                    txt_Convert.Clear();
                    lbl_Convert.Text = "";
                    lbl_Display.Text = "";
                }
                else
                {
                    dbl_Convert = dbl_UofM * CM_TO_FEET;
                    txt_Convert.Text = dbl_Convert.ToString();
                    lbl_Display.Text = txt_UnitOfMeasure.Text + " centimetres equals ";
                    lbl_Convert.Text = " feet.";
                    ListResults[count] = lbl_Display.Text + txt_Convert.Text + lbl_Convert.Text;
                    count++;
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            const double KM_TO_MILES = 0.621371;
            UserInput[4] = dbl_Convert;
            // validate user entry and convert to a double
            if (count >= 5)
            {
                MessageBox.Show("You've hit your limit of 5 conversions. \nPlease click on 'Clear Array' and start over.");
            }
            else
            {
                if (!double.TryParse(txt_UnitOfMeasure.Text, out dbl_UofM))
                {
                    MessageBox.Show("A numeric must be entered. Please re-enter the value.");
                    txt_UnitOfMeasure.Clear();
                    txt_UnitOfMeasure.Focus();
                    txt_Convert.Clear();
                    lbl_Convert.Text = "";
                    lbl_Display.Text = "";
                }
                else
                {
                    dbl_Convert = dbl_UofM * KM_TO_MILES;
                    txt_Convert.Text = dbl_Convert.ToString();
                    lbl_Display.Text = txt_UnitOfMeasure.Text + " Kilometers equals ";
                    lbl_Convert.Text = " miles.";
                    ListResults[count] = lbl_Display.Text + txt_Convert.Text + lbl_Convert.Text;
                    count++;
                }
            }
        }

        private void button4_Click_1(object sender, EventArgs e) //The ListResults array position depends on the value of count. Setting it to zero will allow the user to start over.
        {
            count = 0;
            MessageBox.Show("Array cleared.");
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            MessageBox.Show("List cleared.");
            txt_Result.Clear(); //Empty the text box
        }

        private void btn_M_to_Feet_Click(object sender, EventArgs e)
        {
            const double M_TO_FEET = 3.28084;
            UserInput[3] = dbl_Convert;
            // validate user entry and convert to a double
            if (count >= 5)
            {
                MessageBox.Show("You've hit your limit of 5 conversions. \nPlease click on 'Clear Array' and start over.");
            }
            else
            {
                if (!double.TryParse(txt_UnitOfMeasure.Text, out dbl_UofM))
                {
                    MessageBox.Show("A numeric must be entered. Please re-enter the value.");
                    txt_UnitOfMeasure.Clear();
                    txt_UnitOfMeasure.Focus();
                    txt_Convert.Clear();
                    lbl_Convert.Text = "";
                    lbl_Display.Text = "";
                }
                else
                {
                    dbl_Convert = dbl_UofM * M_TO_FEET;
                    txt_Convert.Text = dbl_Convert.ToString();
                    lbl_Display.Text = txt_UnitOfMeasure.Text + " metres equals ";
                    lbl_Convert.Text = " feet.";
                    ListResults[count] = txt_UnitOfMeasure.Text + lbl_Display.Text + txt_Convert.Text + lbl_Convert.Text;
                    count++;
                }
            }
        }
    }
}
