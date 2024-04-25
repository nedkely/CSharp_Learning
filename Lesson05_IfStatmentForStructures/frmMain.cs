using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson05_IfStatmentForStructures
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAct_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtValue.Text))
            {
                MessageBox.Show("textbox is null or empty");
            }
            else
            {


                var txt = this.txtValue.Text;
                if (txt == "1")
                {
                    MessageBox.Show("number is 1");
                }
                else if (txt == "2")
                {
                    MessageBox.Show("number is 2");
                }
                else if (txt == "3")
                {
                    MessageBox.Show("number is 3");
                }
                else
                {
                    MessageBox.Show("number is something else");
                }



            }







            switch (this.txtValue.Text)
            {
                case "hamed":
                    MessageBox.Show("value is hamed");
                    break;
                case "hamid":
                    MessageBox.Show("value is hamid");
                    break;
                case "farhad":
                    MessageBox.Show("value is farhad");
                    break;
                default:
                    break;
            }
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                this.lslValue.Items.Add("item number = " + i.ToString());
            }
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            while (this.lslValue.Items.Count > 0)
            {
                this.lstWhile.Items.Add(this.lslValue.Items[0].ToString());
                this.lslValue.Items.RemoveAt(0);
            }
        }
    }
}
