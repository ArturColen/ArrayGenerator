using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayGenerator
{
    public partial class FrmArrayGenerator : Form
    {
        public FrmArrayGenerator()
        {
            InitializeComponent();
        }

        int[] vector;

        // Create a vector with the size provided by the user
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtQuantity.Text == "0")
            {
                MessageBox.Show("Forneça o tamanho do vetor!");
            }
            else
            {
                lstElements.Items.Clear();

                vector = new int[int.Parse(txtQuantity.Text)];

                btnFillIn.Enabled = true;
                btnBiggest.Enabled = true;
                btnLowest.Enabled = true;
                btnQtZeros.Enabled = true;
                btnAverage.Enabled = true;

                for (int i = 0; i < vector.Length; i++)
                {
                    lstElements.Items.Add(vector[i]);
                }
            }
        }

        // Fill the vector with random numbers
        private void btnFillIn_Click(object sender, EventArgs e)
        {
            Random elements = new Random();
            lstElements.Items.Clear();

            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = elements.Next(0, 100);
                lstElements.Items.Add(vector[i]);
            }
        }

        // Display the biggest value of the vector
        private void btnBiggest_Click(object sender, EventArgs e)
        {
            int biggest = vector[0];
            int i;

            for (i = 0; i < vector.Length; i++)
            {
                if (vector[i] > biggest)
                {
                    biggest = vector[i];
                }
            }

            lblResults.Text = biggest.ToString();
        }

        // Display the lowest value of the vector
        private void btnLowest_Click(object sender, EventArgs e)
        {
            int lowest = vector[0];
            int i;

            for (i = 0; i < vector.Length; i++)
            {
                if (vector[i] < lowest)
                {
                    lowest = vector[i];
                }
            }

            lblResults.Text = lowest.ToString();
        }

        // Count the number of zeros present in the vector
        private void btnQtZeros_Click(object sender, EventArgs e)
        {
            int count = 0;
            int i;

            for (i = 0; i < vector.Length; i++)
            {
                if (vector[i] == 0)
                {
                    count++;
                }
            }

            lblResults.Text = count.ToString();
        }

        // Calculate the average of the values present in the vector
        private void btnAverage_Click(object sender, EventArgs e)
        {
            int i, sum = 0;
            double average;

            for (i = 0; i < vector.Length; i++)
            {
                sum += vector[i];
            }

            average = (double) sum / vector.Length;

            lblResults.Text = average.ToString("#, ##0.00");
        }
    }
}
