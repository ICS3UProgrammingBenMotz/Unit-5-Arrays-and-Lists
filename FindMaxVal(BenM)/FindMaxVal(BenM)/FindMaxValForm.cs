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
            tmpMaxVal;

            return tmpMaxVal;
        }

        public frmFindMaxVal()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //delcares variables
            const int MAX_ARRAY_SIZE = 10;
            const int MAX_RANDOM_NUMB = 500;
            int[] arrayOfInts = new int[MAX_ARRAY_SIZE];
            int counter, randNumb, maxVal;

            //gets max value in array
            maxVal = GetMaxValue(arrayOfInts);
        }
    }
}
