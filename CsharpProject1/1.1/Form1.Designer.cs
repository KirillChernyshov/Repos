namespace _1._1
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
            this.ChooseTextFile = new System.Windows.Forms.Button();
            this.ChooseNumFile = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.AddtoEndBtn = new System.Windows.Forms.Button();
            this.AddtoSrartBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChooseTextFile
            // 
            this.ChooseTextFile.Location = new System.Drawing.Point(12, 12);
            this.ChooseTextFile.Name = "ChooseTextFile";
            this.ChooseTextFile.Size = new System.Drawing.Size(116, 36);
            this.ChooseTextFile.TabIndex = 0;
            this.ChooseTextFile.Text = "Выбрать текстовый файл";
            this.ChooseTextFile.UseVisualStyleBackColor = true;
            this.ChooseTextFile.Click += new System.EventHandler(this.ChooseTextFile_Click);
            // 
            // ChooseNumFile
            // 
            this.ChooseNumFile.Location = new System.Drawing.Point(12, 54);
            this.ChooseNumFile.Name = "ChooseNumFile";
            this.ChooseNumFile.Size = new System.Drawing.Size(116, 37);
            this.ChooseNumFile.TabIndex = 1;
            this.ChooseNumFile.Text = "Выбрать файл с числами";
            this.ChooseNumFile.UseVisualStyleBackColor = true;
            this.ChooseNumFile.Click += new System.EventHandler(this.ChooseNumFile_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(134, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(544, 346);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // AddtoEndBtn
            // 
            this.AddtoEndBtn.Location = new System.Drawing.Point(12, 137);
            this.AddtoEndBtn.Name = "AddtoEndBtn";
            this.AddtoEndBtn.Size = new System.Drawing.Size(116, 37);
            this.AddtoEndBtn.TabIndex = 3;
            this.AddtoEndBtn.Text = "Добавить числа в конец строк";
            this.AddtoEndBtn.UseVisualStyleBackColor = true;
            this.AddtoEndBtn.Visible = false;
            this.AddtoEndBtn.Click += new System.EventHandler(this.AddtoEndBtn_Click);
            // 
            // AddtoSrartBtn
            // 
            this.AddtoSrartBtn.Location = new System.Drawing.Point(13, 181);
            this.AddtoSrartBtn.Name = "AddtoSrartBtn";
            this.AddtoSrartBtn.Size = new System.Drawing.Size(115, 37);
            this.AddtoSrartBtn.TabIndex = 4;
            this.AddtoSrartBtn.Text = "Добавить числа в начало строк";
            this.AddtoSrartBtn.UseVisualStyleBackColor = true;
            this.AddtoSrartBtn.Visible = false;
            this.AddtoSrartBtn.Click += new System.EventHandler(this.AddtoSrartBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 370);
            this.Controls.Add(this.AddtoSrartBtn);
            this.Controls.Add(this.AddtoEndBtn);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.ChooseNumFile);
            this.Controls.Add(this.ChooseTextFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ChooseTextFile;
        private System.Windows.Forms.Button ChooseNumFile;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button AddtoEndBtn;
        private System.Windows.Forms.Button AddtoSrartBtn;
    }
}

