namespace Task_5
{
    public partial class Form1 : Form
    {
// поля класса для хранения данных о стоимости товаров
        double[] fuel_price = { 42.30, 48.55, 46.15 };
        double[] food_price = { 120,105,80,35};
// поля класса для хранения суммы к оплате по двух категориям
        double sum_fuel;
        double[] sum_cafe = new double[4];
        public Form1()
        {
            InitializeComponent();
// первоначальная инициализации ComboBox
            comboBoxFuel.Items.AddRange(new string[] { "Бензин АИ92", "Бензин АИ95", "Дизель"});
            comboBoxFuel.SelectedIndex = -1;
// событие при изменении данных в строке ввода объема бензина 
            fuelValueBox.TextChanged += MaskedTextBox1_TextChanged;
// события при изменении данных в полях количества товара в меню кафе
            valueBurger.TextChanged += valueBurger_TextChanged;
            valueHotdog.TextChanged += valueHotdog_TextChanged;
            valueCofe.TextChanged += valueCofe_TextChanged;
            valueTea.TextChanged += valueTea_TextChanged;
// события при измении цены на оплату
            labelPayFuel.TextChanged += labelPayTotal_TextChanged;
            labelPayCafe.TextChanged += labelPayTotal_TextChanged;
        }
// вывод общей сумму на оплату в labelPayTotal
        private void labelPayTotal_TextChanged(object? sender, EventArgs e)
        {
            this.labelPayTotal.Text = (this.sum_fuel+this.sum_cafe.Sum()).ToString();
        }
// расчет суммы за оплату топлива при измении поля
        private void MaskedTextBox1_TextChanged(object? sender, EventArgs e)
        {
           switch (this.comboBoxFuel.SelectedIndex)
            {
                case 0:
                    {
                        getFuelSum(this.fuelValueBox.Text, this.fuel_price[(int)Fuel.B92]);
                        break;

                    }
                case 1:
                    {
                        getFuelSum(this.fuelValueBox.Text, this.fuel_price[(int)Fuel.B95]);
                        break;
                    }
                case 2:
                    {
                        getFuelSum(this.fuelValueBox.Text, this.fuel_price[(int)Fuel.DT]);
                        break;
                    }
            }
        }
// описание логики при выборе разных значении в comboBoxFuel
        private void comboBoxFuel_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.comboBoxFuel.SelectedIndex)
            {
                case 0:
                    {
                        this.textBoxFuelPrice.Text = this.fuel_price[(int)Fuel.B92].ToString();
                        this.labelPayFuel.Text = this.sum_fuel.ToString();
                        this.fuelValueBox.Clear();
                        break;
                    }
                case 1:
                    {
                        this.textBoxFuelPrice.Text = this.fuel_price[(int)Fuel.B95].ToString();
                        this.labelPayFuel.Text = this.sum_fuel.ToString();
                        this.fuelValueBox.Clear();
                        break;
                    }
                case 2:
                    {
                        this.textBoxFuelPrice.Text = this.fuel_price[(int)Fuel.DT].ToString();
                        this.labelPayFuel.Text = this.sum_fuel.ToString();
                        this.fuelValueBox.Clear();
                        break;
                    }
            }
        }
// расчет суммы к оплате за кафе для четырех полей 
        private void valueBurger_TextChanged(object? sender, EventArgs e)
        {
            getCafeSum(this.valueBurger.Text, (int)Food.Burger);            
        }
        private void valueHotdog_TextChanged(object? sender, EventArgs e)
        {
            getCafeSum(this.valueHotdog.Text, (int)Food.HotDog);
        }
        private void valueCofe_TextChanged(object? sender, EventArgs e)
        {
            getCafeSum(this.valueCofe.Text, (int)Food.Cofe);
        }
        private void valueTea_TextChanged(object? sender, EventArgs e)
        {
            getCafeSum(this.valueTea.Text, (int)Food.Tea);
        }
// вывод сообщения об оплате и очистка полей формы для последующей работы
        private void payButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("{0:F} оплачено успешно!", this.sum_cafe.Sum() + this.sum_fuel));
            Thread.Sleep(1000);
            clearAll();
        }    
// расчет и вывод суммы на оплату за топливо в форму
        private void getFuelSum(string text, double price)
        {
            if (text != "  ,")
            {
                this.sum_fuel = Convert.ToDouble(text) * price;

            }
            else
            {
                this.sum_fuel = 0;
            }
            this.labelPayFuel.Text = this.sum_fuel.ToString();
        }
// расчет и вывод сумму на оплату за кафе в форму
        private void getCafeSum(string text, int index)
        {
            if (text != "")
            {
                double sum = Convert.ToDouble(text) * this.food_price[index];
                this.sum_cafe[index] = sum;
            }
            else
            {
                this.sum_cafe[index] = 0;
            }
            this.labelPayCafe.Text = this.sum_cafe.Sum().ToString();
        }
// описание логики при разных положениях чекбоксов на форме в блоке кафе
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxLogic(this.checkBoxBurger, this.valueBurger, (int)Food.Burger);
            
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxLogic(this.checkBoxHotdog, this.valueHotdog, (int)Food.HotDog);
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxLogic(this.checkBoxCofe, this.valueCofe, (int)Food.Cofe);
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxLogic(this.checkBoxTea, this.valueTea, (int)Food.Tea);
        }
// описание проверки на ввод только цифр и Backspace в поле количество в кафе
        private void valueBurger_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkValue(e);
        }
        private void valueHotdog_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkValue(e);
        }
        private void valueCofe_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkValue(e);
        }
        private void valueTea_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkValue(e);
        }
// изменения отображения поля для ввода при использование чекбокса
        private void checkBoxLogic(CheckBox checkbox, TextBox textbox, int index)
        {
            if (checkbox.Checked == true)
                textbox.Enabled = true;
            else
            {
                textbox.Enabled = false;
                this.sum_cafe[index] = 0;
                textbox.Clear();
            }
        }
// метод очистки формы
        private void clearAll()
        {
            comboBoxFuel.SelectedIndex = -1;
            this.sum_fuel = 0;
            textBoxFuelPrice.Clear();
            fuelValueBox.Clear();
            Array.Clear(this.sum_cafe);
            checkBoxBurger.Checked = false;
            checkBoxHotdog.Checked = false;
            checkBoxCofe.Checked = false;
            checkBoxTea.Checked = false;
            comboBoxFuel.Refresh();
            labelPayFuel.ResetText();
            labelPayCafe.ResetText();
            labelPayTotal.ResetText();
        }
// метод проверки на цифры и Backspace
        private bool checkValue(KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
            return false;
        }
    }
    enum Fuel
    {
        B92,B95,DT
    }
    enum Food
    {
        Burger,HotDog,Cofe,Tea
    }
}
