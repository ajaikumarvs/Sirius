using ComponentFactory.Krypton.Toolkit;
using ScintillaNET;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows;

namespace Sirius


{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void scintilla1_TextChanged(object sender, EventArgs e)
        {
            var length = scintilla1.TextLength.ToString();

            toolStripLabel1.Text = "Char: " + scintilla1.TextLength.ToString();
            toolStripLabel2.Text = "Line: " + scintilla1.Lines.Count.ToString();
            toolStripLabel3.Text = "Col: " + scintilla1.EdgeColumn.ToString();
            toolStripLabel7.Text = scintilla1.Styles[Style.Cpp.String].Font.ToString(); //Getting Font Name
            toolStripLabel10.Text = Convert.ToInt32(length) / 1000 + " KB";
            label1.Text = scintilla1.Font.Name;





        }

        private void Form1_Changed(object sender, EventArgs e)
        {
            toolStripLabel4.Text = this.Height.ToString();
            toolStripLabel6.Text = this.Width.ToString();
        }



        private void cliplistbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private async void TrackClipboardChanges_EventHandler(object sender, EventArgs e)
        {
            cliplistbox.Items.Add(Clipboard.GetText());
        }

        private void scintilla1_Click(object sender, EventArgs e)
        {

        }
    }
}

