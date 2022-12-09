namespace Task_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
// запуск последовательно трех окон при запуске формы
        private void Form1_Load(object sender, EventArgs e)
        {
            string message1 = "Меня зовут Алексей. Мне 32 года.";
            string message2 = "Я учусь в академии ТОП на курсе \"Разработка программного обеспечения.\"";
            string message3 = "Уже прошли курс С#, а сейчас начали изучать WinForms, а далее будет WPF.";
            int average = (message1.Length + message2.Length + message3.Length) / 3;
            MessageBox.Show(message1, "Сообщение 1", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(message2, "Сообщение 2", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(message3, $"Среднее {average}", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}