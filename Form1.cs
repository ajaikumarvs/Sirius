using System;
using System.Windows.Forms;
using System.ServiceProcess;
using System.Diagnostics;
using System.Text;
using System.IO;
using Tesseract;
using System.Drawing;
using System.Threading.Tasks;
using CefSharp;
using CefSharp.WinForms;
using ScintillaNET;
using IronPython.Hosting;
using IronPython.Runtime;
using Microsoft.Scripting.Hosting;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography.X509Certificates;
using System.Reflection.Emit;

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
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt|Python File|*.py|PNG File|*.png|Javascript|*.js|All Files (*.*)|*.*";




        }
        private string GetTextFromCurrentTab()
        {
            if (tabControl1.SelectedTab != null && tabControl1.SelectedTab.Controls.Count > 0)
            {
                if (tabControl1.SelectedTab.Controls[0] is ScintillaEditor scintilla)
                {
                    return scintilla.Text;
                }
            }

            return string.Empty;
        }

        private void GetTextButton_Click(object sender, EventArgs e)
        {
            string text = GetTextFromCurrentTab();
            MessageBox.Show(text);
        }

        private void AddNewTab()
        {
            var scintillaEditor = new ScintillaEditor();
            scintillaEditor.Dock = DockStyle.Fill;

            var tabPage = new TabPage("Untitled");
            tabPage.Controls.Add(scintillaEditor);

            tabControl1.TabPages.Add(tabPage);
            tabControl1.SelectedTab = tabPage;
            scintillaEditor.AllowDrop = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
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

        private void button6_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(this);
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //For File Extension
            string filePathforExt = openFileDialog1.FileName;
            string fileExtension = Path.GetExtension(filePathforExt);
            //OCR
            if (fileExtension == ".png")
            {






            }


            //START OF NORMAL FILE OPENING FEATURE-------------------------------------------------
            try
            {
                // Retrieve the selected file path
                string filePath = openFileDialog1.FileName;

                // Open the file for reading

                TabPage selectedTab = tabControl1.SelectedTab;
                // Check if the selected tab contains a ScintillaEditor instance
                if (selectedTab.Controls[0] is ScintillaEditor scintillaEditor)
                {
                    // Get the text from your desired source (e.g., a textbox)
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string fileContent = File.ReadAllText(filePath);
                        scintillaEditor.Text = fileContent;
                        selectedTab.Text = openFileDialog1.SafeFileName;
                        this.Text = "Sirius (" + openFileDialog1.SafeFileName + ")";


                    }

                }
            }
            catch (IOException g)
            {
                Console.WriteLine("An error occurred while reading the file: " + g.Message);
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Updating currentext

            TabPage selectedTab = tabControl1.SelectedTab;
            ScintillaEditor scintillaEditor = selectedTab.Controls.OfType<ScintillaEditor>().FirstOrDefault();
            string scintillaText = scintillaEditor?.Text;
            currentext.Text = scintillaText;
            //-END OF UPDATE

            if (workspaceLabel.Text == "workspacenotset")
            {
                MessageBox.Show("Please set a workspace for the project to run the code.", "Workspace Management", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Form work1 = new WorkspaceManagement(this);
                work1.ShowDialog();




            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            chromium.ShowDevTools();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            TabPage selectedTab = tabControl1.SelectedTab;

            ScintillaEditor scintillaEditor = selectedTab.Controls.OfType<ScintillaEditor>().FirstOrDefault();
            scintillaEditor.ZoomIn();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            TabPage selectedTab = tabControl1.SelectedTab;
            ScintillaEditor scintillaEditor = selectedTab.Controls.OfType<ScintillaEditor>().FirstOrDefault();
            scintillaEditor.ZoomOut();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            TabPage selectedTab = tabControl1.SelectedTab;
            ScintillaEditor scintillaEditor = selectedTab.Controls.OfType<ScintillaEditor>().FirstOrDefault();
            scintillaEditor.Zoom = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)

        {
            TabPage selectedTab = tabControl1.SelectedTab;

            ScintillaEditor scintillaEditor = selectedTab.Controls.OfType<ScintillaEditor>().FirstOrDefault();
            //ScintillaEditor scintillaEditor;

            if (comboBox1.SelectedIndex == 0)
            {
                tstriplexname.Text = "plaintext";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                tstriplexname.Text = Lexer.Cpp.ToString();
                scintillaEditor.Lexer = Lexer.Cpp;
                scintillaEditor.SetKeywords(0, "auto break main case char const continue default do double else enum extern float for goto if int long register return short signed sizeof static struct switch typedef union unsigned void volatile while");



            }
            else if (comboBox1.SelectedIndex == 2)
            {
                tstriplexname.Text = Lexer.Cpp.ToString();
                scintillaEditor.Lexer = Lexer.Cpp;


            }
            else if (comboBox1.SelectedIndex == 3)
            {
                tstriplexname.Text = Lexer.Html.ToString();
                scintillaEditor.Lexer = Lexer.Html;
                scintillaEditor.StyleClearAll();
                scintillaEditor.SetKeywords(0, "<!DOCTYPE html> <html> <head> <meta> <title> <style> <link> <script> <noscript> </head> <body> <article> <aside> <details> <figcaption> <figure> <footer> <header> <main> <mark> <nav> <section> <summary> <time> <address> <blockquote> <dd> <div> <dl> <dt> <fieldset> <figcaption> <figure> <hr> <li> <ol> <p> <pre> <ul> <a> <abbr> <b> <bdi> <bdo> <br> <cite> <code> <data> <dfn> <em> <i> <kbd> <mark> <q> <rp> <rt> <rtc> <ruby> <s> <samp> <small> <span> <strong> <sub> <sup> <time> <u> <var> <wbr> <area> <audio> <map> <track> <video> <embed> <object> <param> <source> <canvas> <noscript> <script> <slot> <template> <acronym> <applet> <basefont> <big> <blink> <center> <command> <content> <dir> <element> <font> <frame> <frameset> <image> <isindex> <keygen> <listing> <marquee> <menuitem> <multicol> <nextid> <nobr> <spacer> <strike> <tt> <xmp> </body> </html>");

                // Enable folding markers
                scintillaEditor.Margins[2].Type = MarginType.Symbol;
                scintillaEditor.Margins[2].Mask = Marker.MaskFolders;
                scintillaEditor.Margins[2].Sensitive = true;
                scintillaEditor.Margins[2].Width = 20;

                // Set folder markers
                scintillaEditor.Markers[Marker.Folder].Symbol = MarkerSymbol.BoxPlus;
                scintillaEditor.Markers[Marker.FolderOpen].Symbol = MarkerSymbol.BoxMinus;
                scintillaEditor.Markers[Marker.FolderEnd].Symbol = MarkerSymbol.BoxPlusConnected;
                scintillaEditor.Markers[Marker.FolderMidTail].Symbol = MarkerSymbol.TCorner;
                scintillaEditor.Markers[Marker.FolderOpenMid].Symbol = MarkerSymbol.BoxMinusConnected;
                scintillaEditor.Markers[Marker.FolderSub].Symbol = MarkerSymbol.VLine;
                scintillaEditor.Markers[Marker.FolderTail].Symbol = MarkerSymbol.LCorner;

                // Disable automatic indentation
                scintillaEditor.IndentationGuides = IndentView.None;
                // Load HTML keywords (tags and attributes)
                scintillaEditor.Refresh();


            }
            else if (comboBox1.SelectedIndex == 4)
            {
                tstriplexname.Text = Lexer.Css.ToString();
                scintillaEditor.Lexer = Lexer.Css;
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                tstriplexname.Text = Lexer.Json.ToString();
                scintillaEditor.Lexer = Lexer.Json;
            }
            else if (comboBox1.SelectedIndex == 6)
            {
                tstriplexname.Text = Lexer.Python.ToString();
                scintillaEditor.Lexer = Lexer.Python;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Text = "Sirius (" + tabControl1.SelectedTab.Text + ")";



        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

            if (workspaceLabel.Text == "workspacenotset")
            {
                MessageBox.Show("Please set a workspace for the project to run the code.", "Workspace Management", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Form work1 = new WorkspaceManagement(this);
                work1.ShowDialog();



            }
            //START OF PYTHON DEBUG
            else if (tstriplexname.Text == "Python")
            {
                try
                {

                    string curtext = GetTextFromCurrentTab();
                    File.WriteAllText(filenameLabel.Text, curtext);


                    var engine = Python.CreateEngine();

                    // Create a new scope for the Python script
                    var scope = engine.CreateScope();

                    // Load the Python script from a file
                    var scriptSource = engine.CreateScriptSourceFromFile(filenameLabel.Text);



                    // Redirect standard output to capture it
                    var outputStream = new System.IO.MemoryStream();
                    engine.Runtime.IO.SetOutput(outputStream, System.Text.Encoding.UTF8);

                    // Execute the Python script
                    scriptSource.Execute(scope);

                    // Get the captured output
                    var output = System.Text.Encoding.UTF8.GetString(outputStream.ToArray());

                    pyscint.Text = output;




                }
                catch (Exception ex)
                {
                    outscint.Text = (ex.Message);
                }
            }
            // END OF PYTHON DEBUG
            else if (tstriplexname.Text == "Html")
            {
                string curtext = GetTextFromCurrentTab();
                

                File.WriteAllText(filenameLabel.Text,curtext );

                chromium.Reload();
                chromium.Load(filenameLabel.Text);


            }



        }

        private void currentext_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {


        }

        private void cloneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form git = new Git();
            git.ShowDialog();
        }
    }

}




