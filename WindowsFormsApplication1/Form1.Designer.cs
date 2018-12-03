namespace WindowsFormsApplication1
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
            this.bhCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.kqListBox = new System.Windows.Forms.ListBox();
            this.chandoanbutton = new System.Windows.Forms.Button();
            this.suaTextBox = new System.Windows.Forms.RichTextBox();
            this.suabutton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liênHệToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.knListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bhCheckedListBox
            // 
            this.bhCheckedListBox.CheckOnClick = true;
            this.bhCheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bhCheckedListBox.FormattingEnabled = true;
            this.bhCheckedListBox.HorizontalScrollbar = true;
            this.bhCheckedListBox.IntegralHeight = false;
            this.bhCheckedListBox.Location = new System.Drawing.Point(22, 92);
            this.bhCheckedListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bhCheckedListBox.Name = "bhCheckedListBox";
            this.bhCheckedListBox.ScrollAlwaysVisible = true;
            this.bhCheckedListBox.Size = new System.Drawing.Size(425, 474);
            this.bhCheckedListBox.TabIndex = 1;
            // 
            // kqListBox
            // 
            this.kqListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kqListBox.FormattingEnabled = true;
            this.kqListBox.ItemHeight = 17;
            this.kqListBox.Location = new System.Drawing.Point(588, 92);
            this.kqListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kqListBox.Name = "kqListBox";
            this.kqListBox.Size = new System.Drawing.Size(368, 242);
            this.kqListBox.TabIndex = 1;
            // 
            // chandoanbutton
            // 
            this.chandoanbutton.Location = new System.Drawing.Point(467, 115);
            this.chandoanbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chandoanbutton.Name = "chandoanbutton";
            this.chandoanbutton.Size = new System.Drawing.Size(100, 84);
            this.chandoanbutton.TabIndex = 2;
            this.chandoanbutton.Text = "Chẩn đoán";
            this.chandoanbutton.UseVisualStyleBackColor = true;
            this.chandoanbutton.Click += new System.EventHandler(this.chandoanbutton_Click);
            // 
            // suaTextBox
            // 
            this.suaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suaTextBox.Location = new System.Drawing.Point(489, 415);
            this.suaTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.suaTextBox.Name = "suaTextBox";
            this.suaTextBox.ReadOnly = true;
            this.suaTextBox.Size = new System.Drawing.Size(538, 150);
            this.suaTextBox.TabIndex = 3;
            this.suaTextBox.Text = "";
            // 
            // suabutton
            // 
            this.suabutton.Location = new System.Drawing.Point(657, 358);
            this.suabutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.suabutton.Name = "suabutton";
            this.suabutton.Size = new System.Drawing.Size(170, 32);
            this.suabutton.TabIndex = 4;
            this.suabutton.Text = "Cách sủa chữa";
            this.suabutton.UseVisualStyleBackColor = true;
            this.suabutton.Click += new System.EventHandler(this.suabutton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.thôngTinToolStripMenuItem,
            this.hướngDẫnToolStripMenuItem,
            this.liênHệToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1078, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.thôngTinToolStripMenuItem.Text = "Thông Tin";
            this.thôngTinToolStripMenuItem.Click += new System.EventHandler(this.thôngTinToolStripMenuItem_Click);
            // 
            // hướngDẫnToolStripMenuItem
            // 
            this.hướngDẫnToolStripMenuItem.Name = "hướngDẫnToolStripMenuItem";
            this.hướngDẫnToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.hướngDẫnToolStripMenuItem.Text = "Hướng Dẫn";
            this.hướngDẫnToolStripMenuItem.Click += new System.EventHandler(this.hướngDẫnToolStripMenuItem_Click);
            // 
            // liênHệToolStripMenuItem
            // 
            this.liênHệToolStripMenuItem.Name = "liênHệToolStripMenuItem";
            this.liênHệToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.liênHệToolStripMenuItem.Text = "Liên Hệ";
            this.liênHệToolStripMenuItem.Click += new System.EventHandler(this.liênHệToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Biểu hiện";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(586, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kết quả";
            // 
            // knListBox
            // 
            this.knListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knListBox.FormattingEnabled = true;
            this.knListBox.ItemHeight = 17;
            this.knListBox.Location = new System.Drawing.Point(960, 92);
            this.knListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.knListBox.Name = "knListBox";
            this.knListBox.Size = new System.Drawing.Size(101, 242);
            this.knListBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(958, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Khả năng(%)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 584);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.knListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.suabutton);
            this.Controls.Add(this.suaTextBox);
            this.Controls.Add(this.chandoanbutton);
            this.Controls.Add(this.kqListBox);
            this.Controls.Add(this.bhCheckedListBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Chẩn đoán hư hỏng máy tính";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox bhCheckedListBox;
        private System.Windows.Forms.ListBox kqListBox;
        private System.Windows.Forms.Button chandoanbutton;
        private System.Windows.Forms.RichTextBox suaTextBox;
        private System.Windows.Forms.Button suabutton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liênHệToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ListBox knListBox;
        private System.Windows.Forms.Label label3;





    }
}

