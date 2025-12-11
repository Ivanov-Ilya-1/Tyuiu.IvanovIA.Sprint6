using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.IvanovIA.Sprint6.Task4.V26
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            panelTop_CMV = new Panel();
            buttonDone_CMV = new Button();
            buttonSave_CMV = new Button();
            buttonHelp_CMV = new Button();
            groupBoxInput_CMV = new GroupBox();
            labelStopValue_CMV = new Label();
            textBoxStopValue_CMV = new TextBox();
            labelStartValue_CMV = new Label();
            textBoxStartValue_CMV = new TextBox();
            groupBoxTask_CMV = new GroupBox();
            textBoxTask_CMV = new TextBox();
            panelLeft_CMV = new Panel();
            groupBoxResult_CMV = new GroupBox();
            textBoxResult_CMV = new TextBox();
            panelFill_CMV = new Panel();
            splitter_CMV = new Splitter();
            chartFunction_CMV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelTop_CMV.SuspendLayout();
            groupBoxInput_CMV.SuspendLayout();
            groupBoxTask_CMV.SuspendLayout();
            panelLeft_CMV.SuspendLayout();
            groupBoxResult_CMV.SuspendLayout();
            panelFill_CMV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_CMV).BeginInit();
            SuspendLayout();
            // 
            // panelTop_CMV
            // 
            panelTop_CMV.Controls.Add(buttonDone_CMV);
            panelTop_CMV.Controls.Add(buttonSave_CMV);
            panelTop_CMV.Controls.Add(buttonHelp_CMV);
            panelTop_CMV.Controls.Add(groupBoxInput_CMV);
            panelTop_CMV.Controls.Add(groupBoxTask_CMV);
            panelTop_CMV.Dock = DockStyle.Top;
            panelTop_CMV.Location = new Point(0, 0);
            panelTop_CMV.Margin = new Padding(3, 4, 3, 4);
            panelTop_CMV.Name = "panelTop_CMV";
            panelTop_CMV.Size = new Size(1067, 133);
            panelTop_CMV.TabIndex = 0;
            // 
            // buttonDone_CMV
            // 
            buttonDone_CMV.BackColor = Color.FromArgb(0, 192, 0);
            buttonDone_CMV.Cursor = Cursors.Hand;
            buttonDone_CMV.Location = new Point(760, 31);
            buttonDone_CMV.Margin = new Padding(3, 4, 3, 4);
            buttonDone_CMV.Name = "buttonDone_CMV";
            buttonDone_CMV.Size = new Size(101, 87);
            buttonDone_CMV.TabIndex = 1;
            buttonDone_CMV.Text = "Выполнить";
            buttonDone_CMV.UseVisualStyleBackColor = false;
            buttonDone_CMV.Click += buttonDone_Click;
            // 
            // buttonSave_CMV
            // 
            buttonSave_CMV.BackColor = Color.FromArgb(128, 128, 255);
            buttonSave_CMV.Cursor = Cursors.Hand;
            buttonSave_CMV.Location = new Point(867, 31);
            buttonSave_CMV.Margin = new Padding(3, 4, 3, 4);
            buttonSave_CMV.Name = "buttonSave_CMV";
            buttonSave_CMV.Size = new Size(91, 87);
            buttonSave_CMV.TabIndex = 1;
            buttonSave_CMV.Text = "Сохранить";
            buttonSave_CMV.UseVisualStyleBackColor = false;
            buttonSave_CMV.Click += buttonSave_Click;
            // 
            // buttonHelp_CMV
            // 
            buttonHelp_CMV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_CMV.BackColor = SystemColors.ActiveCaption;
            buttonHelp_CMV.Cursor = Cursors.Hand;
            buttonHelp_CMV.Location = new Point(964, 31);
            buttonHelp_CMV.Margin = new Padding(3, 4, 3, 4);
            buttonHelp_CMV.Name = "buttonHelp_CMV";
            buttonHelp_CMV.Size = new Size(91, 87);
            buttonHelp_CMV.TabIndex = 1;
            buttonHelp_CMV.Text = "Справка";
            buttonHelp_CMV.UseVisualStyleBackColor = false;
            buttonHelp_CMV.Click += buttonHelp_Click;
            // 
            // groupBoxInput_CMV
            // 
            groupBoxInput_CMV.Controls.Add(labelStopValue_CMV);
            groupBoxInput_CMV.Controls.Add(textBoxStopValue_CMV);
            groupBoxInput_CMV.Controls.Add(labelStartValue_CMV);
            groupBoxInput_CMV.Controls.Add(textBoxStartValue_CMV);
            groupBoxInput_CMV.Location = new Point(456, 4);
            groupBoxInput_CMV.Margin = new Padding(3, 4, 3, 4);
            groupBoxInput_CMV.Name = "groupBoxInput_CMV";
            groupBoxInput_CMV.Padding = new Padding(3, 4, 3, 4);
            groupBoxInput_CMV.Size = new Size(297, 125);
            groupBoxInput_CMV.TabIndex = 0;
            groupBoxInput_CMV.TabStop = false;
            groupBoxInput_CMV.Text = "Ввод данных:";
            // 
            // labelStopValue_CMV
            // 
            labelStopValue_CMV.AutoSize = true;
            labelStopValue_CMV.Location = new Point(139, 47);
            labelStopValue_CMV.Name = "labelStopValue_CMV";
            labelStopValue_CMV.Size = new Size(94, 20);
            labelStopValue_CMV.TabIndex = 1;
            labelStopValue_CMV.Text = "Конец шага:";
            // 
            // textBoxStopValue_CMV
            // 
            textBoxStopValue_CMV.Location = new Point(139, 71);
            textBoxStopValue_CMV.Margin = new Padding(3, 4, 3, 4);
            textBoxStopValue_CMV.Name = "textBoxStopValue_CMV";
            textBoxStopValue_CMV.Size = new Size(114, 27);
            textBoxStopValue_CMV.TabIndex = 0;
            textBoxStopValue_CMV.Text = "5";
            // 
            // labelStartValue_CMV
            // 
            labelStartValue_CMV.AutoSize = true;
            labelStartValue_CMV.Location = new Point(7, 47);
            labelStartValue_CMV.Name = "labelStartValue_CMV";
            labelStartValue_CMV.Size = new Size(88, 20);
            labelStartValue_CMV.TabIndex = 1;
            labelStartValue_CMV.Text = "Старт шага:";
            // 
            // textBoxStartValue_CMV
            // 
            textBoxStartValue_CMV.Location = new Point(7, 71);
            textBoxStartValue_CMV.Margin = new Padding(3, 4, 3, 4);
            textBoxStartValue_CMV.Name = "textBoxStartValue_CMV";
            textBoxStartValue_CMV.Size = new Size(114, 27);
            textBoxStartValue_CMV.TabIndex = 0;
            textBoxStartValue_CMV.Text = "-5";
            // 
            // groupBoxTask_CMV
            // 
            groupBoxTask_CMV.Controls.Add(textBoxTask_CMV);
            groupBoxTask_CMV.Location = new Point(9, 4);
            groupBoxTask_CMV.Margin = new Padding(3, 4, 3, 4);
            groupBoxTask_CMV.Name = "groupBoxTask_CMV";
            groupBoxTask_CMV.Padding = new Padding(3, 4, 3, 4);
            groupBoxTask_CMV.Size = new Size(440, 121);
            groupBoxTask_CMV.TabIndex = 0;
            groupBoxTask_CMV.TabStop = false;
            groupBoxTask_CMV.Text = "Условие:";
            // 
            // textBoxTask_CMV
            // 
            textBoxTask_CMV.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxTask_CMV.Location = new Point(7, 29);
            textBoxTask_CMV.Margin = new Padding(3, 4, 3, 4);
            textBoxTask_CMV.Multiline = true;
            textBoxTask_CMV.Name = "textBoxTask_CMV";
            textBoxTask_CMV.ReadOnly = true;
            textBoxTask_CMV.Size = new Size(433, 83);
            textBoxTask_CMV.TabIndex = 0;
            textBoxTask_CMV.Text = "Произвести табулирование функции на заданном диапазоне с шагом 1.\r\nПостроить график функции и сохранить в файл OutPutFileTask4V17.txt";
            // 
            // panelLeft_CMV
            // 
            panelLeft_CMV.BackColor = Color.White;
            panelLeft_CMV.Controls.Add(groupBoxResult_CMV);
            panelLeft_CMV.Dock = DockStyle.Left;
            panelLeft_CMV.Location = new Point(0, 133);
            panelLeft_CMV.Margin = new Padding(3, 4, 3, 4);
            panelLeft_CMV.Name = "panelLeft_CMV";
            panelLeft_CMV.Padding = new Padding(6, 7, 6, 7);
            panelLeft_CMV.Size = new Size(240, 415);
            panelLeft_CMV.TabIndex = 0;
            // 
            // groupBoxResult_CMV
            // 
            groupBoxResult_CMV.Controls.Add(textBoxResult_CMV);
            groupBoxResult_CMV.Dock = DockStyle.Left;
            groupBoxResult_CMV.Location = new Point(6, 7);
            groupBoxResult_CMV.Margin = new Padding(3, 4, 3, 4);
            groupBoxResult_CMV.Name = "groupBoxResult_CMV";
            groupBoxResult_CMV.Padding = new Padding(3, 4, 3, 4);
            groupBoxResult_CMV.Size = new Size(229, 401);
            groupBoxResult_CMV.TabIndex = 0;
            groupBoxResult_CMV.TabStop = false;
            groupBoxResult_CMV.Text = "Вывод:";
            // 
            // textBoxResult_CMV
            // 
            textBoxResult_CMV.Dock = DockStyle.Fill;
            textBoxResult_CMV.Location = new Point(3, 24);
            textBoxResult_CMV.Margin = new Padding(3, 4, 3, 4);
            textBoxResult_CMV.Multiline = true;
            textBoxResult_CMV.Name = "textBoxResult_CMV";
            textBoxResult_CMV.ReadOnly = true;
            textBoxResult_CMV.ScrollBars = ScrollBars.Vertical;
            textBoxResult_CMV.Size = new Size(223, 373);
            textBoxResult_CMV.TabIndex = 0;
            // 
            // panelFill_CMV
            // 
            panelFill_CMV.BackColor = Color.Red;
            panelFill_CMV.Controls.Add(splitter_CMV);
            panelFill_CMV.Controls.Add(chartFunction_CMV);
            panelFill_CMV.Dock = DockStyle.Fill;
            panelFill_CMV.Location = new Point(240, 133);
            panelFill_CMV.Margin = new Padding(3, 4, 3, 4);
            panelFill_CMV.Name = "panelFill_CMV";
            panelFill_CMV.Size = new Size(827, 415);
            panelFill_CMV.TabIndex = 1;
            // 
            // splitter_CMV
            // 
            splitter_CMV.BackColor = Color.White;
            splitter_CMV.Location = new Point(0, 0);
            splitter_CMV.Margin = new Padding(3, 4, 3, 4);
            splitter_CMV.Name = "splitter_CMV";
            splitter_CMV.Size = new Size(3, 415);
            splitter_CMV.TabIndex = 2;
            splitter_CMV.TabStop = false;
            // 
            // chartFunction_CMV
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_CMV.ChartAreas.Add(chartArea1);
            chartFunction_CMV.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartFunction_CMV.Legends.Add(legend1);
            chartFunction_CMV.Location = new Point(0, 0);
            chartFunction_CMV.Margin = new Padding(3, 4, 3, 4);
            chartFunction_CMV.Name = "chartFunction_CMV";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_CMV.Series.Add(series1);
            chartFunction_CMV.Size = new Size(827, 415);
            chartFunction_CMV.TabIndex = 1;
            chartFunction_CMV.Text = "chart1";
            title1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            title1.ForeColor = Color.DodgerBlue;
            title1.Name = "График функции";
            title1.Text = "График функции";
            chartFunction_CMV.Titles.Add(title1);
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 548);
            Controls.Add(panelFill_CMV);
            Controls.Add(panelLeft_CMV);
            Controls.Add(panelTop_CMV);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1083, 584);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 17 | Чигуров М. В. ";
            panelTop_CMV.ResumeLayout(false);
            groupBoxInput_CMV.ResumeLayout(false);
            groupBoxInput_CMV.PerformLayout();
            groupBoxTask_CMV.ResumeLayout(false);
            groupBoxTask_CMV.PerformLayout();
            panelLeft_CMV.ResumeLayout(false);
            groupBoxResult_CMV.ResumeLayout(false);
            groupBoxResult_CMV.PerformLayout();
            panelFill_CMV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction_CMV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_CMV;
        private Panel panelLeft_CMV;
        private Panel panelFill_CMV;
        private GroupBox groupBoxTask_CMV;
        private GroupBox groupBoxResult_CMV;
        private TextBox textBoxResult_CMV;
        private Button buttonHelp_CMV;
        private GroupBox groupBoxInput_CMV;
        private Label labelStartValue_CMV;
        private TextBox textBoxStartValue_CMV;
        private Label labelStopValue_CMV;
        private TextBox textBoxStopValue_CMV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_CMV;
        private TextBox textBoxTask_CMV;
        private Button buttonDone_CMV;
        private Button buttonSave_CMV;
        private Splitter splitter_CMV;
    }
}