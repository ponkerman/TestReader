using System;
using System.Windows.Forms;


namespace TestReader
{
    public partial class Form1 : Form
    {
        Base DB;

        public Form1()
        {
            InitializeComponent();
        }

        private void FolderButt_Click(object sender, EventArgs e)
        {
            DB = new Base();
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.SelectedPath = @"F:\Projects\TestReader";
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                ScanButton.Enabled = true;
                SearchButton.Enabled = true;
                UpdateButton.Enabled = true;
            }
            if (DB.AddTLG(folderBrowser.SelectedPath) != 0)
            {
                MessageBox.Show("files loaded");
            }
            else
            {
                MessageBox.Show("files not found");
            }

        }

        private void Scan_Button_Click(object sender, EventArgs e)
        {
            DB.ReadData();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
