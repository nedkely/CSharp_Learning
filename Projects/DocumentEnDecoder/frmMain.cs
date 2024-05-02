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

namespace DocumentEnDecoder
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Text file|*.txt|Encode file|*.enc";

                FileInfo fileInfo;

                if (openFileDialog.ShowDialog() != DialogResult.OK) return;

                this.txtPath.Text = openFileDialog.FileName.ToString();
                fileInfo = new FileInfo(this.txtPath.Text);

                this.btnEncoder.Enabled = fileInfo.Extension == ".txt" ? true : false;
                this.btnDecoder.Enabled = !(this.btnEncoder.Enabled);


                
                using (StreamReader reader = new StreamReader(fileInfo.FullName))
                {
                    string line;
                    // Read line by line
                    while ((line = reader.ReadLine()) != null)
                    {
                        this.txtFileData.Text += line;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string StringToBinary(string data)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in data.ToCharArray())
            {
                sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
            }
            return sb.ToString();
        }

        private string BinaryToString(string data)
        {
            List<Byte> byteList = new List<Byte>();

            for (int i = 0; i < data.Length; i += 8)
            {
                byteList.Add(Convert.ToByte(data.Substring(i, 8), 2));
            }
            return Encoding.ASCII.GetString(byteList.ToArray());
        }

        private string Changing_Char(string data)
        {
            string result = "";
            for (int i = 0; i < data.Length - 1; i++)
            {
                result += data.Substring(i, 1).ToString() == "0" ? "1" : "0";
            }

            return result;
        }



        private void btnEncoder_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = Changing_Char(StringToBinary(this.txtFileData.Text));
            this.btnSaveAs.Enabled = true;
            this.btnSaveAs.Tag = "encoder";
        }

        private void btnDecoder_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = BinaryToString(Changing_Char(this.txtFileData.Text));
            this.btnSaveAs.Enabled = true;
            this.btnSaveAs.Tag = "decoder";
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.btnSaveAs.Tag.ToString() == "encoder")
                {
                    string fileName = this.txtPath.Text.Substring(0, this.txtPath.Text.Length - 3) + "enc";
                    var f = File.Create(fileName);
                    using (System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(f))
                    {
                        streamWriter.Write(this.txtResult.Text);
                    }
                    f.Close();
                    File.Delete(this.txtPath.Text);
                    MessageBox.Show(this, "save success in " + this.txtPath.Text, "save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else if (this.btnSaveAs.Tag.ToString() == "decoder")
                {
                    using (System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(this.txtPath.Text))
                    {
                        streamWriter.Write(this.txtResult.Text);
                    }

                    MessageBox.Show(this, "save success in " + this.txtPath.Text, "save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtFileData_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
