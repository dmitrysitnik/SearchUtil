namespace SearchUtil
{
    partial class Form11
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
            this.button1 = new System.Windows.Forms.Button();
            this.pathInput = new System.Windows.Forms.TextBox();
            this.Filename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CheckAllDir = new System.Windows.Forms.CheckBox();
            this.cbReadOnly = new System.Windows.Forms.CheckBox();
            this.cbHidden = new System.Windows.Forms.CheckBox();
            this.cbArchive = new System.Windows.Forms.CheckBox();
            this.CheckAttr = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FileSize = new System.Windows.Forms.TextBox();
            this.Date = new System.Windows.Forms.MonthCalendar();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 0;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pathInput
            // 
            this.pathInput.Location = new System.Drawing.Point(145, 41);
            this.pathInput.Name = "pathInput";
            this.pathInput.Size = new System.Drawing.Size(187, 20);
            this.pathInput.TabIndex = 1;
            // 
            // Filename
            // 
            this.Filename.Location = new System.Drawing.Point(145, 67);
            this.Filename.Name = "Filename";
            this.Filename.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Filename.Size = new System.Drawing.Size(100, 20);
            this.Filename.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Каталог для поиска";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Имя файла";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(649, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(92, 22);
            this.toolStripMenuItem3.Text = "111";
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(34, 389);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(549, 179);
            this.outputBox.TabIndex = 6;
            this.outputBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Вывод результатов:";
            // 
            // CheckAllDir
            // 
            this.CheckAllDir.AutoSize = true;
            this.CheckAllDir.Location = new System.Drawing.Point(145, 93);
            this.CheckAllDir.Name = "CheckAllDir";
            this.CheckAllDir.Size = new System.Drawing.Size(171, 17);
            this.CheckAllDir.TabIndex = 8;
            this.CheckAllDir.Text = "Искать во всех директориях";
            this.CheckAllDir.UseVisualStyleBackColor = true;
            // 
            // cbReadOnly
            // 
            this.cbReadOnly.AutoSize = true;
            this.cbReadOnly.Location = new System.Drawing.Point(145, 136);
            this.cbReadOnly.Name = "cbReadOnly";
            this.cbReadOnly.Size = new System.Drawing.Size(74, 17);
            this.cbReadOnly.TabIndex = 9;
            this.cbReadOnly.Text = "Read only";
            this.cbReadOnly.UseVisualStyleBackColor = true;
            // 
            // cbHidden
            // 
            this.cbHidden.AutoSize = true;
            this.cbHidden.Location = new System.Drawing.Point(239, 136);
            this.cbHidden.Name = "cbHidden";
            this.cbHidden.Size = new System.Drawing.Size(60, 17);
            this.cbHidden.TabIndex = 10;
            this.cbHidden.Text = "Hidden";
            this.cbHidden.UseVisualStyleBackColor = true;
            // 
            // cbArchive
            // 
            this.cbArchive.AutoSize = true;
            this.cbArchive.Location = new System.Drawing.Point(319, 136);
            this.cbArchive.Name = "cbArchive";
            this.cbArchive.Size = new System.Drawing.Size(62, 17);
            this.cbArchive.TabIndex = 11;
            this.cbArchive.Text = "Archive";
            this.cbArchive.UseVisualStyleBackColor = true;
            // 
            // CheckAttr
            // 
            this.CheckAttr.AutoSize = true;
            this.CheckAttr.Location = new System.Drawing.Point(145, 113);
            this.CheckAttr.Name = "CheckAttr";
            this.CheckAttr.Size = new System.Drawing.Size(131, 17);
            this.CheckAttr.TabIndex = 12;
            this.CheckAttr.Text = "Учитывать атрибуты";
            this.CheckAttr.UseVisualStyleBackColor = true;
            this.CheckAttr.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Дата изменения:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Размер файла до";
            // 
            // FileSize
            // 
            this.FileSize.Location = new System.Drawing.Point(145, 159);
            this.FileSize.Name = "FileSize";
            this.FileSize.Size = new System.Drawing.Size(100, 20);
            this.FileSize.TabIndex = 15;
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(145, 191);
            this.Date.Name = "Date";
            this.Date.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(251, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "байт";
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 598);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.FileSize);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CheckAttr);
            this.Controls.Add(this.cbArchive);
            this.Controls.Add(this.cbHidden);
            this.Controls.Add(this.cbReadOnly);
            this.Controls.Add(this.CheckAllDir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Filename);
            this.Controls.Add(this.pathInput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form11";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox pathInput;
        private System.Windows.Forms.TextBox Filename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.RichTextBox outputBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox CheckAllDir;
        private System.Windows.Forms.CheckBox cbReadOnly;
        private System.Windows.Forms.CheckBox cbHidden;
        private System.Windows.Forms.CheckBox cbArchive;
        private System.Windows.Forms.CheckBox CheckAttr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FileSize;
        private System.Windows.Forms.MonthCalendar Date;
        private System.Windows.Forms.Label label6;
    }
}

