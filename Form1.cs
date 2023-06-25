using System;
using System.Windows.Forms;
using System.ServiceProcess;
using System.Diagnostics;
using System.Text;
using System.IO;
using Tesseract;
using System.Drawing;


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
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt|Python File|*.py|PNG File|*.png|All Files (*.*)|*.*";



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
                var tesseractEngine = new TesseractEngine("./tessdata", "eng", EngineMode.Default);

                var image = Image.FromFile(filePathforExt); // Replace with the actual image file path
                using (var pix = Pix.LoadFromFile(openFileDialog1.FileName))
                {
                    using (var page = tesseractEngine.Process(pix))
                    {
                        // Get the extracted text from the page
                        var extractedText = page.GetText();

                        // Assuming you have a RichTextBox control named "richTextBox1"
                        richTextBox1.Text = extractedText;
                    }
                }
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
                        StringBuilder textBuilder = new StringBuilder();

                        string line;

                        // Read and process each line of the file
                        while ((line = reader.ReadLine()) != null)
                        {
                            textBuilder.AppendLine(line);
                        }
                        string fileText = textBuilder.ToString();


                        // Update the Scintilla editor's text
                        scintillaEditor.Text = line;
                    }

                }
            }
            catch (IOException g)
            {
                Console.WriteLine("An error occurred while reading the file: " + g.Message);
            }

        }
    }   

}
    


