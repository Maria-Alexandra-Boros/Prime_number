using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prime_number
{
    public partial class Prime_number : Form
        {

        int result;
        int nrPrim = 0;
        int nrNeprim = 0;
        public Prime_number() {
        InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            

            bool isNumber = Int32.TryParse(numberTextBox.Text, out result);
            if (isNumber)
            { 
                int i;
                bool isPrime = true;
                for (i = 2; i <= result / 2; i++)
                {
                    if (result % i == 0)
                        isPrime = false;
                }
                if (isPrime == true)
                {
                    this.BackColor = Color.DarkCyan;
                    nrPrim++;
                    numerePrimeCounter.Text = "Numere prime introduse: " + nrPrim;
                }
                else
                {
                    this.BackColor = Color.Salmon;
                    nrNeprim++;
                    numereNeprimeCounter.Text = "Numere neprime introduse: " + nrNeprim;
                }

            }
            else
            { 
                MessageBox.Show("S-a introdus un text: " + numberTextBox.Text);
                this.BackColor = Color.Cornsilk;
            }
        }
    }
}
