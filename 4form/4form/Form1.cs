using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                result.Text = ("Результат:");
                int[][] myArray = Input();
                int sizeArray = myArray.GetLength(0);
                for (int i = 0; i < sizeArray; i++)
                {
                    result.Text+=("\n\t");
                    for (int j = 0; j < sizeArray; j++)
                    {

                        result.Text +=($"{myArray[i][j]} ");
                    }
                }

                int[] countMore = countingMore(myArray);

                result.Text += ("\n\nЧисел в строках превышающих:");
                for (int i = 0; i < sizeArray; i++)
                {

                    result.Text += ($"\n\t{countMore[i]}");
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                         "Вы ввели не число!",
                         "Предупреждение",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Warning,
                         MessageBoxDefaultButton.Button3);
            }

        }

        int[][] Input()
        {
            Random rnd = new Random();
            int n = int.Parse(textBox1.Text);
            int[][] a = new int[n][];
            for (int i = 0; i < n; i++)
            {
                a[i] = new int[n];
                for (int j = 0; j < n; j++)
                {
                    a[i][j] = rnd.Next(0,100);
                }
            }
            return a;
        }

        int[] countingMore(int[][] a)
        {
            try
            {
                int n = a.Length;
                int whoMore = int.Parse(textBox2.Text);
                int[] count = new int[n];
                for (int i = 0; i < n; i++)
                {
                    count[i] = 0;
                    for (int j = 0; j < n; j++)
                    {
                        if (a[i][j] > whoMore)
                            count[i]++;
                    }
                }
                return count;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
