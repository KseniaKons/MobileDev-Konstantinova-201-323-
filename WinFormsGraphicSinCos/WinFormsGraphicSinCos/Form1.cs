namespace WinFormsGraphicSinCos
{
    public partial class Form1 : Form
    {
        private const int DOT_WIDHT = 3;
        private const int DOT_HEIGHT = 3;

        public Form1()
        {
            InitializeComponent();

            this.BackgroundImageLayout = ImageLayout.None;

            DrawAll();
            this.Resize += (s, e) => DrawAll();
            this.Text += " : (Sin - красный, Cos - синий, Tan - заленый)";
            ll.BringToFront();
            this.MouseMove += MouseMoveSinCosTan;
        }
        
        private void MouseMoveSinCosTan(object? sender, MouseEventArgs e)
        {
            ll.Text = $"Sin = {Math.Sin(5 * Math.PI * e.X / ClientSize.Width)}, Cos = {Math.Cos(5 * Math.PI * e.X / ClientSize.Width)} , Tan = {Math.Tan(5 * Math.PI * e.X / ClientSize.Width)}";

            if (sender is Control c)
            {
                ll.Location = new Point(
                    e.X + 5,
                    e.Y + 5
                    );
               
            }
            var b = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
            var g = Graphics.FromImage(b);

            GC.Collect();
        }

        private void DrawAll()
        {

            var b = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
            var g = Graphics.FromImage(b);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            var grShiftY = b.Height / 2;    
            var grShiftX = b.Width / 2;
            var grCountWave = 5; //количесвто волн 
            var grHeight = grShiftY * 0.9; //половина высоты графика
            var grWidthPI = Math.PI / (b.Width - 1); //ширина отрезка пи в радианах

            //рисуем ось Х

            g.DrawLine(new Pen(Color.Black), 0, grShiftY, b.Width, grShiftY);
            for (int i = 1; i < grCountWave; i++)
            {
                var xPoint = b.Width / grCountWave * i;
                g.DrawLine(Pens.Black, xPoint, grShiftY - 15, xPoint, grShiftY + 15);
                g.DrawString($"{i} pi", new Font("", 10), new SolidBrush(Color.Black), xPoint - 10 , grShiftY + 5);
            }

            //рисуем ось У

            g.DrawLine(new Pen(Color.Black), grShiftX, 0 , grShiftX, b.Height);
           
            float x;
            float y;

            for (int i = 0; i < b.Width; i++)
            {
                 //рисуем график синуса
                x = i;
                y = (float) (grHeight * (-Math.Sin(i * grCountWave * grWidthPI)) + grShiftY);
                g.FillEllipse(new SolidBrush(Color.Red), x - DOT_WIDHT/2, y - DOT_HEIGHT / 2, DOT_WIDHT, DOT_HEIGHT);

                //рисуем график косинуса
                y = (float)(grHeight * (-Math.Cos(i * grCountWave * grWidthPI)) + grShiftY);
                g.FillEllipse(new SolidBrush(Color.Green), x - DOT_WIDHT / 2, y - DOT_HEIGHT / 2, DOT_WIDHT, DOT_HEIGHT);

                y = (float)(grHeight * (-Math.Tan(i * grCountWave * grWidthPI)) + grShiftY);
                if (y>0 && y<b.Height)
                {
                    g.FillEllipse(new SolidBrush(Color.Blue), x - DOT_WIDHT / 2, y - DOT_HEIGHT / 2, DOT_WIDHT, DOT_HEIGHT);
                }
                
            }


            
            //рисуем график тангенса

            this.BackgroundImage = (Bitmap)b.Clone();
        }
    }
}