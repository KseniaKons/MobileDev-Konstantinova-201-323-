namespace WinFormsSearchCity
{
    public partial class Form1 : Form
    {
        private string[] cities;

        public Form1()
        {
            InitializeComponent();

            cities = Properties.Resources.goroda1.Split('\n');

            edSearch.TextChanged += EdSearch_TextChanged;
        }

        private void EdSearch_TextChanged(object? sender, EventArgs e)
        {
            

            var r = cities.Where(v => v.ToUpper().Contains(edSearch.Text.ToUpper()))
                .Where(v => v != "")
                .Where(v => ! v.Contains("Список городов России в формате *.txt - текстовый файл."))
                .OrderBy(v => v)
                .Take(100)
                .ToArray();
            edResult.Text = String.Join(Environment.NewLine, r);   

            Text = $"{Application.ProductName}  : {edSearch.Text}, Count = {r.Count()}";
            
        }
    }
}