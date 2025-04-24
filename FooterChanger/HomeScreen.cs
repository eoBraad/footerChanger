using System.ComponentModel;
using System.Drawing.Printing;
using FooterChanger.Helpers;
using FooterChanger.Structs;
using Spire.Doc;


namespace FooterChanger;

public partial class HomeScreen : Form
{
    private TreeView _treeView;
    private readonly BindingList<CachedModifications> _modifications = [];

    public HomeScreen()
    {
        InitializeComponent();
        _treeView!.BeforeExpand += _treeView_BeforeExpand!;
        _treeView!.AfterSelect += _treeView_AfterSelect!;
    }

    private void HomeScreen_Load(object sender, EventArgs e)
    {
        var savedPath = Properties.Settings.Default.DefaultDirectory;
        var passwords = Properties.Settings.Default.Passwords;

        // Configurações do DataGridView
        dataGridView1.AutoGenerateColumns = true;
        dataGridView1.DataSource = _modifications;

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

        if (string.IsNullOrEmpty(passwords))
        {
            label4.Visible = true;
            passwordInput.Visible = true;
        }

        LoadPrinters();
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
        if (path!.Contains(".doc") || path.Contains(".docx"))
        {
            selectedItem.Text = Path.GetFileName(path);
            selectedFilePath.Text = path;
        }
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

    private void LoadPrinters()
    {
        printInput.Items.Clear();

        foreach (string printer in PrinterSettings.InstalledPrinters)
        {
            printInput.Items.Add(printer);
        }

        // Define a impressora padrão como selecionada
        var defaultPrinter = new PrinterSettings().PrinterName;
        if (printInput.Items.Contains(defaultPrinter))
            printInput.SelectedItem = defaultPrinter;
    }

    private void SaveAndPrint_click(object sender, EventArgs e)
    {
        var passwords = PasswordsController();

        if (string.IsNullOrEmpty(pagina1Input.Text) || int.TryParse(pagina1Input.Text, out _))
        {
            MessageBox.Show("Insira um numero de inicio");
            return;
        }
        
        if (string.IsNullOrEmpty(pagina2Input.Text) || int.TryParse(pagina2Input.Text, out _))
        {
            MessageBox.Show("Insira um numero de final");
            return;
        }

        if (!string.IsNullOrEmpty(selectedFilePath.Text) &&
            !(selectedFilePath.Text.Contains(".doc") || selectedFilePath.Text.Contains(".docx")))
        {
            MessageBox.Show("Selecione um arquivo valido");
            return;
        }

        if (string.IsNullOrEmpty(ficInput.Text))
        {
            MessageBox.Show("Preencha o campo FIC");
            return;
        }

        try
        {
            DocEditorHelper.ChangeFooter(selectedFilePath.Text, ficInput.Text, passwords, true, true, printInput.Text, int.Parse(pagina1Input.Text), int.Parse(pagina2Input.Text), ShowPassword);
            
            _modifications.Add(new CachedModifications
            {
                Data = DateTime.Now,
                FicValue = ficInput.Text,
                Filename = selectedItem.Text,
                Path = selectedFilePath.Text,
                PageEnd = 1,
                PageInit = 1
            });
        }
        catch (Exception exception)
        {
            MessageBox.Show($"{exception.Message}", "Erro ao salvar");
        }

    }

    private void Save_click(object sender, EventArgs e)
    {
        var passwords = PasswordsController();

        if (string.IsNullOrEmpty(selectedFilePath.Text) &&
            !(selectedFilePath.Text.Contains(".doc") || selectedFilePath.Text.Contains(".docx")))
        {
            MessageBox.Show("Selecione um arquivo valido");
            return;
        }

        if (string.IsNullOrEmpty(ficInput.Text))
        {
            MessageBox.Show("Preencha o campo FIC");
            return;
        }
        
        try
        {
            DocEditorHelper.ChangeFooter(selectedFilePath.Text, ficInput.Text, passwords, true, false, "",
                int.Parse(pagina1Input.Text), int.Parse(pagina2Input.Text),
                ShowPassword);


            _modifications.Add(new CachedModifications
            {
                Data = DateTime.Now,
                FicValue = ficInput.Text,
                Filename = selectedItem.Text,
                Path = selectedFilePath.Text,
                PageEnd = 1,
                PageInit = 1
            });
        }
        catch (Exception exception)
        {
            MessageBox.Show($"{exception.Message}", "Erro ao salvar");
        }
    }

    private List<string> PasswordsController()
    {
        var passwords = Properties.Settings.Default.Passwords;

        if (string.IsNullOrEmpty(passwords) && !string.IsNullOrEmpty(passwordInput.Text))
        {
            passwords = passwordInput.Text + ",";
            Properties.Settings.Default.Passwords = passwords;
            Properties.Settings.Default.Save();
        }
        else if (!string.IsNullOrEmpty(passwords) && !string.IsNullOrEmpty(passwordInput.Text))
        {
            passwords = $"{passwords},{passwordInput.Text}";
            Properties.Settings.Default.Passwords = passwords;
            Properties.Settings.Default.Save();
        }
        
        var passwordList = Properties.Settings.Default.Passwords
            .Split(",")
            .Select(s => s.Trim())
            .Where(s => !string.IsNullOrEmpty(s))
            .ToList();

        label4.Visible = false;
        passwordInput.Visible = false;
        
        return passwordList;
    }

    public void ShowPassword()
    {
        passwordInput.Visible = true;
        label4.Visible = true;
    }
}