namespace CookBook.Forms
{
    partial class Devices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Devices));
            this.upd_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.edt_btn = new System.Windows.Forms.Button();
            this.del_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // upd_btn
            // 
            this.upd_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.upd_btn.Location = new System.Drawing.Point(441, 403);
            this.upd_btn.Name = "upd_btn";
            this.upd_btn.Size = new System.Drawing.Size(133, 39);
            this.upd_btn.TabIndex = 19;
            this.upd_btn.Text = "Обновить";
            this.upd_btn.UseVisualStyleBackColor = true;
            this.upd_btn.Click += new System.EventHandler(this.upd_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_btn.Location = new System.Drawing.Point(3, 403);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(126, 39);
            this.add_btn.TabIndex = 18;
            this.add_btn.Text = "Добавить";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // edt_btn
            // 
            this.edt_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edt_btn.Location = new System.Drawing.Point(147, 403);
            this.edt_btn.Name = "edt_btn";
            this.edt_btn.Size = new System.Drawing.Size(126, 39);
            this.edt_btn.TabIndex = 17;
            this.edt_btn.Text = "Изменить";
            this.edt_btn.UseVisualStyleBackColor = true;
            this.edt_btn.Click += new System.EventHandler(this.edt_btn_Click);
            // 
            // del_btn
            // 
            this.del_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.del_btn.Location = new System.Drawing.Point(290, 403);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(133, 39);
            this.del_btn.TabIndex = 16;
            this.del_btn.Text = "Удалить";
            this.del_btn.UseVisualStyleBackColor = true;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back_btn.Location = new System.Drawing.Point(593, 403);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(195, 39);
            this.back_btn.TabIndex = 15;
            this.back_btn.Text = "Вернуться в меню";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 9);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(795, 388);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // Devices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.upd_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.edt_btn);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Devices";
            this.Text = "Приборы";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Devices_FormClosing_1);
            this.Load += new System.EventHandler(this.Devices_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button upd_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button edt_btn;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}