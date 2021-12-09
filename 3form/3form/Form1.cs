using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3form
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
                result.Text = ("Результат:\n");
                int[,] myArray = Input();
                int sizeArray = myArray.GetLength(0);
                result.Text += ("До изменения:");
                for (int i = 0; i < sizeArray; i++)
                {
                    result.Text += ("\n\t");
                    for (int j = 0; j < sizeArray; j++)
                    {
                        result.Text += ($"{myArray[i, j]} ");
                    }
                }
                teleport(myArray);


                result.Text += ("\n\nПосле изменения:");
                for (int i = 0; i < sizeArray; i++)
                {
                    result.Text += ("\n\t");
                    for (int j = 0; j < sizeArray; j++)
                    {
                        result.Text += ($"{myArray[i, j]} ");
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show(
                         "Введено не число!",
                         "Предупреждение",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Warning,
                         MessageBoxDefaultButton.Button3); 
            }
        }

        int[,] Input()
        {
            try
            {
                Random rnd = new Random();
                int n = int.Parse(textBox1.Text);
                int[,] a = new int[n, n];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        a[i, j] = rnd.Next(0,100);
                    }
                }
                return a;
            }
            catch (Exception)
            {
                throw;
            }
        }

        void teleport(int[,] a)
        {
            int sizeArray = a.GetLength(0);
            if (sizeArray % 2 == 0)
            {
                int[] buf = new int[sizeArray];
                for (int i = 0; i < sizeArray; i += 2)
                {
                    for (int j = 0; j < sizeArray; j++)
                    {
                        buf[j] = a[i, j];
                        a[i, j] = a[i + 1, j];
                        a[i + 1, j] = buf[j];
                    }
                }
            }
            else
                result.Text+=("\nВ массиве нечетное количество строк и столбцов - ничего не меняю.\n");
        }
    }
}