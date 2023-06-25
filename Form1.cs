using System;
using System.Windows.Forms;
using System.ServiceProcess;
using System.Diagnostics;
using System.Text;
using System.IO;


namespace SiriusX
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddNewTab();


        }

        private void AddNewTab()
        {
            var scintillaEditor = new ScintillaEditor();
            scintillaEditor.Dock = DockStyle.Fill;

            var tabPage = new TabPage("Untitled");
            tabPage.Controls.Add(scintillaEditor);

            tabControl1.TabPages.Add(tabPage);
            tabControl1.SelectedTab = tabPage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TabPage selectedTab = tabControl1.SelectedTab;

            ScintillaEditor scintillaEditor = selectedTab.Controls.OfType<ScintillaEditor>().FirstOrDefault();
            string scintillaText = scintillaEditor?.Text;
            button1.Text = scintillaText;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddNewTab();
        }





        private void button3_Click_1(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab != null)
            {
                // Get the selected tab
                TabPage selectedTab = tabControl1.SelectedTab;

                // Remove the selected tab from the TabPages collection
                tabControl1.TabPages.Remove(selectedTab);
            }
        }










    }
}

