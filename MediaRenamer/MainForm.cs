using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MediaRenamer
{
    public partial class MainForm : Form
    {
        private string inputFile = "";
        private string outputFile = "";
        private bool renameFolder = false; 

        public MainForm()
        {
            InitializeComponent();
            openFileDialog1.FileName = "";
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            openFileDialog1.ShowDialog();
            inputFile = openFileDialog1.FileName;
            inputFileString.Text = inputFile;
        }

        private void browseOutput_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            outputFile = openFileDialog1.FileName;
            outputFileString.Text = outputFile;
        }

        private void renameFilesButton_Click(object sender, EventArgs e)
        {

        }

        private void renameFolderCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            renameFolder = renameFolderCheckBox.Checked; 
        }
    }
}
