using FooterChanger.Helpers;

namespace FooterChanger;

partial class HomeScreen
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        _treeView = new TreeView();
        changeFolder = new Button();
        printInput = new ComboBox();
        Impressora = new Label();
        label1 = new Label();
        ficInput = new TextBox();
        label2 = new Label();
        pagina1Input = new TextBox();
        pagina2Input = new TextBox();
        label3 = new Label();
        SaveAndPrint = new Button();
        saveButton = new Button();
        selectedItem = new Label();
        selectedFilePath = new Label();
        passwordInput = new TextBox();
        label4 = new Label();
        SuspendLayout();
        // 
        // _treeView
        // 
        _treeView.BackColor = Color.FromArgb(177, 161, 204);
        _treeView.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
        _treeView.Location = new Point(11, 61);
        _treeView.Margin = new Padding(2);
        _treeView.Name = "_treeView";
        _treeView.Size = new Size(355, 633);
        _treeView.TabIndex = 0;
        _treeView.AfterSelect += _treeView_AfterSelect;
        // 
        // changeFolder
        // 
        changeFolder.BackColor = Color.FromArgb(177, 161, 204);
        changeFolder.Cursor = Cursors.Hand;
        changeFolder.FlatAppearance.BorderColor = Color.FromArgb(177, 161, 204);
        changeFolder.FlatAppearance.BorderSize = 0;
        changeFolder.FlatAppearance.MouseDownBackColor = Color.FromArgb(177, 161, 204);
        changeFolder.FlatAppearance.MouseOverBackColor = Color.FromArgb(177, 161, 204);
        changeFolder.FlatStyle = FlatStyle.Flat;
        changeFolder.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        changeFolder.ForeColor = Color.WhiteSmoke;
        changeFolder.Location = new Point(11, 11);
        changeFolder.Margin = new Padding(2);
        changeFolder.Name = "changeFolder";
        changeFolder.Size = new Size(156, 37);
        changeFolder.TabIndex = 1;
        changeFolder.Text = "Alterar Diretório";
        changeFolder.UseVisualStyleBackColor = false;
        changeFolder.Click += changeFolder_Click;
        // 
        // printInput
        // 
        printInput.Font = new Font("Segoe UI", 10.8F);
        printInput.FormattingEnabled = true;
        printInput.Location = new Point(388, 193);
        printInput.Margin = new Padding(2);
        printInput.Name = "printInput";
        printInput.Size = new Size(281, 33);
        printInput.TabIndex = 2;
        // 
        // Impressora
        // 
        Impressora.Font = new Font("Segoe UI", 7.8F);
        Impressora.ForeColor = Color.WhiteSmoke;
        Impressora.Location = new Point(388, 168);
        Impressora.Margin = new Padding(2, 0, 2, 0);
        Impressora.Name = "Impressora";
        Impressora.Size = new Size(76, 23);
        Impressora.TabIndex = 3;
        Impressora.Text = "Impressora\r\n";
        // 
        // label1
        // 
        label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label1.ForeColor = Color.WhiteSmoke;
        label1.Location = new Point(388, 105);
        label1.Margin = new Padding(2, 0, 2, 0);
        label1.Name = "label1";
        label1.Size = new Size(36, 21);
        label1.TabIndex = 5;
        label1.Text = "FIC\r\n";
        // 
        // ficInput
        // 
        ficInput.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        ficInput.Location = new Point(388, 128);
        ficInput.Margin = new Padding(2);
        ficInput.Name = "ficInput";
        ficInput.Size = new Size(281, 31);
        ficInput.TabIndex = 6;
        // 
        // label2
        // 
        label2.Font = new Font("Segoe UI", 7.8F);
        label2.ForeColor = Color.WhiteSmoke;
        label2.Location = new Point(388, 228);
        label2.Margin = new Padding(2, 0, 2, 0);
        label2.Name = "label2";
        label2.Size = new Size(51, 25);
        label2.TabIndex = 7;
        label2.Text = "Página";
        // 
        // pagina1Input
        // 
        pagina1Input.Font = new Font("Segoe UI", 10.8F);
        pagina1Input.Location = new Point(388, 255);
        pagina1Input.Margin = new Padding(2);
        pagina1Input.Name = "pagina1Input";
        pagina1Input.Size = new Size(116, 31);
        pagina1Input.TabIndex = 8;
        // 
        // pagina2Input
        // 
        pagina2Input.Font = new Font("Segoe UI", 10.8F);
        pagina2Input.Location = new Point(544, 256);
        pagina2Input.Margin = new Padding(2);
        pagina2Input.Name = "pagina2Input";
        pagina2Input.Size = new Size(125, 31);
        pagina2Input.TabIndex = 9;
        // 
        // label3
        // 
        label3.Font = new Font("Segoe UI", 7.8F);
        label3.ForeColor = Color.WhiteSmoke;
        label3.Location = new Point(510, 265);
        label3.Margin = new Padding(2, 0, 2, 0);
        label3.Name = "label3";
        label3.Size = new Size(30, 21);
        label3.TabIndex = 10;
        label3.Text = "Até";
        // 
        // SaveAndPrint
        // 
        SaveAndPrint.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        SaveAndPrint.ImageAlign = ContentAlignment.BottomCenter;
        SaveAndPrint.Location = new Point(544, 307);
        SaveAndPrint.Margin = new Padding(2);
        SaveAndPrint.Name = "SaveAndPrint";
        SaveAndPrint.Size = new Size(101, 42);
        SaveAndPrint.TabIndex = 12;
        SaveAndPrint.Text = "Salvar e Imprimir";
        SaveAndPrint.UseVisualStyleBackColor = true;
        SaveAndPrint.Click += SaveAndPrint_click;
        // 
        // saveButton
        // 
        saveButton.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        saveButton.ImageAlign = ContentAlignment.BottomCenter;
        saveButton.Location = new Point(401, 307);
        saveButton.Margin = new Padding(2);
        saveButton.Name = "saveButton";
        saveButton.Size = new Size(105, 42);
        saveButton.TabIndex = 13;
        saveButton.Text = "Salvar";
        saveButton.UseVisualStyleBackColor = true;
        // 
        // selectedItem
        // 
        selectedItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
        selectedItem.ForeColor = Color.WhiteSmoke;
        selectedItem.Location = new Point(388, 61);
        selectedItem.Margin = new Padding(2, 0, 2, 0);
        selectedItem.Name = "selectedItem";
        selectedItem.Size = new Size(447, 28);
        selectedItem.TabIndex = 14;
        // 
        // selectedFilePath
        // 
        selectedFilePath.ForeColor = Color.WhiteSmoke;
        selectedFilePath.Location = new Point(388, 455);
        selectedFilePath.Margin = new Padding(2, 0, 2, 0);
        selectedFilePath.Name = "selectedFilePath";
        selectedFilePath.Size = new Size(193, 12);
        selectedFilePath.TabIndex = 15;
        selectedFilePath.Visible = false;
        // 
        // passwordInput
        // 
        passwordInput.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
        passwordInput.Location = new Point(388, 402);
        passwordInput.Name = "passwordInput";
        passwordInput.Size = new Size(189, 30);
        passwordInput.TabIndex = 16;
        passwordInput.Visible = false;
        // 
        // label4
        // 
        label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label4.ForeColor = Color.WhiteSmoke;
        label4.Location = new Point(388, 375);
        label4.Name = "label4";
        label4.Size = new Size(72, 24);
        label4.TabIndex = 17;
        label4.Text = "Password";
        label4.Visible = false;
        // 
        // HomeScreen
        // 
        AutoScaleMode = AutoScaleMode.None;
        BackColor = Color.FromArgb(107, 75, 151);
        ClientSize = new Size(1230, 705);
        Controls.Add(label4);
        Controls.Add(passwordInput);
        Controls.Add(selectedFilePath);
        Controls.Add(selectedItem);
        Controls.Add(saveButton);
        Controls.Add(SaveAndPrint);
        Controls.Add(label3);
        Controls.Add(pagina2Input);
        Controls.Add(pagina1Input);
        Controls.Add(label2);
        Controls.Add(ficInput);
        Controls.Add(label1);
        Controls.Add(Impressora);
        Controls.Add(printInput);
        Controls.Add(changeFolder);
        Controls.Add(_treeView);
        Font = new Font("Segoe UI", 2.67386913F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Margin = new Padding(3, 2, 3, 2);
        Name = "HomeScreen";
        Text = "Footer Changer";
        Load += HomeScreen_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.TextBox passwordInput;

    private System.Windows.Forms.Label selectedFilePath;

    private System.Windows.Forms.Label selectedItem;

    private System.Windows.Forms.Button SaveAndPrint;

    private System.Windows.Forms.TextBox pagina1Input;
    private System.Windows.Forms.TextBox pagina2Input;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button saveButton;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox ficInput;

    private System.Windows.Forms.Label Impressora;

    private System.Windows.Forms.ComboBox printInput;

    private System.Windows.Forms.Button changeFolder;

    #endregion
}