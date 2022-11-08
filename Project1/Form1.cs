namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //задание 6. Написать программу, которая по введенной дате определяет день недели.Результат выводить в текстовое поле(желательно по-русски). ГОТОВО
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime date;
            DateTime.TryParse(textBox1.Text, out date);
            textBox2.Text = date.ToString("dddd");
        }
    }
}