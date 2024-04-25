
namespace lesson01_MessageBox
{
    partial class Form1
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
            this.btnMessageBox = new System.Windows.Forms.Button();
            this.btnTestMessage = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.rbtWarning = new System.Windows.Forms.RadioButton();
            this.txtCaption = new System.Windows.Forms.TextBox();
            this.txtText = new System.Windows.Forms.TextBox();
            this.rbtError = new System.Windows.Forms.RadioButton();
            this.rbtInformation = new System.Windows.Forms.RadioButton();
            this.rbtQuestion = new System.Windows.Forms.RadioButton();
            this.btnResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMessageBox
            // 
            this.btnMessageBox.Location = new System.Drawing.Point(39, 203);
            this.btnMessageBox.Name = "btnMessageBox";
            this.btnMessageBox.Size = new System.Drawing.Size(156, 40);
            this.btnMessageBox.TabIndex = 0;
            this.btnMessageBox.Text = "MessageBox";
            this.btnMessageBox.UseVisualStyleBackColor = true;
            this.btnMessageBox.Click += new System.EventHandler(this.btnMessageBox_Click);
            // 
            // btnTestMessage
            // 
            this.btnTestMessage.Location = new System.Drawing.Point(244, 398);
            this.btnTestMessage.Name = "btnTestMessage";
            this.btnTestMessage.Size = new System.Drawing.Size(156, 40);
            this.btnTestMessage.TabIndex = 1;
            this.btnTestMessage.Text = "Result";
            this.btnTestMessage.UseVisualStyleBackColor = true;
            this.btnTestMessage.Click += new System.EventHandler(this.btnTestMessage_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 398);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(156, 40);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rbtWarning
            // 
            this.rbtWarning.AutoSize = true;
            this.rbtWarning.Checked = true;
            this.rbtWarning.Location = new System.Drawing.Point(482, 186);
            this.rbtWarning.Name = "rbtWarning";
            this.rbtWarning.Size = new System.Drawing.Size(85, 24);
            this.rbtWarning.TabIndex = 2;
            this.rbtWarning.TabStop = true;
            this.rbtWarning.Text = "Warning";
            this.rbtWarning.UseVisualStyleBackColor = true;
            // 
            // txtCaption
            // 
            this.txtCaption.Location = new System.Drawing.Point(639, 186);
            this.txtCaption.Name = "txtCaption";
            this.txtCaption.Size = new System.Drawing.Size(125, 27);
            this.txtCaption.TabIndex = 3;
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(639, 219);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(326, 112);
            this.txtText.TabIndex = 3;
            // 
            // rbtError
            // 
            this.rbtError.AutoSize = true;
            this.rbtError.Location = new System.Drawing.Point(482, 220);
            this.rbtError.Name = "rbtError";
            this.rbtError.Size = new System.Drawing.Size(62, 24);
            this.rbtError.TabIndex = 2;
            this.rbtError.Text = "Error";
            this.rbtError.UseVisualStyleBackColor = true;
            // 
            // rbtInformation
            // 
            this.rbtInformation.AutoSize = true;
            this.rbtInformation.Location = new System.Drawing.Point(482, 253);
            this.rbtInformation.Name = "rbtInformation";
            this.rbtInformation.Size = new System.Drawing.Size(108, 24);
            this.rbtInformation.TabIndex = 2;
            this.rbtInformation.Text = "Information";
            this.rbtInformation.UseVisualStyleBackColor = true;
            // 
            // rbtQuestion
            // 
            this.rbtQuestion.AutoSize = true;
            this.rbtQuestion.Location = new System.Drawing.Point(482, 287);
            this.rbtQuestion.Name = "rbtQuestion";
            this.rbtQuestion.Size = new System.Drawing.Size(89, 24);
            this.rbtQuestion.TabIndex = 2;
            this.rbtQuestion.Text = "Question";
            this.rbtQuestion.UseVisualStyleBackColor = true;
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(639, 359);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(156, 40);
            this.btnResult.TabIndex = 1;
            this.btnResult.Text = "Show Message";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 460);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.txtCaption);
            this.Controls.Add(this.rbtQuestion);
            this.Controls.Add(this.rbtError);
            this.Controls.Add(this.rbtInformation);
            this.Controls.Add(this.rbtWarning);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btnTestMessage);
            this.Controls.Add(this.btnMessageBox);
            this.Name = "Form1";
            this.Text = "MessageBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMessageBox;
        private System.Windows.Forms.Button btnTestMessage;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton rbtWarning;
        private System.Windows.Forms.TextBox txtCaption;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.RadioButton rbtError;
        private System.Windows.Forms.RadioButton rbtInformation;
        private System.Windows.Forms.RadioButton rbtQuestion;
        private System.Windows.Forms.Button btnResult;
    }
}

