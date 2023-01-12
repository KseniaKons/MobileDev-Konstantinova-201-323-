namespace Exam_18__wfa_
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
            this.components = new System.ComponentModel.Container();
            this.laName = new System.Windows.Forms.Label();
            this.laTimer = new System.Windows.Forms.Label();
            this.cBLevel = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // laName
            // 
            this.laName.AutoSize = true;
            this.laName.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.laName.Location = new System.Drawing.Point(431, 23);
            this.laName.Name = "laName";
            this.laName.Size = new System.Drawing.Size(130, 54);
            this.laName.TabIndex = 1;
            this.laName.Text = "label1";
            // 
            // laTimer
            // 
            this.laTimer.AutoSize = true;
            this.laTimer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.laTimer.Location = new System.Drawing.Point(880, 19);
            this.laTimer.Name = "laTimer";
            this.laTimer.Size = new System.Drawing.Size(65, 28);
            this.laTimer.TabIndex = 2;
            this.laTimer.Text = "label2";
            // 
            // cBLevel
            // 
            this.cBLevel.FormattingEnabled = true;
            this.cBLevel.Location = new System.Drawing.Point(37, 19);
            this.cBLevel.Name = "cBLevel";
            this.cBLevel.Size = new System.Drawing.Size(170, 28);
            this.cBLevel.TabIndex = 3;
            this.cBLevel.Text = "Уровень сложности";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1478, 530);
            this.panel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 653);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cBLevel);
            this.Controls.Add(this.laTimer);
            this.Controls.Add(this.laName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label laName;
        private Label laTimer;
        private ComboBox cBLevel;
        private System.Windows.Forms.Timer timer1;
        private Panel panel1;
    }
}