namespace WinFormsSender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            button1.Click += ButtonAll_Click;
            button2.Click += ButtonAll_Click;
            checkBox1.Click += ButtonAll_Click;
            label1.Click += ButtonAll_Click;

        }

        private void ButtonAll_Click(object? sender, EventArgs e)
        {
            //button1.Text += "*";

            //Button button = sender as Button;
            //button.Text += "*";

            //if(sender is Button)
            //    (sender as Button).Text += "*";


            //if (sender is CheckBox)
            //    (sender as CheckBox).Text += "!";

            if (sender is Control)
                (sender as Control).Text += "!";



        }
    }
}