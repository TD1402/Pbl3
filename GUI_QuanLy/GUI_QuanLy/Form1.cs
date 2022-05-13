namespace GUI_QuanLy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            if (textBox2.Text == "") { textBox2.Text = "Password"; }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            if (textBox1.Text == "") { textBox1.Text = "Username"; }

        }
    }
}