namespace _1._2._29
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.selectFile = new System.Windows.Forms.Button();
            this.windowOfContent = new System.Windows.Forms.RichTextBox();
            this.swap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectFile
            // 
            this.selectFile.Location = new System.Drawing.Point(13, 13);
            this.selectFile.Name = "selectFile";
            this.selectFile.Size = new System.Drawing.Size(75, 37);
            this.selectFile.TabIndex = 0;
            this.selectFile.Text = "Выбрать файл";
            this.selectFile.UseVisualStyleBackColor = true;
            this.selectFile.Click += new System.EventHandler(this.selectFile_Click);
            // 
            // windowOfContent
            // 
            this.windowOfContent.Location = new System.Drawing.Point(94, 12);
            this.windowOfContent.Name = "windowOfContent";
            this.windowOfContent.Size = new System.Drawing.Size(334, 295);
            this.windowOfContent.TabIndex = 1;
            this.windowOfContent.Text = "";
            // 
            // swap
            // 
            this.swap.Location = new System.Drawing.Point(13, 57);
            this.swap.Name = "swap";
            this.swap.Size = new System.Drawing.Size(75, 23);
            this.swap.TabIndex = 2;
            this.swap.Text = "Поменять";
            this.swap.UseVisualStyleBackColor = true;
            this.swap.Visible = false;
            this.swap.Click += new System.EventHandler(this.swap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 319);
            this.Controls.Add(this.swap);
            this.Controls.Add(this.windowOfContent);
            this.Controls.Add(this.selectFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button selectFile;
        private System.Windows.Forms.RichTextBox windowOfContent;
        private System.Windows.Forms.Button swap;
    }
}

