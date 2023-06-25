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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            gitToolStripMenuItem = new ToolStripMenuItem();
            debugToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            tabControl2 = new TabControl();
            tabPage1 = new TabPage();
            textBox1 = new TextBox();
            richTextBox1 = new RichTextBox();
            tabPage2 = new TabPage();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            kryptonPanel4 = new Krypton.Toolkit.KryptonPanel();
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            kryptonPanel3 = new Krypton.Toolkit.KryptonPanel();
            openFileDialog1 = new OpenFileDialog();
            flowLayoutPanel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            tabControl2.SuspendLayout();
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
            tabControl1.Size = new Size(1041, 390);
            tabControl1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(873, 40);
            button1.Name = "button1";
            button1.Size = new Size(131, 32);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(3, 3);
            button2.Name = "button2";
            button2.Size = new Size(61, 31);
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
            flowLayoutPanel1.Dock = DockStyle.Right;
            flowLayoutPanel1.Location = new Point(1053, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(134, 711);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // button3
            // 
            button3.Location = new Point(70, 3);
            button3.Name = "button3";
            button3.Size = new Size(61, 31);
            button3.TabIndex = 5;
            button3.Text = "-";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button4
            // 
            button4.Location = new Point(3, 40);
            button4.Name = "button4";
            button4.Size = new Size(130, 33);
            button4.TabIndex = 6;
            button4.Text = "New";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(3, 79);
            button5.Name = "button5";
            button5.Size = new Size(130, 33);
            button5.TabIndex = 7;
            button5.Text = "Save";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(3, 118);
            button6.Name = "button6";
            button6.Size = new Size(130, 33);
            button6.TabIndex = 8;
            button6.Text = "Open";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Black;
            menuStrip1.Dock = DockStyle.Bottom;
            menuStrip1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem, gitToolStripMenuItem, debugToolStripMenuItem, toolsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 711);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1187, 28);
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
            gitToolStripMenuItem.Name = "gitToolStripMenuItem";
            gitToolStripMenuItem.Size = new Size(42, 24);
            gitToolStripMenuItem.Text = "&Git";
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
            toolStrip1.Location = new Point(0, 686);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.Professional;
            toolStrip1.Size = new Size(1053, 25);
            toolStrip1.TabIndex = 8;
            toolStrip1.Text = "toolStrip1";
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage1);
            tabControl2.Controls.Add(tabPage2);
            tabControl2.Dock = DockStyle.Bottom;
            tabControl2.Location = new Point(0, 408);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(1053, 278);
            tabControl2.TabIndex = 9;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(richTextBox1);
            tabPage1.Controls.Add(button1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1045, 245);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Bottom;
            textBox1.Location = new Point(3, 215);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1039, 27);
            textBox1.TabIndex = 1;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(133, 43);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(597, 173);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1045, 245);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(kryptonPanel4);
            kryptonPanel1.Dock = DockStyle.Right;
            kryptonPanel1.Location = new Point(1051, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.PaletteMode = Krypton.Toolkit.PaletteMode.SparklePurpleLightMode;
            kryptonPanel1.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.ContextMenuHeading;
            kryptonPanel1.Size = new Size(2, 408);
            kryptonPanel1.TabIndex = 11;
            // 
            // kryptonPanel4
            // 
            kryptonPanel4.Dock = DockStyle.Right;
            kryptonPanel4.Location = new Point(0, 0);
            kryptonPanel4.Name = "kryptonPanel4";
            kryptonPanel4.PaletteMode = Krypton.Toolkit.PaletteMode.SparklePurpleLightMode;
            kryptonPanel4.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.ContextMenuHeading;
            kryptonPanel4.Size = new Size(2, 408);
            kryptonPanel4.TabIndex = 12;
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Dock = DockStyle.Bottom;
            kryptonPanel2.Location = new Point(0, 405);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.PaletteMode = Krypton.Toolkit.PaletteMode.SparklePurpleLightMode;
            kryptonPanel2.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.HeaderCustom1;
            kryptonPanel2.Size = new Size(1051, 3);
            kryptonPanel2.TabIndex = 12;
            // 
            // kryptonPanel3
            // 
            kryptonPanel3.Dock = DockStyle.Top;
            kryptonPanel3.Location = new Point(0, 0);
            kryptonPanel3.Name = "kryptonPanel3";
            kryptonPanel3.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleOrangeDarkMode;
            kryptonPanel3.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.HeaderCustom1;
            kryptonPanel3.Size = new Size(1051, 3);
            kryptonPanel3.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 739);
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
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl2.ResumeLayout(false);
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
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private TextBox textBox1;
        private RichTextBox richTextBox1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private Button button4;
        private Button button5;
        private Button button6;
        private OpenFileDialog openFileDialog1;
    }
}