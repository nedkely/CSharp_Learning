
namespace Lesson02_OpenSaveDialog
{
    partial class frmOpenSaveFileDialog
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
            this.ofdOpen = new System.Windows.Forms.OpenFileDialog();
            this.sfdOpen = new System.Windows.Forms.SaveFileDialog();
            this.btnOpenFileDialog = new System.Windows.Forms.Button();
            this.btnSaveFileDialog = new System.Windows.Forms.Button();
            this.txtText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ofdOpen
            // 
            this.ofdOpen.DefaultExt = "*.txt";
            this.ofdOpen.Title = "Lesson 02 - Open File Dialog";
            // 
            // sfdOpen
            // 
            this.sfdOpen.DefaultExt = "*.txt";
            this.sfdOpen.Title = "Lesson 02 - Save File Dialog";
            // 
            // btnOpenFileDialog
            // 
            this.btnOpenFileDialog.Location = new System.Drawing.Point(71, 409);
            this.btnOpenFileDialog.Name = "btnOpenFileDialog";
            this.btnOpenFileDialog.Size = new System.Drawing.Size(198, 29);
            this.btnOpenFileDialog.TabIndex = 0;
            this.btnOpenFileDialog.Text = "Open File Dialog";
            this.btnOpenFileDialog.UseVisualStyleBackColor = true;
            this.btnOpenFileDialog.Click += new System.EventHandler(this.btnOpenFileDialog_Click);
            // 
            // btnSaveFileDialog
            // 
            this.btnSaveFileDialog.Location = new System.Drawing.Point(275, 409);
            this.btnSaveFileDialog.Name = "btnSaveFileDialog";
            this.btnSaveFileDialog.Size = new System.Drawing.Size(198, 29);
            this.btnSaveFileDialog.TabIndex = 0;
            this.btnSaveFileDialog.Text = "Save As";
            this.btnSaveFileDialog.UseVisualStyleBackColor = true;
            this.btnSaveFileDialog.Click += new System.EventHandler(this.btnSaveFileDialog_Click);
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(71, 12);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(717, 391);
            this.txtText.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.btnSaveFileDialog);
            this.Controls.Add(this.btnOpenFileDialog);
            this.Name = "Form1";
            this.Text = "Lesson 02 - Open Save File Dialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdOpen;
        private System.Windows.Forms.SaveFileDialog sfdOpen;
        private System.Windows.Forms.Button btnOpenFileDialog;
        private System.Windows.Forms.Button btnSaveFileDialog;
        private System.Windows.Forms.TextBox txtText;
    }
}

