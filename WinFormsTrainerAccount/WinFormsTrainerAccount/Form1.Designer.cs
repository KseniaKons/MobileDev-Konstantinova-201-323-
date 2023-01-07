namespace WinFormsTrainerAccount
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
            this.label4 = new System.Windows.Forms.Label();
            this.laCode = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buNo = new System.Windows.Forms.Button();
            this.buYes = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.laWrong = new System.Windows.Forms.Label();
            this.laCorrect = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(137, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(804, 37);
            this.label4.TabIndex = 7;
            this.label4.Text = "Верно?";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // laCode
            // 
            this.laCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.laCode.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.laCode.Location = new System.Drawing.Point(293, 150);
            this.laCode.Name = "laCode";
            this.laCode.Size = new System.Drawing.Size(486, 93);
            this.laCode.TabIndex = 6;
            this.laCode.Text = "10 + 11 = 21";
            this.laCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.buYes, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buNo, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(134, 283);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(804, 154);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // buNo
            // 
            this.buNo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buNo.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buNo.Location = new System.Drawing.Point(405, 3);
            this.buNo.Name = "buNo";
            this.buNo.Size = new System.Drawing.Size(396, 148);
            this.buNo.TabIndex = 1;
            this.buNo.Text = "Нет";
            this.buNo.UseVisualStyleBackColor = true;
            // 
            // buYes
            // 
            this.buYes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buYes.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buYes.ForeColor = System.Drawing.Color.Green;
            this.buYes.Location = new System.Drawing.Point(3, 3);
            this.buYes.Name = "buYes";
            this.buYes.Size = new System.Drawing.Size(396, 148);
            this.buYes.TabIndex = 0;
            this.buYes.Text = "Да";
            this.buYes.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.laCorrect, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.laWrong, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(134, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(804, 135);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // laWrong
            // 
            this.laWrong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.laWrong.AutoSize = true;
            this.laWrong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.laWrong.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.laWrong.Location = new System.Drawing.Point(405, 0);
            this.laWrong.Name = "laWrong";
            this.laWrong.Size = new System.Drawing.Size(396, 135);
            this.laWrong.TabIndex = 1;
            this.laWrong.Text = "НеВерно = 0";
            this.laWrong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // laCorrect
            // 
            this.laCorrect.AutoSize = true;
            this.laCorrect.BackColor = System.Drawing.Color.LightGreen;
            this.laCorrect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.laCorrect.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.laCorrect.Location = new System.Drawing.Point(3, 0);
            this.laCorrect.Name = "laCorrect";
            this.laCorrect.Size = new System.Drawing.Size(396, 135);
            this.laCorrect.TabIndex = 0;
            this.laCorrect.Text = "Верно = 0";
            this.laCorrect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 470);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.laCode);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label4;
        private Label laCode;
        private TableLayoutPanel tableLayoutPanel2;
        private Button buYes;
        private Button buNo;
        private TableLayoutPanel tableLayoutPanel1;
        private Label laCorrect;
        private Label laWrong;
    }
}