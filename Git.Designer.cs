namespace SiriusX
{
    partial class Git
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            button2 = new Button();
            label3 = new Label();
            textBox3 = new TextBox();
            treeview = new Krypton.Toolkit.KryptonTreeView();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(122, 89);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(402, 34);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(122, 158);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(402, 34);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(411, 249);
            button1.Name = "button1";
            button1.Size = new Size(113, 40);
            button1.TabIndex = 2;
            button1.Text = "Clone";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 126);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 3;
            label1.Text = "GIthub";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 195);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 4;
            label2.Text = "empty";
            // 
            // button2
            // 
            button2.Location = new Point(533, 165);
            button2.Name = "button2";
            button2.Size = new Size(138, 29);
            button2.TabIndex = 5;
            button2.Text = "Select Folder";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(680, 237);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 6;
            label3.Text = "label3";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(530, 89);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(115, 34);
            textBox3.TabIndex = 7;
            textBox3.Text = "master";
            // 
            // treeview
            // 
            treeview.Location = new Point(797, 97);
            treeview.Name = "treeview";
            treeview.Size = new Size(273, 287);
            treeview.TabIndex = 8;
            // 
            // Git
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1208, 567);
            Controls.Add(treeview);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Git";
            Text = "Git";
            Load += Git_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label1;
        private Label label2;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button button2;
        private Label label3;
        private TextBox textBox3;
        private Krypton.Toolkit.KryptonTreeView treeview;
    }
}