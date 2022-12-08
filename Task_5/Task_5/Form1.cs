﻿namespace Task_5
{
    public partial class Form1 : Form
    {
        double[] fuel_price = { 42.30, 48.55, 46.15 };
        double sum_fuel;
        double sum_cafe;
        public Form1()
        {
            InitializeComponent();
            comboBoxFuel.Items.AddRange(new string[] { "Бензин АИ92", "Бензин АИ95", "Дизель" });
            fuelValueBox.TextChanged += MaskedTextBox1_TextChanged;
            labelPayFuel.TextChanged += labelPayTotal_TextChanged;
            
            
        }
        private void labelPayTotal_TextChanged(object? sender, EventArgs e)
        {
            labelPayTotal.Text = (sum_fuel+sum_cafe).ToString();
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

        private void payButton_Click(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
            MessageBox.Show(string.Format("{0:F} оплачено успешно!", this.sum_cafe + this.sum_fuel));

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
    }
}