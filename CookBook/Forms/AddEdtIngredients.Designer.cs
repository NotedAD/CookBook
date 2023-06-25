namespace CookBook.Forms
{
    partial class AddEdtIngredients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEdtIngredients));
            this.pb_image = new System.Windows.Forms.PictureBox();
            this.save = new System.Windows.Forms.Button();
            this.edt_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.upload_img = new System.Windows.Forms.Button();
            this.cbb_unitCalc = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_image
            // 
            this.pb_image.Location = new System.Drawing.Point(13, 13);
            this.pb_image.Name = "pb_image";
            this.pb_image.Size = new System.Drawing.Size(140, 138);
            this.pb_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_image.TabIndex = 0;
            this.pb_image.TabStop = false;
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save.Location = new System.Drawing.Point(12, 187);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(327, 36);
            this.save.TabIndex = 12;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // edt_name
            // 
            this.edt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edt_name.Location = new System.Drawing.Point(159, 125);
            this.edt_name.MaxLength = 50;
            this.edt_name.Name = "edt_name";
            this.edt_name.Size = new System.Drawing.Size(180, 26);
            this.edt_name.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Единица измерения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(163, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Название ингридиента";
            // 
            // upload_img
            // 
            this.upload_img.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.upload_img.Location = new System.Drawing.Point(167, 13);
            this.upload_img.Name = "upload_img";
            this.upload_img.Size = new System.Drawing.Size(172, 59);
            this.upload_img.TabIndex = 7;
            this.upload_img.Text = "Загрузить изображение";
            this.upload_img.UseVisualStyleBackColor = true;
            this.upload_img.Click += new System.EventHandler(this.upload_img_Click);
            // 
            // cbb_unitCalc
            // 
            this.cbb_unitCalc.FormattingEnabled = true;
            this.cbb_unitCalc.Items.AddRange(new object[] {
            "кг",
            "грамм",
            "мл",
            "л",
            "шт"});
            this.cbb_unitCalc.Location = new System.Drawing.Point(159, 157);
            this.cbb_unitCalc.Name = "cbb_unitCalc";
            this.cbb_unitCalc.Size = new System.Drawing.Size(121, 21);
            this.cbb_unitCalc.TabIndex = 13;
            // 
            // AddEdtIngredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 234);
            this.Controls.Add(this.cbb_unitCalc);
            this.Controls.Add(this.save);
            this.Controls.Add(this.edt_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.upload_img);
            this.Controls.Add(this.pb_image);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddEdtIngredients";
            this.Text = "Добавление/измение ингридиентов";
            this.Load += new System.EventHandler(this.AddEdtIngredients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_image;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox edt_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button upload_img;
        private System.Windows.Forms.ComboBox cbb_unitCalc;
    }
}