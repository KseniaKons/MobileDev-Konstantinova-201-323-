namespace WinFormsSQLLite
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
            this.edSQL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lvLogs = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.buShowLogs = new System.Windows.Forms.Button();
            this.buShowUser = new System.Windows.Forms.Button();
            this.buShowCity = new System.Windows.Forms.Button();
            this.buExecute1 = new System.Windows.Forms.Button();
            this.buExecuteSQL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.edSQL.Location = new System.Drawing.Point(234, 33);
            this.edSQL.Multiline = true;
            this.edSQL.Name = "textBox1";
            this.edSQL.Size = new System.Drawing.Size(538, 177);
            this.edSQL.TabIndex = 0;
            this.edSQL.Text = "select * from Cities";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "SQL";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(234, 308);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(538, 203);
            this.dataGridView1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Result";
            // 
            // lvLogs
            // 
            this.lvLogs.Location = new System.Drawing.Point(19, 33);
            this.lvLogs.Name = "lvLogs";
            this.lvLogs.Size = new System.Drawing.Size(151, 442);
            this.lvLogs.TabIndex = 4;
            this.lvLogs.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Logs";
            // 
            // buShowLogs
            // 
            this.buShowLogs.Location = new System.Drawing.Point(234, 237);
            this.buShowLogs.Name = "buShowLogs";
            this.buShowLogs.Size = new System.Drawing.Size(94, 29);
            this.buShowLogs.TabIndex = 6;
            this.buShowLogs.Text = "Logs";
            this.buShowLogs.UseVisualStyleBackColor = true;
            // 
            // buShowUser
            // 
            this.buShowUser.Location = new System.Drawing.Point(334, 237);
            this.buShowUser.Name = "buShowUser";
            this.buShowUser.Size = new System.Drawing.Size(94, 29);
            this.buShowUser.TabIndex = 7;
            this.buShowUser.Text = "Users";
            this.buShowUser.UseVisualStyleBackColor = true;
            // 
            // buShowCity
            // 
            this.buShowCity.Location = new System.Drawing.Point(434, 237);
            this.buShowCity.Name = "buShowCity";
            this.buShowCity.Size = new System.Drawing.Size(94, 29);
            this.buShowCity.TabIndex = 8;
            this.buShowCity.Text = "City";
            this.buShowCity.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.buExecute1.Location = new System.Drawing.Point(534, 237);
            this.buExecute1.Name = "button1";
            this.buExecute1.Size = new System.Drawing.Size(94, 29);
            this.buExecute1.TabIndex = 9;
            this.buExecute1.Text = "Execute1";
            this.buExecute1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.buExecuteSQL.Location = new System.Drawing.Point(634, 237);
            this.buExecuteSQL.Name = "button2";
            this.buExecuteSQL.Size = new System.Drawing.Size(138, 29);
            this.buExecuteSQL.TabIndex = 10;
            this.buExecuteSQL.Text = "Execute SQL";
            this.buExecuteSQL.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 561);
            this.Controls.Add(this.buExecuteSQL);
            this.Controls.Add(this.buExecute1);
            this.Controls.Add(this.buShowCity);
            this.Controls.Add(this.buShowUser);
            this.Controls.Add(this.buShowLogs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lvLogs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edSQL);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox edSQL;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private ListView lvLogs;
        private Label label3;
        private Button buShowLogs;
        private Button buShowUser;
        private Button buShowCity;
        private Button buExecute1;
        private Button buExecuteSQL;
    }
}