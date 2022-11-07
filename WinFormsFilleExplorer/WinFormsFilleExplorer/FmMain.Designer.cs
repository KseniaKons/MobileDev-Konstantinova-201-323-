namespace WinFormsFilleExplorer
{
    partial class FmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmMain));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.tsButUp = new System.Windows.Forms.ToolStripButton();
            this.edDir = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.miViewLargeIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.miViewSmallIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.miViewList = new System.Windows.Forms.ToolStripMenuItem();
            this.miViewDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.miViewTile = new System.Windows.Forms.ToolStripMenuItem();
            this.treeV = new System.Windows.Forms.TreeView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.listV = new System.Windows.Forms.ListView();
            this.imLargeIcon = new System.Windows.Forms.ImageList(this.components);
            this.imSmallIcon = new System.Windows.Forms.ImageList(this.components);
            this.laSLable = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.laSLable});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 26);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.tsButUp,
            this.edDir,
            this.toolStripButton4,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "◀";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton2.Text = "▶";
            // 
            // tsButUp
            // 
            this.tsButUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsButUp.Image = ((System.Drawing.Image)(resources.GetObject("tsButUp.Image")));
            this.tsButUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButUp.Name = "tsButUp";
            this.tsButUp.Size = new System.Drawing.Size(29, 24);
            this.tsButUp.Text = "▲";
            // 
            // edDir
            // 
            this.edDir.Name = "edDir";
            this.edDir.Size = new System.Drawing.Size(500, 27);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton4.Text = "...";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miViewLargeIcon,
            this.miViewSmallIcon,
            this.miViewList,
            this.miViewDetails,
            this.miViewTile});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(49, 24);
            this.toolStripDropDownButton1.Text = "Вид";
            // 
            // miViewLargeIcon
            // 
            this.miViewLargeIcon.Name = "miViewLargeIcon";
            this.miViewLargeIcon.Size = new System.Drawing.Size(157, 26);
            this.miViewLargeIcon.Text = "LargeIcon";
            // 
            // miViewSmallIcon
            // 
            this.miViewSmallIcon.Name = "miViewSmallIcon";
            this.miViewSmallIcon.Size = new System.Drawing.Size(157, 26);
            this.miViewSmallIcon.Text = "SmallIcon";
            // 
            // miViewList
            // 
            this.miViewList.Name = "miViewList";
            this.miViewList.Size = new System.Drawing.Size(157, 26);
            this.miViewList.Text = "List";
            // 
            // miViewDetails
            // 
            this.miViewDetails.Name = "miViewDetails";
            this.miViewDetails.Size = new System.Drawing.Size(157, 26);
            this.miViewDetails.Text = "Details";
            // 
            // miViewTile
            // 
            this.miViewTile.Name = "miViewTile";
            this.miViewTile.Size = new System.Drawing.Size(157, 26);
            this.miViewTile.Text = "Tile";
            // 
            // treeView1
            // 
            this.treeV.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeV.Location = new System.Drawing.Point(0, 27);
            this.treeV.Name = "treeView1";
            this.treeV.Size = new System.Drawing.Size(151, 397);
            this.treeV.TabIndex = 2;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(151, 27);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 397);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // listV
            // 
            this.listV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listV.LargeImageList = this.imLargeIcon;
            this.listV.Location = new System.Drawing.Point(155, 27);
            this.listV.Name = "listV";
            this.listV.Size = new System.Drawing.Size(645, 397);
            this.listV.SmallImageList = this.imSmallIcon;
            this.listV.TabIndex = 4;
            this.listV.UseCompatibleStateImageBehavior = false;
            // 
            // imLargeIcon
            // 
            this.imLargeIcon.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imLargeIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imLargeIcon.ImageStream")));
            this.imLargeIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.imLargeIcon.Images.SetKeyName(0, "folder1.png");
            this.imLargeIcon.Images.SetKeyName(1, "file1.png");
            // 
            // imSmallIcon
            // 
            this.imSmallIcon.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imSmallIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imSmallIcon.ImageStream")));
            this.imSmallIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.imSmallIcon.Images.SetKeyName(0, "folder1.png");
            this.imSmallIcon.Images.SetKeyName(1, "file1.png");
            // 
            // toolStripStatusLabel1
            // 
            this.laSLable.Name = "toolStripStatusLabel1";
            this.laSLable.Size = new System.Drawing.Size(15, 20);
            this.laSLable.Text = "-";
            // 
            // FmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listV);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.treeV);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FmMain";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton tsButUp;
        private ToolStripTextBox edDir;
        private ToolStripButton toolStripButton4;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private TreeView treeV;
        private Splitter splitter1;
        private ListView listV;
        private ToolStripMenuItem miViewLargeIcon;
        private ToolStripMenuItem miViewSmallIcon;
        private ToolStripMenuItem miViewList;
        private ToolStripMenuItem miViewDetails;
        private ToolStripMenuItem miViewTile;
        private ImageList imLargeIcon;
        private ImageList imSmallIcon;
        private ToolStripStatusLabel laSLable;
    }
}