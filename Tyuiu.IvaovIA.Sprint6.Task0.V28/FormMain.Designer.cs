namespace Tyuiu.IvaovIA.Sprint6.Task0.V28
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxСondition_CMV = new GroupBox();
            textBoxTask_CMV = new TextBox();
            pictureBoxFormula_CMV = new PictureBox();
            groupBoxInput_CMV = new GroupBox();
            labelVarX_CMV = new Label();
            textBoxVarX_CMV = new TextBox();
            groupBoxOutput_CMV = new GroupBox();
            labelResult_CMV = new Label();
            textBoxResult_CMV = new TextBox();
            buttonDone_CMV = new Button();
            buttonHelp_CMV = new Button();
            groupBoxСondition_CMV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_CMV).BeginInit();
            groupBoxInput_CMV.SuspendLayout();
            groupBoxOutput_CMV.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxСondition_CMV
            // 
            groupBoxСondition_CMV.Controls.Add(textBoxTask_CMV);
            groupBoxСondition_CMV.Controls.Add(pictureBoxFormula_CMV);
            groupBoxСondition_CMV.Location = new Point(12, 12);
            groupBoxСondition_CMV.Name = "groupBoxСondition_CMV";
            groupBoxСondition_CMV.Size = new Size(445, 174);
            groupBoxСondition_CMV.TabIndex = 0;
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
            textBoxTask_CMV.Size = new Size(217, 145);
            textBoxTask_CMV.TabIndex = 0;
            textBoxTask_CMV.TabStop = false;
            textBoxTask_CMV.Text = "Вычислить выражение по формуле";
            // 
            // pictureBoxFormula_CMV
            // 
            pictureBoxFormula_CMV.Image = (Image)resources.GetObject("pictureBoxFormula_CMV.Image");
            pictureBoxFormula_CMV.Location = new Point(152, 22);
            pictureBoxFormula_CMV.Name = "pictureBoxFormula_CMV";
            pictureBoxFormula_CMV.Size = new Size(318, 126);
            pictureBoxFormula_CMV.TabIndex = 1;
            pictureBoxFormula_CMV.TabStop = false;
            pictureBoxFormula_CMV.Click += pictureBoxFormula_CMV_Click;
            // 
            // groupBoxInput_CMV
            // 
            groupBoxInput_CMV.Controls.Add(labelVarX_CMV);
            groupBoxInput_CMV.Controls.Add(textBoxVarX_CMV);
            groupBoxInput_CMV.Location = new Point(16, 211);
            groupBoxInput_CMV.Name = "groupBoxInput_CMV";
            groupBoxInput_CMV.Size = new Size(195, 101);
            groupBoxInput_CMV.TabIndex = 2;
            groupBoxInput_CMV.TabStop = false;
            groupBoxInput_CMV.Text = "Ввод данных";
            // 
            // labelVarX_CMV
            // 
            labelVarX_CMV.AutoSize = true;
            labelVarX_CMV.Location = new Point(6, 51);
            labelVarX_CMV.Name = "labelVarX_CMV";
            labelVarX_CMV.Size = new Size(89, 15);
            labelVarX_CMV.TabIndex = 6;
            labelVarX_CMV.Text = "Переменная X:";
            // 
            // textBoxVarX_CMV
            // 
            textBoxVarX_CMV.Location = new Point(6, 72);
            textBoxVarX_CMV.Name = "textBoxVarX_CMV";
            textBoxVarX_CMV.Size = new Size(126, 23);
            textBoxVarX_CMV.TabIndex = 0;
            textBoxVarX_CMV.KeyPress += textBoxVarX_KeyPress;
            // 
            // groupBoxOutput_CMV
            // 
            groupBoxOutput_CMV.Controls.Add(labelResult_CMV);
            groupBoxOutput_CMV.Controls.Add(textBoxResult_CMV);
            groupBoxOutput_CMV.Location = new Point(256, 211);
            groupBoxOutput_CMV.Name = "groupBoxOutput_CMV";
            groupBoxOutput_CMV.Size = new Size(192, 101);
            groupBoxOutput_CMV.TabIndex = 3;
            groupBoxOutput_CMV.TabStop = false;
            groupBoxOutput_CMV.Text = "Вывод данных";
            // 
            // labelResult_CMV
            // 
            labelResult_CMV.AutoSize = true;
            labelResult_CMV.Location = new Point(6, 51);
            labelResult_CMV.Name = "labelResult_CMV";
            labelResult_CMV.Size = new Size(63, 15);
            labelResult_CMV.TabIndex = 8;
            labelResult_CMV.Text = "Результат:";
            // 
            // textBoxResult_CMV
            // 
            textBoxResult_CMV.Location = new Point(6, 72);
            textBoxResult_CMV.Name = "textBoxResult_CMV";
            textBoxResult_CMV.ReadOnly = true;
            textBoxResult_CMV.Size = new Size(180, 23);
            textBoxResult_CMV.TabIndex = 7;
            // 
            // buttonDone_CMV
            // 
            buttonDone_CMV.Location = new Point(318, 332);
            buttonDone_CMV.Name = "buttonDone_CMV";
            buttonDone_CMV.Size = new Size(130, 28);
            buttonDone_CMV.TabIndex = 4;
            buttonDone_CMV.Text = "Выполнить";
            buttonDone_CMV.UseVisualStyleBackColor = true;
            buttonDone_CMV.Click += buttonDone_Click;
            // 
            // buttonHelp_CMV
            // 
            buttonHelp_CMV.Location = new Point(284, 332);
            buttonHelp_CMV.Name = "buttonHelp_CMV";
            buttonHelp_CMV.Size = new Size(28, 28);
            buttonHelp_CMV.TabIndex = 5;
            buttonHelp_CMV.Text = "?";
            buttonHelp_CMV.UseVisualStyleBackColor = true;
            buttonHelp_CMV.Click += buttonHelp_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 383);
            Controls.Add(buttonHelp_CMV);
            Controls.Add(buttonDone_CMV);
            Controls.Add(groupBoxOutput_CMV);
            Controls.Add(groupBoxInput_CMV);
            Controls.Add(groupBoxСondition_CMV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 28 | Иванов И.А. ";
            groupBoxСondition_CMV.ResumeLayout(false);
            groupBoxСondition_CMV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_CMV).EndInit();
            groupBoxInput_CMV.ResumeLayout(false);
            groupBoxInput_CMV.PerformLayout();
            groupBoxOutput_CMV.ResumeLayout(false);
            groupBoxOutput_CMV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxСondition_CMV;
        private PictureBox pictureBoxFormula_CMV;
        private GroupBox groupBoxInput_CMV;
        private GroupBox groupBoxOutput_CMV;
        private Button buttonDone_CMV;
        private TextBox textBoxTask_CMV;
        private TextBox textBoxVarX_CMV;
        private Label labelVarX_CMV;
        private Label labelResult_CMV;
        private TextBox textBoxResult_CMV;
        private Button buttonHelp_CMV;
    }
}