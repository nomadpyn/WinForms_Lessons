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
// Выбор поля Fname из класса Student для отображения в ListBox
            listBoxStudents.DisplayMember = "Fname";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listBoxStudents.MouseDoubleClick += ListBoxStudents_MouseDoubleClick;
        }
// Открытие информации о студенте по двойному клику в поле ListBox
        private void ListBoxStudents_MouseDoubleClick(object? sender, MouseEventArgs e)
        {
            MessageBox.Show(listBoxStudents.SelectedItem.ToString());
        }
// открытие формы для заполнения данных о студенте и последующее сохранения данных в ListBox
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Form2 AddForm = new Form2();
            if (AddForm.ShowDialog() == DialogResult.OK)
            {
                listBoxStudents.Items.Add(AddForm.ST);
            }
            this.checkButtons();  
        }
// обработка действия при нажатии кнопки Сохранить
        private void buttonSave_Click(object sender, EventArgs e)
        {
// Создание диалога для сохранения файла в формате xml
            SaveFileDialog sfd = new SaveFileDialog();
// Создание фильтра для файлов в диалоговом окне
            sfd.Filter = "XML Files (*.xml)|*.xml";
            sfd.FilterIndex = 0;
// Выбор разрешения файла по умолчанию
            sfd.DefaultExt = "xml";
// При успешном открытии диалога продолжение работы программы
            if (sfd.ShowDialog() == DialogResult.OK)
            {
// Получаем путь файла, в который сохраняем
                string filename = sfd.FileName;
// Создаем List студентов и забираем в него данные из ListBox
                List<Student> students = new List<Student>();
                foreach (var s in listBoxStudents.Items)
                {
                    students.Add((Student)s);
                }
// Создаем Xml Сериализатор для сохранения List в файл
                XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Student>));
                using (Stream fStream = File.Create(filename))
                {
                    xmlFormat.Serialize(fStream, students);
                }
            }
        }
// обработка действия при нажатии кнопки Загрузить
        private void buttonLoad_Click(object sender, EventArgs e)
        {
// Создание диалога для открытия файла в формате xml
            OpenFileDialog ofd = new OpenFileDialog();
 // Создание фильтра для файлов в диалоговом окне
            ofd.Filter = "XML Files (*.xml)|*.xml";
            ofd.FilterIndex = 0;
// Выбор разрешения файла по умолчанию
            ofd.DefaultExt = "xml";
// При успешном открытии диалога продолжение работы программы
            if (ofd.ShowDialog() == DialogResult.OK)
            {
// Получаем путь файла, из которого загружаем
                string filename = ofd.FileName;
// Создаем Xml Сериализатор для записи данных из файла в List
                XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Student>));
                List<Student> students = null;
                using (Stream fStream = File.OpenRead(filename))
                {
                    students = (List<Student>)xmlFormat.Deserialize(fStream);
                }
// Перенос данных из List в ListBox для отображения
                foreach (var s in students)
                {
                    listBoxStudents.Items.Add(s);
                }
            }
            this.checkButtons();
        }
// В случае если есть данные в ListBox, кнопка Сохранить активна, а кнопка Загрузить не активна
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