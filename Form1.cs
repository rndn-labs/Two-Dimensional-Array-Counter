using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Two_Dimensional_Array_Sorter2
{
    public partial class Form1 : Form
    {
        int[,] matrix = new int[5, 5];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            matrix[0, 0] = Convert.ToInt32(a11.Text);
            matrix[0, 1] = Convert.ToInt32(a12.Text);
            matrix[0, 2] = Convert.ToInt32(a13.Text);
            matrix[0, 3] = Convert.ToInt32(a14.Text);
            matrix[0, 4] = Convert.ToInt32(a15.Text);
            matrix[1, 0] = Convert.ToInt32(a21.Text);
            matrix[1, 1] = Convert.ToInt32(a22.Text);
            matrix[1, 2] = Convert.ToInt32(a23.Text);
            matrix[1, 3] = Convert.ToInt32(a24.Text);
            matrix[1, 4] = Convert.ToInt32(a25.Text);
            matrix[2, 0] = Convert.ToInt32(a31.Text);
            matrix[2, 1] = Convert.ToInt32(a32.Text);
            matrix[2, 2] = Convert.ToInt32(a33.Text);
            matrix[2, 3] = Convert.ToInt32(a34.Text);
            matrix[2, 4] = Convert.ToInt32(a35.Text);
            matrix[3, 0] = Convert.ToInt32(a41.Text);
            matrix[3, 1] = Convert.ToInt32(a42.Text);
            matrix[3, 2] = Convert.ToInt32(a43.Text);
            matrix[3, 3] = Convert.ToInt32(a44.Text);
            matrix[3, 4] = Convert.ToInt32(a45.Text);
            matrix[4, 0] = Convert.ToInt32(a51.Text);
            matrix[4, 1] = Convert.ToInt32(a52.Text);
            matrix[4, 2] = Convert.ToInt32(a53.Text);
            matrix[4, 3] = Convert.ToInt32(a54.Text);
            matrix[4, 4] = Convert.ToInt32(a55.Text);





            dataGridView1.RowCount = 5;
            dataGridView1.ColumnCount = 5;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = matrix[i,j].ToString();
                }
            }
          
            label1.Text += Convert.ToString(matrix.Length);
        }
     
        private void doneMatrix_Enter(object sender, EventArgs e)
        {
          

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random r = new Random();
         

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = r.Next(-99, 99);

                }
            }
            dataGridView1.RowCount = 5;
            dataGridView1.ColumnCount = 5;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = matrix[i, j].ToString();
                }
            }
           
            label1.Text += Convert.ToString(matrix.Length);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] =0;

                }
            }
            dataGridView1.RowCount = 5;
            dataGridView1.ColumnCount = 5;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = null;
                }
            }
          
            label1.Text = "Количество чисел в массиве: ";
        }
    }
}
