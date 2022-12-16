using System.Data;

namespace Task_4
{
    public partial class Form1 : Form
    {      
        public Form1()
        {
            InitializeComponent();           
        }
// добавление цифры от 1 до 9 в строку по нажатию на кнопку        
        private void button1_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "1";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "2";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "3";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "4";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "5";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "6";
        }
        private void button7_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "7";
        }
        private void button8_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "8";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "9";
        }
// при нажати на кнопку 0 добавляется в строку только при определнных условиях
        private void button0_Click(object sender, EventArgs e)
        {
            if (notAllow())
            {
                textBoxResult.Text += "0";
            }
        }
// обработка нажатия на кнопки действий при соблюдении условия notAllow
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (notAllow())
            {
                textBoxResult.Text += " + ";
            }
        }
        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (notAllow())
            {
                textBoxResult.Text += " - ";
            }
        }
        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (notAllow())
            {
                textBoxResult.Text += " / ";
            }
        }
        private void buttonMult_Click(object sender, EventArgs e)
        {
            if (notAllow())
            {
                textBoxResult.Text += " * ";
            }
        }
// очистка строки при нажатии кнопки Clr
        private void buttonClr_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = null;
        }
// выполнения вычисления выражения при нажатии кнопки = 
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            string result = new DataTable().Compute(textBoxResult.Text, null).ToString();
            textBoxResult.Text = result;
        }
// описание метода проверки при добавлении знака операции
        private bool notAllow()
        {
            if (textBoxResult.Text != null && !textBoxResult.Text.EndsWith("* ") && !textBoxResult.Text.EndsWith("/ ") && !textBoxResult.Text.EndsWith("- ") && !textBoxResult.Text.EndsWith("+ "))
                return true;
            else
                return false;
        }
    }
}