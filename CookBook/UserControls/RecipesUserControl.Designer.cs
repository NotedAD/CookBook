namespace CookBook.UserControls
{
    partial class RecipesUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pb_icon = new System.Windows.Forms.PictureBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_dishType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_icon
            // 
            this.pb_icon.Location = new System.Drawing.Point(0, 0);
            this.pb_icon.Name = "pb_icon";
            this.pb_icon.Size = new System.Drawing.Size(83, 60);
            this.pb_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_icon.TabIndex = 0;
            this.pb_icon.TabStop = false;
            this.pb_icon.Click += new System.EventHandler(this.pb_icon_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(90, 4);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "label1";
            this.lbl_name.Click += new System.EventHandler(this.lbl_name_Click);
            // 
            // lbl_dishType
            // 
            this.lbl_dishType.AutoSize = true;
            this.lbl_dishType.Location = new System.Drawing.Point(89, 26);
            this.lbl_dishType.Name = "lbl_dishType";
            this.lbl_dishType.Size = new System.Drawing.Size(35, 13);
            this.lbl_dishType.TabIndex = 3;
            this.lbl_dishType.Text = "label2";
            this.lbl_dishType.Click += new System.EventHandler(this.lbl_dishType_Click);
            // 
            // RecipesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbl_dishType);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.pb_icon);
            this.Name = "RecipesUserControl";
            this.Size = new System.Drawing.Size(212, 60);
            this.Load += new System.EventHandler(this.RecipesUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_icon;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_dishType;
    }
}
