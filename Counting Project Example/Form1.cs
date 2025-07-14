namespace Counting_Project_Example
{
    public partial class Form1 : Form
    {

        private int term1 = 0;
        private int term2 = 0;

        private int result = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        // +
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textEntry1.Text) && !string.IsNullOrEmpty(textEntry2.Text))
            {
                term1 = Convert.ToInt32(textEntry1.Text);
                term2 = Convert.ToInt32(textEntry2.Text);
                result = term1 + term2;
                resultBox.Text = result.ToString();
            }
        }


        // -
        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textEntry1.Text) && !string.IsNullOrEmpty(textEntry2.Text))
            {
                term1 = Convert.ToInt32(textEntry1.Text);
                term2 = Convert.ToInt32(textEntry2.Text);
                result = term1 - term2;
                resultBox.Text = result.ToString();
            }
        }

        // *
        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textEntry1.Text) && !string.IsNullOrEmpty(textEntry2.Text))
            {
                term1 = Convert.ToInt32(textEntry1.Text);
                term2 = Convert.ToInt32(textEntry2.Text);
                result = term1 * term2;
                resultBox.Text = result.ToString();
            }
        }

        // /
        private void button4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textEntry1.Text) && !string.IsNullOrEmpty(textEntry2.Text) && Convert.ToInt32(textEntry2.Text) != 0)
            {
                term1 = Convert.ToInt32(textEntry1.Text);
                term2 = Convert.ToInt32(textEntry2.Text);
                result = term1 / term2;
                resultBox.Text = result.ToString();
            }
        }

        // Entry 1
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // Entry 2
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        // Result
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
