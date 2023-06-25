namespace CookBook.Forms
{
    partial class AddEdtRecipes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEdtRecipes));
            this.save = new System.Windows.Forms.Button();
            this.edt_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.upload_img = new System.Windows.Forms.Button();
            this.pb_image = new System.Windows.Forms.PictureBox();
            this.edt_description = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_typeRecip = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).BeginInit();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save.Location = new System.Drawing.Point(7, 308);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(389, 36);
            this.save.TabIndex = 19;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // edt_name
            // 
            this.edt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edt_name.Location = new System.Drawing.Point(153, 118);
            this.edt_name.MaxLength = 50;
            this.edt_name.Name = "edt_name";
            this.edt_name.Size = new System.Drawing.Size(243, 26);
            this.edt_name.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Описание блюда";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(157, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Название блюда";
            // 
            // upload_img
            // 
            this.upload_img.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.upload_img.Location = new System.Drawing.Point(161, 6);
            this.upload_img.Name = "upload_img";
            this.upload_img.Size = new System.Drawing.Size(235, 59);
            this.upload_img.TabIndex = 14;
            this.upload_img.Text = "Загрузить изображение";
            this.upload_img.UseVisualStyleBackColor = true;
            this.upload_img.Click += new System.EventHandler(this.upload_img_Click);
            // 
            // pb_image
            // 
            this.pb_image.Location = new System.Drawing.Point(7, 6);
            this.pb_image.Name = "pb_image";
            this.pb_image.Size = new System.Drawing.Size(140, 138);
            this.pb_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_image.TabIndex = 13;
            this.pb_image.TabStop = false;
            // 
            // edt_description
            // 
            this.edt_description.Location = new System.Drawing.Point(7, 170);
            this.edt_description.MaxLength = 600;
            this.edt_description.Multiline = true;
            this.edt_description.Name = "edt_description";
            this.edt_description.Size = new System.Drawing.Size(389, 97);
            this.edt_description.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Тип блюда";
            // 
            // cbb_typeRecip
            // 
            this.cbb_typeRecip.FormattingEnabled = true;
            this.cbb_typeRecip.Items.AddRange(new object[] {
            "Горячее",
            "Холодное"});
            this.cbb_typeRecip.Location = new System.Drawing.Point(90, 279);
            this.cbb_typeRecip.Name = "cbb_typeRecip";
            this.cbb_typeRecip.Size = new System.Drawing.Size(305, 21);
            this.cbb_typeRecip.TabIndex = 22;
            // 
            // AddEdtRecipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 354);
            this.Controls.Add(this.cbb_typeRecip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edt_description);
            this.Controls.Add(this.save);
            this.Controls.Add(this.edt_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.upload_img);
            this.Controls.Add(this.pb_image);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddEdtRecipes";
            this.Text = "Добавить/редактировать рецепт";
            this.Load += new System.EventHandler(this.AddEdtRecipes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox edt_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button upload_img;
        private System.Windows.Forms.PictureBox pb_image;
        private System.Windows.Forms.TextBox edt_description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbb_typeRecip;
    }
}