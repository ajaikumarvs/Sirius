using ScintillaNET;

namespace Sirius
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
            components = new System.ComponentModel.Container();
            kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(components);
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            button12 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            textBox1 = new TextBox();
            panel1 = new Panel();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            projectToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            toolStripLabel2 = new ToolStripLabel();
            toolStripLabel3 = new ToolStripLabel();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripLabel4 = new ToolStripLabel();
            toolStripLabel5 = new ToolStripLabel();
            toolStripLabel6 = new ToolStripLabel();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripLabel7 = new ToolStripLabel();
            toolStripLabel8 = new ToolStripLabel();
            toolStripLabel9 = new ToolStripLabel();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripLabel10 = new ToolStripLabel();
            toolStripLabel11 = new ToolStripLabel();
            toolStripComboBox1 = new ToolStripComboBox();
            scintilla1 = new Scintilla();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            cliplistbox = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            tabPage2 = new TabPage();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // kryptonPalette1
            // 
            kryptonPalette1.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = Color.White;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = Color.White;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 16;
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.Color1 = Color.White;
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.Color2 = Color.White;
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Controls.Add(button5);
            flowLayoutPanel1.Controls.Add(button6);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(tableLayoutPanel1);
            flowLayoutPanel1.Controls.Add(textBox1);
            flowLayoutPanel1.Dock = DockStyle.Right;
            flowLayoutPanel1.Location = new Point(1569, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(101, 750);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(94, 76);
            button1.TabIndex = 0;
            button1.Text = "New";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(3, 85);
            button2.Name = "button2";
            button2.Size = new Size(94, 76);
            button2.TabIndex = 1;
            button2.Text = "Open";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(3, 167);
            button3.Name = "button3";
            button3.Size = new Size(94, 76);
            button3.TabIndex = 2;
            button3.Text = "Compare";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(3, 249);
            button4.Name = "button4";
            button4.Size = new Size(94, 76);
            button4.TabIndex = 3;
            button4.Text = "Sync";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(3, 331);
            button5.Name = "button5";
            button5.Size = new Size(94, 76);
            button5.TabIndex = 4;
            button5.Text = "FIle View";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(3, 413);
            button6.Name = "button6";
            button6.Size = new Size(94, 76);
            button6.TabIndex = 5;
            button6.Text = "DnD";
            button6.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 492);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 6;
            label1.Text = "Font Size : ";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(button12, 0, 3);
            tableLayoutPanel1.Controls.Add(button7, 0, 0);
            tableLayoutPanel1.Controls.Add(button8, 1, 0);
            tableLayoutPanel1.Controls.Add(button9, 0, 1);
            tableLayoutPanel1.Controls.Add(button10, 0, 2);
            tableLayoutPanel1.Controls.Add(button11, 1, 2);
            tableLayoutPanel1.Location = new Point(3, 515);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(86, 151);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // button12
            // 
            button12.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button12.Location = new Point(3, 114);
            button12.Name = "button12";
            button12.Size = new Size(37, 28);
            button12.TabIndex = 5;
            button12.Text = "Reset";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(3, 3);
            button7.Name = "button7";
            button7.Size = new Size(37, 28);
            button7.TabIndex = 0;
            button7.Text = "B";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Lucida Bright", 9F, FontStyle.Italic, GraphicsUnit.Point);
            button8.Location = new Point(46, 3);
            button8.Name = "button8";
            button8.Size = new Size(37, 28);
            button8.TabIndex = 1;
            button8.Text = "I";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            button9.Location = new Point(3, 40);
            button9.Name = "button9";
            button9.Size = new Size(37, 28);
            button9.TabIndex = 2;
            button9.Text = "U";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button10.Location = new Point(3, 77);
            button10.Name = "button10";
            button10.Size = new Size(37, 28);
            button10.TabIndex = 3;
            button10.Text = "+";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button11.Location = new Point(46, 77);
            button11.Name = "button11";
            button11.Size = new Size(37, 28);
            button11.TabIndex = 4;
            button11.Text = "-";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = Color.Gray;
            textBox1.Location = new Point(3, 672);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(94, 27);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1559, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 750);
            panel1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Bottom;
            menuStrip1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem, projectToolStripMenuItem });
            menuStrip1.Location = new Point(0, 750);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1670, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "&File";
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
            // projectToolStripMenuItem
            // 
            projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            projectToolStripMenuItem.Size = new Size(69, 24);
            projectToolStripMenuItem.Text = "&Project";
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.White;
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, toolStripLabel2, toolStripLabel3, toolStripSeparator1, toolStripLabel4, toolStripLabel5, toolStripLabel6, toolStripSeparator2, toolStripLabel7, toolStripLabel8, toolStripLabel9, toolStripSeparator3, toolStripLabel10, toolStripLabel11, toolStripComboBox1 });
            toolStrip1.Location = new Point(0, 722);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1559, 28);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(111, 25);
            toolStripLabel1.Text = "toolStripLabel1";
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(111, 25);
            toolStripLabel2.Text = "toolStripLabel2";
            // 
            // toolStripLabel3
            // 
            toolStripLabel3.Name = "toolStripLabel3";
            toolStripLabel3.Size = new Size(111, 25);
            toolStripLabel3.Text = "toolStripLabel3";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 28);
            // 
            // toolStripLabel4
            // 
            toolStripLabel4.Name = "toolStripLabel4";
            toolStripLabel4.Size = new Size(111, 25);
            toolStripLabel4.Text = "toolStripLabel4";
            // 
            // toolStripLabel5
            // 
            toolStripLabel5.Name = "toolStripLabel5";
            toolStripLabel5.Size = new Size(16, 25);
            toolStripLabel5.Text = "x";
            // 
            // toolStripLabel6
            // 
            toolStripLabel6.Name = "toolStripLabel6";
            toolStripLabel6.Size = new Size(111, 25);
            toolStripLabel6.Text = "toolStripLabel6";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 28);
            // 
            // toolStripLabel7
            // 
            toolStripLabel7.Name = "toolStripLabel7";
            toolStripLabel7.Size = new Size(111, 25);
            toolStripLabel7.Text = "toolStripLabel7";
            // 
            // toolStripLabel8
            // 
            toolStripLabel8.Name = "toolStripLabel8";
            toolStripLabel8.Size = new Size(111, 25);
            toolStripLabel8.Text = "toolStripLabel8";
            // 
            // toolStripLabel9
            // 
            toolStripLabel9.Name = "toolStripLabel9";
            toolStripLabel9.Size = new Size(111, 25);
            toolStripLabel9.Text = "toolStripLabel9";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 28);
            // 
            // toolStripLabel10
            // 
            toolStripLabel10.Name = "toolStripLabel10";
            toolStripLabel10.Size = new Size(66, 25);
            toolStripLabel10.Text = "0.001 KB";
            // 
            // toolStripLabel11
            // 
            toolStripLabel11.Name = "toolStripLabel11";
            toolStripLabel11.Size = new Size(119, 25);
            toolStripLabel11.Text = "toolStripLabel11";
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(121, 28);
            // 
            // scintilla1
            // 
            scintilla1.AutoCMaxHeight = 9;
            scintilla1.BiDirectionality = BiDirectionalDisplayType.Disabled;
            scintilla1.CaretLineBackColor = Color.Azure;
            scintilla1.CaretLineVisible = true;
            scintilla1.Dock = DockStyle.Fill;
            scintilla1.EdgeColor = Color.Black;
            scintilla1.LexerName = null;
            scintilla1.Location = new Point(3, 3);
            scintilla1.Name = "scintilla1";
            scintilla1.ScrollWidth = 57;
            scintilla1.Size = new Size(1545, 683);
            scintilla1.TabIndents = true;
            scintilla1.TabIndex = 4;
            scintilla1.UseRightToLeftReadingLayout = false;
            scintilla1.WrapMode = WrapMode.None;
            scintilla1.CharAdded += scintilla1_CharAdded;
            scintilla1.MarginClick += Scintilla1_MarginClick;
            scintilla1.UpdateUI += scintilla_UpdateUI;
            scintilla1.TextChanged += scintilla1_TextChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1559, 722);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(cliplistbox);
            tabPage1.Controls.Add(scintilla1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1551, 689);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Untitled";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // cliplistbox
            // 
            cliplistbox.Items.AddRange(new object[] { "Clipboard Text 1", "Clipboard Text 2" });
            cliplistbox.Location = new Point(828, 6);
            cliplistbox.Name = "cliplistbox";
            cliplistbox.Size = new Size(221, 516);
            cliplistbox.TabIndex = 5;
            cliplistbox.Visible = false;
            cliplistbox.SelectedIndexChanged += cliplistbox_SelectedIndexChanged;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1551, 689);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Macro";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1670, 778);
            Controls.Add(tabControl1);
            Controls.Add(toolStrip1);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Palette = kryptonPalette1;
            PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            ShowIcon = false;
            StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            StateCommon.Border.Rounding = 14;
            Text = "New Untitled Project";
            Load += Form1_Load;
            SizeChanged += Form1_Changed;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }





        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem projectToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ScintillaNET.Scintilla scintilla1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ToolStripLabel toolStripLabel2;
        private ToolStripLabel toolStripLabel3;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripLabel4;
        private ToolStripLabel toolStripLabel5;
        private ToolStripLabel toolStripLabel6;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripLabel toolStripLabel7;
        private ToolStripLabel toolStripLabel8;
        private ToolStripLabel toolStripLabel9;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripLabel toolStripLabel10;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox cliplistbox;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button7;
        private Button button8;
        private Button button9;
        private TextBox textBox1;
        private ToolStripLabel toolStripLabel11;
        private Button button10;
        private Button button11;
        private Button button12;
        private ToolStripLabel toolStripLabel1;
        private ToolStripComboBox toolStripComboBox1;
    }
}