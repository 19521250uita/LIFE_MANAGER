
namespace LIFE_MANAGER.FormUI
{
    partial class frm_Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Profile));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_Name = new System.Windows.Forms.Label();
            this.lb_Bio = new System.Windows.Forms.Label();
            this.lb_Date = new System.Windows.Forms.Label();
            this.lb_Id = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Id = new System.Windows.Forms.TextBox();
            this.tb_Date = new System.Windows.Forms.TextBox();
            this.rtb_Bio = new System.Windows.Forms.RichTextBox();
            this.btn_SaveChanges = new LIFE_MANAGER.Custom_Control.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(322, 462);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_Name.Location = new System.Drawing.Point(394, 72);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(85, 25);
            this.lb_Name.TabIndex = 2;
            this.lb_Name.Text = "Họ tên : ";
            // 
            // lb_Bio
            // 
            this.lb_Bio.AutoSize = true;
            this.lb_Bio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Bio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_Bio.Location = new System.Drawing.Point(394, 215);
            this.lb_Bio.Name = "lb_Bio";
            this.lb_Bio.Size = new System.Drawing.Size(93, 25);
            this.lb_Bio.TabIndex = 3;
            this.lb_Bio.Text = "Tiểu sử : ";
            // 
            // lb_Date
            // 
            this.lb_Date.AutoSize = true;
            this.lb_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Date.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_Date.Location = new System.Drawing.Point(394, 165);
            this.lb_Date.Name = "lb_Date";
            this.lb_Date.Size = new System.Drawing.Size(115, 25);
            this.lb_Date.TabIndex = 4;
            this.lb_Date.Text = "Ngày sinh : ";
            // 
            // lb_Id
            // 
            this.lb_Id.AutoSize = true;
            this.lb_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Id.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_Id.Location = new System.Drawing.Point(394, 120);
            this.lb_Id.Name = "lb_Id";
            this.lb_Id.Size = new System.Drawing.Size(47, 25);
            this.lb_Id.TabIndex = 5;
            this.lb_Id.Text = "ID : ";
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(520, 72);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(258, 30);
            this.tb_Name.TabIndex = 6;
            // 
            // tb_Id
            // 
            this.tb_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Id.Location = new System.Drawing.Point(520, 117);
            this.tb_Id.Name = "tb_Id";
            this.tb_Id.ReadOnly = true;
            this.tb_Id.Size = new System.Drawing.Size(258, 30);
            this.tb_Id.TabIndex = 7;
            // 
            // tb_Date
            // 
            this.tb_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Date.Location = new System.Drawing.Point(520, 165);
            this.tb_Date.Name = "tb_Date";
            this.tb_Date.Size = new System.Drawing.Size(258, 30);
            this.tb_Date.TabIndex = 8;
            // 
            // rtb_Bio
            // 
            this.rtb_Bio.Location = new System.Drawing.Point(520, 215);
            this.rtb_Bio.Name = "rtb_Bio";
            this.rtb_Bio.Size = new System.Drawing.Size(258, 168);
            this.rtb_Bio.TabIndex = 9;
            this.rtb_Bio.Text = "";
            // 
            // btn_SaveChanges
            // 
            this.btn_SaveChanges.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_SaveChanges.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_SaveChanges.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_SaveChanges.BorderRadius = 40;
            this.btn_SaveChanges.BorderSize = 0;
            this.btn_SaveChanges.FlatAppearance.BorderSize = 0;
            this.btn_SaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveChanges.ForeColor = System.Drawing.Color.White;
            this.btn_SaveChanges.Location = new System.Drawing.Point(557, 402);
            this.btn_SaveChanges.Name = "btn_SaveChanges";
            this.btn_SaveChanges.Size = new System.Drawing.Size(221, 46);
            this.btn_SaveChanges.TabIndex = 10;
            this.btn_SaveChanges.Text = "Save changes";
            this.btn_SaveChanges.TextColor = System.Drawing.Color.White;
            this.btn_SaveChanges.UseVisualStyleBackColor = false;
            this.btn_SaveChanges.Click += new System.EventHandler(this.btn_SaveChanges_Click);
            // 
            // frm_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(853, 480);
            this.Controls.Add(this.btn_SaveChanges);
            this.Controls.Add(this.rtb_Bio);
            this.Controls.Add(this.tb_Date);
            this.Controls.Add(this.tb_Id);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.lb_Id);
            this.Controls.Add(this.lb_Date);
            this.Controls.Add(this.lb_Bio);
            this.Controls.Add(this.lb_Name);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frm_Profile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.frm_Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Label lb_Bio;
        private System.Windows.Forms.Label lb_Date;
        private System.Windows.Forms.Label lb_Id;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Id;
        private System.Windows.Forms.TextBox tb_Date;
        private System.Windows.Forms.RichTextBox rtb_Bio;
        private Custom_Control.RoundedButton btn_SaveChanges;
    }
}