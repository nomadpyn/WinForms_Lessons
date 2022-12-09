namespace Task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
// обработчик нажатия кнопки "Привет"
        private void button1_Click(object sender, EventArgs e)
        {
            string name;

            if (textBox1.Text != "")
            {
                name = "Привет " + textBox1.Text;
            }
            else
            {
                name = "Вы не задали имя";
            }

            MessageBox.Show(name, "Приветствие");
        }
    }
}