namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //������� 6. �������� ���������, ������� �� ��������� ���� ���������� ���� ������.��������� �������� � ��������� ����(���������� ��-������). ������
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime date;
            DateTime.TryParse(textBox1.Text, out date);
            textBox2.Text = date.ToString("dddd");
        }
    }
}