using System.Drawing;
using System.Windows.Forms;

namespace TimNotepad
{
    public partial class TimNotepadForm : Form
    {
        public TimNotepadForm() { InitializeComponent(); }

        private void InitializeComponent()
        {
            #region Creating
            this.richTextBox1 = new RichTextBox();
            this.menuStrip1 = new MenuStrip();
            this.fileToolStripMenuItem = new ToolStripMenuItem();
            this.opeToolStripMenuItem = new ToolStripMenuItem();
            this.saveToolStripMenuItem = new ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new ToolStripMenuItem();
            this.editToolStripMenuItem = new ToolStripMenuItem();
            this.copyToolStripMenuItem = new ToolStripMenuItem();
            this.insertToolStripMenuItem = new ToolStripMenuItem();
            this.cutToolStripMenuItem = new ToolStripMenuItem();
            this.vydelitVseToolStripMenuItem = new ToolStripMenuItem();
            this.backgroundToolStripMenuItem = new ToolStripMenuItem();
            this.backgroundSettingsToolStripMenuItem = new ToolStripMenuItem();
            this.fontToolStripMenuItem = new ToolStripMenuItem();
            this.fontSettingToolStripMenuItem = new ToolStripMenuItem();
            this.saveFileDialog1 = new SaveFileDialog();
            this.openFileDialog1 = new OpenFileDialog();
            this.fontDialog1 = new FontDialog();
            this.colorDialog1 = new ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            #endregion
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new Point(0, 27);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new Size(462, 265);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.backgroundToolStripMenuItem,
            this.fontToolStripMenuItem});
            this.menuStrip1.Location = new Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            this.opeToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // opeToolStripMenuItem
            // 
            this.opeToolStripMenuItem.Name = "opeToolStripMenuItem";
            this.opeToolStripMenuItem.Size = new Size(112, 22);
            this.opeToolStripMenuItem.Text = "Open";
            this.opeToolStripMenuItem.Click += new System.EventHandler(this.opeToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new Size(112, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new Size(112, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.insertToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.vydelitVseToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new Size(120, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new Size(120, 22);
            this.insertToolStripMenuItem.Text = "Insert";
            this.insertToolStripMenuItem.Click += new System.EventHandler(this.insertToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new Size(120, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // vydelitVseToolStripMenuItem
            // 
            this.vydelitVseToolStripMenuItem.Name = "vydelitVseToolStripMenuItem";
            this.vydelitVseToolStripMenuItem.Size = new Size(120, 22);
            this.vydelitVseToolStripMenuItem.Text = "Select all";
            this.vydelitVseToolStripMenuItem.Click += new System.EventHandler(this.vydelitVseToolStripMenuItem_Click);
            // 
            // backgroundToolStripMenuItem
            // 
            this.backgroundToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            this.backgroundSettingsToolStripMenuItem});
            this.backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            this.backgroundToolStripMenuItem.Size = new Size(83, 20);
            this.backgroundToolStripMenuItem.Text = "Background";
            // 
            // backgroundSettingsToolStripMenuItem
            // 
            this.backgroundSettingsToolStripMenuItem.Name = "backgroundSettingsToolStripMenuItem";
            this.backgroundSettingsToolStripMenuItem.Size = new Size(182, 22);
            this.backgroundSettingsToolStripMenuItem.Text = "Background settings";
            this.backgroundSettingsToolStripMenuItem.Click += new System.EventHandler(this.backgroundSettingsToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            this.fontSettingToolStripMenuItem});
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new Size(43, 20);
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // fontSettingToolStripMenuItem
            // 
            this.fontSettingToolStripMenuItem.Name = "fontSettingToolStripMenuItem";
            this.fontSettingToolStripMenuItem.Size = new Size(142, 22);
            this.fontSettingToolStripMenuItem.Text = "Font settings";
            this.fontSettingToolStripMenuItem.Click += new System.EventHandler(this.fontSettingToolStripMenuItem_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Text File(*.txt) | *.txt|TIM Notepad File(*.tnf)|*.tnf";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fontDialog1
            // 
            this.fontDialog1.Apply += new System.EventHandler(this.fontDialog1_Apply);
            // 
            // TimNotepadForm
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TimNotepadForm";
            this.Text = "TimNotepad";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private System.ComponentModel.IContainer components = null;

        private RichTextBox richTextBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem opeToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem insertToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem backgroundToolStripMenuItem;
        private ToolStripMenuItem backgroundSettingsToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripMenuItem fontSettingToolStripMenuItem;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private FontDialog fontDialog1;
        private ColorDialog colorDialog1;
        private ToolStripMenuItem vydelitVseToolStripMenuItem;
    }
}

