using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2form
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
                result.Text = "Результат:\n";
                int indMax = 0, indMin = 0;
                int[] myArray = Input();
                double summ = 0;
                for (int i = 0; i < myArray.Length; i++)
                {
                    if (myArray[i] < myArray[indMin])
                        indMin = i;
                    if (myArray[i] > myArray[indMax])
                        indMax = i;
                }
                result.Text += ($"\nMax:{indMax + 1} min:{indMin + 1}");
                if (indMax < indMin)
                {
                    summ = Summ(myArray, indMax, indMin);
                    result.Text += ($"\nСумма элементов между максимальным и минимальными элементами(включительно): {summ}");
                }

                if (indMax > indMin)
                {
                    result.Text += ($"\nНарушен порядок(идет сначала минимальный, а затем максимальный элемент).");
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

        int[] Input()
        {
            Random rnd = new Random();
            int n = int.Parse(textBox1.Text);
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = rnd.Next(0, 100);
                result.Text += ($"{a[i]} ");
            }
            return a;
        }

        double Summ(int[] a, int startN, int stopN)
        {
            double sum = 0;
            for (int i = startN; i <= stopN; i++)
            {
                if (a[i] > 0) sum += a[i];
            }
            return sum;
        }
    }
}
