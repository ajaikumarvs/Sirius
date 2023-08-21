using ScintillaNET;
using System.Diagnostics;

namespace SiriusX
{
    partial class Form1
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            button1 = new Button();
            button2 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            kryptonPanel5 = new Krypton.Toolkit.KryptonPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label1 = new Label();
            button7 = new Button();
            button8 = new Button();
            kryptonPanel6 = new Krypton.Toolkit.KryptonPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            button16 = new Button();
            button15 = new Button();
            button14 = new Button();
            button13 = new Button();
            button12 = new Button();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            comboBox1 = new ComboBox();
            flowLayoutPanel3 = new FlowLayoutPanel();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            gitToolStripMenuItem = new ToolStripMenuItem();
            cloneToolStripMenuItem = new ToolStripMenuItem();
            debugToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            tstriplexname = new ToolStripLabel();
            toolStripLabel1 = new ToolStripLabel();
            tabControl2 = new TabControl();
            outTab = new TabPage();
            outscint = new Scintilla();
            textBox1 = new TextBox();
            webTab = new TabPage();
            chromium = new CefSharp.WinForms.ChromiumWebBrowser();
            pyTab = new TabPage();
            pyscint = new Scintilla();
            tabPage1 = new TabPage();
            currentext = new Scintilla();
            label2 = new Label();
            filenameLabel = new Label();
            workspaceLabel = new Label();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            kryptonPanel4 = new Krypton.Toolkit.KryptonPanel();
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            kryptonPanel3 = new Krypton.Toolkit.KryptonPanel();
            openFileDialog1 = new OpenFileDialog();
            previewscint = new Scintilla();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel5).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel6).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            tabControl2.SuspendLayout();
            outTab.SuspendLayout();
            webTab.SuspendLayout();
            pyTab.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Location = new Point(4, 9);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1047, 506);
            tabControl1.TabIndex = 2;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(3, 93);
            button1.Name = "button1";
            button1.Size = new Size(131, 32);
            button1.TabIndex = 3;
            button1.Text = "Capture";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(3, 3);
            button2.Name = "button2";
            button2.Size = new Size(68, 31);
            button2.TabIndex = 4;
            button2.Text = "+";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Controls.Add(button5);
            flowLayoutPanel1.Controls.Add(button6);
            flowLayoutPanel1.Controls.Add(kryptonPanel5);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Controls.Add(kryptonPanel6);
            flowLayoutPanel1.Controls.Add(tableLayoutPanel1);
            flowLayoutPanel1.Controls.Add(comboBox1);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel3);
            flowLayoutPanel1.Dock = DockStyle.Right;
            flowLayoutPanel1.Location = new Point(1185, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(146, 824);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // button3
            // 
            button3.Location = new Point(77, 3);
            button3.Name = "button3";
            button3.Size = new Size(66, 31);
            button3.TabIndex = 5;
            button3.Text = "-";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button4
            // 
            button4.Location = new Point(3, 40);
            button4.Name = "button4";
            button4.Size = new Size(140, 33);
            button4.TabIndex = 6;
            button4.Text = "New";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(3, 79);
            button5.Name = "button5";
            button5.Size = new Size(140, 33);
            button5.TabIndex = 7;
            button5.Text = "Save";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(3, 118);
            button6.Name = "button6";
            button6.Size = new Size(140, 33);
            button6.TabIndex = 8;
            button6.Text = "Open";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // kryptonPanel5
            // 
            kryptonPanel5.Location = new Point(3, 157);
            kryptonPanel5.Name = "kryptonPanel5";
            kryptonPanel5.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007SilverLightMode;
            kryptonPanel5.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.ContextMenuHeading;
            kryptonPanel5.Size = new Size(140, 2);
            kryptonPanel5.TabIndex = 9;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(label1);
            flowLayoutPanel2.Controls.Add(button7);
            flowLayoutPanel2.Controls.Add(button8);
            flowLayoutPanel2.Controls.Add(button1);
            flowLayoutPanel2.Location = new Point(3, 165);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(143, 173);
            flowLayoutPanel2.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 0;
            label1.Text = "Web Debug Tools";
            // 
            // button7
            // 
            button7.Location = new Point(3, 23);
            button7.Name = "button7";
            button7.Size = new Size(137, 29);
            button7.TabIndex = 1;
            button7.Text = "Run";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(3, 58);
            button8.Name = "button8";
            button8.Size = new Size(137, 29);
            button8.TabIndex = 2;
            button8.Text = "DevTools";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // kryptonPanel6
            // 
            kryptonPanel6.Location = new Point(3, 344);
            kryptonPanel6.Name = "kryptonPanel6";
            kryptonPanel6.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007SilverDarkMode;
            kryptonPanel6.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.ContextMenuHeading;
            kryptonPanel6.Size = new Size(140, 2);
            kryptonPanel6.TabIndex = 12;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 44F));
            tableLayoutPanel1.Controls.Add(button16, 1, 2);
            tableLayoutPanel1.Controls.Add(button15, 0, 2);
            tableLayoutPanel1.Controls.Add(button14, 2, 1);
            tableLayoutPanel1.Controls.Add(button13, 1, 1);
            tableLayoutPanel1.Controls.Add(button12, 0, 1);
            tableLayoutPanel1.Controls.Add(button11, 2, 0);
            tableLayoutPanel1.Controls.Add(button10, 1, 0);
            tableLayoutPanel1.Controls.Add(button9, 0, 0);
            tableLayoutPanel1.Location = new Point(3, 352);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableLayoutPanel1.Size = new Size(143, 159);
            tableLayoutPanel1.TabIndex = 15;
            // 
            // button16
            // 
            button16.Location = new Point(52, 105);
            button16.Name = "button16";
            button16.Size = new Size(43, 45);
            button16.TabIndex = 7;
            button16.Text = "Stop";
            button16.UseVisualStyleBackColor = true;
            button16.Click += button16_Click;
            // 
            // button15
            // 
            button15.BackgroundImageLayout = ImageLayout.Zoom;
            button15.ImageAlign = ContentAlignment.TopLeft;
            button15.Location = new Point(3, 105);
            button15.Name = "button15";
            button15.Size = new Size(43, 45);
            button15.TabIndex = 6;
            button15.Text = "Run";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // button14
            // 
            button14.Location = new Point(101, 54);
            button14.Name = "button14";
            button14.Size = new Size(39, 45);
            button14.TabIndex = 5;
            button14.Text = "button14";
            button14.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            button13.Location = new Point(52, 54);
            button13.Name = "button13";
            button13.Size = new Size(43, 45);
            button13.TabIndex = 4;
            button13.Text = "button13";
            button13.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.BackgroundImageLayout = ImageLayout.Zoom;
            button12.Location = new Point(3, 54);
            button12.Name = "button12";
            button12.Size = new Size(43, 45);
            button12.TabIndex = 3;
            button12.Text = "Mic";
            button12.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Location = new Point(101, 3);
            button11.Name = "button11";
            button11.Size = new Size(39, 45);
            button11.TabIndex = 2;
            button11.Text = "R";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button10
            // 
            button10.Location = new Point(52, 3);
            button10.Name = "button10";
            button10.Size = new Size(43, 45);
            button10.TabIndex = 1;
            button10.Text = "-";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button9
            // 
            button9.Location = new Point(3, 3);
            button9.Name = "button9";
            button9.Size = new Size(43, 45);
            button9.TabIndex = 0;
            button9.Text = "+";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Plain Text", "C", "C++", "HTML", "CSS", "Javascript", "Python" });
            comboBox1.Location = new Point(3, 517);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(140, 28);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Location = new Point(3, 551);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(140, 125);
            flowLayoutPanel3.TabIndex = 16;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Black;
            menuStrip1.Dock = DockStyle.Bottom;
            menuStrip1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem, gitToolStripMenuItem, debugToolStripMenuItem, toolsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 824);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1331, 28);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, newToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(128, 26);
            openToolStripMenuItem.Text = "Open";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(128, 26);
            newToolStripMenuItem.Text = "New";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "&Edit";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(55, 24);
            viewToolStripMenuItem.Text = "&View";
            // 
            // gitToolStripMenuItem
            // 
            gitToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cloneToolStripMenuItem });
            gitToolStripMenuItem.Name = "gitToolStripMenuItem";
            gitToolStripMenuItem.Size = new Size(42, 24);
            gitToolStripMenuItem.Text = "&Git";
            // 
            // cloneToolStripMenuItem
            // 
            cloneToolStripMenuItem.Name = "cloneToolStripMenuItem";
            cloneToolStripMenuItem.Size = new Size(130, 26);
            cloneToolStripMenuItem.Text = "Clone";
            cloneToolStripMenuItem.Click += cloneToolStripMenuItem_Click;
            // 
            // debugToolStripMenuItem
            // 
            debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            debugToolStripMenuItem.Size = new Size(68, 24);
            debugToolStripMenuItem.Text = "&Debug";
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(58, 24);
            toolsToolStripMenuItem.Text = "&Tools";
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tstriplexname, toolStripLabel1 });
            toolStrip1.Location = new Point(0, 799);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.Professional;
            toolStrip1.Size = new Size(1185, 25);
            toolStrip1.TabIndex = 8;
            toolStrip1.Text = "toolStrip1";
            // 
            // tstriplexname
            // 
            tstriplexname.Name = "tstriplexname";
            tstriplexname.Size = new Size(72, 22);
            tstriplexname.Text = "Plain Text";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(50, 22);
            toolStripLabel1.Text = "Ready";
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(outTab);
            tabControl2.Controls.Add(webTab);
            tabControl2.Controls.Add(pyTab);
            tabControl2.Controls.Add(tabPage1);
            tabControl2.Dock = DockStyle.Bottom;
            tabControl2.Location = new Point(0, 521);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(1185, 278);
            tabControl2.TabIndex = 9;
            // 
            // outTab
            // 
            outTab.Controls.Add(outscint);
            outTab.Controls.Add(textBox1);
            outTab.Location = new Point(4, 29);
            outTab.Name = "outTab";
            outTab.Padding = new Padding(3);
            outTab.Size = new Size(1177, 245);
            outTab.TabIndex = 0;
            outTab.Text = "Output";
            outTab.UseVisualStyleBackColor = true;
            // 
            // outscint
            // 
            outscint.AutoCMaxHeight = 9;
            outscint.BiDirectionality = BiDirectionalDisplayType.Disabled;
            outscint.CaretForeColor = Color.Gray;
            outscint.CaretLineBackColor = Color.White;
            outscint.CaretLineVisible = true;
            outscint.Dock = DockStyle.Fill;
            outscint.LexerName = null;
            outscint.Location = new Point(3, 3);
            outscint.Name = "outscint";
            outscint.ScrollWidth = 57;
            outscint.Size = new Size(1171, 212);
            outscint.TabIndents = true;
            outscint.TabIndex = 4;
            outscint.UseRightToLeftReadingLayout = false;
            outscint.WrapMode = WrapMode.None;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Bottom;
            textBox1.Location = new Point(3, 215);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1171, 27);
            textBox1.TabIndex = 1;
            // 
            // webTab
            // 
            webTab.Controls.Add(chromium);
            webTab.Location = new Point(4, 29);
            webTab.Name = "webTab";
            webTab.Padding = new Padding(3);
            webTab.Size = new Size(1177, 245);
            webTab.TabIndex = 1;
            webTab.Text = "Web";
            webTab.UseVisualStyleBackColor = true;
            // 
            // chromium
            // 
            chromium.ActivateBrowserOnCreation = false;
            chromium.Dock = DockStyle.Fill;
            chromium.Location = new Point(3, 3);
            chromium.Name = "chromium";
            chromium.Size = new Size(1171, 239);
            chromium.TabIndex = 0;
            // 
            // pyTab
            // 
            pyTab.Controls.Add(pyscint);
            pyTab.Location = new Point(4, 29);
            pyTab.Name = "pyTab";
            pyTab.Size = new Size(1177, 245);
            pyTab.TabIndex = 2;
            pyTab.Text = "Python";
            pyTab.UseVisualStyleBackColor = true;
            // 
            // pyscint
            // 
            pyscint.AutoCMaxHeight = 9;
            pyscint.BiDirectionality = BiDirectionalDisplayType.Disabled;
            pyscint.CaretForeColor = Color.White;
            pyscint.CaretLineBackColor = Color.White;
            pyscint.CaretLineVisible = true;
            pyscint.Dock = DockStyle.Fill;
            pyscint.LexerName = null;
            pyscint.Location = new Point(0, 0);
            pyscint.Name = "pyscint";
            pyscint.ScrollWidth = 57;
            pyscint.Size = new Size(1177, 245);
            pyscint.TabIndents = true;
            pyscint.TabIndex = 0;
            pyscint.UseRightToLeftReadingLayout = false;
            pyscint.WrapMode = WrapMode.None;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(currentext);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(filenameLabel);
            tabPage1.Controls.Add(workspaceLabel);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(1177, 245);
            tabPage1.TabIndex = 3;
            tabPage1.Text = "DEBUG TAB";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // currentext
            // 
            currentext.AutoCMaxHeight = 9;
            currentext.BiDirectionality = BiDirectionalDisplayType.Disabled;
            currentext.CaretLineBackColor = Color.White;
            currentext.CaretLineVisible = true;
            currentext.LexerName = null;
            currentext.Location = new Point(803, 0);
            currentext.Name = "currentext";
            currentext.ScrollWidth = 69;
            currentext.Size = new Size(250, 125);
            currentext.TabIndents = true;
            currentext.TabIndex = 10;
            currentext.Text = "currentext";
            currentext.UseRightToLeftReadingLayout = false;
            currentext.WrapMode = WrapMode.None;
            currentext.Click += currentext_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 53);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 9;
            label2.Text = "saveautonotset";
            // 
            // filenameLabel
            // 
            filenameLabel.AutoSize = true;
            filenameLabel.Location = new Point(8, 33);
            filenameLabel.Name = "filenameLabel";
            filenameLabel.Size = new Size(108, 20);
            filenameLabel.TabIndex = 8;
            filenameLabel.Text = "filenamenotset";
            // 
            // workspaceLabel
            // 
            workspaceLabel.AutoSize = true;
            workspaceLabel.Location = new Point(8, 11);
            workspaceLabel.Name = "workspaceLabel";
            workspaceLabel.Size = new Size(120, 20);
            workspaceLabel.TabIndex = 7;
            workspaceLabel.Text = "workspacenotset";
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(kryptonPanel4);
            kryptonPanel1.Dock = DockStyle.Right;
            kryptonPanel1.Location = new Point(1183, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.PaletteMode = Krypton.Toolkit.PaletteMode.SparklePurpleLightMode;
            kryptonPanel1.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.ContextMenuHeading;
            kryptonPanel1.Size = new Size(2, 521);
            kryptonPanel1.TabIndex = 11;
            // 
            // kryptonPanel4
            // 
            kryptonPanel4.Dock = DockStyle.Right;
            kryptonPanel4.Location = new Point(0, 0);
            kryptonPanel4.Name = "kryptonPanel4";
            kryptonPanel4.PaletteMode = Krypton.Toolkit.PaletteMode.SparklePurpleLightMode;
            kryptonPanel4.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.ContextMenuHeading;
            kryptonPanel4.Size = new Size(2, 521);
            kryptonPanel4.TabIndex = 12;
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Dock = DockStyle.Bottom;
            kryptonPanel2.Location = new Point(0, 518);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.PaletteMode = Krypton.Toolkit.PaletteMode.SparklePurpleLightMode;
            kryptonPanel2.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.HeaderCustom1;
            kryptonPanel2.Size = new Size(1183, 3);
            kryptonPanel2.TabIndex = 12;
            // 
            // kryptonPanel3
            // 
            kryptonPanel3.Dock = DockStyle.Top;
            kryptonPanel3.Location = new Point(0, 0);
            kryptonPanel3.Name = "kryptonPanel3";
            kryptonPanel3.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleOrangeDarkMode;
            kryptonPanel3.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.HeaderCustom1;
            kryptonPanel3.Size = new Size(1183, 3);
            kryptonPanel3.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // previewscint
            // 
            previewscint.AutoCMaxHeight = 9;
            previewscint.BiDirectionality = BiDirectionalDisplayType.Disabled;
            previewscint.CaretLineBackColor = Color.White;
            previewscint.CaretLineVisible = true;
            previewscint.Dock = DockStyle.Right;
            previewscint.Font = new Font("Verdana", 4F, FontStyle.Regular, GraphicsUnit.Point);
            previewscint.LexerName = null;
            previewscint.Location = new Point(1057, 3);
            previewscint.Name = "previewscint";
            previewscint.ScrollWidth = 57;
            previewscint.Size = new Size(126, 515);
            previewscint.TabIndents = true;
            previewscint.TabIndex = 13;
            previewscint.UseRightToLeftReadingLayout = false;
            previewscint.WrapMode = WrapMode.None;
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1331, 852);
            Controls.Add(previewscint);
            Controls.Add(kryptonPanel3);
            Controls.Add(kryptonPanel2);
            Controls.Add(kryptonPanel1);
            Controls.Add(tabControl2);
            Controls.Add(toolStrip1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Sirius (Untitled)";
            Load += Form1_Load;
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel5).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel6).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tabControl2.ResumeLayout(false);
            outTab.ResumeLayout(false);
            outTab.PerformLayout();
            webTab.ResumeLayout(false);
            pyTab.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel4).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }





        #endregion

        private TabControl tabControl1;
        private Button button1;
        private Button button2;
        private FlowLayoutPanel flowLayoutPanel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private Button button3;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem gitToolStripMenuItem;
        private ToolStripMenuItem debugToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStrip toolStrip1;
        private TabControl tabControl2;
        private TabPage outTab;
        private TabPage webTab;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private TextBox textBox1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private Button button4;
        private Button button5;
        private Button button6;
        private OpenFileDialog openFileDialog1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel5;
        private CefSharp.WinForms.ChromiumWebBrowser chromium;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label1;
        private Button button7;
        private Button button8;
        private TabPage pyTab;
        private Krypton.Toolkit.KryptonPanel kryptonPanel6;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button16;
        private Button button15;
        private Button button14;
        private Button button13;
        private Button button12;
        private Button button10;
        private Button button9;
        private ToolStripLabel tstriplexname;
        private Button button11;
        private ComboBox comboBox1;
        private TabPage tabPage1;
        public Label label2;
        public Label filenameLabel;
        public Label workspaceLabel;
        private FlowLayoutPanel flowLayoutPanel3;
        private ToolStripMenuItem cloneToolStripMenuItem;
        private ToolStripLabel toolStripLabel1;
        private Scintilla outscint;
        public Scintilla currentext;
        private Scintilla previewscint;
        private Scintilla pyscint;
    }
}