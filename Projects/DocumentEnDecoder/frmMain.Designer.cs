
namespace DocumentEnDecoder
{
    partial class frmMain
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
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.txtFileData = new System.Windows.Forms.RichTextBox();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.btnDecoder = new System.Windows.Forms.Button();
            this.btnEncoder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(583, 12);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(94, 29);
            this.btnLoadFile.TabIndex = 0;
            this.btnLoadFile.Text = "Open";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(12, 14);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(565, 27);
            this.txtPath.TabIndex = 1;
            // 
            // txtFileData
            // 
            this.txtFileData.Location = new System.Drawing.Point(12, 47);
            this.txtFileData.Name = "txtFileData";
            this.txtFileData.Size = new System.Drawing.Size(865, 207);
            this.txtFileData.TabIndex = 2;
            this.txtFileData.Text = "";
            this.txtFileData.TextChanged += new System.EventHandler(this.txtFileData_TextChanged);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(12, 295);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(865, 310);
            this.txtResult.TabIndex = 3;
            this.txtResult.Text = "";
            // 
            // btnDecoder
            // 
            this.btnDecoder.Enabled = false;
            this.btnDecoder.Location = new System.Drawing.Point(783, 260);
            this.btnDecoder.Name = "btnDecoder";
            this.btnDecoder.Size = new System.Drawing.Size(94, 29);
            this.btnDecoder.TabIndex = 4;
            this.btnDecoder.Text = "Decoder";
            this.btnDecoder.UseVisualStyleBackColor = true;
            this.btnDecoder.Click += new System.EventHandler(this.btnDecoder_Click);
            // 
            // btnEncoder
            // 
            this.btnEncoder.Enabled = false;
            this.btnEncoder.Location = new System.Drawing.Point(683, 260);
            this.btnEncoder.Name = "btnEncoder";
            this.btnEncoder.Size = new System.Drawing.Size(94, 29);
            this.btnEncoder.TabIndex = 5;
            this.btnEncoder.Text = "Encoder";
            this.btnEncoder.UseVisualStyleBackColor = true;
            this.btnEncoder.Click += new System.EventHandler(this.btnEncoder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(12, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "http://www.youtube.com/@Nedkely/";
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Enabled = false;
            this.btnSaveAs.Location = new System.Drawing.Point(683, 12);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(194, 29);
            this.btnSaveAs.TabIndex = 8;
            this.btnSaveAs.Text = "Save Change";
            this.btnSaveAs.UseVisualStyleBackColor = true;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 617);
            this.Controls.Add(this.btnSaveAs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEncoder);
            this.Controls.Add(this.btnDecoder);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtFileData);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnLoadFile);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encoder - Decoder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.RichTextBox txtFileData;
        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.Button btnDecoder;
        private System.Windows.Forms.Button btnEncoder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveAs;
    }
}

