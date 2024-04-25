using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson01_MessageBox
{
    public partial class frmMessageBox : Form
    {
        public frmMessageBox()
        {
            InitializeComponent();
        }

        private void btnMessageBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("this is a test off message box function or class");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(this, "are you sure you want to exit ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            MessageBoxIcon messageBoxIcon = MessageBoxIcon.Warning;

            if (rbtError.Checked)
            {
                messageBoxIcon = MessageBoxIcon.Error;
            }
            else if (rbtInformation.Checked)
            {
                messageBoxIcon = MessageBoxIcon.Information;
            }
            else if (rbtQuestion.Checked)
            {
                messageBoxIcon = MessageBoxIcon.Question;
            }
            else if (rbtWarning.Checked)
            {
                messageBoxIcon = MessageBoxIcon.Warning;
            }


            MessageBox.Show(this, txtText.Text, txtCaption.Text, MessageBoxButtons.OK, messageBoxIcon);
        }

        private void btnTestMessage_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "آیا مایل به ذخیره اطلاعات می باشید؟", "ذخیره", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                btnTestMessage.Text = "DialogResult.Cancel";
            }
            else
            {
                btnTestMessage.Text = "DialogResult.Ok";
            }
        }
    }
}
