namespace Task_2
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.win(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.win(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.win(3);
        }
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