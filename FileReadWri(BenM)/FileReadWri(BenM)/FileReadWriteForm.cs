/*
 * Created by: Ben M
 * Created on: 6-12-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #40 - String Equality
 * This program checks if strings are equal
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

namespace FileReadWri_BenM_
{
    public partial class frmFileReadWrite : Form
    {
        //creates function
        private bool StringsAreEqual(string stringOne, string stringTwo)
        {
            bool isEqual;

            stringOne.ToLower();

            stringTwo.ToLower();

            

            if (stringOne==stringTwo)
            {
                isEqual = true;
            }
            else
            {
                isEqual = false;
            }
            return isEqual;
        }

        public frmFileReadWrite()
        {
            InitializeComponent();

            //hides label
            lblTextEqualOrNot.Hide();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //creates array for line
            string[] lines = System.IO.File.ReadAllLines(@"input.txt");

            //splits the line
            char[] charSeparators = new char[] { ' ', '\t' };

            //will determine where the results will be put
            string output = "";

            //compares strings
            foreach (string line in lines)
            {
                string[] words = line.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);

                if ((StringsAreEqual(words[0],words[1])) == true)
                    {
                    output = output + "True\r\n";
                    }
                else
                {
                    output = output + "False\r\n";
                }
            }
            //overwrites the file
            System.IO.File.WriteAllText(@"output.txt", output);

            //shows the label
            lblTextEqualOrNot.Show();
        }
    }
}
