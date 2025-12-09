using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.IvanovIA.Sprint6.Task0.V28 
{
    partial class FormMain
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal FormMain() {
        }
        
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
    #endregion
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
        groupBoxСondition_BTO = new GroupBox();
        textBoxTask_BTO = new TextBox();
        pictureBoxFormula_BTO = new PictureBox();
        groupBoxInput_BTO = new GroupBox();
        labelVarX_BTO = new Label();
        textBoxVarX_BTO = new TextBox();
        groupBoxOutput_BTO = new GroupBox();
        labelResult_BTO = new Label();
        textBoxResult_BTO = new TextBox();
        buttonDone_BTO = new Button();
        buttonHelp_BTO = new Button();
        groupBoxСondition_BTO.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_BTO).BeginInit();
        groupBoxInput_BTO.SuspendLayout();
        groupBoxOutput_BTO.SuspendLayout();
        SuspendLayout();
        // 
        // groupBoxСondition_BTO
        // 
        groupBoxСondition_BTO.Controls.Add(textBoxTask_BTO);
        groupBoxСondition_BTO.Controls.Add(pictureBoxFormula_BTO);
        groupBoxСondition_BTO.Location = new Point(14, 16);
        groupBoxСondition_BTO.Margin = new Padding(3, 4, 3, 4);
        groupBoxСondition_BTO.Name = "groupBoxСondition_BTO";
        groupBoxСondition_BTO.Padding = new Padding(3, 4, 3, 4);
        groupBoxСondition_BTO.Size = new Size(509, 232);
        groupBoxСondition_BTO.TabIndex = 0;
        groupBoxСondition_BTO.TabStop = false;
        groupBoxСondition_BTO.Tag = "";
        groupBoxСondition_BTO.Text = "Условие";
        // 
        // textBoxTask_BTO
        // 
        textBoxTask_BTO.BorderStyle = BorderStyle.None;
        textBoxTask_BTO.Location = new Point(7, 29);
        textBoxTask_BTO.Margin = new Padding(3, 4, 3, 4);
        textBoxTask_BTO.Multiline = true;
        textBoxTask_BTO.Name = "textBoxTask_BTO";
        textBoxTask_BTO.ReadOnly = true;
        textBoxTask_BTO.Size = new Size(159, 193);
        textBoxTask_BTO.TabIndex = 0;
        textBoxTask_BTO.TabStop = false;
        textBoxTask_BTO.Text = "Вычислить выражение по формуле";
        // 
        // pictureBoxFormula_BTO
        // 
        pictureBoxFormula_BTO.Image = (Image)resources.GetObject("pictureBoxFormula_BTO.Image");
        pictureBoxFormula_BTO.Location = new Point(172, 29);
        pictureBoxFormula_BTO.Margin = new Padding(3, 4, 3, 4);
        pictureBoxFormula_BTO.Name = "pictureBoxFormula_BTO";
        pictureBoxFormula_BTO.Size = new Size(361, 134);
        pictureBoxFormula_BTO.TabIndex = 1;
        pictureBoxFormula_BTO.TabStop = false;
        pictureBoxFormula_BTO.Click += pictureBoxFormula_BTO_Click;
        // 
        // groupBoxInput_BTO
        // 
        groupBoxInput_BTO.Controls.Add(labelVarX_BTO);
        groupBoxInput_BTO.Controls.Add(textBoxVarX_BTO);
        groupBoxInput_BTO.Location = new Point(18, 281);
        groupBoxInput_BTO.Margin = new Padding(3, 4, 3, 4);
        groupBoxInput_BTO.Name = "groupBoxInput_BTO";
        groupBoxInput_BTO.Padding = new Padding(3, 4, 3, 4);
        groupBoxInput_BTO.Size = new Size(223, 135);
        groupBoxInput_BTO.TabIndex = 2;
        groupBoxInput_BTO.TabStop = false;
        groupBoxInput_BTO.Text = "Ввод данных";
        // 
        // labelVarX_BTO
        // 
        labelVarX_BTO.AutoSize = true;
        labelVarX_BTO.Location = new Point(7, 68);
        labelVarX_BTO.Name = "labelVarX_BTO";
        labelVarX_BTO.Size = new Size(114, 20);
        labelVarX_BTO.TabIndex = 6;
        labelVarX_BTO.Text = "Переменная X:";
        // 
        // textBoxVarX_BTO
        // 
        textBoxVarX_BTO.Location = new Point(7, 96);
        textBoxVarX_BTO.Margin = new Padding(3, 4, 3, 4);
        textBoxVarX_BTO.Name = "textBoxVarX_BTO";
        textBoxVarX_BTO.Size = new Size(143, 27);
        textBoxVarX_BTO.TabIndex = 0;
        textBoxVarX_BTO.KeyPress += textBoxVarX_KeyPress;
        // 
        // groupBoxOutput_BTO
        // 
        groupBoxOutput_BTO.Controls.Add(labelResult_BTO);
        groupBoxOutput_BTO.Controls.Add(textBoxResult_BTO);
        groupBoxOutput_BTO.Location = new Point(293, 281);
        groupBoxOutput_BTO.Margin = new Padding(3, 4, 3, 4);
        groupBoxOutput_BTO.Name = "groupBoxOutput_BTO";
        groupBoxOutput_BTO.Padding = new Padding(3, 4, 3, 4);
        groupBoxOutput_BTO.Size = new Size(219, 135);
        groupBoxOutput_BTO.TabIndex = 3;
        groupBoxOutput_BTO.TabStop = false;
        groupBoxOutput_BTO.Text = "Вывод данных";
        // 
        // labelResult_BTO
        // 
        labelResult_BTO.AutoSize = true;
        labelResult_BTO.Location = new Point(7, 68);
        labelResult_BTO.Name = "labelResult_BTO";
        labelResult_BTO.Size = new Size(78, 20);
        labelResult_BTO.TabIndex = 8;
        labelResult_BTO.Text = "Результат:";
        // 
        // textBoxResult_BTO
        // 
        textBoxResult_BTO.Location = new Point(7, 96);
        textBoxResult_BTO.Margin = new Padding(3, 4, 3, 4);
        textBoxResult_BTO.Name = "textBoxResult_BTO";
        textBoxResult_BTO.ReadOnly = true;
        textBoxResult_BTO.Size = new Size(205, 27);
        textBoxResult_BTO.TabIndex = 7;
        // 
        // buttonDone_BTO
        // 
        buttonDone_BTO.Location = new Point(363, 443);
        buttonDone_BTO.Margin = new Padding(3, 4, 3, 4);
        buttonDone_BTO.Name = "buttonDone_BTO";
        buttonDone_BTO.Size = new Size(149, 37);
        buttonDone_BTO.TabIndex = 4;
        buttonDone_BTO.Text = "Выполнить";
        buttonDone_BTO.UseVisualStyleBackColor = true;
        buttonDone_BTO.Click += buttonDone_Click;
        // 
        // buttonHelp_BTO
        // 
        buttonHelp_BTO.Location = new Point(325, 443);
        buttonHelp_BTO.Margin = new Padding(3, 4, 3, 4);
        buttonHelp_BTO.Name = "buttonHelp_BTO";
        buttonHelp_BTO.Size = new Size(32, 37);
        buttonHelp_BTO.TabIndex = 5;
        buttonHelp_BTO.Text = "?";
        buttonHelp_BTO.UseVisualStyleBackColor = true;
        buttonHelp_BTO.Click += buttonHelp_Click;
        // 
        // FormMain
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(526, 511);
        Controls.Add(buttonHelp_BTO);
        Controls.Add(buttonDone_BTO);
        Controls.Add(groupBoxOutput_BTO);
        Controls.Add(groupBoxInput_BTO);
        Controls.Add(groupBoxСondition_BTO);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(3, 4, 3, 4);
        MaximizeBox = false;
        Name = "FormMain";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Спринт 6 | Таск 0 | Вариант 22 | Бабенков Т ";
        groupBoxСondition_BTO.ResumeLayout(false);
        groupBoxСondition_BTO.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_BTO).EndInit();
        groupBoxInput_BTO.ResumeLayout(false);
        groupBoxInput_BTO.PerformLayout();
        groupBoxOutput_BTO.ResumeLayout(false);
        groupBoxOutput_BTO.PerformLayout();
        ResumeLayout(false);
        }
    private GroupBox groupBoxСondition_BTO;
    private TextBox textBoxTask_BTO;
    private PictureBox pictureBoxFormula_BTO;
    private GroupBox groupBoxInput_BTO;
    private Label labelVarX_BTO;
    private TextBox textBoxVarX_BTO;
    private GroupBox groupBoxOutput_BTO;
    private Label labelResult_BTO;
    private TextBox textBoxResult_BTO;
    private Button buttonDone_BTO;
    private Button buttonHelp_BTO;
    }
}
