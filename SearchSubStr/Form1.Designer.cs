﻿namespace SearchSubStr
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
            this.Path = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchString = new System.Windows.Forms.TextBox();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Path
            // 
            this.Path.Location = new System.Drawing.Point(105, 42);
            this.Path.Name = "Path";
            this.Path.Size = new System.Drawing.Size(156, 20);
            this.Path.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Путь";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Искомая строка";
            // 
            // SearchString
            // 
            this.SearchString.Location = new System.Drawing.Point(105, 88);
            this.SearchString.Name = "SearchString";
            this.SearchString.Size = new System.Drawing.Size(156, 20);
            this.SearchString.TabIndex = 4;
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(40, 145);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(332, 125);
            this.outputBox.TabIndex = 5;
            this.outputBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Результаты:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 316);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.SearchString);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Path);
            this.Name = "Form1";
            this.Text = "Search Sub String";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Path;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SearchString;
        private System.Windows.Forms.RichTextBox outputBox;
        private System.Windows.Forms.Label label3;
    }
}