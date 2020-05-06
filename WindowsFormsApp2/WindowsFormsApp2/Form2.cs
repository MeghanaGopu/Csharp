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

            // File.AppendAllText(@"C: \Users\Meghana\Desktop\students.txt","" + Environment.NewLine);
            
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