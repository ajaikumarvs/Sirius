using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sirius
{
    public partial class Form2 : Form
    {
        public static string filapathfordebug = "";

   



        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox1.Text = textBox.Text.Replace(" ", "");
            label3.Text = "Project will be saved in C:\\Users\\Documents\\Sirius\\" + textBox1.Text;

        }
      

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label4.Visible = true;
            label4.Text = "File will be saved as C:\\Users\\Documents\\Sirius\\" + textBox1.Text + "\\" + textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + "Sirius" + "\\" + textBox1.Text;
            string filePath = folderPath + "\\" + textBox2.Text;

            try
            {
                Directory.CreateDirectory(folderPath);
                Console.WriteLine("Folder created successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while creating the folder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            //WRITING DATA TO FILE------------------------------------------------
            try
            {
               
                // Create a new file and open it for writing
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Write data to the file
                    writer.WriteLine(Form1.transfercode);

                    // You can also use writer.Write() to write data without a new line character
                    // writer.Write("Some text");
                }

                Console.WriteLine("Data written to the file successfully!");
                filapathfordebug = filePath;
                Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
                if (form1 != null)
                {
                    form1.LabelText = filePath;
                }

                this.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to write data to the file: " + ex.Message);
            }

            
        }
    }
   
}
