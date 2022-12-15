using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_7
{
    public partial class Form2 : Form
    {
// Создаем "пустого" Студента для добавления в него данных из полей
        public Student ST =new Student();
        public Form2()
        {
            InitializeComponent();
// Создаем список данных для отображения групп в ComboBox
            string[] groups = { "СТ3", "БВ1", "ВК5" };
            comboBoxGroup.Items.AddRange(groups);                       
        }
// Записываем фамилию из поля textBoxFname в поле студента
        private void textBoxFname_TextChanged(object sender, EventArgs e)
        {
            this.ST.Fname = textBoxFname.Text;
        }
// Записываем имя из поля textBoxName в поле студента
        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            this.ST.Name = textBoxName.Text;
        }
// Записываем группу в поле студента при выборе ее в ComboBox
        private void comboBoxGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ST.Group = comboBoxGroup.Text;
        }
// Забираем дату в поле студента из dateTimePicker
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.ST.BirthDay = dateTimePicker1.Value;
// если все поля имеют какое-то значение, кнопка Добавить становиться активной
            if (ST.Name != null && ST.Fname != null && ST.Group != null)
                buttonAddToList.Enabled = true;
        }
// Возвращаем результат диалога и объект в первую форму
        private void buttonAddToList_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
