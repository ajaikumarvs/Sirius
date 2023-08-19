namespace SiriusX
{
    partial class Dash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dash));
            kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            kryptonButton3 = new Krypton.Toolkit.KryptonButton();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            label1 = new Label();
            label2 = new Label();
            kryptonButton4 = new Krypton.Toolkit.KryptonButton();
            kryptonButton5 = new Krypton.Toolkit.KryptonButton();
            SuspendLayout();
            // 
            // kryptonButton2
            // 
            kryptonButton2.ButtonStyle = Krypton.Toolkit.ButtonStyle.Custom1;
            kryptonButton2.CornerRoundingRadius = 10F;
            kryptonButton2.Location = new Point(12, 273);
            kryptonButton2.Name = "kryptonButton2";
            kryptonButton2.PaletteMode = Krypton.Toolkit.PaletteMode.Office365BlackDarkMode;
            kryptonButton2.Size = new Size(186, 73);
            kryptonButton2.StateCommon.Back.Image = (Image)resources.GetObject("kryptonButton2.StateCommon.Back.Image");
            kryptonButton2.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton2.StateCommon.Border.Rounding = 10F;
            kryptonButton2.TabIndex = 3;
            kryptonButton2.Values.Text = "Open Project";
            // 
            // kryptonButton3
            // 
            kryptonButton3.ButtonStyle = Krypton.Toolkit.ButtonStyle.Custom1;
            kryptonButton3.CornerRoundingRadius = 10F;
            kryptonButton3.Location = new Point(12, 352);
            kryptonButton3.Name = "kryptonButton3";
            kryptonButton3.PaletteMode = Krypton.Toolkit.PaletteMode.Office365BlackDarkMode;
            kryptonButton3.Size = new Size(186, 73);
            kryptonButton3.StateCommon.Back.Image = Properties.Resources.Git_Icon_Black;
            kryptonButton3.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Tile;
            kryptonButton3.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton3.StateCommon.Border.Rounding = 10F;
            kryptonButton3.TabIndex = 4;
            kryptonButton3.Values.Text = "Clone a Repository";
            // 
            // kryptonButton1
            // 
            kryptonButton1.CornerRoundingRadius = 10F;
            kryptonButton1.Location = new Point(12, 194);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.PaletteMode = Krypton.Toolkit.PaletteMode.Office365BlackDarkMode;
            kryptonButton1.Size = new Size(186, 73);
            kryptonButton1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton1.StateCommon.Border.Rounding = 10F;
            kryptonButton1.TabIndex = 5;
            kryptonButton1.Values.Text = "New Project";
            kryptonButton1.Click += kryptonButton1_Click;
            kryptonButton1.MouseLeave += kryptonButton1_LostFocus;
            kryptonButton1.MouseHover += kryptonButton1_MouseFocus;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(256, 54);
            label1.TabIndex = 6;
            label1.Text = "SiriusX Alpha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.GradientInactiveCaption;
            label2.Location = new Point(204, 210);
            label2.Name = "label2";
            label2.Size = new Size(274, 40);
            label2.TabIndex = 7;
            label2.Text = "Automatically creates a workspace and \r\ncreates necessary files for your template\r\n";
            label2.Visible = false;
            // 
            // kryptonButton4
            // 
            kryptonButton4.ButtonStyle = Krypton.Toolkit.ButtonStyle.Custom1;
            kryptonButton4.CornerRoundingRadius = 10F;
            kryptonButton4.Location = new Point(805, 12);
            kryptonButton4.Name = "kryptonButton4";
            kryptonButton4.PaletteMode = Krypton.Toolkit.PaletteMode.SparklePurpleLightMode;
            kryptonButton4.Size = new Size(41, 31);
            kryptonButton4.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton4.StateCommon.Border.Rounding = 10F;
            kryptonButton4.TabIndex = 8;
            kryptonButton4.Values.Text = "X";
            kryptonButton4.Click += kryptonButton4_Click;
            // 
            // kryptonButton5
            // 
            kryptonButton5.CornerRoundingRadius = 10F;
            kryptonButton5.Location = new Point(758, 12);
            kryptonButton5.Name = "kryptonButton5";
            kryptonButton5.PaletteMode = Krypton.Toolkit.PaletteMode.SparklePurpleLightMode;
            kryptonButton5.Size = new Size(41, 31);
            kryptonButton5.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton5.StateCommon.Border.Rounding = 10F;
            kryptonButton5.TabIndex = 9;
            kryptonButton5.Values.Text = "-";
            kryptonButton5.Click += kryptonButton5_Click;
            // 
            // Dash
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 24, 24);
            ClientSize = new Size(858, 602);
            ControlBox = false;
            Controls.Add(kryptonButton5);
            Controls.Add(kryptonButton4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(kryptonButton1);
            Controls.Add(kryptonButton3);
            Controls.Add(kryptonButton2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dash";
            Load += Dash_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Krypton.Toolkit.KryptonButton kryptonButton2;
        private Krypton.Toolkit.KryptonButton kryptonButton3;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Label label1;
        private Label label2;
        private Krypton.Toolkit.KryptonButton kryptonButton4;
        private Krypton.Toolkit.KryptonButton kryptonButton5;
    }
}