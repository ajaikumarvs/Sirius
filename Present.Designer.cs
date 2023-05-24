namespace Sirius
{
    partial class Present
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
            presentscintilla = new ScintillaNET.Scintilla();
            panel1 = new Panel();
            kryptonWrapLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            SuspendLayout();
            // 
            // presentscintilla
            // 
            presentscintilla.AutoCMaxHeight = 9;
            presentscintilla.BiDirectionality = ScintillaNET.BiDirectionalDisplayType.Disabled;
            presentscintilla.CaretLineBackColor = Color.Black;
            presentscintilla.Dock = DockStyle.Top;
            presentscintilla.LexerName = null;
            presentscintilla.Location = new Point(0, 0);
            presentscintilla.Name = "presentscintilla";
            presentscintilla.ScrollWidth = 83;
            presentscintilla.Size = new Size(1263, 617);
            presentscintilla.TabIndents = true;
            presentscintilla.TabIndex = 0;
            presentscintilla.Text = "Presentation";
            presentscintilla.UseRightToLeftReadingLayout = false;
            presentscintilla.WrapMode = ScintillaNET.WrapMode.None;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Desktop;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 617);
            panel1.Name = "panel1";
            panel1.Size = new Size(1263, 22);
            panel1.TabIndex = 1;
            // 
            // kryptonWrapLabel1
            // 
            kryptonWrapLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonWrapLabel1.ForeColor = Color.FromArgb(30, 57, 91);
            kryptonWrapLabel1.Location = new Point(533, 674);
            kryptonWrapLabel1.Name = "kryptonWrapLabel1";
            kryptonWrapLabel1.Size = new Size(139, 20);
            kryptonWrapLabel1.Text = "kryptonWrapLabel1";
            // 
            // Present
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1263, 778);
            Controls.Add(kryptonWrapLabel1);
            Controls.Add(panel1);
            Controls.Add(presentscintilla);
            Name = "Present";
            Text = "Presentation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ScintillaNET.Scintilla presentscintilla;
        private Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel kryptonWrapLabel1;
    }
}