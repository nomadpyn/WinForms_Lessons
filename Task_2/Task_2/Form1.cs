namespace Task_2
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
        }      
// обработка нажантия кнопки "1", в которой запускается метод игры Win
        private void button1_Click(object sender, EventArgs e)
        {
            this.win(1);
        }
 // обработка нажантия кнопки "2", в которой запускается метод игры Win
        private void button2_Click(object sender, EventArgs e)
        {
            this.win(2);
        }
// обработка нажантия кнопки "3", в которой запускается метод игры Win
        private void button3_Click(object sender, EventArgs e)
        {
            this.win(3);
        }
// описание игры Win
        private void win(int value)
        {
            int digit = new Random().Next(1, 3);
            if (digit == value)
            {
                MessageBox.Show($"Вы угадали. Число {digit}");
            }
            else
                MessageBox.Show($"Неверно. Число{digit}:(");
        }
    }
}