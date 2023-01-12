using System.Diagnostics;
using System.Drawing;

namespace Exam_18__wfa_
{
    public partial class Form1 : Form
    {

        string[] levels;
        int gameLevel;
        private PictureBox[,] piB;
        int[,] busy = new int[100, 100];
        private readonly Stopwatch stopwatch = new Stopwatch();
        int kolCells;
        int circle;
        int colorV;
        bool vzato = false;
        int str, colon;
        int strP, colonP;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();

            //this.cBLevel.FormattingEnabled = true;
            this.cBLevel.Items.AddRange(new object[] {
            "Уровень1",
            "Уровень2",
            "Уровень3"});

            laTimer.Text = $"Прошло Времени: 00:00";

            cBLevel.SelectionChangeCommitted += CBLevel_SelectionChangeCommitted;


            laName.Text = $"LINE 98";

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    busy[i, j] = 0;
                }
            }

            
        }

        private void CBLevel_SelectionChangeCommitted(object? sender, EventArgs e)
        {
            panel1.Controls.Clear();
            timer1.Start();
            timer1.Tick += Timer1_Tick;
            stopwatch.Start();
            CreateCells(gameLevel);
            CirclePaintOne();
            
            Invalidate();
        }

        //private void CirclePost()
        //{
        //    throw new NotImplementedException();
        //}

        private void Timer1_Tick(object? sender, EventArgs e)
        {
            
            laTimer.Text = $"Прошло Времени: { stopwatch.Elapsed.ToString("mm\\:ss")}";
        }

        

        public void chekLevel()
        {
           
            levels = new string[] { "Уровень 1", "Уровень 2", "Уровень 3" };

            string chooseLevel1 = cBLevel.SelectedIndex.ToString();

            if (chooseLevel1 == "0")
            {
                gameLevel = 1;
            }
            else if (chooseLevel1 == "1")
            {
                gameLevel = 2;
            }
            else if (chooseLevel1 == "2")
            {
                gameLevel = 3;
            }



            if (gameLevel == 1)
                kolCells = 5;
            else if (gameLevel == 2)
                kolCells = 7;
            else if (gameLevel == 3)
                kolCells = 10;
        }

        private void CreateCells(int gameLevel)
        {
            chekLevel();

           
            piB = new PictureBox[5, kolCells];


            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < kolCells; j++)
                {
                    piB[i, j] = new PictureBox();
                    piB[i, j].Size = new Size(100, 100);
                    piB[i, j].BorderStyle = BorderStyle.FixedSingle;
                    piB[i, j].Location = new Point(250 + j * 100, 10 + i * 100);
                    panel1.Controls.Add(piB[i, j]);
                    piB[i, j].Click += PerenosObj;
                    piB[i, j].Click += PostObj;
                }
            }

            Invalidate();

        }

        private void PostObj(object? sender, EventArgs e)
        {
            PictureBox pressedPictureBox = sender as PictureBox;
            int id = pressedPictureBox.TabIndex.GetHashCode();
            id++;

            chekLevel();
            int c = 1;
            if (gameLevel == 1)
                c = 5;
            else if (gameLevel == 2)
                c = 7;
            else if (gameLevel == 3)
                c = 10;


            colonP = id % c;
            if (colonP == 0)
                colonP = c;

            if (id > 0 && id < 6)
                strP = 1;
            else if (id > 5 && id < 11)
                strP = 2;
            else if (id > 10 && id < 16)
                strP = 3;
            else if (id > 15 && id < 21)
                strP = 4;
            else if (id > 20 && id < 26)
                strP = 5;

            colonP--;
            strP--;

            if (busy[strP, colonP] != 1 && busy[strP, colonP] != 2 && busy[strP, colonP] != 3)
            {
                if (vzato == true)
                {
                    vzato = false;
                    busy[strP, colonP] = colorV;
                    CirclePost(strP, colonP, colorV);
                }


            }
        }

        private void CirclePost(int _a, int _b, int colorV)
        {
            piB[_a, _b].Image = new Bitmap(100, 100);
            var g = Graphics.FromImage(piB[_a, _b].Image);
            switch (colorV)
            {
                case 1:
                    g.DrawImage(Properties.Resources.BlueCircle, new Rectangle(0, 0, 100, 100));
                    busy[_a, _b] = 1;
                    break;
                case 2:
                    g.DrawImage(Properties.Resources.GreenCircle, new Rectangle(0, 0, 100, 100));
                    busy[_a, _b] = 2;
                    break;
                case 3:
                    g.DrawImage(Properties.Resources.RedCircle, new Rectangle(0, 0, 100, 100));
                    busy[_a, _b] = 3;
                    break;
            }
            Invalidate();
        }

        private void PerenosObj(object? sender, EventArgs e)
        {
            PictureBox pressedPictureBox = sender as PictureBox;
            int id1 = pressedPictureBox.TabIndex.GetHashCode();
            id1++;

            chekLevel();
            int c = 1;
            if (gameLevel == 1)
                c = 5;
            else if (gameLevel == 2)
                c = 7;
            else if (gameLevel == 3)
                c = 10;


            colon = id1 % c;
            if (colon == 0)
                colon = c;

            if (id1 > 0 && id1 < 6)
                str = 1;
            else if (id1 > 5 && id1 < 11)
                str = 2;
            else if (id1 > 10 && id1 < 16)
                str = 3;
            else if (id1 > 15 && id1 < 21)
                str = 4;
            else if (id1 > 20 && id1 < 26)
                str = 5;

            colon--;
            str--;

            if (busy[str, colon] == 1 || busy[str, colon] == 2 || busy[str, colon] == 3)
            {
                if (vzato == false)
                {
                    vzato = true;
                    colorV = busy[str, colon];
                    busy[str, colon] = 0;
                    CircleVzato(str, colon, colorV);
                }


            }

        }

        private void CircleVzato(int _a, int _b, int colorV)
        {
            piB[_a, _b].Image = new Bitmap(50, 50);
            var g = Graphics.FromImage(piB[_a, _b].Image);
            switch (colorV)
            {
                case 1:
                    g.DrawImage(Properties.Resources.BlueCircle, new Rectangle(0, 0, 50, 50));
                    busy[_a, _b] = 1;
                    break;
                case 2:
                    g.DrawImage(Properties.Resources.GreenCircle, new Rectangle(0, 0, 50, 50));
                    busy[_a, _b] = 2;
                    break;
                case 3:
                    g.DrawImage(Properties.Resources.RedCircle, new Rectangle(0, 0, 50, 50));
                    busy[_a, _b] = 3;
                    break;
            }
            Invalidate();
        }

        private void CirclePaintOne()
        {
            chekLevel();
            int a = 10 + 5 * (gameLevel - 1) + 1;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < kolCells; j++)
                {
                    circle = rnd.Next(1, a);
                    piB[i, j].Image = new Bitmap(100, 100);
                    var g = Graphics.FromImage(piB[i, j].Image);
                    switch (circle)
                    {
                        case 1:
                            g.DrawImage(Properties.Resources.BlueCircle, new Rectangle(0, 0, 100, 100));
                            busy[i, j] = 1;
                            break;
                        case 2:
                            g.DrawImage(Properties.Resources.GreenCircle, new Rectangle(0, 0, 100, 100));
                            busy[i, j] = 2;
                            break;
                        case 3:
                            g.DrawImage(Properties.Resources.RedCircle, new Rectangle(0, 0, 100, 100));
                            busy[i, j] = 3;
                            break;
                    }

                }
            }
            Invalidate();
        }
    }
}