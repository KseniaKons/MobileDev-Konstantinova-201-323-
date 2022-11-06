using System.Windows.Forms;



namespace WinFormsImageScroll
{
    public partial class Form1 : Form
    {
        private Bitmap p;
        private Point startPoint;
        private Point curPoint = new Point(0, 0);
        private Rectangle rect = new Rectangle (0,0,300,300);
        public static int NumImage { get; private set; } = 0;
        public int ZoomDel1 { get; private set; } = 100;
        int xDelta;
        

        public Form1()
        {
            InitializeComponent();

            NextImage();

            
            
           // pxImage.Paint += (s, e) => e.Graphics.DrawImage(p, curPoint);
            // public void DrawImage(Image image, int x, int y, Rectangle srcRect, GraphicsUnit srcUnit);


            pxImage.Paint += (s, e) => e.Graphics.DrawImageUnscaled(p, rect);

            //pxImage.Image = p;


            pxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;  
            
            

            pxImage.MouseMove += PxImage_MouseMove;
            pxImage.MouseWheel += PxImage_MouseWheel;
            pxImage.MouseDown += PxImage_MouseDown;

           this.KeyDown += Form1_KeyDown;
           this.Text += $" : F1 - Следующая картинка";

        }

        private void PxImage_MouseDown(object? sender, MouseEventArgs e)
        {
            startPoint = e.Location;
        }

        private void NextImage()
        {
            NumImage = ++NumImage % 2;
            switch (NumImage)
            {
                case 0:
                    p = new Bitmap(Properties.Resources._123); 
                    break;
                case 1:
                    p = new Bitmap(Properties.Resources._456);
                    break;
            }
            pxImage.Invalidate();
            RefresStatus();
        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            
            switch(e.KeyCode)
            {
                case Keys.F1:
                    NextImage();
                    break;
            }

        }

        private void PxImage_MouseWheel(object? sender, MouseEventArgs e)
        {

            xDelta = e.Delta > 0 ? 2 : -2;
            ZoomDel1 += xDelta;
            if (sender is Control c)
            {
                c.Location = new Point(
                        c.Location.X - xDelta,
                        c.Location.Y - xDelta
                    );
                c.Width += xDelta * 2;
                c.Height += xDelta * 2;
                //rect = new Rectangle (c.Location.X, c.Location.Y, c.Width, c.Height);   
            }
            pxImage.Invalidate();
            RefresStatus();
        }

        private void PxImage_MouseMove(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                curPoint.X += e.X - startPoint.X;
                curPoint.Y += e.Y - startPoint.Y;
                pxImage.Invalidate();
            }

            RefresStatus();

        }

        private void RefresStatus()
        {
           // LaStatus.Text = $" NumImage = {NumImage}, startPoint = {startPoint}, curPoint = {curPoint}, ZoomDel = {ZoomDel1}";
            LaStatus.Text = $" NumImage = {NumImage}, startPoint = {startPoint}, rect = {rect}, ZoomDel = {ZoomDel1}";
        }
    }
}