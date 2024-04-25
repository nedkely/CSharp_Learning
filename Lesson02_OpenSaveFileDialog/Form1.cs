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

namespace Lesson02_OpenSaveDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        string fileName = null;
        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {
            this.ofdOpen.FileName = "";
            this.ofdOpen.Filter = "all text file|*.txt";
            this.ofdOpen.Multiselect = false;
            this.ofdOpen.InitialDirectory = @"C:\";


            var result = ofdOpen.ShowDialog();


            if (result == DialogResult.OK)
            {
                fileName = ofdOpen.FileName;
                StreamReader streamReader = new StreamReader(fileName);
               
                this.txtText.Text = streamReader.ReadToEnd();


                btnSaveFileDialog.Text = "Save";
            }
        }

        private void btnSaveFileDialog_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(fileName))
            {
                StreamWriter streamWriter = new StreamWriter(fileName);
                streamWriter.Write(this.txtText.Text);
                streamWriter.Close();
                streamWriter.Dispose();
            }
            else
            {
                var result = sfdOpen.ShowDialog();
                if (result == DialogResult.OK)
                {
                    fileName = sfdOpen.FileName;
                    StreamWriter streamWriter = new StreamWriter(fileName);
                    streamWriter.Write(this.txtText.Text);
                    streamWriter.Close();
                    streamWriter.Dispose();
                }
            }


            this.txtText.Text = "";
            this.btnSaveFileDialog.Text = "Save As";

        }
    }
}
