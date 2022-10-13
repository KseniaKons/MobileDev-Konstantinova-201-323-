using System.Windows.Forms;

namespace WinFormsPaint
{
    public partial class Form1 : Form
    {
        private Bitmap b;
        private Graphics g;
        private Point startMousDown;
        private Bitmap bb;
        private Pen myPen;
        private MyDrawMode myDrawMode = MyDrawMode.Pencil;

        enum MyDrawMode
    {
            Pencil,
            Line,
            Ellipse,
            Rctangle,
            Triangle
        }

        public Form1()
        {
            InitializeComponent();

            b = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);//полотно
            g = Graphics.FromImage(b); //инструменты для рисования
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            myPen = new Pen(pxBlue.BackColor, 10);
            myPen.StartCap = myPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            pxBlue.Click += (s, e) => myPen.Color = pxBlue.BackColor;
            pxRed.Click += (s, e) => myPen.Color = pxRed.BackColor;
            pxYellow.Click += (s, e) => myPen.Color = pxYellow.BackColor;
            pxGreen.Click += (s, e) => myPen.Color = pxGreen.BackColor;
            pxBlack.Click += (s, e) => myPen.Color = pxBlack.BackColor;

            trPenWidth.Value = Convert.ToInt32(myPen.Width);
            trPenWidth.ValueChanged += (s,e) => myPen.Width = trPenWidth.Value;


            pxImage.MouseDown += PxImage_MouseDown;
            pxImage.MouseMove += PxImage_MouseMove;
            pxImage.MouseUp += PxImage_MouseUp;
            pxImage.Paint += (s, e) => e.Graphics.DrawImage(b, 0, 0);

            buImageClear.Click += BuImageClear_Click;
            buImageLoadFromFile.Click += BuImageLoadFromFile_Click;
            buImageSaveToFile.Click += BuImageSaveToFile_Click;
            buImageSaveBuffer.Click += (s, e) => Clipboard.SetImage(b);

            buDrawPencil.Click += (s, e) => myDrawMode = MyDrawMode.Pencil;
            buDrawLine.Click += (s, e) => myDrawMode = MyDrawMode.Line;
            buDrawEllipse.Click += (s, e) => myDrawMode = MyDrawMode.Ellipse;
            buDraweRctangle.Click += (s, e) => myDrawMode = MyDrawMode.Rctangle;
            buDrawTriangle.Click += (s, e) => myDrawMode = MyDrawMode.Triangle;
           

        }

        private void BuImageSaveToFile_Click(object? sender, EventArgs e)
        {
            SaveFileDialog Dialog = new SaveFileDialog();
            Dialog.Filter = "Image Files(*.PNG)| *.PNG";
            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                b.Save(Dialog.FileName);
                //b.Save(Dialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }

        private void BuImageLoadFromFile_Click(object? sender, EventArgs e)
        {
            OpenFileDialog Dialog = new OpenFileDialog();
            Dialog.Filter = "Image Files(*.BMP; *.JPG; *.GIF)| *.BMP; *.JPG; *.GIF";

            g.Clear(DefaultBackColor);
            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                g.DrawImage(Bitmap.FromFile(Dialog.FileName), 0, 0);
            }
            pxImage.Invalidate();
        }

        private void BuImageClear_Click(object? sender, EventArgs e)
        {
            g.Clear(DefaultBackColor);
            pxImage.Invalidate();
        }

        private void PxImage_MouseUp(object? sender, MouseEventArgs e)
        {
            //
        }

        private void PxImage_MouseMove(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // g.DrawLine(myPen, startMousDown, e.Location);
                // startMousDown = e.Location;

                switch (myDrawMode)
                {
                    case MyDrawMode.Pencil:
                        g.DrawLine(myPen, startMousDown, e.Location);
                        startMousDown = e.Location;
                        break;

                    case MyDrawMode.Line:
                        RestorBitMap();
                        g.DrawLine(myPen, startMousDown, e.Location);

                        break;

                    case MyDrawMode.Ellipse:
                        RestorBitMap();

                        if (ckFillMode.Checked)
                        {
                            g.FillEllipse(new SolidBrush(myPen.Color),
                                new Rectangle(startMousDown.X, startMousDown.Y,
                            e.X - startMousDown.X, e.Y - startMousDown.Y));
                        }
                        else
                        {

                            g.DrawEllipse(myPen,
                            new Rectangle(startMousDown.X, startMousDown.Y,
                            e.X - startMousDown.X, e.Y - startMousDown.Y));
                        }
                        break;

                    case MyDrawMode.Rctangle:
                        RestorBitMap();
                        break;

                    case MyDrawMode.Triangle:
                        RestorBitMap();
                        break;

                    default:
                        break;
                }

                pxImage.Invalidate();

            }
        }

        private void RestorBitMap()
        {
            g.Dispose();
            b.Dispose();
            b = (Bitmap)bb.Clone();
            g = Graphics.FromImage(b);
        }

        private void PxImage_MouseDown(object? sender, MouseEventArgs e)
        {
            startMousDown = e.Location;
            bb = (Bitmap)b.Clone();

        }

        
    }

}