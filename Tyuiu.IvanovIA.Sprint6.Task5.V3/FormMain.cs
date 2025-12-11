using Tyuiu.IvanovIA.Sprint6.Task5.V3.Lib;
namespace Tyuiu.IvanovIA.Sprint6.Task5.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        string path = Path.Combine(new string[] { "C:", "Users", "gilya", "Desktop", "InPutFileTask5V3.txt" });

        private void buttonDone_Click(object sender, EventArgs e)
        {
            dataGridViewNums.Rows.Clear();

            dataGridViewNums.ColumnCount = 2;
            dataGridViewNums.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            this.chartDiag.ChartAreas[0].AxisX.Title = "Îñü X";
            this.chartDiag.ChartAreas[0].AxisY.Title = "Îñü Y";

            chartDiag.Series[0].Points.Clear();

            double[] numMass = new double[ds.len];

            numMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numMass.Length; i++)
            {
                dataGridViewNums.Rows.Add(Convert.ToString(i), Convert.ToString(numMass[i]));
                chartDiag.Series[0].Points.AddXY(i, numMass[i]);
            }
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Òàñê 5 âûïîëíèë ñòóäåíò ãðóïïû ÈÈÏá-25-1 Áàáåíêîâ Òðîôèì Îëåãîâè÷", "Ñîîáùåíèå", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
