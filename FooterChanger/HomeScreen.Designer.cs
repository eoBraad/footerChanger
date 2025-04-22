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
        _treeView = new System.Windows.Forms.TreeView();
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
        // HomeScreen
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)107)), ((int)((byte)75)), ((int)((byte)151)));
        ClientSize = new System.Drawing.Size(1224, 681);
        Controls.Add(_treeView);
        Text = "Footer Changer";
        Load += HomeScreen_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
}