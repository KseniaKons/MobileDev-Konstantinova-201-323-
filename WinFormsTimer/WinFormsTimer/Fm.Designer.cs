namespace WinFormsTimer
{
    partial class Fm
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
            this.laDownStatus = new System.Windows.Forms.Label();
            this.pbDownMs = new System.Windows.Forms.ProgressBar();
            this.pbDown = new System.Windows.Forms.ProgressBar();
            this.buDownPause = new System.Windows.Forms.Button();
            this.buDown = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pbUpMs = new System.Windows.Forms.ProgressBar();
            this.pbUp = new System.Windows.Forms.ProgressBar();
            this.buUpPause = new System.Windows.Forms.Button();
            this.buUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // laDownStatus
            // 
            this.laDownStatus.AutoSize = true;
            this.laDownStatus.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.laDownStatus.Location = new System.Drawing.Point(695, 130);
            this.laDownStatus.Name = "laDownStatus";
            this.laDownStatus.Size = new System.Drawing.Size(99, 41);
            this.laDownStatus.TabIndex = 30;
            this.laDownStatus.Text = "100 %";
            // 
            // pbDownMs
            // 
            this.pbDownMs.Location = new System.Drawing.Point(426, 180);
            this.pbDownMs.Name = "pbDownMs";
            this.pbDownMs.Size = new System.Drawing.Size(263, 29);
            this.pbDownMs.TabIndex = 29;
            // 
            // pbDown
            // 
            this.pbDown.Location = new System.Drawing.Point(426, 121);
            this.pbDown.Name = "pbDown";
            this.pbDown.Size = new System.Drawing.Size(263, 29);
            this.pbDown.TabIndex = 28;
            // 
            // buDownPause
            // 
            this.buDownPause.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buDownPause.Location = new System.Drawing.Point(288, 121);
            this.buDownPause.Margin = new System.Windows.Forms.Padding(10);
            this.buDownPause.Name = "buDownPause";
            this.buDownPause.Size = new System.Drawing.Size(125, 88);
            this.buDownPause.TabIndex = 27;
            this.buDownPause.Text = "⏸";
            this.buDownPause.UseVisualStyleBackColor = true;
            // 
            // buDown
            // 
            this.buDown.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buDown.Location = new System.Drawing.Point(11, 121);
            this.buDown.Margin = new System.Windows.Forms.Padding(10);
            this.buDown.Name = "buDown";
            this.buDown.Size = new System.Drawing.Size(257, 88);
            this.buDown.TabIndex = 26;
            this.buDown.Text = "00:00:000";
            this.buDown.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(695, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 41);
            this.label2.TabIndex = 25;
            this.label2.Text = "100 %";
            // 
            // pbUpMs
            // 
            this.pbUpMs.Location = new System.Drawing.Point(426, 72);
            this.pbUpMs.Name = "pbUpMs";
            this.pbUpMs.Size = new System.Drawing.Size(263, 29);
            this.pbUpMs.TabIndex = 24;
            // 
            // pbUp
            // 
            this.pbUp.Location = new System.Drawing.Point(426, 13);
            this.pbUp.Name = "pbUp";
            this.pbUp.Size = new System.Drawing.Size(263, 29);
            this.pbUp.TabIndex = 23;
            // 
            // buUpPause
            // 
            this.buUpPause.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buUpPause.Location = new System.Drawing.Point(288, 13);
            this.buUpPause.Margin = new System.Windows.Forms.Padding(10);
            this.buUpPause.Name = "buUpPause";
            this.buUpPause.Size = new System.Drawing.Size(125, 88);
            this.buUpPause.TabIndex = 22;
            this.buUpPause.Text = "⏸";
            this.buUpPause.UseVisualStyleBackColor = true;
            // 
            // buUp
            // 
            this.buUp.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buUp.Location = new System.Drawing.Point(11, 13);
            this.buUp.Margin = new System.Windows.Forms.Padding(10);
            this.buUp.Name = "buUp";
            this.buUp.Size = new System.Drawing.Size(257, 88);
            this.buUp.TabIndex = 21;
            this.buUp.Text = "00:00:000";
            this.buUp.UseVisualStyleBackColor = true;
            // 
            // Fm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 236);
            this.Controls.Add(this.laDownStatus);
            this.Controls.Add(this.pbDownMs);
            this.Controls.Add(this.pbDown);
            this.Controls.Add(this.buDownPause);
            this.Controls.Add(this.buDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbUpMs);
            this.Controls.Add(this.pbUp);
            this.Controls.Add(this.buUpPause);
            this.Controls.Add(this.buUp);
            this.Name = "Fm";
            this.Text = "Timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label laDownStatus;
        private ProgressBar pbDownMs;
        private ProgressBar pbDown;
        private Button buDownPause;
        private Button buDown;
        private Label label2;
        private ProgressBar pbUpMs;
        private ProgressBar pbUp;
        private Button buUpPause;
        private Button buUp;
    }
}