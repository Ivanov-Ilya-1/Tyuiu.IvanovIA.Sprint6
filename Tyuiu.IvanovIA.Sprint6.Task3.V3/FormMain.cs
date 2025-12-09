using Tyuiu.IvanovIA.Sprint6.Task3.V3.Lib;
namespace Tyuiu.IvanovIA.Sprint6.Task3.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        int[,] mtrx = new int[,] {   { 14,   5,   -9,  18, 21 },
                                    { -5,  -12, -12,  4,  28 },
                                    { 27,  -2,  -14,  23, 27 },
                                    { -19, -15,  17 , 15, 1},
                                    { 33,   2,    6,  24, 24 } };

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetLength(0);
            int cols = mtrx.GetLength(1);

            dataGridViewMatrix_CMV.ColumnCount = cols;
            dataGridViewMatrix_CMV.RowCount = rows;

            dataGridViewResult_CMV.ColumnCount = cols;
            dataGridViewResult_CMV.RowCount = rows;

            dataGridViewMatrix_CMV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewResult_CMV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewMatrix_CMV.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {

            int[,] resMatrix = ds.Calculate(mtrx);
            int rows = mtrx.GetLength(0);
            int cols = mtrx.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewResult_CMV.Rows[i].Cells[j].Value = Convert.ToString(resMatrix[i, j]);
                }
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Òàñê 3 âûïîëíèë ñòóäåíò ãðóïïû ÏÊÒá-24-1 ×èãóðîâ Ìàêñèì Âëàäèñëàâîâè÷", "Ñîîáùåíèå", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}