/*
 * Created by: Ben M
 * Created on: 29-11-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #36 - Introduction to Arrays
 * This program calculates the average of random numbers
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

namespace ArrayAverage_BenM_
{
    public partial class Form1 : Form
    {
        //Creates conts and array
        const int MAX_ARRAY_SIZE=10;
        int[] arrayOfNumbers = new int[MAX_ARRAY_SIZE];


        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //creates variables
            int randNumber;
            int counter;
            Random randNumbGen = new Random();

            //Clears list box
            this.lstNumbs.Items.Clear();

            for (counter=0; counter < MAX_ARRAY_SIZE;counter++)
            {
                //generates new number
                randNumber = randNumbGen.Next(1, MAX_ARRAY_SIZE + 1);

                //assigns randNumb to counterin the array
                arrayOfNumbers[counter] = randNumber;

                //adds numb to list box
                this.lstNumbs.Items.Add(randNumber);
          
                //refreshes form
                this.Refresh();
            }
        }

        private void btnCalculateAv_Click(object sender, EventArgs e)
        {
            //declares variables
            double average = 0;
            double sum = 0;
            int counter;

            //calculates sum
            for (counter = 0; counter < arrayOfNumbers.Length; counter++)
            {
                sum = sum + arrayOfNumbers[counter];
            }

            //calculates sum
            average = sum / arrayOfNumbers.Length;

            //displdays average in message box
            MessageBox.Show("The average is: " + average);
        }
    }
}
