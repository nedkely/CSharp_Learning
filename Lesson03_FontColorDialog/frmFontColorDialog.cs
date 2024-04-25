using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson03_FontColorDialog
{
    public partial class frmFontColorDialog : Form
    {
        public frmFontColorDialog()
        {
            InitializeComponent();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (cdMainColor.ShowDialog() == DialogResult.OK)
            {
                this.lblShowResult.BackColor = cdMainColor.Color;
            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            if (this.fontDialog1.ShowDialog() == DialogResult.OK)
            {
                this.lblShowResult.Font = this.fontDialog1.Font;
            }
        }

        private void btnFolderBrowseDialog_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.lblShowResult.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
