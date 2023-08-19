using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibGit2Sharp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SiriusX
{
    public partial class Git : Form
    {
        public Git()
        {
            InitializeComponent();
            
        }

        private void Git_Load(object sender, EventArgs e)
        {

        }

        static string GetRepositoryNameFromUrl(string url)
        {
            // Extract the last part of the URL after the last slash and remove the '.git' extension
            int lastSlashIndex = url.LastIndexOf('/');
            if (lastSlashIndex >= 0)
            {
                string repositoryNameWithGit = url.Substring(lastSlashIndex + 1);
                if (repositoryNameWithGit.EndsWith(".git"))
                {
                    return repositoryNameWithGit.Substring(0, repositoryNameWithGit.Length - 4);
                }
                return repositoryNameWithGit;
            }

            return string.Empty;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string gitUrl = textBox1.Text; // Replace with your Git URL

            string repositoryName = GetRepositoryNameFromUrl(gitUrl);

            label1.Text = repositoryName;

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderDialog.SelectedPath))
                {
                    string selectedFolderPath = folderDialog.SelectedPath;
                    label2.Text = selectedFolderPath;
                }
                else
                {
                    Console.WriteLine("No folder selected.");
                }


            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label2.Text = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {

                string repositoryUrl = textBox1.Text; // Replace with the repository URL
                string targetFolderPath = label2.Text; // Replace with the target folder path

                CloneOptions options = new CloneOptions
                {
                    BranchName = textBox3.Text // Replace with the desired branch name
                };

                Repository.Clone(repositoryUrl, targetFolderPath, options);

                MessageBox.Show("Repository cloned successfully.");

            

            }
        }

      
        }
    }



