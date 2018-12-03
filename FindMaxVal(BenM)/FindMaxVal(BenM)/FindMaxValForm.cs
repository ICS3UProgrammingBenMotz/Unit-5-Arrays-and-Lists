/*
 * Created by: Ben M
 * Created on: 29-11-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #37 - Find Max Value
 * This program finds the max value
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

namespace FindMaxVal_BenM_
{
    public partial class frmFindMaxVal : Form
    {
        private int GetMaxValue(int[] tmpArrayOfInts)
        {
            int tmpMaxVal;

            int maxVal = -1;

            foreach (int value in tmpArrayOfInts)
            {
                tmpMaxVal = value;
                if (tmpMaxVal > maxVal)
                {
                    maxVal = tmpMaxVal ;
                }
            }

            return maxVal;
        }

        public frmFindMaxVal()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //creates max Val
            const int MAX_VAL = -1;

            const int MAX_ARRAY_SIZE = 10;

            int displayVal;

            //creates random number generator
            Random randNumbGen = new Random();

            //clears list box
            this.lstNumbs.Items.Clear();

            //Creates array
            int[] arrOfNumbs = new int[MAX_ARRAY_SIZE];

            int randNumb, counter;

            for (counter = 0; counter < MAX_ARRAY_SIZE; counter++)
            {
                //generates number
                randNumb = randNumbGen.Next(1, 500+1);

                //puts it in the array
                arrOfNumbs[counter] = randNumb;

                //adds numb ot lst box
                lstNumbs.Items.Add(randNumb);

                //refrehses list box
                this.Refresh();
            }

            displayVal = GetMaxValue(arrOfNumbs);

            MessageBox.Show("The max value is: " + displayVal);
        }
    }
}
