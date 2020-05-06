using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        Form1 fgrid;
        public Form2(Form1 fg)
        {
            InitializeComponent();
            this.fgrid = fg;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
               TextWriter txt =new StreamWriter(@"C: \Users\Meghana\Desktop\students.txt",true);

            if (textBox1.Text == string.Empty)
            {
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "Please enter the Surname");
            }
            if (textBox2.Text == string.Empty)
            {
                textBox2.Focus();
                errorProvider2.SetError(textBox2, "Please enter the Name");
            }
            if (textBox3.Text == string.Empty)
            {
                textBox3.Focus();
                errorProvider3.SetError(textBox3, "Enter marks of HW1- Value between 0-10");
            }
            if (textBox4.Text == string.Empty)
            {
                textBox4.Focus();
                errorProvider4.SetError(textBox4, "Enter marks of HW2 - Value between 0-10");
            }
            if (textBox5.Text == string.Empty)
            {
                textBox5.Focus();
                errorProvider5.SetError(textBox5, "Enter marks of HW3- Value between 0-10");
            }
            if (textBox6.Text == string.Empty)
            {
                textBox6.Focus();
                errorProvider6.SetError(textBox6, "Enter marks of HW4- Value between 0-10");
            }
            if (textBox7.Text == string.Empty)
            {
                textBox7.Focus();
                errorProvider7.SetError(textBox7, "Enter marks of HW5- Value between 0-10");
            }
            if (textBox8.Text == string.Empty)
            {
                textBox8.Focus();
                errorProvider8.SetError(textBox8, "Enter marks of Exam- Value between 0-10");
            }

            txt.Write(textBox1.Text);
               txt.Write("/");
               txt.Write(textBox2.Text);
               txt.Write("/");
               txt.Write(textBox3.Text);
               txt.Write("/");
               txt.Write(textBox4.Text);
               txt.Write("/");
               txt.Write(textBox5.Text);
               txt.Write("/");
               txt.Write(textBox6.Text);
               txt.Write("/");
               txt.Write(textBox7.Text);
               txt.Write("/");
               txt.Write(textBox8.Text);
               txt.Write("\r");



            txt.Close();

               
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
    }
}