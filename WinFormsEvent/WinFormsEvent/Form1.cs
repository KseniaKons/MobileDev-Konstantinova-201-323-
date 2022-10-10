namespace WinFormsEvent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            button2.Click += Button2_Click;

            button3.Click += delegate
            {
                MessageBox.Show("Test 3");
            };

            //button3.Click += Button2_Click;

            button4.Click +=  (s,e) => MessageBox.Show("Test 4");
        }

        private void Button2_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Test 2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test 1");
        }
    }
}