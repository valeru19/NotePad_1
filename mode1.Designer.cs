namespace TtxEdr
{
    partial class mode1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            richTextBox1 = new RichTextBox();
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            editingToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            cutToolStripMenuItem = new ToolStripMenuItem();
            hightlightAllToolStripMenuItem = new ToolStripMenuItem();
            shriftToolStripMenuItem = new ToolStripMenuItem();
            shriftSettigsToolStripMenuItem = new ToolStripMenuItem();
            fontToolStripMenuItem = new ToolStripMenuItem();
            fontSettingsToolStripMenuItem = new ToolStripMenuItem();
            launchToolStripMenuItem = new ToolStripMenuItem();
            launchWebsiteToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            fontDialog1 = new FontDialog();
            colorDialog1 = new ColorDialog();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 28);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1695, 751);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Cyan;
            panel1.Controls.Add(comboBox1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 723);
            panel1.Name = "panel1";
            panel1.Size = new Size(1695, 56);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "JavaScript", "HTML", "CSS" });
            comboBox1.Location = new Point(1532, 16);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 2;
            comboBox1.Text = "HTML";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editingToolStripMenuItem, shriftToolStripMenuItem, fontToolStripMenuItem, launchToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1695, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, saveAsToolStripMenuItem, openToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(224, 26);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(224, 26);
            saveAsToolStripMenuItem.Text = "Save As";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(224, 26);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // editingToolStripMenuItem
            // 
            editingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { copyToolStripMenuItem, pasteToolStripMenuItem, cutToolStripMenuItem, hightlightAllToolStripMenuItem });
            editingToolStripMenuItem.Name = "editingToolStripMenuItem";
            editingToolStripMenuItem.Size = new Size(70, 24);
            editingToolStripMenuItem.Text = "Editing";
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(179, 26);
            copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new Size(179, 26);
            pasteToolStripMenuItem.Text = "Paste";
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.Size = new Size(179, 26);
            cutToolStripMenuItem.Text = "Cut";
            // 
            // hightlightAllToolStripMenuItem
            // 
            hightlightAllToolStripMenuItem.Name = "hightlightAllToolStripMenuItem";
            hightlightAllToolStripMenuItem.Size = new Size(179, 26);
            hightlightAllToolStripMenuItem.Text = "Hightlight all";
            // 
            // shriftToolStripMenuItem
            // 
            shriftToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { shriftSettigsToolStripMenuItem });
            shriftToolStripMenuItem.Name = "shriftToolStripMenuItem";
            shriftToolStripMenuItem.Size = new Size(58, 24);
            shriftToolStripMenuItem.Text = "Shrift";
            // 
            // shriftSettigsToolStripMenuItem
            // 
            shriftSettigsToolStripMenuItem.Name = "shriftSettigsToolStripMenuItem";
            shriftSettigsToolStripMenuItem.Size = new Size(174, 26);
            shriftSettigsToolStripMenuItem.Text = "Shrift settigs";
            shriftSettigsToolStripMenuItem.Click += shriftSettigsToolStripMenuItem_Click;
            // 
            // fontToolStripMenuItem
            // 
            fontToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fontSettingsToolStripMenuItem });
            fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            fontToolStripMenuItem.Size = new Size(52, 24);
            fontToolStripMenuItem.Text = "Font";
            // 
            // fontSettingsToolStripMenuItem
            // 
            fontSettingsToolStripMenuItem.Name = "fontSettingsToolStripMenuItem";
            fontSettingsToolStripMenuItem.Size = new Size(176, 26);
            fontSettingsToolStripMenuItem.Text = "Font settings";
            // 
            // launchToolStripMenuItem
            // 
            launchToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { launchWebsiteToolStripMenuItem });
            launchToolStripMenuItem.Name = "launchToolStripMenuItem";
            launchToolStripMenuItem.Size = new Size(69, 24);
            launchToolStripMenuItem.Text = "Launch";
            // 
            // launchWebsiteToolStripMenuItem
            // 
            launchWebsiteToolStripMenuItem.Name = "launchWebsiteToolStripMenuItem";
            launchWebsiteToolStripMenuItem.Size = new Size(224, 26);
            launchWebsiteToolStripMenuItem.Text = "Launch website";
            launchWebsiteToolStripMenuItem.Click += launchWebsiteToolStripMenuItem_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // mode1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1695, 779);
            Controls.Add(panel1);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "mode1";
            Text = "mode1";
            panel1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Panel panel1;
        private ComboBox comboBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem editingToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem hightlightAllToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private ToolStripMenuItem shriftToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private SaveFileDialog saveFileDialog1;
        private FontDialog fontDialog1;
        private ColorDialog colorDialog1;
        private ToolStripMenuItem shriftSettigsToolStripMenuItem;
        private ToolStripMenuItem fontSettingsToolStripMenuItem;
        private ToolStripMenuItem launchToolStripMenuItem;
        private ToolStripMenuItem launchWebsiteToolStripMenuItem;
    }
}