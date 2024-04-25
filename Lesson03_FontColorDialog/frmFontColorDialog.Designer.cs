
namespace Lesson03_FontColorDialog
{
    partial class frmFontColorDialog
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cdMainColor = new System.Windows.Forms.ColorDialog();
            this.btnColor = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.lblShowResult = new System.Windows.Forms.Label();
            this.btnFont = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnFolderBrowseDialog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(47, 386);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(150, 29);
            this.btnColor.TabIndex = 0;
            this.btnColor.Text = "BackColor";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // lblShowResult
            // 
            this.lblShowResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblShowResult.Location = new System.Drawing.Point(0, 0);
            this.lblShowResult.Name = "lblShowResult";
            this.lblShowResult.Size = new System.Drawing.Size(800, 210);
            this.lblShowResult.TabIndex = 1;
            this.lblShowResult.Text = "this is dialog result";
            this.lblShowResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(47, 351);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(150, 29);
            this.btnFont.TabIndex = 2;
            this.btnFont.Text = "Font";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // btnFolderBrowseDialog
            // 
            this.btnFolderBrowseDialog.Location = new System.Drawing.Point(221, 386);
            this.btnFolderBrowseDialog.Name = "btnFolderBrowseDialog";
            this.btnFolderBrowseDialog.Size = new System.Drawing.Size(321, 29);
            this.btnFolderBrowseDialog.TabIndex = 3;
            this.btnFolderBrowseDialog.Text = "Folder Browse Dialog";
            this.btnFolderBrowseDialog.UseVisualStyleBackColor = true;
            this.btnFolderBrowseDialog.Click += new System.EventHandler(this.btnFolderBrowseDialog_Click);
            // 
            // frmFontColorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFolderBrowseDialog);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.lblShowResult);
            this.Controls.Add(this.btnColor);
            this.Name = "frmFontColorDialog";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog cdMainColor;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label lblShowResult;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnFolderBrowseDialog;
    }
}

