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
        public Student ST =new Student();
        public Form2()
        {
            InitializeComponent();
            string[] groups = { "СТ3", "БВ1", "ВК5" };
            comboBoxGroup.Items.AddRange(groups);                       
        }

        private void textBoxFname_TextChanged(object sender, EventArgs e)
        {
            this.ST.Fname = textBoxFname.Text;
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            this.ST.Name = textBoxName.Text;
        }

        private void comboBoxGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ST.Group = comboBoxGroup.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int day = dateTimePicker1.Value.Day;
            int month = dateTimePicker1.Value.Month;
            int year = dateTimePicker1.Value.Year;
            this.ST.BirthDay = new DateOnly(year, month, day);
            if (ST.Name != null && ST.Fname != null && ST.Group != null)
                buttonAddToList.Enabled = true;
        }

        private void buttonAddToList_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
