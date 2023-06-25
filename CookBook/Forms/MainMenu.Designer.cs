namespace CookBook
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.recipes_btn = new System.Windows.Forms.Button();
            this.ingredients_btn = new System.Windows.Forms.Button();
            this.devices_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // recipes_btn
            // 
            this.recipes_btn.BackColor = System.Drawing.Color.Transparent;
            this.recipes_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recipes_btn.ForeColor = System.Drawing.Color.Black;
            this.recipes_btn.Location = new System.Drawing.Point(69, 88);
            this.recipes_btn.Name = "recipes_btn";
            this.recipes_btn.Size = new System.Drawing.Size(213, 35);
            this.recipes_btn.TabIndex = 0;
            this.recipes_btn.Text = "Рецепты";
            this.recipes_btn.UseVisualStyleBackColor = false;
            this.recipes_btn.Click += new System.EventHandler(this.recipes_btn_Click);
            // 
            // ingredients_btn
            // 
            this.ingredients_btn.BackColor = System.Drawing.Color.Transparent;
            this.ingredients_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ingredients_btn.ForeColor = System.Drawing.Color.Black;
            this.ingredients_btn.Location = new System.Drawing.Point(53, 189);
            this.ingredients_btn.Name = "ingredients_btn";
            this.ingredients_btn.Size = new System.Drawing.Size(245, 35);
            this.ingredients_btn.TabIndex = 1;
            this.ingredients_btn.Text = "Ингридиенты";
            this.ingredients_btn.UseVisualStyleBackColor = false;
            this.ingredients_btn.Click += new System.EventHandler(this.ingredients_btn_Click);
            // 
            // devices_btn
            // 
            this.devices_btn.BackColor = System.Drawing.Color.Transparent;
            this.devices_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.devices_btn.ForeColor = System.Drawing.Color.Black;
            this.devices_btn.Location = new System.Drawing.Point(53, 286);
            this.devices_btn.Name = "devices_btn";
            this.devices_btn.Size = new System.Drawing.Size(245, 35);
            this.devices_btn.TabIndex = 2;
            this.devices_btn.Text = "Приборы";
            this.devices_btn.UseVisualStyleBackColor = false;
            this.devices_btn.Click += new System.EventHandler(this.devices_btn_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CookBook.Properties.Resources._1619553057_17_phonoteka_org_p_fon_dlya_kulinarnoi_knigi_18;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(350, 450);
            this.Controls.Add(this.devices_btn);
            this.Controls.Add(this.ingredients_btn);
            this.Controls.Add(this.recipes_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.Text = "Главное меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button recipes_btn;
        private System.Windows.Forms.Button ingredients_btn;
        private System.Windows.Forms.Button devices_btn;
    }
}

