using Tyuiu.IvanovIA.Sprint6.Task0.V28.Lib;
namespace Tyuiu.IvaovIA.Sprint6.Task0.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_CMV.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_CMV.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBoxVarX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ИИПб-25-1 Иванов Илья Анатольевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBoxFormula_CMV_Click(object sender, EventArgs e)
        {

        }
    }
}