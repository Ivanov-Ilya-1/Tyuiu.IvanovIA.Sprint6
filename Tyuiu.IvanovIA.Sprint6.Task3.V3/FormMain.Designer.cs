namespace Tyuiu.IvanovIA.Sprint6.Task3.V3
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxСondition_CMV = new GroupBox();
            textBoxTask_CMV = new TextBox();
            dataGridViewMatrix_CMV = new DataGridView();
            groupBoxOutput_CMV = new GroupBox();
            dataGridViewResult_CMV = new DataGridView();
            labelResult_CMV = new Label();
            buttonDone_CMV = new Button();
            buttonHelp_CMV = new Button();
            groupBoxСondition_CMV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_CMV).BeginInit();
            groupBoxOutput_CMV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_CMV).BeginInit();
            SuspendLayout();
            // 
            // groupBoxСondition_CMV
            // 
            groupBoxСondition_CMV.Controls.Add(textBoxTask_CMV);
            groupBoxСondition_CMV.Controls.Add(dataGridViewMatrix_CMV);
            groupBoxСondition_CMV.Location = new Point(12, 12);
            groupBoxСondition_CMV.Name = "groupBoxСondition_CMV";
            groupBoxСondition_CMV.Size = new Size(416, 310);
            groupBoxСondition_CMV.TabIndex = 7;
            groupBoxСondition_CMV.TabStop = false;
            groupBoxСondition_CMV.Tag = "";
            groupBoxСondition_CMV.Text = "Условие";
            // 
            // textBoxTask_CMV
            // 
            textBoxTask_CMV.BorderStyle = BorderStyle.None;
            textBoxTask_CMV.Location = new Point(6, 22);
            textBoxTask_CMV.Multiline = true;
            textBoxTask_CMV.Name = "textBoxTask_CMV";
            textBoxTask_CMV.ReadOnly = true;
            textBoxTask_CMV.Size = new Size(217, 192);
            textBoxTask_CMV.TabIndex = 0;
            textBoxTask_CMV.TabStop = false;
            textBoxTask_CMV.Text = "Дана матрица 5 на 5\r\n14   5  -9  18  21\r\n\r\n -5 -12 -12   4  28\r\n\r\n  27  -2 -14  23  27\r\n\r\n -19 -15  17  15   1\r\n\r\n  33   2   6  24  24\r\nВыполнить сортировку по возрастанию в третьем столбце.";
            // 
            // dataGridViewMatrix_CMV
            // 
            dataGridViewMatrix_CMV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix_CMV.ColumnHeadersVisible = false;
            dataGridViewMatrix_CMV.Location = new Point(243, 37);
            dataGridViewMatrix_CMV.Name = "dataGridViewMatrix_CMV";
            dataGridViewMatrix_CMV.RowHeadersVisible = false;
            dataGridViewMatrix_CMV.Size = new Size(167, 154);
            dataGridViewMatrix_CMV.TabIndex = 8;
            // 
            // groupBoxOutput_CMV
            // 
            groupBoxOutput_CMV.Controls.Add(dataGridViewResult_CMV);
            groupBoxOutput_CMV.Controls.Add(labelResult_CMV);
            groupBoxOutput_CMV.Location = new Point(434, 12);
            groupBoxOutput_CMV.Name = "groupBoxOutput_CMV";
            groupBoxOutput_CMV.Size = new Size(262, 258);
            groupBoxOutput_CMV.TabIndex = 9;
            groupBoxOutput_CMV.TabStop = false;
            groupBoxOutput_CMV.Text = "Вывод данных: ";
            // 
            // dataGridViewResult_CMV
            // 
            dataGridViewResult_CMV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_CMV.ColumnHeadersVisible = false;
            dataGridViewResult_CMV.Location = new Point(6, 37);
            dataGridViewResult_CMV.Name = "dataGridViewResult_CMV";
            dataGridViewResult_CMV.RowHeadersVisible = false;
            dataGridViewResult_CMV.Size = new Size(174, 154);
            dataGridViewResult_CMV.TabIndex = 1;
            // 
            // labelResult_CMV
            // 
            labelResult_CMV.AutoSize = true;
            labelResult_CMV.Location = new Point(6, 19);
            labelResult_CMV.Name = "labelResult_CMV";
            labelResult_CMV.Size = new Size(63, 15);
            labelResult_CMV.TabIndex = 0;
            labelResult_CMV.Text = "Результат:";
            // 
            // buttonDone_CMV
            // 
            buttonDone_CMV.Location = new Point(483, 276);
            buttonDone_CMV.Name = "buttonDone_CMV";
            buttonDone_CMV.Size = new Size(131, 37);
            buttonDone_CMV.TabIndex = 10;
            buttonDone_CMV.Text = "Выполнить";
            buttonDone_CMV.UseVisualStyleBackColor = true;
            buttonDone_CMV.Click += buttonDone_Click;
            // 
            // buttonHelp_CMV
            // 
            buttonHelp_CMV.FlatStyle = FlatStyle.Flat;
            buttonHelp_CMV.Location = new Point(434, 276);
            buttonHelp_CMV.Name = "buttonHelp_CMV";
            buttonHelp_CMV.Size = new Size(43, 37);
            buttonHelp_CMV.TabIndex = 11;
            buttonHelp_CMV.Text = "?";
            buttonHelp_CMV.UseVisualStyleBackColor = true;
            buttonHelp_CMV.Click += buttonHelp_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 325);
            Controls.Add(buttonHelp_CMV);
            Controls.Add(buttonDone_CMV);
            Controls.Add(groupBoxOutput_CMV);
            Controls.Add(groupBoxСondition_CMV);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 3 | Вариант 3 | Иванов И.А. ";
            Load += FormMain_Load;
            groupBoxСondition_CMV.ResumeLayout(false);
            groupBoxСondition_CMV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_CMV).EndInit();
            groupBoxOutput_CMV.ResumeLayout(false);
            groupBoxOutput_CMV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_CMV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxСondition_CMV;
        private TextBox textBoxTask_CMV;
        private DataGridView dataGridViewMatrix_CMV;
        private GroupBox groupBoxOutput_CMV;
        private Label labelResult_CMV;
        private Button buttonDone_CMV;
        private Button buttonHelp_CMV;
        private DataGridView dataGridViewResult_CMV;
    }
}