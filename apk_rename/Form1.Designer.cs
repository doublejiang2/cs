namespace apk_rename
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btSelectFiles = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btSelectFold = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btRun = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(340, 475);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // btSelectFiles
            // 
            this.btSelectFiles.Location = new System.Drawing.Point(12, 493);
            this.btSelectFiles.Name = "btSelectFiles";
            this.btSelectFiles.Size = new System.Drawing.Size(75, 23);
            this.btSelectFiles.TabIndex = 1;
            this.btSelectFiles.Text = "选择文件";
            this.btSelectFiles.UseVisualStyleBackColor = true;
            this.btSelectFiles.Click += new System.EventHandler(this.btSelectFiles_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(358, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(559, 21);
            this.textBox1.TabIndex = 2;
            // 
            // btSelectFold
            // 
            this.btSelectFold.Location = new System.Drawing.Point(923, 12);
            this.btSelectFold.Name = "btSelectFold";
            this.btSelectFold.Size = new System.Drawing.Size(86, 23);
            this.btSelectFold.TabIndex = 3;
            this.btSelectFold.Text = "build-tools";
            this.btSelectFold.UseVisualStyleBackColor = true;
            this.btSelectFold.Click += new System.EventHandler(this.btSelectFold_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 600;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(358, 39);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(651, 241);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // btRun
            // 
            this.btRun.Location = new System.Drawing.Point(277, 493);
            this.btRun.Name = "btRun";
            this.btRun.Size = new System.Drawing.Size(75, 23);
            this.btRun.TabIndex = 5;
            this.btRun.Text = "run";
            this.btRun.UseVisualStyleBackColor = true;
            this.btRun.Click += new System.EventHandler(this.btRun_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(358, 286);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(651, 230);
            this.richTextBox2.TabIndex = 6;
            this.richTextBox2.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 528);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.btRun);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btSelectFold);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btSelectFiles);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btSelectFiles;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btSelectFold;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btRun;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}

