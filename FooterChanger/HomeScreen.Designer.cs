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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeScreen));
        _treeView = new System.Windows.Forms.TreeView();
        changeFolder = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // _treeView
        // 
        _treeView.BackColor = System.Drawing.Color.FromArgb(((int)((byte)177)), ((int)((byte)161)), ((int)((byte)204)));
        _treeView.Location = new System.Drawing.Point(14, 70);
        _treeView.Name = "_treeView";
        _treeView.Size = new System.Drawing.Size(264, 599);
        _treeView.TabIndex = 0;
        _treeView.AfterSelect += _treeView_AfterSelect;
        // 
        // changeFolder
        // 
        changeFolder.BackColor = System.Drawing.Color.FromArgb(((int)((byte)177)), ((int)((byte)161)), ((int)((byte)204)));
        changeFolder.Cursor = System.Windows.Forms.Cursors.Hand;
        changeFolder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)177)), ((int)((byte)161)), ((int)((byte)204)));
        changeFolder.FlatAppearance.BorderSize = 0;
        changeFolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)177)), ((int)((byte)161)), ((int)((byte)204)));
        changeFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)177)), ((int)((byte)161)), ((int)((byte)204)));
        changeFolder.Font = new System.Drawing.Font("Segoe UI", 7.2000003F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        changeFolder.Location = new System.Drawing.Point(14, 16);
        changeFolder.Name = "changeFolder";
        changeFolder.Size = new System.Drawing.Size(157, 35);
        changeFolder.TabIndex = 1;
        changeFolder.Text = "Alterar Diretório";
        changeFolder.UseVisualStyleBackColor = false;
        changeFolder.Click += changeFolder_Click;
        // 
        // HomeScreen
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)107)), ((int)((byte)75)), ((int)((byte)151)));
        ClientSize = new System.Drawing.Size(1226, 689);
        Controls.Add(changeFolder);
        Controls.Add(_treeView);
        Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
        Text = "Footer Changer";
        Load += HomeScreen_Load;
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button changeFolder;

    #endregion
}