namespace WinFormsPaint
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.buImageSaveBuffer = new System.Windows.Forms.Button();
            this.buImageSaveToFile = new System.Windows.Forms.Button();
            this.buImageLoadFromFile = new System.Windows.Forms.Button();
            this.buImageClear = new System.Windows.Forms.Button();
            this.pxBlack = new System.Windows.Forms.PictureBox();
            this.trPenWidth = new System.Windows.Forms.TrackBar();
            this.pxGreen = new System.Windows.Forms.PictureBox();
            this.pxYellow = new System.Windows.Forms.PictureBox();
            this.pxRed = new System.Windows.Forms.PictureBox();
            this.pxBlue = new System.Windows.Forms.PictureBox();
            this.pxImage = new System.Windows.Forms.PictureBox();
            this.buDrawPencil = new System.Windows.Forms.Button();
            this.buDrawLine = new System.Windows.Forms.Button();
            this.buDrawEllipse = new System.Windows.Forms.Button();
            this.buDraweRctangle = new System.Windows.Forms.Button();
            this.buDrawTriangle = new System.Windows.Forms.Button();
            this.ckFillMode = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxBlack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trPenWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ckFillMode);
            this.panel1.Controls.Add(this.buDrawTriangle);
            this.panel1.Controls.Add(this.buDraweRctangle);
            this.panel1.Controls.Add(this.buDrawEllipse);
            this.panel1.Controls.Add(this.buDrawLine);
            this.panel1.Controls.Add(this.buDrawPencil);
            this.panel1.Controls.Add(this.buImageSaveBuffer);
            this.panel1.Controls.Add(this.buImageSaveToFile);
            this.panel1.Controls.Add(this.buImageLoadFromFile);
            this.panel1.Controls.Add(this.buImageClear);
            this.panel1.Controls.Add(this.pxBlack);
            this.panel1.Controls.Add(this.trPenWidth);
            this.panel1.Controls.Add(this.pxGreen);
            this.panel1.Controls.Add(this.pxYellow);
            this.panel1.Controls.Add(this.pxRed);
            this.panel1.Controls.Add(this.pxBlue);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 620);
            this.panel1.TabIndex = 0;
            // 
            // buImageSaveBuffer
            // 
            this.buImageSaveBuffer.Location = new System.Drawing.Point(12, 256);
            this.buImageSaveBuffer.Name = "buImageSaveBuffer";
            this.buImageSaveBuffer.Size = new System.Drawing.Size(149, 57);
            this.buImageSaveBuffer.TabIndex = 10;
            this.buImageSaveBuffer.Text = "Сохранить в буфер обмена";
            this.buImageSaveBuffer.UseVisualStyleBackColor = true;
            // 
            // buImageSaveToFile
            // 
            this.buImageSaveToFile.Location = new System.Drawing.Point(12, 211);
            this.buImageSaveToFile.Name = "buImageSaveToFile";
            this.buImageSaveToFile.Size = new System.Drawing.Size(149, 29);
            this.buImageSaveToFile.TabIndex = 9;
            this.buImageSaveToFile.Text = "Сохранить";
            this.buImageSaveToFile.UseVisualStyleBackColor = true;
            // 
            // buImageLoadFromFile
            // 
            this.buImageLoadFromFile.Location = new System.Drawing.Point(12, 166);
            this.buImageLoadFromFile.Name = "buImageLoadFromFile";
            this.buImageLoadFromFile.Size = new System.Drawing.Size(149, 29);
            this.buImageLoadFromFile.TabIndex = 8;
            this.buImageLoadFromFile.Text = "Открыть";
            this.buImageLoadFromFile.UseVisualStyleBackColor = true;
            // 
            // buImageClear
            // 
            this.buImageClear.Location = new System.Drawing.Point(12, 118);
            this.buImageClear.Name = "buImageClear";
            this.buImageClear.Size = new System.Drawing.Size(149, 29);
            this.buImageClear.TabIndex = 7;
            this.buImageClear.Text = "Очистить";
            this.buImageClear.UseVisualStyleBackColor = true;
            // 
            // pxBlack
            // 
            this.pxBlack.BackColor = System.Drawing.Color.Black;
            this.pxBlack.Location = new System.Drawing.Point(135, 23);
            this.pxBlack.Name = "pxBlack";
            this.pxBlack.Size = new System.Drawing.Size(26, 19);
            this.pxBlack.TabIndex = 6;
            this.pxBlack.TabStop = false;
            // 
            // trPenWidth
            // 
            this.trPenWidth.Location = new System.Drawing.Point(3, 57);
            this.trPenWidth.Minimum = 1;
            this.trPenWidth.Name = "trPenWidth";
            this.trPenWidth.Size = new System.Drawing.Size(168, 56);
            this.trPenWidth.TabIndex = 5;
            this.trPenWidth.Value = 1;
            // 
            // pxGreen
            // 
            this.pxGreen.BackColor = System.Drawing.Color.Lime;
            this.pxGreen.Location = new System.Drawing.Point(103, 23);
            this.pxGreen.Name = "pxGreen";
            this.pxGreen.Size = new System.Drawing.Size(26, 19);
            this.pxGreen.TabIndex = 3;
            this.pxGreen.TabStop = false;
            // 
            // pxYellow
            // 
            this.pxYellow.BackColor = System.Drawing.Color.Yellow;
            this.pxYellow.Location = new System.Drawing.Point(71, 23);
            this.pxYellow.Name = "pxYellow";
            this.pxYellow.Size = new System.Drawing.Size(26, 19);
            this.pxYellow.TabIndex = 2;
            this.pxYellow.TabStop = false;
            // 
            // pxRed
            // 
            this.pxRed.BackColor = System.Drawing.Color.Red;
            this.pxRed.Location = new System.Drawing.Point(39, 23);
            this.pxRed.Name = "pxRed";
            this.pxRed.Size = new System.Drawing.Size(26, 19);
            this.pxRed.TabIndex = 1;
            this.pxRed.TabStop = false;
            // 
            // pxBlue
            // 
            this.pxBlue.BackColor = System.Drawing.Color.Blue;
            this.pxBlue.Location = new System.Drawing.Point(7, 23);
            this.pxBlue.Name = "pxBlue";
            this.pxBlue.Size = new System.Drawing.Size(26, 19);
            this.pxBlue.TabIndex = 0;
            this.pxBlue.TabStop = false;
            // 
            // pxImage
            // 
            this.pxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pxImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pxImage.Location = new System.Drawing.Point(174, 0);
            this.pxImage.Name = "pxImage";
            this.pxImage.Size = new System.Drawing.Size(701, 620);
            this.pxImage.TabIndex = 1;
            this.pxImage.TabStop = false;
            // 
            // button1
            // 
            this.buDrawPencil.Location = new System.Drawing.Point(12, 335);
            this.buDrawPencil.Name = "button1";
            this.buDrawPencil.Size = new System.Drawing.Size(149, 29);
            this.buDrawPencil.TabIndex = 11;
            this.buDrawPencil.Text = "Карандаш";
            this.buDrawPencil.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.buDrawLine.Location = new System.Drawing.Point(12, 370);
            this.buDrawLine.Name = "button2";
            this.buDrawLine.Size = new System.Drawing.Size(149, 29);
            this.buDrawLine.TabIndex = 12;
            this.buDrawLine.Text = "Линия";
            this.buDrawLine.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.buDrawEllipse.Location = new System.Drawing.Point(12, 405);
            this.buDrawEllipse.Name = "button3";
            this.buDrawEllipse.Size = new System.Drawing.Size(149, 29);
            this.buDrawEllipse.TabIndex = 13;
            this.buDrawEllipse.Text = "Элипс";
            this.buDrawEllipse.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.buDraweRctangle.Location = new System.Drawing.Point(12, 440);
            this.buDraweRctangle.Name = "button4";
            this.buDraweRctangle.Size = new System.Drawing.Size(149, 29);
            this.buDraweRctangle.TabIndex = 14;
            this.buDraweRctangle.Text = "Прямоугольник";
            this.buDraweRctangle.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.buDrawTriangle.Location = new System.Drawing.Point(12, 475);
            this.buDrawTriangle.Name = "button5";
            this.buDrawTriangle.Size = new System.Drawing.Size(149, 29);
            this.buDrawTriangle.TabIndex = 15;
            this.buDrawTriangle.Text = "Треугольник";
            this.buDrawTriangle.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.ckFillMode.AutoSize = true;
            this.ckFillMode.Location = new System.Drawing.Point(18, 510);
            this.ckFillMode.Name = "checkBox1";
            this.ckFillMode.Size = new System.Drawing.Size(143, 24);
            this.ckFillMode.TabIndex = 17;
            this.ckFillMode.Text = "Заливка фигуры";
            this.ckFillMode.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 620);
            this.Controls.Add(this.pxImage);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Paint";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxBlack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trPenWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox pxImage;
        private TrackBar trPenWidth;
        private PictureBox pxGreen;
        private PictureBox pxYellow;
        private PictureBox pxRed;
        private PictureBox pxBlue;
        private PictureBox pxBlack;
        private Button buImageSaveBuffer;
        private Button buImageSaveToFile;
        private Button buImageLoadFromFile;
        private Button buImageClear;
        private Button buDrawPencil;
        private Button buDrawTriangle;
        private Button buDraweRctangle;
        private Button buDrawEllipse;
        private Button buDrawLine;
        private CheckBox ckFillMode;
    }
}