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

namespace Lesson06_ErrorHandling
{
    public partial class frmErrorHandling : Form
    {
        public frmErrorHandling()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int age = Int32.Parse(textBox1.Text);
                if (age < 18)
                {
                    throw new ArithmeticException("Access denied - You must be at least 18 years old.");
                }
                else
                {
                    MessageBox.Show("Access granted - You are old enough!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                File.Open("E:\\test.txt", FileMode.Append);

            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("کاربر گرامی فایل مورد نظر یافت نشد");
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }
    }
}
