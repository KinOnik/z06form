using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1form
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
                result.Text = ($"Результат:\n");
                result2.Text = ($"Результат:\n");
                int[] myArray = Input();
                double sumArray = Summ(myArray);
                result.Text += ($"\nСумма элементов массива: {sumArray}");

                //DualMassive
                int[,] myArrayDual = InputDual();
                double sumArrayDual = Summ(myArrayDual);
                result2.Text += ($"\nСумма элементов двумерного массива: {sumArrayDual}");
            }
            catch (Exception)
            {
                MessageBox.Show(
                       "Одно или более чисел имеет некорректное значение!",
                       "Предупреждение",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning,
                       MessageBoxDefaultButton.Button3);
            }

        }

        int[] Input()
        {
            Random rnd = new Random(20);
            int n = int.Parse(textBox1.Text);
            int[] a = new int[n];
            for (int i = 0; i < n; ++i)
            {
                a[i] = rnd.Next(0,100);
                result.Text += ($" {a[i]}");
            }
            result.Text += ($"\n");
            return a;
        }
        int[,] InputDual()
        {
            Random rnd = new Random();
            int n = int.Parse(textBoxDualN.Text);
            int m = int.Parse(textBoxDualM.Text);
            int[,] a = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = rnd.Next(0,100);
                    result2.Text += ($"\t {a[i,j]}");
                }
                result2.Text += "\n";
            }
            return a;
        }
        double Summ(int[] a)
        {
            bool excep = false;
            try
            {
                double sum = 0;
                string start = Barrier.Text;
                string[] borderStart = start.Split(',');
                int startN = int.Parse(borderStart[0]);
                int stopN = int.Parse(borderStart[1]);

                if (startN > a.Length || stopN > a.Length || startN < 1|| stopN<startN)
                {
                    excep = true;
                    throw new Exception("Ошибка при указании диапазона (выход за пределы или конец меньше начала).");
                }

                for (int i = startN - 1; i < stopN; i++)
                {
                    if (a[i] > 0) sum += a[i];
                }
                return sum;
            }
            catch (Exception e) when (excep)
            {
                MessageBox.Show(
                      $"{e}",
                      "Предупреждение",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Warning,
                      MessageBoxDefaultButton.Button3);
                return 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        double Summ(int[,] a)
        {
            bool excep = false;
            try
            {
                double sum = 0;
                string start = startBarrier.Text;
                string[] borderStart = start.Split(',');

                int startN = Convert.ToInt32(borderStart[0]);
                int startM = Convert.ToInt32(borderStart[1]);

                if (startN > a.GetLength(0) || startM > a.GetLength(1) || startN < 1 || startM < 1)
                {
                    excep = true;
                    throw new Exception("Ошибка при указании диапазона начала диапазона индексов (выход за пределы).");
                }

                string stop = stopBarrier.Text;
                string[] borderStop = stop.Split(',');

                int stopN = Convert.ToInt32(borderStop[0]);
                int stopM = Convert.ToInt32(borderStop[1]);
                if (stopN > a.GetLength(0) || stopM > a.GetLength(1) || stopN<startN||stopM<startM)
                {
                    excep = true;
                    throw new Exception("Ошибка при указании диапазона конца диапазона индексов (выход за пределы).");
                }

                for (int i = startN - 1; i < stopN; i++)
                {
                    for (int j = startM - 1; j < stopM; j++)
                    {
                        if (a[i, j] > 0) sum += a[i, j];
                    }
                }
                return sum;
            }
            catch (Exception e) when (excep)
            {
                MessageBox.Show(
                      $"{e}",
                      "Предупреждение",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Warning,
                      MessageBoxDefaultButton.Button3);
                return 0;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
