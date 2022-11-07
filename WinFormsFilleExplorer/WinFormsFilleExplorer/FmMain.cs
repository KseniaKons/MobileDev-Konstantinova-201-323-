namespace WinFormsFilleExplorer
{
    public partial class FmMain : Form
    { 
        public string CurDir { get; private set; }
        public string SelItem { get; private set; }

        public FmMain()
        {
            InitializeComponent();

            CurDir = Directory.GetCurrentDirectory();
            //CurDir = "C:/";
            edDir.Text = CurDir;

            tsButUp.Click += (s, e) => LoaderDir(Directory.GetParent(CurDir).ToString());

            edDir.KeyDown += EdDir_KeyDown;

            miViewLargeIcon.Click += (s, e) => listV.View = View.LargeIcon;
            miViewSmallIcon.Click += (s, e) => listV.View = View.SmallIcon;
            miViewList.Click += (s, e) => listV.View = View.List;
            miViewDetails.Click += (s, e) => listV.View = View.Details;
            miViewTile.Click += (s, e) => listV.View = View.Tile;

            
            treeV.DoubleClick += TreeV_DoubleClick;

            foreach(var drive in Directory.GetLogicalDrives())
            {
                treeV.Nodes.Add(drive); 

            }

            //(1)

            //var c1 = new ColumnHeader();
            //c1.Text = "Имя";
            //c1.Width = 400;
            //listV.Columns.Add(c1);

            //(2)

            //listV.Columns.Add(new ColumnHeader() { Text = "Имя", Width = 400});

            //(3)

            listV.Columns.Add("Имя", 400);
            listV.Columns.Add("Дата изменения", 150);
            listV.Columns.Add("Тип", 100);
            listV.Columns.Add("Размер", 150);

            treeV.AfterSelect += TreeV_AfterSelect;

            listV.ItemSelectionChanged += ListV_ItemSelectionChanged;
            listV.DoubleClick += ListV_DoubleClick;

            LoaderDir(CurDir);
        }

        private void TreeV_AfterSelect(object? sender, TreeViewEventArgs e)
        {
            LoaderDir(treeV.SelectedNode.FullPath);
        }

        private void TreeV_DoubleClick(object? sender, EventArgs e)
        {
           DirectoryInfo directoryInfo = new DirectoryInfo(treeV.SelectedNode.FullPath);
            treeV.BeginUpdate();
            try
            {
                treeV.SelectedNode.Nodes.Clear();
                foreach(var dir in directoryInfo.GetDirectories())
                {
                    treeV.SelectedNode.Nodes.Add(dir.Name);
                }
                treeV.SelectedNode.Expand();
            }
            finally
            {
                treeV.EndUpdate();
            }
            
        }

        

        private void EdDir_KeyDown(object? sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                LoaderDir(edDir.Text);
            }    
        }

        private void ListV_ItemSelectionChanged(object? sender, ListViewItemSelectionChangedEventArgs e)
        {
            SelItem = Path.Combine(CurDir, e.Item.Text);
            RefreshStatus();
        }

        private void RefreshStatus()
        {
            laSLable.Text = $"Элементов: {listV.Items.Count} Выбратано: {listV.SelectedItems.Count} ";
        }

        private void ListV_DoubleClick(object? sender, EventArgs e)
        {
            LoaderDir(SelItem);
        }

        private void LoaderDir(string newDir)
        {
            
            DirectoryInfo dirInfo = new DirectoryInfo(newDir);
            listV.BeginUpdate();
            listV.Items.Clear();    
            if (dirInfo.Exists)
            {
                foreach (var dir in dirInfo.GetDirectories())
                {
                    //(1) 
                    //listV.Items.Add(dir.Name, 0);

                    //(2)
                    listV.Items.Add(new ListViewItem(
                        new string[] {dir.Name, dir.LastWriteTime.ToString(), "Папка", "//"},
                        0));  
                }
                foreach (var file in dirInfo.GetFiles())
                {
                    //listV.Items.Add(file.Name, 1);

                    //(2)
                    listV.Items.Add(new ListViewItem(
                        new string[] { file.Name, file.LastWriteTime.ToString(), "Файл", $" {file.Length} байт" },
                        0)); ;
                }
            }
            listV.EndUpdate();

            edDir.Text = newDir; 
            CurDir = newDir;

            RefreshStatus();
        }
    }
}