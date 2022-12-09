using System.Data;

namespace Task_4
{
    public partial class Form1 : Form
    {
// поле класса для хранения строки-выражения
        string data = null;
        public Form1()
        {
            InitializeComponent();
            richTextBox1.Text = this.data;
        }
// добавление цифры от 1 до 9 в строку по нажатию на кнопку        
        private void button1_Click(object sender, EventArgs e)
        {
            this.data += "1";
            richTextBox1.Text = this.data;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.data += "2";
            richTextBox1.Text = this.data;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.data += "3";
            richTextBox1.Text = this.data;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.data += "4";
            richTextBox1.Text = this.data;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.data += "5";
            richTextBox1.Text = this.data;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            this.data += "6";
            richTextBox1.Text = this.data;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            this.data += "7";
            richTextBox1.Text = this.data;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            this.data += "8";
            richTextBox1.Text = this.data;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            this.data += "9";
            richTextBox1.Text = this.data;
        }
// при нажати на кнопку 0 добавляется в строку только при определнных условиях
        private void button0_Click(object sender, EventArgs e)
        {
            if (this.data != null && !this.data.EndsWith("* ") && !this.data.EndsWith("/ ") && !this.data.EndsWith("- ") && !this.data.EndsWith("+ "))
            {
                this.data += "0";
                richTextBox1.Text = this.data;
            }
        }
// обработка нажатия на кнопки действий при соблюдении условия notAllow
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (notAllow())
            {
                this.data += " + ";
                richTextBox1.Text = this.data;
            }

        }
        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (notAllow())
            {
                this.data += " - ";
                richTextBox1.Text = this.data;
            }
        }
        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (notAllow())
            {
                this.data += " / ";
                richTextBox1.Text = this.data;
            }
        }
        private void buttonMult_Click(object sender, EventArgs e)
        {
            if (notAllow())
            {
                this.data += " * ";
                richTextBox1.Text = this.data;
            }
        }
// очистка строки при нажатии кнопки Clr
        private void buttonClr_Click(object sender, EventArgs e)
        {
            this.data = null;
            richTextBox1.Text = "Очищено";
        }
// выполнения вычисления выражения при нажатии кнопки = 
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            this.data = getResult().ToString();
            richTextBox1.Text = this.data;
        }
// описание метода проверки при добавлении знака операции
        private bool notAllow()
        {
            if (this.data != null && (this.data.Contains('*') || this.data.Contains('/') || this.data.Contains('-') || this.data.Contains('+')))
                return false;
            if (this.data != null && !this.data.EndsWith("* ") && !this.data.EndsWith("/ ") && !this.data.EndsWith("- ") && !this.data.EndsWith("+ "))
                return true;
            else
                return false;
        }
// описание метода вычисления выражения из строки в число
        private double getResult()
        {
            string[] result = this.data.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            double a = Convert.ToDouble(result[0]);
            double b = Convert.ToDouble(result[2]);
            double c=0;
            switch(result[1])
            {
                case "+":
                    {
                        c= a + b;
                        break;
                    }
                case "-":
                    {
                        c= a - b;
                        break;
                    }
                case "/":
                    {
                        c = a / b;
                        break;
                    }
                case "*":
                    {
                        c = a * b;
                        break;
                    }
            }
            return c;
        }
    }
}