using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiriusX
{
    public partial class WorkspaceManagement : Form
    {
        private Form1 _form1;
        public static string filepath = string.Empty;
        public static string workspacepath = string.Empty;

        public WorkspaceManagement(Form1 form1)
        {
            InitializeComponent();
            timer1.Start();
            _form1 = form1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ;
        }

        private void folderBrowserDialog1_Selected(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1 = new FolderBrowserDialog();
            folderBrowserDialog1.ShowDialog();
        }




        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                if (_form1.currentext.Text == "currentext")
                {
                    // Create the file if no text was entered previously
                    FileStream fs = File.Create(label4.Text);
                    fs.Close();
                }
                else
                {
                    File.WriteAllText(label4.Text, _form1.currentext.Text);
                }
                
                // Show a success message
                MessageBox.Show("Workspace Created Successfully.", "Workspace Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 form = new Form1();
                workspacepath = textBox1.Text;
                filepath = label4.Text;
               _form1.workspaceLabel.Text = workspacepath;
                _form1.filenameLabel.Text = filepath;

            }
            catch (Exception ex)
            {
                // Show an error message
                MessageBox.Show("Error : ", MessageBoxIcon.Error + ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = folderBrowserDialog1.SelectedPath;
            timer1.Start();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label4.Text = textBox1.Text + "\\" + textBox2.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label4.Text = textBox1.Text + "\\" + textBox2.Text;
        }

        private void WorkspaceManagement_Load(object sender, EventArgs e)
        {

        }
        
    }


}
