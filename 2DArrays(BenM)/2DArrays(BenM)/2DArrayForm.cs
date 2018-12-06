/*
 * Created by: Ben M
 * Created on: 5-12=2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #38- 2D Arrays
 * This program displays a 2D array in a text box and then calculates its average
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

namespace _2DArrays_BenM_
{
    public partial class frm2DArray : Form
    {

        Random randNumbGen;

        public frm2DArray()
        {
            InitializeComponent();

            randNumbGen = new Random();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //clears listbox
            txtNumbers.Clear();

            //declares variables
            int width;
            int length;
            string pieText = null;
            int randNumb;
            int average;
            int total = 0;

            //assigns length and width to text boxes
            width = Convert.ToInt16(nudWidth.Value);
            length = Convert.ToInt16(nudHeight.Value);
            
            //creates array
            int[,]a2DArray = new int[width, length];

            //for loop for width
            for (int widthCount = 0; widthCount < width; widthCount++)
            {
                //for loop for length
                for (int lengthCount = 0; lengthCount < length; lengthCount++)
                {
                    //generates rand number
                    randNumb = randNumbGen.Next(0, 9 + 1);

                    //total will be added up
                    total = total + randNumb;

                    //inserts rand number in array
                    a2DArray[widthCount, lengthCount] = randNumb;

                    // join the random number to the piece of text that will then go into the listbox
                    pieText = pieText + " " + randNumb;

                }
                pieText = pieText + "\r" + "\n";
            }
            this.txtNumbers.Text=pieText;

            //calculates average
            average = total / a2DArray.Length;

            //displays average in a message box
            MessageBox.Show("The average is: " + average);
            
        }

        private void lstNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
