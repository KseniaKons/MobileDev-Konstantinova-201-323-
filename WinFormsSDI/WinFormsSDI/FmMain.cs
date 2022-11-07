namespace WinFormsSDI
{
    public partial class FmMain : Form
    {
        private readonly FmOptions FmOptions = new();

        public FmMain()
        {
            InitializeComponent();

            // для FmOptions.Show();
            FmOptions.FormClosing += (s, e) =>
            {
               e.Cancel = true;
                FmOptions.Hide();
            };


            button1.Click += (s, e) => new FormAbout().Show();
            button2.Click += (s, e) => new FormAbout().ShowDialog();
            button3.Click += (s, e) => FmOptions.Show();
            button4.Click += (s, e) => FmOptions.ShowDialog();
        }
    }
}