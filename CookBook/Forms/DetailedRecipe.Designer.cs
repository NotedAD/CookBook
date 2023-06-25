namespace CookBook.Forms
{
    partial class DetailedRecipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailedRecipe));
            this.pb_img = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_dishType = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_description = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbb_devices = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbb_ingred = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.edt_unitCalc = new System.Windows.Forms.TextBox();
            this.btn_addDev = new System.Windows.Forms.Button();
            this.btn_addIngrid = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Devices = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Ingred = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_delIngr = new System.Windows.Forms.Button();
            this.btn_delDev = new System.Windows.Forms.Button();
            this.lbl_unit = new System.Windows.Forms.Label();
            this.btn_Word = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_img
            // 
            this.pb_img.Location = new System.Drawing.Point(12, 12);
            this.pb_img.Name = "pb_img";
            this.pb_img.Size = new System.Drawing.Size(138, 136);
            this.pb_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_img.TabIndex = 0;
            this.pb_img.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название блюда";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(157, 33);
            this.lbl_name.MaximumSize = new System.Drawing.Size(250, 20);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(92, 13);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "Название блюда";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Тип блюда";
            // 
            // lbl_dishType
            // 
            this.lbl_dishType.AutoSize = true;
            this.lbl_dishType.Location = new System.Drawing.Point(157, 77);
            this.lbl_dishType.MaximumSize = new System.Drawing.Size(250, 20);
            this.lbl_dishType.Name = "lbl_dishType";
            this.lbl_dishType.Size = new System.Drawing.Size(61, 13);
            this.lbl_dishType.TabIndex = 4;
            this.lbl_dishType.Text = "Тип блюда\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Описание";
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Location = new System.Drawing.Point(12, 182);
            this.lbl_description.MaximumSize = new System.Drawing.Size(380, 90);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(57, 13);
            this.lbl_description.TabIndex = 6;
            this.lbl_description.Text = "Описание";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Добавить приборы";
            // 
            // cbb_devices
            // 
            this.cbb_devices.FormattingEnabled = true;
            this.cbb_devices.Location = new System.Drawing.Point(12, 326);
            this.cbb_devices.Name = "cbb_devices";
            this.cbb_devices.Size = new System.Drawing.Size(121, 21);
            this.cbb_devices.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Добавить ингридиенты";
            // 
            // cbb_ingred
            // 
            this.cbb_ingred.FormattingEnabled = true;
            this.cbb_ingred.Location = new System.Drawing.Point(151, 326);
            this.cbb_ingred.Name = "cbb_ingred";
            this.cbb_ingred.Size = new System.Drawing.Size(121, 21);
            this.cbb_ingred.TabIndex = 10;
            this.cbb_ingred.SelectedIndexChanged += new System.EventHandler(this.cbb_ingred_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(308, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Введите кол-во";
            // 
            // edt_unitCalc
            // 
            this.edt_unitCalc.Location = new System.Drawing.Point(311, 327);
            this.edt_unitCalc.Name = "edt_unitCalc";
            this.edt_unitCalc.Size = new System.Drawing.Size(136, 20);
            this.edt_unitCalc.TabIndex = 12;
            // 
            // btn_addDev
            // 
            this.btn_addDev.Location = new System.Drawing.Point(15, 356);
            this.btn_addDev.Name = "btn_addDev";
            this.btn_addDev.Size = new System.Drawing.Size(118, 23);
            this.btn_addDev.TabIndex = 13;
            this.btn_addDev.Text = "Добавить прибор";
            this.btn_addDev.UseVisualStyleBackColor = true;
            this.btn_addDev.Click += new System.EventHandler(this.btn_addDev_Click);
            // 
            // btn_addIngrid
            // 
            this.btn_addIngrid.Location = new System.Drawing.Point(151, 356);
            this.btn_addIngrid.Name = "btn_addIngrid";
            this.btn_addIngrid.Size = new System.Drawing.Size(299, 23);
            this.btn_addIngrid.TabIndex = 14;
            this.btn_addIngrid.Text = "Добавить ингридиент";
            this.btn_addIngrid.UseVisualStyleBackColor = true;
            this.btn_addIngrid.Click += new System.EventHandler(this.btn_addIngrid_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(380, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Приборы";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(551, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Ингридиенты";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Devices});
            this.dataGridView1.Location = new System.Drawing.Point(383, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(145, 224);
            this.dataGridView1.TabIndex = 19;
            // 
            // Devices
            // 
            this.Devices.HeaderText = "Прибор";
            this.Devices.Name = "Devices";
            this.Devices.ReadOnly = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ingred,
            this.quantity});
            this.dataGridView2.Location = new System.Drawing.Point(554, 33);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(128, 224);
            this.dataGridView2.TabIndex = 20;
            // 
            // Ingred
            // 
            this.Ingred.HeaderText = "Ингридиенты";
            this.Ingred.Name = "Ingred";
            this.Ingred.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Количество";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(165, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(272, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Ингридиенты добавляються на 200 грамм продукта";
            // 
            // btn_delIngr
            // 
            this.btn_delIngr.Location = new System.Drawing.Point(580, 326);
            this.btn_delIngr.Name = "btn_delIngr";
            this.btn_delIngr.Size = new System.Drawing.Size(102, 55);
            this.btn_delIngr.TabIndex = 22;
            this.btn_delIngr.Text = "Удалить ингридиент";
            this.btn_delIngr.UseVisualStyleBackColor = true;
            this.btn_delIngr.Click += new System.EventHandler(this.btn_delIngr_Click);
            // 
            // btn_delDev
            // 
            this.btn_delDev.Location = new System.Drawing.Point(472, 326);
            this.btn_delDev.Name = "btn_delDev";
            this.btn_delDev.Size = new System.Drawing.Size(102, 55);
            this.btn_delDev.TabIndex = 23;
            this.btn_delDev.Text = "Удалить прибор";
            this.btn_delDev.UseVisualStyleBackColor = true;
            this.btn_delDev.Click += new System.EventHandler(this.btn_delDev_Click);
            // 
            // lbl_unit
            // 
            this.lbl_unit.AutoSize = true;
            this.lbl_unit.Location = new System.Drawing.Point(398, 312);
            this.lbl_unit.Name = "lbl_unit";
            this.lbl_unit.Size = new System.Drawing.Size(85, 13);
            this.lbl_unit.TabIndex = 24;
            this.lbl_unit.Text = "Введите кол-во";
            // 
            // btn_Word
            // 
            this.btn_Word.Location = new System.Drawing.Point(580, 297);
            this.btn_Word.Name = "btn_Word";
            this.btn_Word.Size = new System.Drawing.Size(102, 28);
            this.btn_Word.TabIndex = 25;
            this.btn_Word.Text = "Вывести в Word";
            this.btn_Word.UseVisualStyleBackColor = true;
            this.btn_Word.Click += new System.EventHandler(this.btn_Word_Click);
            // 
            // DetailedRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 391);
            this.Controls.Add(this.btn_Word);
            this.Controls.Add(this.lbl_unit);
            this.Controls.Add(this.btn_delDev);
            this.Controls.Add(this.btn_delIngr);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_addIngrid);
            this.Controls.Add(this.btn_addDev);
            this.Controls.Add(this.edt_unitCalc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbb_ingred);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbb_devices);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_dishType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_img);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DetailedRecipe";
            this.Text = "Подробный рецепт";
            this.Load += new System.EventHandler(this.DetailedRecipe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_img;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_dishType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbb_devices;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbb_ingred;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox edt_unitCalc;
        private System.Windows.Forms.Button btn_addDev;
        private System.Windows.Forms.Button btn_addIngrid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Devices;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ingred;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_delIngr;
        private System.Windows.Forms.Button btn_delDev;
        private System.Windows.Forms.Label lbl_unit;
        private System.Windows.Forms.Button btn_Word;
    }
}