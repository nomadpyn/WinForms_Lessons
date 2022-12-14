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
        }
    }
}