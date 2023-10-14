
namespace WordPad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            var netice = colorDialog1.ShowDialog();

            if(netice == DialogResult.OK)
            {
            }
            
        }
        Color _color = Color.Black;
        //Font font = Font.

        private void panel7_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                _color= colorDialog1.Color;
                richTextBox1.ForeColor = _color;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            var netice = fontDialog1.ShowDialog();

            if(netice == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Font font  = fontDialog1.Font;
           // var netice_ = fontDialog1.ShowDialog();

            

                richTextBox1.SelectionFont = new Font(font, FontStyle.Bold);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var netice = openFileDialog1.ShowDialog();

            if(netice == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Font font = fontDialog1.Font;
            // var netice_ = fontDialog1.ShowDialog();



            richTextBox1.SelectionFont = new Font(font, FontStyle.Underline);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Font font = fontDialog1.Font;
            // var netice_ = fontDialog1.ShowDialog();



            richTextBox1.SelectionFont = new Font(font, FontStyle.Italic);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var netice = fontDialog1.ShowDialog();

            if (netice == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;

            }


        }
    }
}