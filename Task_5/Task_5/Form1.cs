namespace Task_5
{
    public partial class Form1 : Form
    {
        double[] fuel_price = { 42.30, 48.55, 46.15 };
        double[] food_price = { 120,105,80,35};
        double sum_fuel;
        double[] sum_cafe = new double[4];
        public Form1()
        {
            InitializeComponent();
            comboBoxFuel.Items.AddRange(new string[] { "Бензин АИ92", "Бензин АИ95", "Дизель" });
            fuelValueBox.TextChanged += MaskedTextBox1_TextChanged;
            valueBurger.TextChanged += valueBurger_TextChanged;
            valueHotdog.TextChanged += valueHotdog_TextChanged;
            valueCofe.TextChanged += valueCofe_TextChanged;
            valueTea.TextChanged += valueTea_TextChanged;
            labelPayFuel.TextChanged += labelPayTotal_TextChanged;
            labelPayCafe.TextChanged += labelPayTotal_TextChanged;



        }
        private void labelPayTotal_TextChanged(object? sender, EventArgs e)
        {
            labelPayTotal.Text = (sum_fuel+sum_cafe.Sum()).ToString();
        }
        private void MaskedTextBox1_TextChanged(object? sender, EventArgs e)
        {
           switch (comboBoxFuel.SelectedIndex)
            {
                case 0:
                    {
                        getFuelSum(fuelValueBox.Text, fuel_price[0]);
                        break;

                    }
                case 1:
                    {
                        getFuelSum(fuelValueBox.Text, fuel_price[1]);
                        break;
                    }
                case 2:
                    {
                        getFuelSum(fuelValueBox.Text, fuel_price[2]);
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
                        labelPayFuel.Text = sum_fuel.ToString();
                        fuelValueBox.Clear();
                        break;
                    }
                case 1:
                    {
                        textBoxFuelPrice.Text = fuel_price[1].ToString();
                        labelPayFuel.Text = sum_fuel.ToString();
                        fuelValueBox.Clear();
                        break;
                    }
                case 2:
                    {
                        textBoxFuelPrice.Text = fuel_price[2].ToString();
                        labelPayFuel.Text = sum_fuel.ToString();
                        fuelValueBox.Clear();
                        break;
                    }
            }
        }
        private void valueBurger_TextChanged(object? sender, EventArgs e)
        {
            double sum = Convert.ToDouble(valueBurger.Text) * food_price[0];
            sum_cafe[0] += sum;
            labelPayCafe.Text = sum_cafe.Sum().ToString();
        }
        private void valueHotdog_TextChanged(object? sender, EventArgs e)
        {
            double sum = Convert.ToDouble(valueHotdog.Text) * food_price[1];
            sum_cafe[1] += sum;
            labelPayCafe.Text = sum_cafe.Sum().ToString();
        }
        private void valueCofe_TextChanged(object? sender, EventArgs e)
        {
            double sum = Convert.ToDouble(valueCofe.Text) * food_price[2];
            sum_cafe[2] += sum;
            labelPayCafe.Text = sum_cafe.Sum().ToString();
        }
        private void valueTea_TextChanged(object? sender, EventArgs e)
        {
            double sum = Convert.ToDouble(valueTea.Text) * food_price[3];
            sum_cafe[3] += sum;
            labelPayCafe.Text = sum_cafe.Sum().ToString();
        }
        private void payButton_Click(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
            MessageBox.Show(string.Format("{0:F} оплачено успешно!", this.sum_cafe.Sum() + this.sum_fuel));

        }    
        private void getFuelSum(string text, double price)
        {
            if (text != "  ,")
            {
                sum_fuel = Convert.ToDouble(text) * price;

            }
            else
            {
                sum_fuel = 0;
            }
            labelPayFuel.Text = sum_fuel.ToString();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
                valueBurger.Enabled= true;
            else
                valueBurger.Enabled = false;
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
                valueHotdog.Enabled = true;
            else
                valueHotdog.Enabled = false;
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
                valueCofe.Enabled = true;
            else
                valueCofe.Enabled = false;
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
                valueTea.Enabled = true;
            else
                valueTea.Enabled = false;
        }
        private void valueBurger_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }
        private void valueHotdog_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }
        private void valueCofe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }
        private void valueTea_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}