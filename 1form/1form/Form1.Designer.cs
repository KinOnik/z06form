namespace _1form
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDualN = new System.Windows.Forms.TextBox();
            this.textBoxDualM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.startBarrier = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.stopBarrier = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Barrier = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.Label();
            this.result2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество элементов одномерного массива:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBox1.Location = new System.Drawing.Point(17, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 32);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(542, 539);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 65);
            this.button1.TabIndex = 3;
            this.button1.Text = "Итоги";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(681, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(473, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Количество элементов двумерного массива:";
            // 
            // textBoxDualN
            // 
            this.textBoxDualN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBoxDualN.Location = new System.Drawing.Point(686, 47);
            this.textBoxDualN.Name = "textBoxDualN";
            this.textBoxDualN.Size = new System.Drawing.Size(100, 32);
            this.textBoxDualN.TabIndex = 1;
            // 
            // textBoxDualM
            // 
            this.textBoxDualM.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBoxDualM.Location = new System.Drawing.Point(817, 47);
            this.textBoxDualM.Name = "textBoxDualM";
            this.textBoxDualM.Size = new System.Drawing.Size(100, 32);
            this.textBoxDualM.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(681, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(463, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Диапазон поиска, начало (строка, столбец):";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // startBarrier
            // 
            this.startBarrier.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.startBarrier.Location = new System.Drawing.Point(686, 146);
            this.startBarrier.Name = "startBarrier";
            this.startBarrier.Size = new System.Drawing.Size(100, 32);
            this.startBarrier.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.Location = new System.Drawing.Point(681, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(450, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Диапазон поиска, конец (строка, столбец):";
            // 
            // stopBarrier
            // 
            this.stopBarrier.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.stopBarrier.Location = new System.Drawing.Point(686, 248);
            this.stopBarrier.Name = "stopBarrier";
            this.stopBarrier.Size = new System.Drawing.Size(100, 32);
            this.stopBarrier.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label5.Location = new System.Drawing.Point(12, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(359, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "Диапазон поиска (начало, конец):";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Barrier
            // 
            this.Barrier.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Barrier.Location = new System.Drawing.Point(17, 155);
            this.Barrier.Name = "Barrier";
            this.Barrier.Size = new System.Drawing.Size(100, 32);
            this.Barrier.TabIndex = 1;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.result.Location = new System.Drawing.Point(12, 248);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(124, 26);
            this.result.TabIndex = 5;
            this.result.Text = "Результат:";
            // 
            // result2
            // 
            this.result2.AutoSize = true;
            this.result2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.result2.Location = new System.Drawing.Point(690, 322);
            this.result2.Name = "result2";
            this.result2.Size = new System.Drawing.Size(124, 26);
            this.result2.TabIndex = 6;
            this.result2.Text = "Результат:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 616);
            this.Controls.Add(this.result2);
            this.Controls.Add(this.result);
            this.Controls.Add(this.textBoxDualM);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.stopBarrier);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Barrier);
            this.Controls.Add(this.startBarrier);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDualN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDualN;
        private System.Windows.Forms.TextBox textBoxDualM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox startBarrier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox stopBarrier;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Barrier;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label result2;
    }
}

