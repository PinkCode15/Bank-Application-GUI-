namespace BankApp
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.depositBtn = new System.Windows.Forms.Button();
            this.withdrawBtn = new System.Windows.Forms.Button();
            this.transferBtn = new System.Windows.Forms.Button();
            this.balanceBtn = new System.Windows.Forms.Button();
            this.acctnoLbl = new System.Windows.Forms.Label();
            this.acctnotxtBox = new System.Windows.Forms.TextBox();
            this.welcomeLbl = new System.Windows.Forms.Label();
            this.amounttxtBox = new System.Windows.Forms.TextBox();
            this.amountLbl = new System.Windows.Forms.Label();
            this.acct2Lbl = new System.Windows.Forms.Label();
            this.acct2txtBox = new System.Windows.Forms.TextBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.doneBtn = new System.Windows.Forms.Button();
            this.balLbl = new System.Windows.Forms.Label();
            this.depnameLbl = new System.Windows.Forms.Label();
            this.depnamextxBox = new System.Windows.Forms.TextBox();
            this.enterBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Log In";
            // 
            // depositBtn
            // 
            this.depositBtn.BackColor = System.Drawing.Color.Black;
            this.depositBtn.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.depositBtn.Location = new System.Drawing.Point(3, 171);
            this.depositBtn.Name = "depositBtn";
            this.depositBtn.Size = new System.Drawing.Size(89, 31);
            this.depositBtn.TabIndex = 1;
            this.depositBtn.Text = "Deposit";
            this.depositBtn.UseVisualStyleBackColor = false;
            this.depositBtn.Visible = false;
            this.depositBtn.Click += new System.EventHandler(this.depositBtn_Click);
            // 
            // withdrawBtn
            // 
            this.withdrawBtn.BackColor = System.Drawing.Color.Black;
            this.withdrawBtn.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.withdrawBtn.Location = new System.Drawing.Point(98, 171);
            this.withdrawBtn.Name = "withdrawBtn";
            this.withdrawBtn.Size = new System.Drawing.Size(84, 31);
            this.withdrawBtn.TabIndex = 2;
            this.withdrawBtn.Text = "Withdraw";
            this.withdrawBtn.UseVisualStyleBackColor = false;
            this.withdrawBtn.Visible = false;
            this.withdrawBtn.Click += new System.EventHandler(this.withdrawBtn_Click);
            // 
            // transferBtn
            // 
            this.transferBtn.BackColor = System.Drawing.Color.Black;
            this.transferBtn.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.transferBtn.Location = new System.Drawing.Point(188, 173);
            this.transferBtn.Name = "transferBtn";
            this.transferBtn.Size = new System.Drawing.Size(85, 29);
            this.transferBtn.TabIndex = 3;
            this.transferBtn.Text = "Transfer";
            this.transferBtn.UseVisualStyleBackColor = false;
            this.transferBtn.Visible = false;
            this.transferBtn.Click += new System.EventHandler(this.transferBtn_Click);
            // 
            // balanceBtn
            // 
            this.balanceBtn.BackColor = System.Drawing.Color.Black;
            this.balanceBtn.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.balanceBtn.Location = new System.Drawing.Point(279, 173);
            this.balanceBtn.Name = "balanceBtn";
            this.balanceBtn.Size = new System.Drawing.Size(84, 29);
            this.balanceBtn.TabIndex = 4;
            this.balanceBtn.Text = "Balance";
            this.balanceBtn.UseVisualStyleBackColor = false;
            this.balanceBtn.Visible = false;
            this.balanceBtn.Click += new System.EventHandler(this.balanceBtn_Click);
            // 
            // acctnoLbl
            // 
            this.acctnoLbl.AutoSize = true;
            this.acctnoLbl.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acctnoLbl.Location = new System.Drawing.Point(9, 71);
            this.acctnoLbl.Name = "acctnoLbl";
            this.acctnoLbl.Size = new System.Drawing.Size(118, 18);
            this.acctnoLbl.TabIndex = 5;
            this.acctnoLbl.Text = "Account Number";
            // 
            // acctnotxtBox
            // 
            this.acctnotxtBox.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acctnotxtBox.Location = new System.Drawing.Point(154, 71);
            this.acctnotxtBox.Name = "acctnotxtBox";
            this.acctnotxtBox.Size = new System.Drawing.Size(174, 25);
            this.acctnotxtBox.TabIndex = 6;
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLbl.Location = new System.Drawing.Point(34, 119);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(301, 37);
            this.welcomeLbl.TabIndex = 7;
            this.welcomeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.welcomeLbl.Click += new System.EventHandler(this.label3_Click);
            // 
            // amounttxtBox
            // 
            this.amounttxtBox.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amounttxtBox.Location = new System.Drawing.Point(142, 295);
            this.amounttxtBox.Name = "amounttxtBox";
            this.amounttxtBox.Size = new System.Drawing.Size(193, 25);
            this.amounttxtBox.TabIndex = 8;
            this.amounttxtBox.Visible = false;
            // 
            // amountLbl
            // 
            this.amountLbl.AutoSize = true;
            this.amountLbl.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLbl.Location = new System.Drawing.Point(13, 298);
            this.amountLbl.Name = "amountLbl";
            this.amountLbl.Size = new System.Drawing.Size(61, 18);
            this.amountLbl.TabIndex = 9;
            this.amountLbl.Text = "Amount";
            this.amountLbl.Visible = false;
            // 
            // acct2Lbl
            // 
            this.acct2Lbl.AutoSize = true;
            this.acct2Lbl.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acct2Lbl.Location = new System.Drawing.Point(12, 261);
            this.acct2Lbl.Name = "acct2Lbl";
            this.acct2Lbl.Size = new System.Drawing.Size(118, 18);
            this.acct2Lbl.TabIndex = 10;
            this.acct2Lbl.Text = "Account Number";
            this.acct2Lbl.Visible = false;
            // 
            // acct2txtBox
            // 
            this.acct2txtBox.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acct2txtBox.Location = new System.Drawing.Point(142, 258);
            this.acct2txtBox.Name = "acct2txtBox";
            this.acct2txtBox.Size = new System.Drawing.Size(193, 25);
            this.acct2txtBox.TabIndex = 11;
            this.acct2txtBox.Visible = false;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Orchid;
            this.backBtn.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(27, 343);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(80, 29);
            this.backBtn.TabIndex = 12;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.BackColor = System.Drawing.Color.Orchid;
            this.okBtn.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okBtn.Location = new System.Drawing.Point(163, 343);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(48, 29);
            this.okBtn.TabIndex = 13;
            this.okBtn.Text = "Ok";
            this.okBtn.UseVisualStyleBackColor = false;
            this.okBtn.Visible = false;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // doneBtn
            // 
            this.doneBtn.BackColor = System.Drawing.Color.Orchid;
            this.doneBtn.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneBtn.Location = new System.Drawing.Point(264, 343);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Size = new System.Drawing.Size(81, 29);
            this.doneBtn.TabIndex = 14;
            this.doneBtn.Text = "Exit";
            this.doneBtn.UseVisualStyleBackColor = false;
            this.doneBtn.Visible = false;
            this.doneBtn.Click += new System.EventHandler(this.doneBtn_Click);
            // 
            // balLbl
            // 
            this.balLbl.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balLbl.Location = new System.Drawing.Point(51, 229);
            this.balLbl.Name = "balLbl";
            this.balLbl.Size = new System.Drawing.Size(261, 74);
            this.balLbl.TabIndex = 15;
            this.balLbl.Visible = false;
            // 
            // depnameLbl
            // 
            this.depnameLbl.AutoSize = true;
            this.depnameLbl.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depnameLbl.Location = new System.Drawing.Point(13, 226);
            this.depnameLbl.Name = "depnameLbl";
            this.depnameLbl.Size = new System.Drawing.Size(48, 18);
            this.depnameLbl.TabIndex = 16;
            this.depnameLbl.Text = "Name";
            this.depnameLbl.Visible = false;
            // 
            // depnamextxBox
            // 
            this.depnamextxBox.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depnamextxBox.Location = new System.Drawing.Point(142, 226);
            this.depnamextxBox.Name = "depnamextxBox";
            this.depnamextxBox.Size = new System.Drawing.Size(193, 25);
            this.depnamextxBox.TabIndex = 17;
            this.depnamextxBox.Visible = false;
            // 
            // enterBtn
            // 
            this.enterBtn.BackColor = System.Drawing.Color.Black;
            this.enterBtn.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.enterBtn.Location = new System.Drawing.Point(136, 128);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(75, 28);
            this.enterBtn.TabIndex = 18;
            this.enterBtn.Text = "Enter";
            this.enterBtn.UseVisualStyleBackColor = false;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orchid;
            this.ClientSize = new System.Drawing.Size(368, 384);
            this.Controls.Add(this.enterBtn);
            this.Controls.Add(this.depnamextxBox);
            this.Controls.Add(this.depnameLbl);
            this.Controls.Add(this.balLbl);
            this.Controls.Add(this.doneBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.acct2txtBox);
            this.Controls.Add(this.acct2Lbl);
            this.Controls.Add(this.amountLbl);
            this.Controls.Add(this.amounttxtBox);
            this.Controls.Add(this.welcomeLbl);
            this.Controls.Add(this.acctnotxtBox);
            this.Controls.Add(this.acctnoLbl);
            this.Controls.Add(this.balanceBtn);
            this.Controls.Add(this.transferBtn);
            this.Controls.Add(this.withdrawBtn);
            this.Controls.Add(this.depositBtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button depositBtn;
        private System.Windows.Forms.Button withdrawBtn;
        private System.Windows.Forms.Button transferBtn;
        private System.Windows.Forms.Button balanceBtn;
        private System.Windows.Forms.Label acctnoLbl;
        private System.Windows.Forms.TextBox acctnotxtBox;
        private System.Windows.Forms.Label welcomeLbl;
        private System.Windows.Forms.TextBox amounttxtBox;
        private System.Windows.Forms.Label amountLbl;
        private System.Windows.Forms.Label acct2Lbl;
        private System.Windows.Forms.TextBox acct2txtBox;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button doneBtn;
        private System.Windows.Forms.Label balLbl;
        private System.Windows.Forms.Label depnameLbl;
        private System.Windows.Forms.TextBox depnamextxBox;
        private System.Windows.Forms.Button enterBtn;
    }
}