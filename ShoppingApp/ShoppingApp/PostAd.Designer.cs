namespace ShoppingApp
{
    partial class PostAd
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
            this.txtAdID = new System.Windows.Forms.TextBox();
            this.txtAdName = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblAdID = new System.Windows.Forms.Label();
            this.lblAdName = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.btnPost = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAdID
            // 
            this.txtAdID.Location = new System.Drawing.Point(258, 47);
            this.txtAdID.Name = "txtAdID";
            this.txtAdID.Size = new System.Drawing.Size(100, 20);
            this.txtAdID.TabIndex = 0;
            // 
            // txtAdName
            // 
            this.txtAdName.Location = new System.Drawing.Point(258, 90);
            this.txtAdName.Name = "txtAdName";
            this.txtAdName.Size = new System.Drawing.Size(100, 20);
            this.txtAdName.TabIndex = 1;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(258, 138);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(100, 20);
            this.txtDesc.TabIndex = 2;
            // 
            // lblAdID
            // 
            this.lblAdID.AutoSize = true;
            this.lblAdID.Location = new System.Drawing.Point(168, 47);
            this.lblAdID.Name = "lblAdID";
            this.lblAdID.Size = new System.Drawing.Size(31, 13);
            this.lblAdID.TabIndex = 3;
            this.lblAdID.Text = "AdID";
            // 
            // lblAdName
            // 
            this.lblAdName.AutoSize = true;
            this.lblAdName.Location = new System.Drawing.Point(168, 97);
            this.lblAdName.Name = "lblAdName";
            this.lblAdName.Size = new System.Drawing.Size(48, 13);
            this.lblAdName.TabIndex = 4;
            this.lblAdName.Text = "AdName";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(168, 145);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(60, 13);
            this.lblDesc.TabIndex = 5;
            this.lblDesc.Text = "Description";
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(258, 199);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(75, 23);
            this.btnPost.TabIndex = 6;
            this.btnPost.Text = "Post";
            this.btnPost.UseVisualStyleBackColor = true;
            // 
            // PostAd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 306);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblAdName);
            this.Controls.Add(this.lblAdID);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtAdName);
            this.Controls.Add(this.txtAdID);
            this.Name = "PostAd";
            this.Text = "PostAd";
            this.Load += new System.EventHandler(this.PostAd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdID;
        private System.Windows.Forms.TextBox txtAdName;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblAdID;
        private System.Windows.Forms.Label lblAdName;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Button btnPost;
    }
}