namespace Task_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string message1 = "���� ����� �������. ��� 32 ����.";
            string message2 = "� ����� � �������� ��� �� ����� \"���������� ������������ �����������.\"";
            string message3 = "��� ������ ���� �#, � ������ ������ ������� WinForms, � ����� ����� WPF.";
            int average = (message1.Length + message2.Length + message3.Length) / 3;
            MessageBox.Show(message1, "��������� 1", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(message2, "��������� 2", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(message3, $"������� {average}", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}