namespace _4._1._27
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.test = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.districtP = new System.Windows.Forms.NumericUpDown();
            this.district = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.floorP = new System.Windows.Forms.NumericUpDown();
            this.floor = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.roomsP = new System.Windows.Forms.NumericUpDown();
            this.rooms = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.areaP = new System.Windows.Forms.NumericUpDown();
            this.area = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.priceP = new System.Windows.Forms.NumericUpDown();
            this.price = new System.Windows.Forms.ComboBox();
            this.search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.districtP)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.floorP)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsP)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.areaP)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceP)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.test,
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(290, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 294);
            this.dataGridView1.TabIndex = 2;
            // 
            // test
            // 
            this.test.Frozen = true;
            this.test.HeaderText = "Критерий";
            this.test.Name = "test";
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Значение";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Приоритет";
            this.Column2.Name = "Column2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.districtP);
            this.groupBox1.Controls.Add(this.district);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 54);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Район";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // districtP
            // 
            this.districtP.Location = new System.Drawing.Point(134, 19);
            this.districtP.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.districtP.Name = "districtP";
            this.districtP.Size = new System.Drawing.Size(120, 20);
            this.districtP.TabIndex = 1;
            this.districtP.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // district
            // 
            this.district.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.district.FormattingEnabled = true;
            this.district.Items.AddRange(new object[] {
            "Северный",
            "Южный",
            "Восточный",
            "Западный"});
            this.district.Location = new System.Drawing.Point(6, 19);
            this.district.Name = "district";
            this.district.Size = new System.Drawing.Size(121, 21);
            this.district.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.floorP);
            this.groupBox2.Controls.Add(this.floor);
            this.groupBox2.Location = new System.Drawing.Point(12, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 54);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Этаж";
            // 
            // floorP
            // 
            this.floorP.Location = new System.Drawing.Point(134, 19);
            this.floorP.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.floorP.Name = "floorP";
            this.floorP.Size = new System.Drawing.Size(120, 20);
            this.floorP.TabIndex = 1;
            this.floorP.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // floor
            // 
            this.floor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.floor.FormattingEnabled = true;
            this.floor.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.floor.Location = new System.Drawing.Point(6, 19);
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(121, 21);
            this.floor.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.roomsP);
            this.groupBox3.Controls.Add(this.rooms);
            this.groupBox3.Location = new System.Drawing.Point(12, 132);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(272, 54);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Количество комнат";
            // 
            // roomsP
            // 
            this.roomsP.Location = new System.Drawing.Point(134, 19);
            this.roomsP.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.roomsP.Name = "roomsP";
            this.roomsP.Size = new System.Drawing.Size(120, 20);
            this.roomsP.TabIndex = 1;
            this.roomsP.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rooms
            // 
            this.rooms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rooms.FormattingEnabled = true;
            this.rooms.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.rooms.Location = new System.Drawing.Point(6, 19);
            this.rooms.Name = "rooms";
            this.rooms.Size = new System.Drawing.Size(121, 21);
            this.rooms.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.areaP);
            this.groupBox4.Controls.Add(this.area);
            this.groupBox4.Location = new System.Drawing.Point(12, 192);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(272, 54);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "общая площадь";
            // 
            // areaP
            // 
            this.areaP.Location = new System.Drawing.Point(134, 19);
            this.areaP.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.areaP.Name = "areaP";
            this.areaP.Size = new System.Drawing.Size(120, 20);
            this.areaP.TabIndex = 1;
            this.areaP.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // area
            // 
            this.area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.area.FormattingEnabled = true;
            this.area.Items.AddRange(new object[] {
            "36",
            "42",
            "54",
            "62",
            "68",
            "82"});
            this.area.Location = new System.Drawing.Point(6, 19);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(121, 21);
            this.area.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.priceP);
            this.groupBox5.Controls.Add(this.price);
            this.groupBox5.Location = new System.Drawing.Point(12, 252);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(272, 54);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "цена за 1 м^2";
            // 
            // priceP
            // 
            this.priceP.Location = new System.Drawing.Point(134, 19);
            this.priceP.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.priceP.Name = "priceP";
            this.priceP.Size = new System.Drawing.Size(120, 20);
            this.priceP.TabIndex = 1;
            this.priceP.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // price
            // 
            this.price.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.price.FormattingEnabled = true;
            this.price.Items.AddRange(new object[] {
            "38900",
            "39000",
            "37000"});
            this.price.Location = new System.Drawing.Point(6, 19);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(121, 21);
            this.price.TabIndex = 0;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(208, 313);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 9;
            this.search.Text = "Искать";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 346);
            this.Controls.Add(this.search);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.districtP)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.floorP)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roomsP)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.areaP)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.priceP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox district;
        private System.Windows.Forms.NumericUpDown districtP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown floorP;
        private System.Windows.Forms.ComboBox floor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown roomsP;
        private System.Windows.Forms.ComboBox rooms;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown areaP;
        private System.Windows.Forms.ComboBox area;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown priceP;
        private System.Windows.Forms.ComboBox price;
        private System.Windows.Forms.DataGridViewTextBoxColumn test;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button search;
    }
}

