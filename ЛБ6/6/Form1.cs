namespace _6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "������ ����� ��� �������� �� � �� ����������:";
            label2.Text = "���������: ";
            label3.Text = " ";
            button1.Text = "���������";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;

            if (IsPalindrome(input))
                label3.Text = "����� � ����������.";
            else
                label3.Text = "����� �� � ����������.";
        }
        private bool IsPalindrome(string str)
        {
            int i = 0;
            int j = str.Length - 1;

            while (i < j)
            {
                if (str[i] != str[j])
                    return false;

                i++;
                j--;
            }
            return true;
        }
    }
}
