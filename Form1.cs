namespace Calculator
{
    public partial class Form1 : Form
    {
        double x, y;
        string Symbol;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text += "1";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }
        
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text += "0";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            Symbol = "*";
            label1.Text = textBox1.Text + "*";
            textBox1.Text = "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            y = Convert.ToDouble(textBox1.Text);
            if (Symbol == "*")
            {
                textBox1.Text = Convert.ToString(x * y);
                label1.Text = "";
            }
            if (Symbol == "+")
            {
                textBox1.Text = Convert.ToString(x + y);
                label1.Text = "";
            }
            if (Symbol == "-")
            {
                textBox1.Text = Convert.ToString(x - y);
                label1.Text = "";
            }
            if (Symbol == "/")
            {
                textBox1.Text = Convert.ToString(x / y);
                label1.Text = "";
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            Symbol = "+";
            label1.Text = textBox1.Text + "+";
            textBox1.Text = "0";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            Symbol = "-";
            label1.Text = textBox1.Text + "-";
            textBox1.Text = "0";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            Symbol = "/";
            label1.Text = textBox1.Text + "/";
            textBox1.Text = "0";
        }
    }
}
