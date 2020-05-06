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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            string[] lines = File.ReadAllLines(@"C:\Users\Meghana\Desktop\students.txt");
            string[] values;
            string[] valuesn;

            Array.Sort(lines);

            for(int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split('/');
                string[] row = new string[values.Length];// string row had the values of surname and name

                for(int j = 0; j < 2; j++)
                {
                    row[j] = values[j].Trim();
                }
                

                double sum = 0;
                double average = 0;
                double median = 0;
               
                valuesn = lines[i].ToString().Split('/');
                double[] rown = new double[valuesn.Length];// double rown has the HW values

                for (int j = 2; j < valuesn.Length-1; j++)
                {       
                        rown[j] = Convert.ToDouble(valuesn[j].Trim());
                        sum += Convert.ToDouble(valuesn[j]);
                }

                average = sum / 5;

                
               Array.Sort(rown);
                
                if ((rown.Length) % 2 != 0)
                {
                 median = rown[2];//Convert.ToDouble(rown[valuesn.Length / 2]);
                }
                else
                {

                 median = (Convert.ToDouble(rown[(rown.Length+3) / 2]) + Convert.ToDouble(rown[(rown.Length+2) / 2])) / 2.0;
                   
                }





                double AHW = 0;
                double MHW = 0;
                valuesn = lines[i].ToString().Split('/');
                string[] rown1 = new string[valuesn.Length]; //string rown1 has exam value
                for (int j = 7; j < valuesn.Length; j++)
                {
                    rown1[j] = valuesn[j].Trim();
                }
                AHW = (0.3 * average) + (0.7 * Convert.ToDouble(rown1[7]));
                MHW = (0.3 * median) + (0.7 * Convert.ToDouble(rown1[7]));

                table.Rows.Add(row[0],row[1],AHW,MHW); // prints string row in the table

                

                //Console.WriteLine("AHW:" + average);

            }
            
        }
        DataTable table = new DataTable();
        private void Form1_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Surname", typeof(string));
            table.Columns.Add("Name", typeof(string));
           // table.Columns.Add("HW1", typeof(double));
           // table.Columns.Add("HW2", typeof(double));
            //table.Columns.Add("HW3", typeof(double));
           // table.Columns.Add("HW4", typeof(double));
           // table.Columns.Add("HW5", typeof(double));
           // table.Columns.Add("Exam", typeof(double));
            table.Columns.Add("AHW", typeof(double));
            table.Columns.Add("MHW", typeof(double));


            dataGridView1.DataSource = table;

        }

      //  private void button1_Click_1(object sender, EventArgs e)
      //  {
        //    foreach(DataGridViewRow row in dataGridView1.Rows)
         //   {
               

        //    }
            
       // }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Form2 finfo = new Form2(this);
            finfo.Show();
            
        }
    }
}
