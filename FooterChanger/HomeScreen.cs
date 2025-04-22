using FooterChanger.Helpers;

namespace FooterChanger;

public partial class HomeScreen : Form
{
    private System.Windows.Forms.TreeView _treeView;
    public HomeScreen()
    {
        InitializeComponent();
        _treeView!.BeforeExpand += _treeView_BeforeExpand!;
        _treeView!.AfterSelect += _treeView_AfterSelect!;
        
    }

    private void HomeScreen_Load(object sender, EventArgs e)
    {
        var savedPath = Properties.Settings.Default.DefaultDirectory;

        if (!Directory.Exists(savedPath) && string.IsNullOrEmpty(savedPath))
        {
            using var dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.DefaultDirectory = dialog.SelectedPath;
                Properties.Settings.Default.Save();
                savedPath = dialog.SelectedPath;
                LoadDirectory(savedPath);
                
            }
        }
        else
        {
            LoadDirectory(savedPath);
        }
    }

    private void LoadDirectory(string path)
    {
        try
        {
            _treeView!.Nodes.Clear();
            var root = new TreeNode(Path.GetFileName(path))
            {
                Tag = path,
            };
            root.Nodes.Add("...");
            _treeView!.Nodes.Add(root);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao carregar pastas {ex.Message}");
        }
    }

    private void _treeView_AfterSelect(object sender, TreeViewEventArgs e)
    {
        var path = e.Node?.Tag?.ToString();
    }

    private void _treeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
    {
        try
        {
            if (e.Node?.Nodes.Count != 1 || e.Node.Nodes[0].Text != "...") return;
            e.Node.Nodes.Clear();
            AddFiles(e.Node);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao carregar arquivos {ex.Message}");
        }
    }

    private void AddFiles(TreeNode node)
    {
        var path = node.Tag!.ToString();
        
        var subFolders = Directory.GetDirectories(path!);
        foreach (var subFolder in subFolders)
        {
            var subNode = new TreeNode(Path.GetFileName(subFolder))
            {
                Tag = subFolder
            };
            
            subNode.Nodes.Add("...");
            _treeView!.Nodes.Add(subNode);
        }
        
        var subFilesDoc = Directory.GetFiles(path!, "*.doc");
        foreach (var subFile in subFilesDoc)
        {
            var fileNode = new TreeNode(Path.GetFileName(subFile))
            {
                Tag = subFile,
                ForeColor = Color.WhiteSmoke,
                
                ImageIndex = 1
            };
            
            node.Nodes.Add(fileNode);
        }
        
        var subFilesDocx = Directory.GetFiles(path!, "*.docx");
        foreach (var subFile in subFilesDocx)
        {
            var fileNode = new TreeNode(Path.GetFileName(subFile))
            {
                Tag = subFile,
                ForeColor = Color.WhiteSmoke,
                ImageIndex = 1
            };
            
            node.Nodes.Add(fileNode);
        }
    }

    private void changeFolder_Click(object sender, EventArgs e)
    {
        using var dialog = new FolderBrowserDialog();
        if (dialog.ShowDialog() == DialogResult.OK)
        {
            Properties.Settings.Default.DefaultDirectory = dialog.SelectedPath;
            Properties.Settings.Default.Save();
            var savedPath = dialog.SelectedPath;
            LoadDirectory(savedPath);
        }
    }
}