using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ExampleForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBoxValidate(textBox1, textBox2)) {

                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);

                double b1 = b * b;
                double a1 = a * a;
                double c1 = a1 + b1;
                double c = Math.Sqrt(c1);
                double P = a + b + c;

                    resultLabel.Text = "Периметр = " + P;

            }
        }

        private bool textBoxValidate(params TextBox[] textBox) {

            bool result = true;

            foreach (TextBox t in textBox)
            {
                if (t.Text == "")
                {
                    errorProvider1.SetError(t, "Заполните поле");
                    result = false;
                }
                else errorProvider1.SetError(t, "");
            }

            return result;
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
