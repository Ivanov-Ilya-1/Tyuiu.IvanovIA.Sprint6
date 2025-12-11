using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.IvanovIA.Sprint6.Task5.V3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelTop_BTO = new Panel();
            buttonDone_BTO = new Button();
            buttonOpenFile_BTO = new Button();
            buttonHelp_BTO = new Button();
            groupBoxTask_BTO = new GroupBox();
            textBoxTask_BTO = new TextBox();
            panelSplitContainer_BTO = new Panel();
            splitContainer_BTO = new SplitContainer();
            groupBoxOutput_BTO = new GroupBox();
            dataGridViewNums = new DataGridView();
            chartDiag = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelTop_BTO.SuspendLayout();
            groupBoxTask_BTO.SuspendLayout();
            panelSplitContainer_BTO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer_BTO).BeginInit();
            splitContainer_BTO.Panel1.SuspendLayout();
            splitContainer_BTO.Panel2.SuspendLayout();
            splitContainer_BTO.SuspendLayout();
            groupBoxOutput_BTO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartDiag).BeginInit();
            SuspendLayout();
            // 
            // panelTop_BTO
            // 
            panelTop_BTO.BackColor = Color.White;
            panelTop_BTO.Controls.Add(buttonDone_BTO);
            panelTop_BTO.Controls.Add(buttonOpenFile_BTO);
            panelTop_BTO.Controls.Add(buttonHelp_BTO);
            panelTop_BTO.Controls.Add(groupBoxTask_BTO);
            panelTop_BTO.Dock = DockStyle.Top;
            panelTop_BTO.Location = new Point(0, 0);
            panelTop_BTO.Margin = new Padding(3, 4, 3, 4);
            panelTop_BTO.Name = "panelTop_BTO";
            panelTop_BTO.Size = new Size(896, 133);
            panelTop_BTO.TabIndex = 1;
            // 
            // buttonDone_BTO
            // 
            buttonDone_BTO.BackColor = Color.FromArgb(0, 192, 0);
            buttonDone_BTO.Cursor = Cursors.Hand;
            buttonDone_BTO.Location = new Point(597, 33);
            buttonDone_BTO.Margin = new Padding(3, 4, 3, 4);
            buttonDone_BTO.Name = "buttonDone_BTO";
            buttonDone_BTO.Size = new Size(118, 87);
            buttonDone_BTO.TabIndex = 4;
            buttonDone_BTO.Text = "Выполнить";
            buttonDone_BTO.UseVisualStyleBackColor = false;
            buttonDone_BTO.Click += buttonDone_Click;
            // 
            // buttonOpenFile_BTO
            // 
            buttonOpenFile_BTO.BackColor = Color.FromArgb(128, 128, 255);
            buttonOpenFile_BTO.Cursor = Cursors.Hand;
            buttonOpenFile_BTO.Location = new Point(721, 33);
            buttonOpenFile_BTO.Margin = new Padding(3, 4, 3, 4);
            buttonOpenFile_BTO.Name = "buttonOpenFile_BTO";
            buttonOpenFile_BTO.Size = new Size(118, 87);
            buttonOpenFile_BTO.TabIndex = 5;
            buttonOpenFile_BTO.Text = "Открыть файл";
            buttonOpenFile_BTO.UseVisualStyleBackColor = false;
            buttonOpenFile_BTO.Click += buttonOpenFile_Click;
            // 
            // buttonHelp_BTO
            // 
            buttonHelp_BTO.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_BTO.BackColor = Color.FromArgb(0, 192, 0);
            buttonHelp_BTO.Cursor = Cursors.Hand;
            buttonHelp_BTO.Location = new Point(845, 33);
            buttonHelp_BTO.Margin = new Padding(3, 4, 3, 4);
            buttonHelp_BTO.Name = "buttonHelp_BTO";
            buttonHelp_BTO.Size = new Size(47, 44);
            buttonHelp_BTO.TabIndex = 6;
            buttonHelp_BTO.Text = "?";
            buttonHelp_BTO.UseVisualStyleBackColor = false;
            buttonHelp_BTO.Click += buttonHelp_Click;
            // 
            // groupBoxTask_BTO
            // 
            groupBoxTask_BTO.Controls.Add(textBoxTask_BTO);
            groupBoxTask_BTO.Location = new Point(6, 4);
            groupBoxTask_BTO.Margin = new Padding(3, 4, 3, 4);
            groupBoxTask_BTO.Name = "groupBoxTask_BTO";
            groupBoxTask_BTO.Padding = new Padding(3, 4, 3, 4);
            groupBoxTask_BTO.Size = new Size(584, 121);
            groupBoxTask_BTO.TabIndex = 3;
            groupBoxTask_BTO.TabStop = false;
            groupBoxTask_BTO.Text = "Условие:";
            // 
            // textBoxTask_BTO
            // 
            textBoxTask_BTO.Font = new Font("Segoe UI", 10.25F);
            textBoxTask_BTO.Location = new Point(7, 29);
            textBoxTask_BTO.Margin = new Padding(3, 4, 3, 4);
            textBoxTask_BTO.Multiline = true;
            textBoxTask_BTO.Name = "textBoxTask_BTO";
            textBoxTask_BTO.ReadOnly = true;
            textBoxTask_BTO.Size = new Size(567, 83);
            textBoxTask_BTO.TabIndex = 0;
            textBoxTask_BTO.Text = "Прочитать данные из файла InPutFileTask5V27.txt. Вывести в dataGridView. Вывести все числа не кратные 5. Построить диаграмму по этим значениям.\r\n";
            // 
            // panelSplitContainer_BTO
            // 
            panelSplitContainer_BTO.Controls.Add(splitContainer_BTO);
            panelSplitContainer_BTO.Dock = DockStyle.Fill;
            panelSplitContainer_BTO.Location = new Point(0, 133);
            panelSplitContainer_BTO.Margin = new Padding(3, 4, 3, 4);
            panelSplitContainer_BTO.Name = "panelSplitContainer_BTO";
            panelSplitContainer_BTO.Size = new Size(896, 455);
            panelSplitContainer_BTO.TabIndex = 2;
            // 
            // splitContainer_BTO
            // 
            splitContainer_BTO.Dock = DockStyle.Fill;
            splitContainer_BTO.Location = new Point(0, 0);
            splitContainer_BTO.Margin = new Padding(3, 4, 3, 4);
            splitContainer_BTO.Name = "splitContainer_BTO";
            // 
            // splitContainer_BTO.Panel1
            // 
            splitContainer_BTO.Panel1.BackColor = Color.White;
            splitContainer_BTO.Panel1.Controls.Add(groupBoxOutput_BTO);
            // 
            // splitContainer_BTO.Panel2
            // 
            splitContainer_BTO.Panel2.Controls.Add(chartDiag);
            splitContainer_BTO.Size = new Size(896, 455);
            splitContainer_BTO.SplitterDistance = 248;
            splitContainer_BTO.SplitterWidth = 5;
            splitContainer_BTO.TabIndex = 0;
            // 
            // groupBoxOutput_BTO
            // 
            groupBoxOutput_BTO.Controls.Add(dataGridViewNums);
            groupBoxOutput_BTO.Dock = DockStyle.Fill;
            groupBoxOutput_BTO.Location = new Point(0, 0);
            groupBoxOutput_BTO.Margin = new Padding(3, 4, 3, 4);
            groupBoxOutput_BTO.Name = "groupBoxOutput_BTO";
            groupBoxOutput_BTO.Padding = new Padding(3, 4, 3, 4);
            groupBoxOutput_BTO.Size = new Size(248, 455);
            groupBoxOutput_BTO.TabIndex = 0;
            groupBoxOutput_BTO.TabStop = false;
            groupBoxOutput_BTO.Text = "Вывод данных:";
            // 
            // dataGridViewNums
            // 
            dataGridViewNums.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNums.ColumnHeadersVisible = false;
            dataGridViewNums.Dock = DockStyle.Fill;
            dataGridViewNums.Location = new Point(3, 24);
            dataGridViewNums.Margin = new Padding(3, 4, 3, 4);
            dataGridViewNums.Name = "dataGridViewNums";
            dataGridViewNums.RowHeadersVisible = false;
            dataGridViewNums.RowHeadersWidth = 51;
            dataGridViewNums.Size = new Size(242, 427);
            dataGridViewNums.TabIndex = 0;
            // 
            // chartDiag
            // 
            chartArea1.Name = "ChartArea1";
            chartDiag.ChartAreas.Add(chartArea1);
            chartDiag.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartDiag.Legends.Add(legend1);
            chartDiag.Location = new Point(0, 0);
            chartDiag.Margin = new Padding(3, 4, 3, 4);
            chartDiag.Name = "chartDiag";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartDiag.Series.Add(series1);
            chartDiag.Size = new Size(643, 455);
            chartDiag.TabIndex = 0;
            chartDiag.Text = "chartDiag";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 588);
            Controls.Add(panelSplitContainer_BTO);
            Controls.Add(panelTop_BTO);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(912, 624);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 5 | Вариант 25 | Бaбенков Т. О. ";
            panelTop_BTO.ResumeLayout(false);
            groupBoxTask_BTO.ResumeLayout(false);
            groupBoxTask_BTO.PerformLayout();
            panelSplitContainer_BTO.ResumeLayout(false);
            splitContainer_BTO.Panel1.ResumeLayout(false);
            splitContainer_BTO.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer_BTO).EndInit();
            splitContainer_BTO.ResumeLayout(false);
            groupBoxOutput_BTO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartDiag).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelTop_BTO;
        private Panel panelSplitContainer_BTO;
        private SplitContainer splitContainer_BTO;
        private Button buttonDone_BTO;
        private Button buttonOpenFile_BTO;
        private Button buttonHelp_BTO;
        private GroupBox groupBoxTask_BTO;
        private TextBox textBoxTask_BTO;
        private GroupBox groupBoxOutput_BTO;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag;
        private DataGridView dataGridViewNums;
    }
}