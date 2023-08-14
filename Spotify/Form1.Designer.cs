namespace Spotify
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Connection = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.Execution = new System.Windows.Forms.Button();
            this.UploadFiles = new System.Windows.Forms.Button();
            this.SelectAll = new System.Windows.Forms.Button();
            this.DeleteAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Connection
            // 
            this.Connection.Location = new System.Drawing.Point(587, 173);
            this.Connection.Name = "Connection";
            this.Connection.Size = new System.Drawing.Size(75, 23);
            this.Connection.TabIndex = 0;
            this.Connection.Text = "Connection";
            this.Connection.UseVisualStyleBackColor = true;
            this.Connection.Click += new System.EventHandler(this.Connection_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(26, 90);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(379, 349);
            this.checkedListBox1.TabIndex = 1;
            // 
            // Execution
            // 
            this.Execution.Location = new System.Drawing.Point(587, 111);
            this.Execution.Name = "Execution";
            this.Execution.Size = new System.Drawing.Size(75, 23);
            this.Execution.TabIndex = 2;
            this.Execution.Text = "Execute";
            this.Execution.UseVisualStyleBackColor = true;
            this.Execution.Click += new System.EventHandler(this.Execution_Click);
            // 
            // UploadFiles
            // 
            this.UploadFiles.Location = new System.Drawing.Point(587, 82);
            this.UploadFiles.Name = "UploadFiles";
            this.UploadFiles.Size = new System.Drawing.Size(75, 23);
            this.UploadFiles.TabIndex = 4;
            this.UploadFiles.Text = "Upload Files";
            this.UploadFiles.UseVisualStyleBackColor = true;
            this.UploadFiles.Click += new System.EventHandler(this.UploadFiles_Click);
            // 
            // SelectAll
            // 
            this.SelectAll.Location = new System.Drawing.Point(26, 50);
            this.SelectAll.Name = "SelectAll";
            this.SelectAll.Size = new System.Drawing.Size(75, 23);
            this.SelectAll.TabIndex = 5;
            this.SelectAll.Text = "Select All";
            this.SelectAll.UseVisualStyleBackColor = true;
            this.SelectAll.Click += new System.EventHandler(this.SelectAll_Click);
            // 
            // DeleteAll
            // 
            this.DeleteAll.Location = new System.Drawing.Point(133, 49);
            this.DeleteAll.Name = "DeleteAll";
            this.DeleteAll.Size = new System.Drawing.Size(75, 23);
            this.DeleteAll.TabIndex = 6;
            this.DeleteAll.Text = "Delete All";
            this.DeleteAll.UseVisualStyleBackColor = true;
            this.DeleteAll.Click += new System.EventHandler(this.DeleteAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteAll);
            this.Controls.Add(this.SelectAll);
            this.Controls.Add(this.UploadFiles);
            this.Controls.Add(this.Execution);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.Connection);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Connection;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button Execution;
        private System.Windows.Forms.Button UploadFiles;
        private System.Windows.Forms.Button SelectAll;
        private System.Windows.Forms.Button DeleteAll;
    }
}

