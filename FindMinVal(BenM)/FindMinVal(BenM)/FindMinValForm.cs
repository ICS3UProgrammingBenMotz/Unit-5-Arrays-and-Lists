/*
 * Created by: Ben Motz
 * Created on: 3-12-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #37 - Find Min Value
 * This program finds a min value in a list box
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

namespace FindMinVal_BenM_
{
    public partial class frmFindMinVal : Form
    {
        private int FindMinVal(int[] array)
        {
            int tmpValue;
            int minValue = 501;

                foreach (int value in array)
                {
                   tmpValue = value;
                    if (tmpValue < minValue)
                    {
                      minValue = tmpValue;
                    }
                }
           
        
            return minValue;
        }

        public frmFindMinVal()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //creates max Val
            const int MIN_VAL=501;

            const int MAX_ARRAY_SIZE = 10;

            int displayVal;

            //creates random number generator
            Random randNumbGen = new Random();

            //clears list box
            lstMinVals.Items.Clear();

            //Creates array
            int[] arrOfNumbs = new int [MAX_ARRAY_SIZE];

            int randNumb, counter;

            for (counter=0; counter <MAX_ARRAY_SIZE; counter++)
            {
                //generates number
                randNumb = randNumbGen.Next(1, MIN_VAL + 1);

                //puts it in the array
                arrOfNumbs[counter] = randNumb;

                //adds numb ot lst box
                lstMinVals.Items.Add(randNumb);

                //refrehses list box
                this.Refresh();
            }
            displayVal = FindMinVal(arrOfNumbs);

            MessageBox.Show("The min value is: " + displayVal);
        }
    }
}
