using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Task_6
{
    public partial class Form1 : Form
    {
// поле класса для считывание данных их файла
        string? data;
        public Form1()
        {
            InitializeComponent();
// фильтр для диалогового окна на текстовые файлы            
            this.openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }
// обработка нажатия на кнопку "Загрузить"
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            getProgress(readText());      
        }
// обработка нажатия на кнопку "Открыть"
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            Form f2 = new form2(this.data);
            f2.ShowDialog();
            this.data = null;
            this.progressBarLoad.Value = 0;
            this.buttonOpen.Enabled = false;
        }
// метод считывания текста из файла в строку data
        private int readText()
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return -1;
            string filename = this.openFileDialog1.FileName;
            this.data = System.IO.File.ReadAllText(filename);
            return this.data.Length;
        }
// метод вывода прогресс бара на экран или сообщения о том что файл пуст
        private void getProgress(int l)
        {
            if (l > 0)
            {
                this.progressBarLoad.Minimum = 0;
                this.progressBarLoad.Maximum = l;
                this.progressBarLoad.Step = 1;
                for (int i = this.progressBarLoad.Minimum; i <= l; i++)
                {
                    this.progressBarLoad.PerformStep();
                    Thread.Sleep(1);
                }
                this.buttonOpen.Enabled = true;
            }
            if (l == 0)
            {
                MessageBox.Show("Текстовый файл пуст");
            }
        }
    }
}