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
        comboBox1 = new System.Windows.Forms.ComboBox();
        Impressora = new System.Windows.Forms.Label();
        button1 = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        textBox1 = new System.Windows.Forms.TextBox();
        label2 = new System.Windows.Forms.Label();
        textBox2 = new System.Windows.Forms.TextBox();
        textBox3 = new System.Windows.Forms.TextBox();
        label3 = new System.Windows.Forms.Label();
        button2 = new System.Windows.Forms.Button();
        label4 = new System.Windows.Forms.Label();
        comboBox2 = new System.Windows.Forms.ComboBox();
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
        // comboBox1
        // 
        comboBox1.FormattingEnabled = true;
        comboBox1.Location = new System.Drawing.Point(538, 47);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new System.Drawing.Size(378, 23);
        comboBox1.TabIndex = 2;
        // 
        // Impressora
        // 
        Impressora.Location = new System.Drawing.Point(538, 24);
        Impressora.Name = "Impressora";
        Impressora.Size = new System.Drawing.Size(68, 20);
        Impressora.TabIndex = 3;
        Impressora.Text = "Impressora\r\n";
        Impressora.Click += label1_Click;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(937, 47);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(144, 26);
        button1.TabIndex = 4;
        button1.Text = "Abrir Fila de Impressão";
        button1.UseVisualStyleBackColor = true;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(538, 105);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(32, 20);
        label1.TabIndex = 5;
        label1.Text = "FIC\r\n";
        // 
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(617, 102);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(299, 23);
        textBox1.TabIndex = 6;
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(538, 147);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(49, 20);
        label2.TabIndex = 7;
        label2.Text = "Página";
        // 
        // textBox2
        // 
        textBox2.Location = new System.Drawing.Point(617, 147);
        textBox2.Name = "textBox2";
        textBox2.Size = new System.Drawing.Size(80, 23);
        textBox2.TabIndex = 8;
        // 
        // textBox3
        // 
        textBox3.Location = new System.Drawing.Point(739, 147);
        textBox3.Name = "textBox3";
        textBox3.Size = new System.Drawing.Size(80, 23);
        textBox3.TabIndex = 9;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(703, 150);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(30, 20);
        label3.TabIndex = 10;
        label3.Text = "Até";
        // 
        // button2
        // 
        button2.Location = new System.Drawing.Point(674, 287);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(88, 44);
        button2.TabIndex = 11;
        button2.Text = "Executar";
        button2.UseVisualStyleBackColor = true;
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(617, 207);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(49, 17);
        label4.TabIndex = 12;
        label4.Text = "Destino";
        // 
        // comboBox2
        // 
        comboBox2.FormattingEnabled = true;
        comboBox2.Location = new System.Drawing.Point(617, 227);
        comboBox2.Name = "comboBox2";
        comboBox2.Size = new System.Drawing.Size(135, 23);
        comboBox2.TabIndex = 13;
        // 
        // HomeScreen
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)107)), ((int)((byte)75)), ((int)((byte)151)));
        ClientSize = new System.Drawing.Size(1226, 689);
        Controls.Add(comboBox2);
        Controls.Add(label4);
        Controls.Add(button2);
        Controls.Add(label3);
        Controls.Add(textBox3);
        Controls.Add(textBox2);
        Controls.Add(label2);
        Controls.Add(textBox1);
        Controls.Add(label1);
        Controls.Add(button1);
        Controls.Add(Impressora);
        Controls.Add(comboBox1);
        Controls.Add(changeFolder);
        Controls.Add(_treeView);
        Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
        Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
        Text = "Footer Changer";
        Load += HomeScreen_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.ComboBox comboBox2;

    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBox1;

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.Label Impressora;

    private System.Windows.Forms.ComboBox comboBox1;

    private System.Windows.Forms.Button changeFolder;

    #endregion
}