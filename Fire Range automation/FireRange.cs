using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fire_Range_automation
{
    public partial class FireRange : Form
    {
        List<string> soldierID = new List<string> { };
        List<string> soldierName = new List<string> { };
        List<int> targetOneScore = new List<int> { };
        List<int> targetTwoScore = new List<int> { };
        List<int> targetThreeScore = new List<int> { };
        List<int> targetFourScore = new List<int> { };

        public FireRange()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(soldierNumBox.Text))
            {
                MessageBox.Show("Please enter soldier id number");
                return;
            }
            if (soldierID.Contains(soldierNumBox.Text))
            {
                MessageBox.Show("Soldier already exits");
                return;
            }
            if (String.IsNullOrEmpty(soldierNameBox.Text))
            {
                MessageBox.Show("Please enter soldier Name");
                return;
            }
            if (String.IsNullOrEmpty(scoreOneBox.Text))
            {
                MessageBox.Show("Please enter first score");
                return;
            }
            if (String.IsNullOrEmpty(scoreTwoBox.Text))
            {
                MessageBox.Show("Please enter second score");
                return;
            }
            if (String.IsNullOrEmpty(scoreThreeBox.Text))
            {
                MessageBox.Show("Please enter third score");
                return;
            }
            if (String.IsNullOrEmpty(scoreFourBox.Text))
            {
                MessageBox.Show("Please enter four score");
                return;
            }

            else
            {
                soldierID.Add(soldierNumBox.Text);
                soldierName.Add(soldierNameBox.Text);
                targetOneScore.Add(Convert.ToInt32(scoreOneBox.Text));
                targetTwoScore.Add(Convert.ToInt32(scoreTwoBox.Text));
                targetThreeScore.Add(Convert.ToInt32(scoreThreeBox.Text));
                targetFourScore.Add(Convert.ToInt32(scoreFourBox.Text));
            }
            string output = "";
            for (int i = 0; i < soldierID.Count(); i++)
            {
                output = "Soldier No: " + soldierID[i] + "\n" + "Soldier Name: " + soldierName[i] + "\n"
                         + "Target one score: " + targetOneScore[i] + "\n" + "Target two score: " + targetTwoScore[i] + "\n" + "Target three score: " + targetThreeScore[i] + "\n" + "Target four score: " + targetFourScore[i] + "\n\n";
            }
            outputRichBox.Text = output;

            soldierNumBox.Text = "";
            soldierNameBox.Text = "";
            scoreOneBox.Text = "";
            scoreTwoBox.Text = "";
            scoreThreeBox.Text = "";
            scoreFourBox.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void showAll_Click(object sender, EventArgs e)
        {
            string output = "";
            for (int i = 0; i < soldierID.Count(); i++)
            {
                output += "Soldier No: " + soldierID[i] + "\n" + "Soldier Name: " + soldierName[i] + "\n"
                          + "Target one score: " + targetOneScore[i] + "\n" + "Target two score: " + targetTwoScore[i] + "\n" + "Target three score: " + targetThreeScore[i] + "\n" + "Target four score: " + targetFourScore[i] + "\n\n";
            }
            outputRichBox.Text = output;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (soldierNoRadioButton.Checked == true)
            {
                if (soldierID.Contains(soldierNumBox.Text))
                {
                    int index = soldierID.IndexOf(soldierNumBox.Text);
                    var average = (targetOneScore[index] + targetTwoScore[index] + targetThreeScore[index] +
                                   targetFourScore[index]) / 4;
                    var total = (targetOneScore[index] + targetTwoScore[index] + targetThreeScore[index] +
                                   targetFourScore[index]);

                    var searchOutput = "Search Result\n" + "Soldier No: " + soldierID[index] + "\n" + "Soldier Name: " + soldierName[index] + "\n" +
                                    "Average score: " + average + "\n" + "Total Score:" + total;
                    outputRichBox.Text = searchOutput;
                }
                else
                {
                    MessageBox.Show("Data not available");
                }

            }

            if (soldierNameRadioButton.Checked == true)
            {
                if (soldierName.Contains(soldierNameBox.Text))
                {
                    int index = soldierName.IndexOf(soldierNameBox.Text);
                    var average = (targetOneScore[index] + targetTwoScore[index] + targetThreeScore[index] +
                                   targetFourScore[index]) / 4;
                    var total = (targetOneScore[index] + targetTwoScore[index] + targetThreeScore[index] +
                                 targetFourScore[index]);

                    var searchOutput = "Search Result\n" + "Soldier No: " + soldierID[index] + "\n" + "Soldier Name: " +
                                       soldierName[index] + "\n" +
                                       "Average score: " + average + "\n" + "Total Score:" + total;
                    outputRichBox.Text = searchOutput;
                }
                else
                {
                    MessageBox.Show("Data not available");
                }

                //top scorer
                //var max = (targetOneScore + targetTwoScore + targetThreeScore + targetFourScore).Max();
            }

        }
        }
}
