namespace BankApp
{
    partial class Form1
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
            this.dolphinLbl = new System.Windows.Forms.Label();
            this.createBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.captionLbl = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dolphinLbl
            // 
            this.dolphinLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dolphinLbl.AutoSize = true;
            this.dolphinLbl.BackColor = System.Drawing.Color.Orchid;
            this.dolphinLbl.Font = new System.Drawing.Font("Goudy Old Style", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dolphinLbl.Location = new System.Drawing.Point(40, 23);
            this.dolphinLbl.Name = "dolphinLbl";
            this.dolphinLbl.Size = new System.Drawing.Size(206, 37);
            this.dolphinLbl.TabIndex = 0;
            this.dolphinLbl.Text = "Dolphin Bank";
            // 
            // createBtn
            // 
            this.createBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createBtn.BackColor = System.Drawing.Color.Orchid;
            this.createBtn.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBtn.Location = new System.Drawing.Point(12, 124);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(124, 37);
            this.createBtn.TabIndex = 1;
            this.createBtn.Text = "Create Account";
            this.createBtn.UseVisualStyleBackColor = false;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginBtn.BackColor = System.Drawing.Color.Orchid;
            this.loginBtn.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.Location = new System.Drawing.Point(173, 124);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(105, 37);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Log In";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // captionLbl
            // 
            this.captionLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.captionLbl.BackColor = System.Drawing.Color.Orchid;
            this.captionLbl.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captionLbl.Location = new System.Drawing.Point(123, 60);
            this.captionLbl.Name = "captionLbl";
            this.captionLbl.Size = new System.Drawing.Size(123, 17);
            this.captionLbl.TabIndex = 0;
            this.captionLbl.Text = "Taking you higher...";
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Orchid;
            this.exitBtn.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(267, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(23, 26);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orchid;
            this.ClientSize = new System.Drawing.Size(290, 232);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.captionLbl);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.dolphinLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-Banking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dolphinLbl;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label captionLbl;
        private System.Windows.Forms.Button exitBtn;
    }
}

