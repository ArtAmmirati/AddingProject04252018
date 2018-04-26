using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddingProject04252108
{
    public partial class Form1 : Form
    {
        double[] additionArray = new double[100];
        int i = 0;
        double total = 0;
      

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                if (this.textBox2.Text != "")
                {
                    listBox1.Items.Add(this.textBox2.Text);
                    additionArray[i] = double.Parse(textBox2.Text);
                    total = total + double.Parse(textBox2.Text);
                    textBox1.Text = total.ToString();
                    this.textBox2.Clear();
                    this.textBox2.Focus();

                }
                else
                {
                    MessageBox.Show("Please Enter a Number");

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
