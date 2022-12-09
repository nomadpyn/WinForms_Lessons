namespace Task_5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelPayFuel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fuelValueBox = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFuelPrice = new System.Windows.Forms.TextBox();
            this.comboBoxFuel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.priceBurger = new System.Windows.Forms.TextBox();
            this.priceHotdog = new System.Windows.Forms.TextBox();
            this.priceCofe = new System.Windows.Forms.TextBox();
            this.priceTea = new System.Windows.Forms.TextBox();
            this.valueBurger = new System.Windows.Forms.TextBox();
            this.valueHotdog = new System.Windows.Forms.TextBox();
            this.valueCofe = new System.Windows.Forms.TextBox();
            this.valueTea = new System.Windows.Forms.TextBox();
            this.checkBoxTea = new System.Windows.Forms.CheckBox();
            this.checkBoxCofe = new System.Windows.Forms.CheckBox();
            this.checkBoxHotdog = new System.Windows.Forms.CheckBox();
            this.checkBoxBurger = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelPayCafe = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.payButton = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.labelPayTotal = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.fuelValueBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxFuelPrice);
            this.groupBox1.Controls.Add(this.comboBoxFuel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 151);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Автозаправка";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.labelPayFuel);
            this.groupBox4.Location = new System.Drawing.Point(236, 37);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(183, 97);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "К оплате за топливо";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(133, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "руб.";
            // 
            // labelPayFuel
            // 
            this.labelPayFuel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPayFuel.Location = new System.Drawing.Point(23, 30);
            this.labelPayFuel.Name = "labelPayFuel";
            this.labelPayFuel.Size = new System.Drawing.Size(91, 43);
            this.labelPayFuel.TabIndex = 0;
            this.labelPayFuel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(166, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "л.";
            // 
            // fuelValueBox
            // 
            this.fuelValueBox.Location = new System.Drawing.Point(82, 111);
            this.fuelValueBox.Mask = "00.00";
            this.fuelValueBox.Name = "fuelValueBox";
            this.fuelValueBox.Size = new System.Drawing.Size(78, 23);
            this.fuelValueBox.TabIndex = 7;
            this.fuelValueBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(28, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Объем";
            // 
            // textBoxFuelPrice
            // 
            this.textBoxFuelPrice.Location = new System.Drawing.Point(82, 76);
            this.textBoxFuelPrice.Name = "textBoxFuelPrice";
            this.textBoxFuelPrice.ReadOnly = true;
            this.textBoxFuelPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxFuelPrice.Size = new System.Drawing.Size(78, 23);
            this.textBoxFuelPrice.TabIndex = 3;
            // 
            // comboBoxFuel
            // 
            this.comboBoxFuel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFuel.FormattingEnabled = true;
            this.comboBoxFuel.Location = new System.Drawing.Point(82, 37);
            this.comboBoxFuel.Name = "comboBoxFuel";
            this.comboBoxFuel.Size = new System.Drawing.Size(111, 23);
            this.comboBoxFuel.TabIndex = 0;
            this.comboBoxFuel.SelectedIndexChanged += new System.EventHandler(this.comboBoxFuel_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "руб.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(28, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Цена";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Топливо";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Controls.Add(this.checkBoxTea);
            this.groupBox2.Controls.Add(this.checkBoxCofe);
            this.groupBox2.Controls.Add(this.checkBoxHotdog);
            this.groupBox2.Controls.Add(this.checkBoxBurger);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Location = new System.Drawing.Point(12, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(439, 145);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Мини-кафе";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.priceBurger, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.priceHotdog, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.priceCofe, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.priceTea, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.valueBurger, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.valueHotdog, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.valueCofe, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.valueTea, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(82, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.6055F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.93578F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(150, 109);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // priceBurger
            // 
            this.priceBurger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.priceBurger.Location = new System.Drawing.Point(3, 3);
            this.priceBurger.Name = "priceBurger";
            this.priceBurger.ReadOnly = true;
            this.priceBurger.Size = new System.Drawing.Size(69, 23);
            this.priceBurger.TabIndex = 0;
            this.priceBurger.Text = "120";
            this.priceBurger.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // priceHotdog
            // 
            this.priceHotdog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.priceHotdog.Location = new System.Drawing.Point(3, 30);
            this.priceHotdog.Name = "priceHotdog";
            this.priceHotdog.ReadOnly = true;
            this.priceHotdog.Size = new System.Drawing.Size(69, 23);
            this.priceHotdog.TabIndex = 1;
            this.priceHotdog.Text = "105";
            this.priceHotdog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // priceCofe
            // 
            this.priceCofe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.priceCofe.Location = new System.Drawing.Point(3, 59);
            this.priceCofe.Name = "priceCofe";
            this.priceCofe.ReadOnly = true;
            this.priceCofe.Size = new System.Drawing.Size(69, 23);
            this.priceCofe.TabIndex = 2;
            this.priceCofe.Text = "80";
            this.priceCofe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // priceTea
            // 
            this.priceTea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.priceTea.Location = new System.Drawing.Point(3, 84);
            this.priceTea.Name = "priceTea";
            this.priceTea.ReadOnly = true;
            this.priceTea.Size = new System.Drawing.Size(69, 23);
            this.priceTea.TabIndex = 3;
            this.priceTea.Text = "35";
            this.priceTea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // valueBurger
            // 
            this.valueBurger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valueBurger.Enabled = false;
            this.valueBurger.Location = new System.Drawing.Point(78, 3);
            this.valueBurger.Name = "valueBurger";
            this.valueBurger.Size = new System.Drawing.Size(69, 23);
            this.valueBurger.TabIndex = 4;
            this.valueBurger.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.valueBurger.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valueBurger_KeyPress);
            // 
            // valueHotdog
            // 
            this.valueHotdog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valueHotdog.Enabled = false;
            this.valueHotdog.Location = new System.Drawing.Point(78, 30);
            this.valueHotdog.Name = "valueHotdog";
            this.valueHotdog.Size = new System.Drawing.Size(69, 23);
            this.valueHotdog.TabIndex = 5;
            this.valueHotdog.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.valueHotdog.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valueHotdog_KeyPress);
            // 
            // valueCofe
            // 
            this.valueCofe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valueCofe.Enabled = false;
            this.valueCofe.Location = new System.Drawing.Point(78, 59);
            this.valueCofe.Name = "valueCofe";
            this.valueCofe.Size = new System.Drawing.Size(69, 23);
            this.valueCofe.TabIndex = 6;
            this.valueCofe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.valueCofe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valueCofe_KeyPress);
            // 
            // valueTea
            // 
            this.valueTea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valueTea.Enabled = false;
            this.valueTea.Location = new System.Drawing.Point(78, 84);
            this.valueTea.Name = "valueTea";
            this.valueTea.Size = new System.Drawing.Size(69, 23);
            this.valueTea.TabIndex = 7;
            this.valueTea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.valueTea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valueTea_KeyPress);
            // 
            // checkBoxTea
            // 
            this.checkBoxTea.AutoSize = true;
            this.checkBoxTea.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxTea.Location = new System.Drawing.Point(14, 108);
            this.checkBoxTea.Name = "checkBoxTea";
            this.checkBoxTea.Size = new System.Drawing.Size(50, 21);
            this.checkBoxTea.TabIndex = 9;
            this.checkBoxTea.Text = "Чай";
            this.checkBoxTea.UseVisualStyleBackColor = true;
            this.checkBoxTea.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBoxCofe
            // 
            this.checkBoxCofe.AutoSize = true;
            this.checkBoxCofe.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxCofe.Location = new System.Drawing.Point(13, 80);
            this.checkBoxCofe.Name = "checkBoxCofe";
            this.checkBoxCofe.Size = new System.Drawing.Size(59, 21);
            this.checkBoxCofe.TabIndex = 8;
            this.checkBoxCofe.Text = "Кофе";
            this.checkBoxCofe.UseVisualStyleBackColor = true;
            this.checkBoxCofe.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBoxHotdog
            // 
            this.checkBoxHotdog.AutoSize = true;
            this.checkBoxHotdog.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxHotdog.Location = new System.Drawing.Point(13, 53);
            this.checkBoxHotdog.Name = "checkBoxHotdog";
            this.checkBoxHotdog.Size = new System.Drawing.Size(75, 21);
            this.checkBoxHotdog.TabIndex = 7;
            this.checkBoxHotdog.Text = "Хот-Дог";
            this.checkBoxHotdog.UseVisualStyleBackColor = true;
            this.checkBoxHotdog.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBoxBurger
            // 
            this.checkBoxBurger.AutoSize = true;
            this.checkBoxBurger.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxBurger.Location = new System.Drawing.Point(13, 27);
            this.checkBoxBurger.Name = "checkBoxBurger";
            this.checkBoxBurger.Size = new System.Drawing.Size(68, 21);
            this.checkBoxBurger.TabIndex = 6;
            this.checkBoxBurger.Text = "Бургер";
            this.checkBoxBurger.UseVisualStyleBackColor = true;
            this.checkBoxBurger.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.labelPayCafe);
            this.groupBox5.Location = new System.Drawing.Point(236, 22);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(183, 97);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "К оплате в кафе";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(133, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "руб.";
            // 
            // labelPayCafe
            // 
            this.labelPayCafe.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPayCafe.Location = new System.Drawing.Point(23, 30);
            this.labelPayCafe.Name = "labelPayCafe";
            this.labelPayCafe.Size = new System.Drawing.Size(91, 43);
            this.labelPayCafe.TabIndex = 0;
            this.labelPayCafe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.payButton);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Location = new System.Drawing.Point(12, 320);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(439, 118);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Итого к оплате";
            // 
            // payButton
            // 
            this.payButton.BackColor = System.Drawing.Color.PaleGreen;
            this.payButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.payButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.payButton.Location = new System.Drawing.Point(38, 34);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(155, 74);
            this.payButton.TabIndex = 6;
            this.payButton.Text = "Оплатить";
            this.payButton.UseVisualStyleBackColor = false;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.labelPayTotal);
            this.groupBox6.Location = new System.Drawing.Point(236, 15);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(183, 97);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "К оплате итого";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(133, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "руб.";
            // 
            // labelPayTotal
            // 
            this.labelPayTotal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPayTotal.Location = new System.Drawing.Point(23, 30);
            this.labelPayTotal.Name = "labelPayTotal";
            this.labelPayTotal.Size = new System.Drawing.Size(91, 43);
            this.labelPayTotal.TabIndex = 0;
            this.labelPayTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label1;
        private ComboBox comboBoxFuel;
        private TextBox textBoxFuelPrice;
        private Label label2;
        private Label label3;
        private GroupBox groupBox4;
        private Label label4;
        private Label label5;
        private MaskedTextBox fuelValueBox;
        private Label label7;
        private Label labelPayFuel;
        private GroupBox groupBox5;
        private Label label6;
        private Label labelPayCafe;
        private GroupBox groupBox6;
        private Label label9;
        private Label labelPayTotal;
        private Button payButton;
        private CheckBox checkBoxTea;
        private CheckBox checkBoxCofe;
        private CheckBox checkBoxHotdog;
        private CheckBox checkBoxBurger;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox priceBurger;
        private TextBox priceHotdog;
        private TextBox priceCofe;
        private TextBox priceTea;
        private TextBox valueBurger;
        private TextBox valueHotdog;
        private TextBox valueCofe;
        private TextBox valueTea;
    }
}