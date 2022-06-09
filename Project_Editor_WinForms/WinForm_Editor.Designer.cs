namespace Project_Editor_WinForms
{
    partial class WinForm_Editor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinForm_Editor));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rulersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridlinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foreColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.CuttoolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.CopytoolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.PastetoolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.LeftAligntoolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.RightAligntoolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.CentreAligntoolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.FonttoolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.BoldtoolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.ItalictoolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.FontSizetoolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.menuStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.formatToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.printToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("undoToolStripMenuItem.Image")));
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("redoToolStripMenuItem.Image")));
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printPreviewToolStripMenuItem,
            this.rulersToolStripMenuItem,
            this.gridlinesToolStripMenuItem,
            this.zoomToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.printPreviewToolStripMenuItem.Text = "Print Preview";
            this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.printPreviewToolStripMenuItem_Click);
            // 
            // rulersToolStripMenuItem
            // 
            this.rulersToolStripMenuItem.Name = "rulersToolStripMenuItem";
            this.rulersToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.rulersToolStripMenuItem.Text = "Rulers";
            // 
            // gridlinesToolStripMenuItem
            // 
            this.gridlinesToolStripMenuItem.Name = "gridlinesToolStripMenuItem";
            this.gridlinesToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.gridlinesToolStripMenuItem.Text = "Gridlines";
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomInToolStripMenuItem,
            this.zoomOutToolStripMenuItem});
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.zoomToolStripMenuItem.Text = "Zoom";
            // 
            // zoomInToolStripMenuItem
            // 
            this.zoomInToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("zoomInToolStripMenuItem.Image")));
            this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.zoomInToolStripMenuItem.Text = "Zoom In";
            this.zoomInToolStripMenuItem.Click += new System.EventHandler(this.zoomInToolStripMenuItem_Click);
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("zoomOutToolStripMenuItem.Image")));
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.zoomOutToolStripMenuItem.Text = "Zoom Out";
            this.zoomOutToolStripMenuItem.Click += new System.EventHandler(this.zoomOutToolStripMenuItem_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backColorToolStripMenuItem,
            this.foreColorToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // backColorToolStripMenuItem
            // 
            this.backColorToolStripMenuItem.Name = "backColorToolStripMenuItem";
            this.backColorToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.backColorToolStripMenuItem.Text = "Back Color";
            this.backColorToolStripMenuItem.Click += new System.EventHandler(this.backColorToolStripMenuItem_Click);
            // 
            // foreColorToolStripMenuItem
            // 
            this.foreColorToolStripMenuItem.Name = "foreColorToolStripMenuItem";
            this.foreColorToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.foreColorToolStripMenuItem.Text = "Fore Color";
            this.foreColorToolStripMenuItem.Click += new System.EventHandler(this.foreColorToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CuttoolStripButton1,
            this.CopytoolStripButton1,
            this.PastetoolStripButton1,
            this.LeftAligntoolStripButton1,
            this.RightAligntoolStripButton1,
            this.CentreAligntoolStripButton1,
            this.FonttoolStripComboBox1,
            this.BoldtoolStripButton1,
            this.ItalictoolStripButton1,
            this.FontSizetoolStripComboBox2,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 28);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // CuttoolStripButton1
            // 
            this.CuttoolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CuttoolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("CuttoolStripButton1.Image")));
            this.CuttoolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CuttoolStripButton1.Name = "CuttoolStripButton1";
            this.CuttoolStripButton1.Size = new System.Drawing.Size(29, 25);
            this.CuttoolStripButton1.Text = "Cut Ctrl+X";
            this.CuttoolStripButton1.Click += new System.EventHandler(this.CuttoolStripButton1_Click);
            this.CuttoolStripButton1.MouseHover += new System.EventHandler(this.CuttoolStripButton1_MouseHover);
            // 
            // CopytoolStripButton1
            // 
            this.CopytoolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CopytoolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("CopytoolStripButton1.Image")));
            this.CopytoolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CopytoolStripButton1.Name = "CopytoolStripButton1";
            this.CopytoolStripButton1.Size = new System.Drawing.Size(29, 25);
            this.CopytoolStripButton1.Text = "Copy Ctrl+C";
            this.CopytoolStripButton1.Click += new System.EventHandler(this.CopytoolStripButton1_Click);
            // 
            // PastetoolStripButton1
            // 
            this.PastetoolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PastetoolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("PastetoolStripButton1.Image")));
            this.PastetoolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PastetoolStripButton1.Name = "PastetoolStripButton1";
            this.PastetoolStripButton1.Size = new System.Drawing.Size(29, 25);
            this.PastetoolStripButton1.Text = "Paste Ctrl+P";
            this.PastetoolStripButton1.ToolTipText = "Paste Ctrl+V";
            this.PastetoolStripButton1.Click += new System.EventHandler(this.PastetoolStripButton1_Click);
            // 
            // LeftAligntoolStripButton1
            // 
            this.LeftAligntoolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LeftAligntoolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("LeftAligntoolStripButton1.Image")));
            this.LeftAligntoolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LeftAligntoolStripButton1.Name = "LeftAligntoolStripButton1";
            this.LeftAligntoolStripButton1.Size = new System.Drawing.Size(29, 25);
            this.LeftAligntoolStripButton1.Text = "toolStripButton1";
            this.LeftAligntoolStripButton1.ToolTipText = "Left Align";
            this.LeftAligntoolStripButton1.Click += new System.EventHandler(this.LeftAligntoolStripButton1_Click);
            // 
            // RightAligntoolStripButton1
            // 
            this.RightAligntoolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RightAligntoolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("RightAligntoolStripButton1.Image")));
            this.RightAligntoolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RightAligntoolStripButton1.Name = "RightAligntoolStripButton1";
            this.RightAligntoolStripButton1.Size = new System.Drawing.Size(29, 25);
            this.RightAligntoolStripButton1.Text = "toolStripButton1";
            this.RightAligntoolStripButton1.ToolTipText = "Right Align";
            this.RightAligntoolStripButton1.Click += new System.EventHandler(this.RightAligntoolStripButton1_Click);
            // 
            // CentreAligntoolStripButton1
            // 
            this.CentreAligntoolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CentreAligntoolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("CentreAligntoolStripButton1.Image")));
            this.CentreAligntoolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CentreAligntoolStripButton1.Name = "CentreAligntoolStripButton1";
            this.CentreAligntoolStripButton1.Size = new System.Drawing.Size(29, 25);
            this.CentreAligntoolStripButton1.Text = "toolStripButton1";
            this.CentreAligntoolStripButton1.ToolTipText = "Center Align";
            this.CentreAligntoolStripButton1.Click += new System.EventHandler(this.CentreAligntoolStripButton1_Click);
            // 
            // FonttoolStripComboBox1
            // 
            this.FonttoolStripComboBox1.Name = "FonttoolStripComboBox1";
            this.FonttoolStripComboBox1.Size = new System.Drawing.Size(121, 28);
            this.FonttoolStripComboBox1.Text = "Font";
            this.FonttoolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.FonttoolStripComboBox1_SelectedIndexChanged);
            // 
            // BoldtoolStripButton1
            // 
            this.BoldtoolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BoldtoolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("BoldtoolStripButton1.Image")));
            this.BoldtoolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BoldtoolStripButton1.Name = "BoldtoolStripButton1";
            this.BoldtoolStripButton1.Size = new System.Drawing.Size(29, 25);
            this.BoldtoolStripButton1.Text = "Bold";
            this.BoldtoolStripButton1.Click += new System.EventHandler(this.BoldtoolStripButton1_Click);
            // 
            // ItalictoolStripButton1
            // 
            this.ItalictoolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ItalictoolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("ItalictoolStripButton1.Image")));
            this.ItalictoolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ItalictoolStripButton1.Name = "ItalictoolStripButton1";
            this.ItalictoolStripButton1.Size = new System.Drawing.Size(29, 25);
            this.ItalictoolStripButton1.Text = "Italic";
            // 
            // FontSizetoolStripComboBox2
            // 
            this.FontSizetoolStripComboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "24",
            "26",
            "28",
            "30",
            "34",
            "38",
            "40",
            "45",
            "50",
            "55",
            "60",
            "70",
            "80"});
            this.FontSizetoolStripComboBox2.Name = "FontSizetoolStripComboBox2";
            this.FontSizetoolStripComboBox2.Size = new System.Drawing.Size(121, 28);
            this.FontSizetoolStripComboBox2.Text = "Font Size";
            this.FontSizetoolStripComboBox2.SelectedIndexChanged += new System.EventHandler(this.FontSizetoolStripComboBox2_SelectedIndexChanged);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 25);
            this.toolStripButton1.Text = "Zoom In";
            this.toolStripButton1.Click += new System.EventHandler(this.zoomInToolStripMenuItem_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 25);
            this.toolStripButton2.Text = "Zoom Out";
            this.toolStripButton2.Click += new System.EventHandler(this.zoomOutToolStripMenuItem_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(29, 25);
            this.toolStripButton3.Text = "Undo Ctrl+Z";
            this.toolStripButton3.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(29, 25);
            this.toolStripButton4.Text = "Redo Ctrl+Y";
            this.toolStripButton4.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 56);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 394);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 26);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(213, 20);
            this.toolStripStatusLabel1.Text = "Document: Project Prototyping";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(103, 20);
            this.toolStripStatusLabel2.Text = "Word Count: 0";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(786, 56);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(14, 368);
            this.vScrollBar1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form1";
            this.Text = "WinForm - Editor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton CuttoolStripButton1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rulersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gridlinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foreColorToolStripMenuItem;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripButton CopytoolStripButton1;
        private System.Windows.Forms.ToolStripButton PastetoolStripButton1;
        private System.Windows.Forms.ToolStripButton LeftAligntoolStripButton1;
        private System.Windows.Forms.ToolStripButton RightAligntoolStripButton1;
        private System.Windows.Forms.ToolStripButton CentreAligntoolStripButton1;
        private System.Windows.Forms.ToolStripComboBox FonttoolStripComboBox1;
        private System.Windows.Forms.ToolStripButton BoldtoolStripButton1;
        private System.Windows.Forms.ToolStripButton ItalictoolStripButton1;
        private System.Windows.Forms.ToolStripComboBox FontSizetoolStripComboBox2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}

