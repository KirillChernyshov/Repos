namespace _2._1._29
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
            this.chessBoard = new System.Windows.Forms.DataGridView();
            this.start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chessBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // chessBoard
            // 
            this.chessBoard.AllowUserToAddRows = false;
            this.chessBoard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.chessBoard.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.chessBoard.ColumnHeadersHeight = 20;
            this.chessBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.chessBoard.ColumnHeadersVisible = false;
            this.chessBoard.Location = new System.Drawing.Point(110, 12);
            this.chessBoard.Name = "chessBoard";
            this.chessBoard.RowHeadersVisible = false;
            this.chessBoard.RowHeadersWidth = 20;
            this.chessBoard.Size = new System.Drawing.Size(180, 180);
            this.chessBoard.TabIndex = 0;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(13, 13);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 1;
            this.start.Text = "start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 340);
            this.Controls.Add(this.start);
            this.Controls.Add(this.chessBoard);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chessBoard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView chessBoard;
        private System.Windows.Forms.Button start;
    }
}

