namespace _1._3._14
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
            this.show = new System.Windows.Forms.Button();
            this.studentsGrid = new System.Windows.Forms.DataGridView();
            this.fio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.chooseFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(12, 53);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(75, 23);
            this.show.TabIndex = 0;
            this.show.Text = "Show";
            this.show.UseVisualStyleBackColor = true;
            this.show.Visible = false;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // studentsGrid
            // 
            this.studentsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fio,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.studentsGrid.Location = new System.Drawing.Point(106, 12);
            this.studentsGrid.Name = "studentsGrid";
            this.studentsGrid.Size = new System.Drawing.Size(662, 350);
            this.studentsGrid.TabIndex = 1;
            // 
            // fio
            // 
            this.fio.HeaderText = "ФИО";
            this.fio.Name = "fio";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Дата рождения";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Оценки";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Курс";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "группа";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Средняя оценка";
            this.Column5.Name = "Column5";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 127);
            this.label1.TabIndex = 2;
            this.label1.Text = "Показать студентов каждого курса с наименьшим средним баллом";
            this.label1.Visible = false;
            // 
            // chooseFile
            // 
            this.chooseFile.Location = new System.Drawing.Point(13, 12);
            this.chooseFile.Name = "chooseFile";
            this.chooseFile.Size = new System.Drawing.Size(75, 35);
            this.chooseFile.TabIndex = 3;
            this.chooseFile.Text = "Выбрать файл";
            this.chooseFile.UseVisualStyleBackColor = true;
            this.chooseFile.Click += new System.EventHandler(this.chooseFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 374);
            this.Controls.Add(this.chooseFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentsGrid);
            this.Controls.Add(this.show);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.studentsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button show;
        private System.Windows.Forms.DataGridView studentsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn fio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button chooseFile;
    }
}

