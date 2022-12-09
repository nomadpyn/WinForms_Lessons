using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Task_6
{
    public partial class Form1 : Form
    {
        string data;
        public Form1()
        {
            InitializeComponent();
            
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            getProgress(readText());
            

        }
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            Form f2 = new form2(this.data);
            f2.ShowDialog();
            this.data = null;
            progressBarLoad.Value = 0;
            buttonOpen.Enabled = false;
        }
        private int readText()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return -1;
            string filename = openFileDialog1.FileName;
            this.data = System.IO.File.ReadAllText(filename);
            return this.data.Length;
            
        }
        private void getProgress(int l)
        {
            if (l > 0)
            {
                progressBarLoad.Minimum = 0;
                progressBarLoad.Maximum = l;
                progressBarLoad.Step = 1;
                for (int i = progressBarLoad.Minimum; i <= l; i++)
                {
                    progressBarLoad.PerformStep();
                    Thread.Sleep(1);
                }
                buttonOpen.Enabled = true;
            }
            if (l == 0)
            {
                MessageBox.Show("Текстовый файл пуст");
            }
        }
    }
}