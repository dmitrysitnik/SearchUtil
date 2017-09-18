namespace WordAttributes
{
    partial class FormWord
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
            this.label1 = new System.Windows.Forms.Label();
            this.Path = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CompanyName = new System.Windows.Forms.TextBox();
            this.Manager = new System.Windows.Forms.TextBox();
            this.Characters = new System.Windows.Forms.TextBox();
            this.Lines = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Template = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Путь к каталогу";
            // 
            // Path
            // 
            this.Path.Location = new System.Drawing.Point(141, 53);
            this.Path.Name = "Path";
            this.Path.Size = new System.Drawing.Size(202, 20);
            this.Path.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Компания";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Руководитель";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Количество символов менее";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Количество строк менее";
            // 
            // CompanyName
            // 
            this.CompanyName.Location = new System.Drawing.Point(141, 88);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Size = new System.Drawing.Size(202, 20);
            this.CompanyName.TabIndex = 6;
            // 
            // Manager
            // 
            this.Manager.Location = new System.Drawing.Point(141, 117);
            this.Manager.Name = "Manager";
            this.Manager.Size = new System.Drawing.Size(202, 20);
            this.Manager.TabIndex = 7;
            // 
            // Characters
            // 
            this.Characters.Location = new System.Drawing.Point(196, 145);
            this.Characters.Name = "Characters";
            this.Characters.Size = new System.Drawing.Size(147, 20);
            this.Characters.TabIndex = 8;
            // 
            // Lines
            // 
            this.Lines.Location = new System.Drawing.Point(176, 173);
            this.Lines.Name = "Lines";
            this.Lines.Size = new System.Drawing.Size(167, 20);
            this.Lines.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 27);
            this.button1.TabIndex = 10;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(12, 301);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(372, 192);
            this.outputBox.TabIndex = 11;
            this.outputBox.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Результаты:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Имя шаблона";
            // 
            // Template
            // 
            this.Template.Location = new System.Drawing.Point(176, 202);
            this.Template.Name = "Template";
            this.Template.Size = new System.Drawing.Size(167, 20);
            this.Template.TabIndex = 14;
            // 
            // FormWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 515);
            this.Controls.Add(this.Template);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Lines);
            this.Controls.Add(this.Characters);
            this.Controls.Add(this.Manager);
            this.Controls.Add(this.CompanyName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Path);
            this.Controls.Add(this.label1);
            this.Name = "FormWord";
            this.Text = "FormWord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Path;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CompanyName;
        private System.Windows.Forms.TextBox Manager;
        private System.Windows.Forms.TextBox Characters;
        private System.Windows.Forms.TextBox Lines;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox outputBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Template;
    }
}