namespace ShoppingApp
{
    partial class AfterLogin
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
            this.btnPostAd = new System.Windows.Forms.Button();
            this.btnEditAd = new System.Windows.Forms.Button();
            this.btnDeleteAd = new System.Windows.Forms.Button();
            this.lblAfterlogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPostAd
            // 
            this.btnPostAd.Location = new System.Drawing.Point(111, 67);
            this.btnPostAd.Name = "btnPostAd";
            this.btnPostAd.Size = new System.Drawing.Size(75, 23);
            this.btnPostAd.TabIndex = 0;
            this.btnPostAd.Text = "PostAd";
            this.btnPostAd.UseVisualStyleBackColor = true;
            // 
            // btnEditAd
            // 
            this.btnEditAd.Location = new System.Drawing.Point(229, 67);
            this.btnEditAd.Name = "btnEditAd";
            this.btnEditAd.Size = new System.Drawing.Size(75, 23);
            this.btnEditAd.TabIndex = 1;
            this.btnEditAd.Text = "EditAd";
            this.btnEditAd.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAd
            // 
            this.btnDeleteAd.Location = new System.Drawing.Point(365, 67);
            this.btnDeleteAd.Name = "btnDeleteAd";
            this.btnDeleteAd.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteAd.TabIndex = 2;
            this.btnDeleteAd.Text = "DeleteAd";
            this.btnDeleteAd.UseVisualStyleBackColor = true;
            // 
            // lblAfterlogin
            // 
            this.lblAfterlogin.AutoSize = true;
            this.lblAfterlogin.Location = new System.Drawing.Point(226, 19);
            this.lblAfterlogin.Name = "lblAfterlogin";
            this.lblAfterlogin.Size = new System.Drawing.Size(0, 13);
            this.lblAfterlogin.TabIndex = 3;
            // 
            // AfterLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 299);
            this.Controls.Add(this.lblAfterlogin);
            this.Controls.Add(this.btnDeleteAd);
            this.Controls.Add(this.btnEditAd);
            this.Controls.Add(this.btnPostAd);
            this.Name = "AfterLogin";
            this.Text = "AfterLogin";
            this.Load += new System.EventHandler(this.AfterLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPostAd;
        private System.Windows.Forms.Button btnEditAd;
        private System.Windows.Forms.Button btnDeleteAd;
        private System.Windows.Forms.Label lblAfterlogin;
    }
}