﻿namespace laba10_oaip_3_
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
            buttonSort = new Button();
            radioButtonSimplSort = new RadioButton();
            radioButtonFastSort = new RadioButton();
            listBox1 = new ListBox();
            trackBar1 = new TrackBar();
            label1 = new Label();
            textBoxCountOfElements = new TextBox();
            buttonCreateMas = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            labelChanges = new Label();
            labelRepits = new Label();
            labelTime = new Label();
            buttonFile = new Button();
            buttonForAnalyis = new Button();
            dataGridView1 = new DataGridView();
            buttonOpenFile = new Button();
            button1 = new Button();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonSort
            // 
            buttonSort.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSort.Location = new Point(901, 235);
            buttonSort.Name = "buttonSort";
            buttonSort.Size = new Size(104, 22);
            buttonSort.TabIndex = 0;
            buttonSort.Text = "Сортировать";
            buttonSort.UseVisualStyleBackColor = true;
            buttonSort.Click += buttonSort_Click;
            // 
            // radioButtonSimplSort
            // 
            radioButtonSimplSort.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            radioButtonSimplSort.AutoSize = true;
            radioButtonSimplSort.Checked = true;
            radioButtonSimplSort.Location = new Point(772, 160);
            radioButtonSimplSort.Name = "radioButtonSimplSort";
            radioButtonSimplSort.Size = new Size(105, 19);
            radioButtonSimplSort.TabIndex = 1;
            radioButtonSimplSort.TabStop = true;
            radioButtonSimplSort.Text = "Метод выбора";
            radioButtonSimplSort.UseVisualStyleBackColor = true;
            // 
            // radioButtonFastSort
            // 
            radioButtonFastSort.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            radioButtonFastSort.AutoSize = true;
            radioButtonFastSort.Location = new Point(772, 185);
            radioButtonFastSort.Name = "radioButtonFastSort";
            radioButtonFastSort.Size = new Size(179, 19);
            radioButtonFastSort.TabIndex = 2;
            radioButtonFastSort.Text = "Метод быстрой сортировки";
            radioButtonFastSort.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(7, 9);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(759, 424);
            listBox1.TabIndex = 4;
            // 
            // trackBar1
            // 
            trackBar1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            trackBar1.Location = new Point(772, 67);
            trackBar1.Maximum = 100000;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(138, 45);
            trackBar1.TabIndex = 5;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(777, 49);
            label1.Name = "label1";
            label1.Size = new Size(239, 15);
            label1.TabIndex = 6;
            label1.Text = "Выберите количество элементов массива";
            // 
            // textBoxCountOfElements
            // 
            textBoxCountOfElements.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxCountOfElements.Location = new Point(915, 76);
            textBoxCountOfElements.Name = "textBoxCountOfElements";
            textBoxCountOfElements.Size = new Size(88, 23);
            textBoxCountOfElements.TabIndex = 7;
            textBoxCountOfElements.TextChanged += textBoxCountOfElements_TextChanged;
            // 
            // buttonCreateMas
            // 
            buttonCreateMas.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCreateMas.Location = new Point(878, 115);
            buttonCreateMas.Name = "buttonCreateMas";
            buttonCreateMas.Size = new Size(127, 29);
            buttonCreateMas.TabIndex = 8;
            buttonCreateMas.Text = "Создать массив";
            buttonCreateMas.UseVisualStyleBackColor = true;
            buttonCreateMas.Click += buttonCreateMas_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(784, 279);
            label3.Name = "label3";
            label3.Size = new Size(151, 15);
            label3.TabIndex = 11;
            label3.Text = "Количество перестановок";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(784, 305);
            label4.Name = "label4";
            label4.Size = new Size(134, 15);
            label4.TabIndex = 12;
            label4.Text = "Количество сравнений";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(784, 333);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 13;
            label5.Text = "Время";
            // 
            // labelChanges
            // 
            labelChanges.Anchor = AnchorStyles.Right;
            labelChanges.AutoSize = true;
            labelChanges.Location = new Point(941, 279);
            labelChanges.Name = "labelChanges";
            labelChanges.Size = new Size(12, 15);
            labelChanges.TabIndex = 14;
            labelChanges.Text = "-";
            // 
            // labelRepits
            // 
            labelRepits.Anchor = AnchorStyles.Right;
            labelRepits.AutoSize = true;
            labelRepits.Location = new Point(923, 305);
            labelRepits.Name = "labelRepits";
            labelRepits.Size = new Size(12, 15);
            labelRepits.TabIndex = 15;
            labelRepits.Text = "-";
            // 
            // labelTime
            // 
            labelTime.Anchor = AnchorStyles.Right;
            labelTime.AutoSize = true;
            labelTime.Location = new Point(832, 333);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(12, 15);
            labelTime.TabIndex = 16;
            labelTime.Text = "-";
            // 
            // buttonFile
            // 
            buttonFile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonFile.Location = new Point(901, 9);
            buttonFile.Margin = new Padding(3, 2, 3, 2);
            buttonFile.Name = "buttonFile";
            buttonFile.Size = new Size(115, 22);
            buttonFile.TabIndex = 17;
            buttonFile.Text = "Создать файл";
            buttonFile.UseVisualStyleBackColor = true;
            buttonFile.Click += buttonFile_Click;
            // 
            // buttonForAnalyis
            // 
            buttonForAnalyis.Anchor = AnchorStyles.Bottom;
            buttonForAnalyis.Location = new Point(533, 508);
            buttonForAnalyis.Margin = new Padding(3, 2, 3, 2);
            buttonForAnalyis.Name = "buttonForAnalyis";
            buttonForAnalyis.Size = new Size(227, 22);
            buttonForAnalyis.TabIndex = 18;
            buttonForAnalyis.Text = "Запустить сравнительный анализ";
            buttonForAnalyis.UseVisualStyleBackColor = true;
            buttonForAnalyis.Click += buttonForAnalyis_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridView1.Location = new Point(7, 444);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(520, 141);
            dataGridView1.TabIndex = 19;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonOpenFile.Location = new Point(776, 9);
            buttonOpenFile.Margin = new Padding(3, 2, 3, 2);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(116, 22);
            buttonOpenFile.TabIndex = 20;
            buttonOpenFile.Text = "Открыть файл";
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(923, 508);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 21;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(776, 210);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(132, 19);
            checkBox1.TabIndex = 22;
            checkBox1.Text = "Записывать в файл";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1033, 596);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(buttonOpenFile);
            Controls.Add(dataGridView1);
            Controls.Add(buttonForAnalyis);
            Controls.Add(buttonFile);
            Controls.Add(labelTime);
            Controls.Add(labelRepits);
            Controls.Add(labelChanges);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(buttonCreateMas);
            Controls.Add(textBoxCountOfElements);
            Controls.Add(label1);
            Controls.Add(trackBar1);
            Controls.Add(listBox1);
            Controls.Add(radioButtonFastSort);
            Controls.Add(radioButtonSimplSort);
            Controls.Add(buttonSort);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.RadioButton radioButtonSimplSort;
        private System.Windows.Forms.RadioButton radioButtonFastSort;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCountOfElements;
        private System.Windows.Forms.Button buttonCreateMas;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label labelChanges;
        private Label labelRepits;
        private Label labelTime;
        private Button buttonFile;
        private Button buttonForAnalyis;
        private DataGridView dataGridView1;
        private Button buttonOpenFile;
        private Button button1;
        private CheckBox checkBox1;
    }
}