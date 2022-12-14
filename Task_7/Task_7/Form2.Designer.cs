namespace Task_7
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelFname = new System.Windows.Forms.Label();
            this.textBoxFname = new System.Windows.Forms.TextBox();
            this.buttonAddToList = new System.Windows.Forms.Button();
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.labelGroup = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 201);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // labelName
            // 
            this.labelName.Location = new System.Drawing.Point(12, 13);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(200, 23);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Имя студента";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 39);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(200, 23);
            this.textBoxName.TabIndex = 2;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // labelFname
            // 
            this.labelFname.Location = new System.Drawing.Point(12, 66);
            this.labelFname.Name = "labelFname";
            this.labelFname.Size = new System.Drawing.Size(200, 23);
            this.labelFname.TabIndex = 3;
            this.labelFname.Text = "Фамилия студента";
            this.labelFname.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxFname
            // 
            this.textBoxFname.Location = new System.Drawing.Point(12, 91);
            this.textBoxFname.Name = "textBoxFname";
            this.textBoxFname.Size = new System.Drawing.Size(200, 23);
            this.textBoxFname.TabIndex = 4;
            this.textBoxFname.TextChanged += new System.EventHandler(this.textBoxFname_TextChanged);
            // 
            // buttonAddToList
            // 
            this.buttonAddToList.Location = new System.Drawing.Point(12, 241);
            this.buttonAddToList.Name = "buttonAddToList";
            this.buttonAddToList.Size = new System.Drawing.Size(200, 50);
            this.buttonAddToList.TabIndex = 5;
            this.buttonAddToList.Text = "Добавить";
            this.buttonAddToList.UseVisualStyleBackColor = true;
            this.buttonAddToList.Click += new System.EventHandler(this.buttonAddToList_Click);
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.FormattingEnabled = true;
            this.comboBoxGroup.Location = new System.Drawing.Point(12, 149);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(200, 23);
            this.comboBoxGroup.TabIndex = 6;
            this.comboBoxGroup.SelectedIndexChanged += new System.EventHandler(this.comboBoxGroup_SelectedIndexChanged);
            // 
            // labelGroup
            // 
            this.labelGroup.Location = new System.Drawing.Point(12, 123);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(200, 23);
            this.labelGroup.TabIndex = 7;
            this.labelGroup.Text = "Группа студента";
            this.labelGroup.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelBirthday
            // 
            this.labelBirthday.Location = new System.Drawing.Point(12, 175);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(200, 23);
            this.labelBirthday.TabIndex = 8;
            this.labelBirthday.Text = "Дата рождения";
            this.labelBirthday.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 301);
            this.Controls.Add(this.labelBirthday);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.comboBoxGroup);
            this.Controls.Add(this.buttonAddToList);
            this.Controls.Add(this.textBoxFname);
            this.Controls.Add(this.labelFname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label labelName;
        private TextBox textBoxName;
        private Label labelFname;
        private TextBox textBoxFname;
        private Button buttonAddToList;
        private ComboBox comboBoxGroup;
        private Label labelGroup;
        private Label labelBirthday;
    }
}