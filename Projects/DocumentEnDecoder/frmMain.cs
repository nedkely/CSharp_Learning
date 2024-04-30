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

        Mode_State mode = new Mode_State();
        private enum Mode_State
        {
            save,
            encoder,
            decoder
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Text file|*.txt|Encode file|*.enc";

                FileInfo fileInfo;

                if (openFileDialog.ShowDialog() != DialogResult.OK) return;
                mode = Mode_State.save;

                this.txtPath.Text = openFileDialog.FileName.ToString();
                fileInfo = new FileInfo(this.txtPath.Text);

                this.btnEncoder.Enabled = fileInfo.Extension == ".txt" ? true : false;
                this.btnDecoder.Enabled = !(this.btnEncoder.Enabled);


                using (System.IO.StreamReader streamReader = new System.IO.StreamReader(this.txtPath.Text))
                {
                    this.txtFileData.Text = streamReader.ReadToEnd();
                }
                textChangeMode = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(this.txtPath.Text))
                {
                    streamWriter.Write(this.txtResult.Text);
                }

                MessageBox.Show(this, "save success", "save", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.btnSave.Enabled = this.btnSaveAs.Enabled = false;
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
            mode = Mode_State.encoder;
            this.btnSave.Enabled = false;
            this.btnSaveAs.Enabled = true;
        }

        private void btnDecoder_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = BinaryToString(this.txtFileData.Text);
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            try
            {
                if (mode == Mode_State.save)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.DefaultExt = "txt";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(saveFileDialog.FileName))
                        {
                            streamWriter.Write(this.txtResult.Text);
                        }

                        this.txtPath.Text = saveFileDialog.FileName.ToString();
                        MessageBox.Show(this, "save success in " + saveFileDialog.FileName.ToString(), "save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.btnSave.Enabled = this.btnSaveAs.Enabled = false;
                    }
                }
                else if (mode == Mode_State.encoder)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.DefaultExt = "enc";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(saveFileDialog.FileName))
                        {
                            streamWriter.Write(this.txtResult.Text);
                        }

                        MessageBox.Show(this, "save success in " + saveFileDialog.FileName.ToString(), "save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    this.btnSave.Enabled = this.btnSaveAs.Enabled = this.btnEncoder.Enabled = this.btnDecoder.Enabled = false;
                    this.btnLoadFile.Enabled = true;
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        bool textChangeMode = false;
        private void txtFileData_TextChanged(object sender, EventArgs e)
        {
            if (textChangeMode)
            {
                this.btnSave.Enabled = this.btnSaveAs.Enabled = true;
            }
        }
    }
}
