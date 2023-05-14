namespace laba10_oaip_3_
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
            this.buttonSort = new System.Windows.Forms.Button();
            this.radioButtonSimplSort = new System.Windows.Forms.RadioButton();
            this.radioButtonFastSort = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCountOfElements = new System.Windows.Forms.TextBox();
            this.buttonCreateMas = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelPerestanovka = new System.Windows.Forms.Label();
            this.labelSravnenia = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.buttonFile = new System.Windows.Forms.Button();
            this.buttonForAnalyis = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(1030, 290);
            this.buttonSort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(119, 29);
            this.buttonSort.TabIndex = 0;
            this.buttonSort.Text = "Сортировать";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // radioButtonSimplSort
            // 
            this.radioButtonSimplSort.AutoSize = true;
            this.radioButtonSimplSort.Location = new System.Drawing.Point(882, 214);
            this.radioButtonSimplSort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonSimplSort.Name = "radioButtonSimplSort";
            this.radioButtonSimplSort.Size = new System.Drawing.Size(132, 24);
            this.radioButtonSimplSort.TabIndex = 1;
            this.radioButtonSimplSort.TabStop = true;
            this.radioButtonSimplSort.Text = "Метод выбора";
            this.radioButtonSimplSort.UseVisualStyleBackColor = true;
            // 
            // radioButtonFastSort
            // 
            this.radioButtonFastSort.AutoSize = true;
            this.radioButtonFastSort.Location = new System.Drawing.Point(882, 258);
            this.radioButtonFastSort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonFastSort.Name = "radioButtonFastSort";
            this.radioButtonFastSort.Size = new System.Drawing.Size(224, 24);
            this.radioButtonFastSort.TabIndex = 2;
            this.radioButtonFastSort.TabStop = true;
            this.radioButtonFastSort.Text = "Метод быстрой сортировки";
            this.radioButtonFastSort.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(1, -1);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(867, 564);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(882, 89);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trackBar1.Maximum = 100000;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(158, 56);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(874, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Выберите количество элементов массива";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxCountOfElements
            // 
            this.textBoxCountOfElements.Location = new System.Drawing.Point(1046, 102);
            this.textBoxCountOfElements.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCountOfElements.Name = "textBoxCountOfElements";
            this.textBoxCountOfElements.Size = new System.Drawing.Size(100, 27);
            this.textBoxCountOfElements.TabIndex = 7;
            this.textBoxCountOfElements.TextChanged += new System.EventHandler(this.textBoxCountOfElements_TextChanged);
            // 
            // buttonCreateMas
            // 
            this.buttonCreateMas.Location = new System.Drawing.Point(1004, 153);
            this.buttonCreateMas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCreateMas.Name = "buttonCreateMas";
            this.buttonCreateMas.Size = new System.Drawing.Size(145, 39);
            this.buttonCreateMas.TabIndex = 8;
            this.buttonCreateMas.Text = "Создать массив";
            this.buttonCreateMas.UseVisualStyleBackColor = true;
            this.buttonCreateMas.Click += new System.EventHandler(this.buttonCreateMas_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(896, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Количество перестановок";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(896, 407);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "количество сравнений";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(896, 444);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Время";
            // 
            // labelPerestanovka
            // 
            this.labelPerestanovka.AutoSize = true;
            this.labelPerestanovka.Location = new System.Drawing.Point(1093, 412);
            this.labelPerestanovka.Name = "labelPerestanovka";
            this.labelPerestanovka.Size = new System.Drawing.Size(15, 20);
            this.labelPerestanovka.TabIndex = 14;
            this.labelPerestanovka.Text = "-";
            // 
            // labelSravnenia
            // 
            this.labelSravnenia.AutoSize = true;
            this.labelSravnenia.Location = new System.Drawing.Point(1093, 447);
            this.labelSravnenia.Name = "labelSravnenia";
            this.labelSravnenia.Size = new System.Drawing.Size(15, 20);
            this.labelSravnenia.TabIndex = 15;
            this.labelSravnenia.Text = "-";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(1014, 444);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(15, 20);
            this.labelTime.TabIndex = 16;
            this.labelTime.Text = "-";
            // 
            // buttonFile
            // 
            this.buttonFile.Location = new System.Drawing.Point(1030, 12);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(131, 29);
            this.buttonFile.TabIndex = 17;
            this.buttonFile.Text = "Создать файл";
            this.buttonFile.UseVisualStyleBackColor = true;
            this.buttonFile.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // buttonForAnalyis
            // 
            this.buttonForAnalyis.Location = new System.Drawing.Point(609, 677);
            this.buttonForAnalyis.Name = "buttonForAnalyis";
            this.buttonForAnalyis.Size = new System.Drawing.Size(259, 29);
            this.buttonForAnalyis.TabIndex = 18;
            this.buttonForAnalyis.Text = "Запустить сравнительный анализ";
            this.buttonForAnalyis.UseVisualStyleBackColor = true;
            this.buttonForAnalyis.Click += new System.EventHandler(this.buttonForAnalyis_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 570);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(565, 188);
            this.dataGridView1.TabIndex = 19;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(887, 12);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(132, 29);
            this.buttonOpenFile.TabIndex = 20;
            this.buttonOpenFile.Text = "Открыть файл";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1055, 677);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 21;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 770);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonForAnalyis);
            this.Controls.Add(this.buttonFile);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelSravnenia);
            this.Controls.Add(this.labelPerestanovka);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonCreateMas);
            this.Controls.Add(this.textBoxCountOfElements);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.radioButtonFastSort);
            this.Controls.Add(this.radioButtonSimplSort);
            this.Controls.Add(this.buttonSort);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Label labelPerestanovka;
        private Label labelSravnenia;
        private Label labelTime;
        private Button buttonFile;
        private Button buttonForAnalyis;
        private DataGridView dataGridView1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Button buttonOpenFile;
        private Button button1;
    }
}