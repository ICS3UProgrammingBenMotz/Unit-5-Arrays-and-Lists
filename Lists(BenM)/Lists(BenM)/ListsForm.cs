/*
 * Created by: Ben M
 * Created on: 5-12-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #39 - Lists
 * This program assignes entered values to a list then calculates their average
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

namespace Lists_BenM_
{
    public partial class frmLists : Form
    {
        //creates list
        List<int> myListOfInts = new List<int>();

        //creates number of entries variables
        int numbOfEntries = 0;

        public frmLists()
        {
            InitializeComponent();
        }

        //creates function
        private int CalculateAverage(ref int total)
        {
            //creates int for average
            int average;

            //average=total divided by numb of entries
            average = total / numbOfEntries;

            //returns average
            return average;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //declares variables
            int userMark = -1;

            //converts to an interger
            try
            {
                userMark = int.Parse(txtScores.Text);
            }

            //if user doesn't eneter a valid number
            catch (Exception parseError)
            {
                Console.WriteLine("An error occurred: '{0}'", parseError);
            }

            //checks if the entry is valid
            if ( ( userMark >= 0 ) && ( userMark <= 100) )
            {
                lstScores.Items.Add(userMark);

                myListOfInts.Add(userMark);

                numbOfEntries++;
            }
            else
            {
                MessageBox.Show("Please enter a number between 0 and 100", "Invalid Number");
            }
            
            

        }

        private void lblAverage_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcuAver_Click(object sender, EventArgs e)
        {
            //creates variables
            int userTotal;
            int userAverage;

            //user total will add up the list's sum
            userTotal = myListOfInts.Sum();

            //calls calculate average function
            userAverage = CalculateAverage(ref userTotal);

            //Displays average
            lblAverage.Text = "Your average is: " + userAverage;
        }
    }
}
