
namespace Lesson05_IfStatmentForStructures
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
            this.btnAct = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.btnFor = new System.Windows.Forms.Button();
            this.lslValue = new System.Windows.Forms.ListBox();
            this.btnWhile = new System.Windows.Forms.Button();
            this.lstWhile = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAct
            // 
            this.btnAct.Location = new System.Drawing.Point(45, 273);
            this.btnAct.Name = "btnAct";
            this.btnAct.Size = new System.Drawing.Size(265, 29);
            this.btnAct.TabIndex = 0;
            this.btnAct.Text = "IF Statment";
            this.btnAct.UseVisualStyleBackColor = true;
            this.btnAct.Click += new System.EventHandler(this.btnAct_Click);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(45, 141);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(265, 27);
            this.txtValue.TabIndex = 1;
            // 
            // btnFor
            // 
            this.btnFor.Location = new System.Drawing.Point(385, 273);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(300, 29);
            this.btnFor.TabIndex = 2;
            this.btnFor.Text = "For";
            this.btnFor.UseVisualStyleBackColor = true;
            this.btnFor.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // lslValue
            // 
            this.lslValue.FormattingEnabled = true;
            this.lslValue.ItemHeight = 20;
            this.lslValue.Location = new System.Drawing.Point(385, 24);
            this.lslValue.Name = "lslValue";
            this.lslValue.Size = new System.Drawing.Size(300, 144);
            this.lslValue.TabIndex = 3;
            // 
            // btnWhile
            // 
            this.btnWhile.Location = new System.Drawing.Point(691, 273);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(300, 29);
            this.btnWhile.TabIndex = 4;
            this.btnWhile.Text = "While";
            this.btnWhile.UseVisualStyleBackColor = true;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // lstWhile
            // 
            this.lstWhile.FormattingEnabled = true;
            this.lstWhile.ItemHeight = 20;
            this.lstWhile.Location = new System.Drawing.Point(691, 24);
            this.lstWhile.Name = "lstWhile";
            this.lstWhile.Size = new System.Drawing.Size(300, 144);
            this.lstWhile.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 450);
            this.Controls.Add(this.btnWhile);
            this.Controls.Add(this.lstWhile);
            this.Controls.Add(this.lslValue);
            this.Controls.Add(this.btnFor);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.btnAct);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAct;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button btnFor;
        private System.Windows.Forms.ListBox lslValue;
        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.ListBox lstWhile;
    }
}

