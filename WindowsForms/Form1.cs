namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(button1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(button15.Text);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(button2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(button3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(button4.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(button5.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(button6.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(button7.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(button8.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(button9.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(button10.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(button11.Text);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(button12.Text);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(button13.Text);
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }
    }
}
