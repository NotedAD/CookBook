namespace CookBook.Forms
{
    partial class Recipes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recipes));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_search = new System.Windows.Forms.Button();
            this.edt_search = new System.Windows.Forms.TextBox();
            this.btn_upd = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.edt_btn = new System.Windows.Forms.Button();
            this.del_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_raschet = new System.Windows.Forms.Button();
            this.edt_count = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ingr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbb_recipes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imulQuant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 475);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_search);
            this.tabPage1.Controls.Add(this.edt_search);
            this.tabPage1.Controls.Add(this.btn_upd);
            this.tabPage1.Controls.Add(this.add_btn);
            this.tabPage1.Controls.Add(this.edt_btn);
            this.tabPage1.Controls.Add(this.del_btn);
            this.tabPage1.Controls.Add(this.back_btn);
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 449);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Рецепты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_search.Location = new System.Drawing.Point(200, 405);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(126, 39);
            this.btn_search.TabIndex = 15;
            this.btn_search.Text = "Поиск";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // edt_search
            // 
            this.edt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edt_search.Location = new System.Drawing.Point(6, 411);
            this.edt_search.Name = "edt_search";
            this.edt_search.Size = new System.Drawing.Size(187, 26);
            this.edt_search.TabIndex = 14;
            // 
            // btn_upd
            // 
            this.btn_upd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_upd.Location = new System.Drawing.Point(406, 365);
            this.btn_upd.Name = "btn_upd";
            this.btn_upd.Size = new System.Drawing.Size(133, 39);
            this.btn_upd.TabIndex = 13;
            this.btn_upd.Text = "Обновить";
            this.btn_upd.UseVisualStyleBackColor = true;
            this.btn_upd.Click += new System.EventHandler(this.btn_upd_Click);
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_btn.Location = new System.Drawing.Point(3, 365);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(126, 39);
            this.add_btn.TabIndex = 12;
            this.add_btn.Text = "Добавить";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // edt_btn
            // 
            this.edt_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edt_btn.Location = new System.Drawing.Point(135, 365);
            this.edt_btn.Name = "edt_btn";
            this.edt_btn.Size = new System.Drawing.Size(126, 39);
            this.edt_btn.TabIndex = 11;
            this.edt_btn.Text = "Изменить";
            this.edt_btn.UseVisualStyleBackColor = true;
            this.edt_btn.Click += new System.EventHandler(this.edt_btn_Click);
            // 
            // del_btn
            // 
            this.del_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.del_btn.Location = new System.Drawing.Point(267, 365);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(133, 39);
            this.del_btn.TabIndex = 10;
            this.del_btn.Text = "Удалить";
            this.del_btn.UseVisualStyleBackColor = true;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back_btn.Location = new System.Drawing.Point(591, 365);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(195, 39);
            this.back_btn.TabIndex = 9;
            this.back_btn.Text = "Вернуться в меню";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click_1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(792, 359);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.btn_raschet);
            this.tabPage2.Controls.Add(this.edt_count);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.cbb_recipes);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 449);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Калькулятор ингридиентов";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            this.tabPage2.Leave += new System.EventHandler(this.tabPage2_Leave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Выбрать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_raschet
            // 
            this.btn_raschet.Location = new System.Drawing.Point(78, 305);
            this.btn_raschet.Name = "btn_raschet";
            this.btn_raschet.Size = new System.Drawing.Size(89, 23);
            this.btn_raschet.TabIndex = 5;
            this.btn_raschet.Text = "Рассчитать";
            this.btn_raschet.UseVisualStyleBackColor = true;
            this.btn_raschet.Click += new System.EventHandler(this.btn_raschet_Click);
            // 
            // edt_count
            // 
            this.edt_count.Location = new System.Drawing.Point(8, 78);
            this.edt_count.Name = "edt_count";
            this.edt_count.Size = new System.Drawing.Size(263, 20);
            this.edt_count.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Укажите сколько блюда вы хотите сделать (штук)";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ingr,
            this.quantity,
            this.imulQuant});
            this.dataGridView1.Location = new System.Drawing.Point(8, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(263, 172);
            this.dataGridView1.TabIndex = 2;
            // 
            // ingr
            // 
            this.ingr.HeaderText = "Ингридиенты";
            this.ingr.Name = "ingr";
            this.ingr.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Количество";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // cbb_recipes
            // 
            this.cbb_recipes.FormattingEnabled = true;
            this.cbb_recipes.Location = new System.Drawing.Point(61, 29);
            this.cbb_recipes.Name = "cbb_recipes";
            this.cbb_recipes.Size = new System.Drawing.Size(121, 21);
            this.cbb_recipes.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите блюдо";
            // 
            // imulQuant
            // 
            this.imulQuant.HeaderText = "Количество ингридиентов ";
            this.imulQuant.Name = "imulQuant";
            this.imulQuant.ReadOnly = true;
            // 
            // Recipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Recipes";
            this.Text = "Рецепты";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Recipes_FormClosing);
            this.Load += new System.EventHandler(this.Recipes_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button edt_btn;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_upd;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox edt_search;
        private System.Windows.Forms.ComboBox cbb_recipes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox edt_count;
        private System.Windows.Forms.Button btn_raschet;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingr;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn imulQuant;
    }
}