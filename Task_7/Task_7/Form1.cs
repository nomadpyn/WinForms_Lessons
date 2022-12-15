using System.Xml.Serialization;
using System;
using System.Xml.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Task_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBoxStudents.DisplayMember = "Fname";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBoxStudents.MouseDoubleClick += ListBoxStudents_MouseDoubleClick;
        }

        private void ListBoxStudents_MouseDoubleClick(object? sender, MouseEventArgs e)
        {
            MessageBox.Show(listBoxStudents.SelectedItem.ToString());
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Form2 AddForm = new Form2();
            if (AddForm.ShowDialog() == DialogResult.OK)
            {
                listBoxStudents.Items.Add(AddForm.ST);
            }
            this.checkButtons();
            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML Files (*.xml)|*.xml";
            sfd.FilterIndex = 0;
            sfd.DefaultExt = "xml";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string filename = sfd.FileName;
                List<Student> students = new List<Student>();
                foreach (var s in listBoxStudents.Items)
                {
                    students.Add((Student)s);
                }

                XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Student>));

                using (Stream fStream = File.Create(filename))
                {
                    xmlFormat.Serialize(fStream, students);
                }
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML Files (*.xml)|*.xml";
            ofd.FilterIndex = 0;
            ofd.DefaultExt = "xml";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filename = ofd.FileName;

                XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Student>));
                List<Student> students = null;
                using (Stream fStream = File.OpenRead(filename))
                {
                    students = (List<Student>)xmlFormat.Deserialize(fStream);
                }
                foreach (var s in students)
                {
                    listBoxStudents.Items.Add(s);
                }
            }
            this.checkButtons();
        }
        private void checkButtons()
        {
            if (listBoxStudents.Items.Count > 0)
            {
                buttonSave.Enabled = true;
                buttonLoad.Enabled = false;
            }
        }
    }
}