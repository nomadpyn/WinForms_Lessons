namespace Task_5
{
    public partial class Form1 : Form
    {
        double[] fuel_price = { 42.30, 48.55, 46.15 };
        public Form1()
        {
            InitializeComponent();
            comboBoxFuel.Items.AddRange(new string[] { "Бензин АИ92", "Бензин АИ95", "Дизель" });
            maskedTextBox1.TextChanged += MaskedTextBox1_TextChanged;

            
        }

        private void MaskedTextBox1_TextChanged(object? sender, EventArgs e)
        {
            switch (comboBoxFuel.SelectedIndex)
            {
                case 0:
                    {
                        double sum = Convert.ToDouble(maskedTextBox1.Text) * 42.30;
                        label6.Text = sum.ToString();
                        break;
                    }
                case 1:
                    {
                        double sum = Convert.ToDouble(maskedTextBox1.Text) * 48.55;
                        label6.Text = sum.ToString();
                        break;
                    }
                case 2:
                    {
                        double sum = Convert.ToDouble(maskedTextBox1.Text) * 46.15;
                        label6.Text = sum.ToString();
                        break;
                    }
            }
        }

        private void comboBoxFuel_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxFuel.SelectedIndex)
            {
                case 0:
                    {
                        textBoxFuelPrice.Text = fuel_price[0].ToString();
                        maskedTextBox1.Clear();
                        break;
                    }
                case 1:
                    {
                        textBoxFuelPrice.Text = fuel_price[1].ToString();
                        maskedTextBox1.Clear();
                        break;
                    }
                case 2:
                    {
                        textBoxFuelPrice.Text = fuel_price[2].ToString();
                        maskedTextBox1.Clear();
                        break;
                    }
            }
        }
       
        
    }
}