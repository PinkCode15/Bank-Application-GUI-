namespace BankApp
{
    partial class Form2
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
            this.createLbl = new System.Windows.Forms.Label();
            this.nametxtBox = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.pinLbl = new System.Windows.Forms.Label();
            this.pintxtBox = new System.Windows.Forms.TextBox();
            this.accttypeLbl = new System.Windows.Forms.Label();
            this.acctnotxtBox = new System.Windows.Forms.TextBox();
            this.acctnoLbl = new System.Windows.Forms.Label();
            this.depositBtn = new System.Windows.Forms.Button();
            this.amttxtBox = new System.Windows.Forms.TextBox();
            this.createBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.amtLbl = new System.Windows.Forms.Label();
            this.doneBtn = new System.Windows.Forms.Button();
            this.accttypeBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // createLbl
            // 
            this.createLbl.AutoSize = true;
            this.createLbl.Font = new System.Drawing.Font("Goudy Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createLbl.Location = new System.Drawing.Point(90, 9);
            this.createLbl.Name = "createLbl";
            this.createLbl.Size = new System.Drawing.Size(165, 28);
            this.createLbl.TabIndex = 0;
            this.createLbl.Text = "Create Account";
            // 
            // nametxtBox
            // 
            this.nametxtBox.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametxtBox.Location = new System.Drawing.Point(137, 61);
            this.nametxtBox.Name = "nametxtBox";
            this.nametxtBox.Size = new System.Drawing.Size(202, 25);
            this.nametxtBox.TabIndex = 1;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.Location = new System.Drawing.Point(9, 64);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(75, 18);
            this.nameLbl.TabIndex = 2;
            this.nameLbl.Text = "Full Name";
            // 
            // pinLbl
            // 
            this.pinLbl.AutoSize = true;
            this.pinLbl.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinLbl.Location = new System.Drawing.Point(9, 103);
            this.pinLbl.Name = "pinLbl";
            this.pinLbl.Size = new System.Drawing.Size(29, 18);
            this.pinLbl.TabIndex = 3;
            this.pinLbl.Text = "Pin";
            // 
            // pintxtBox
            // 
            this.pintxtBox.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pintxtBox.Location = new System.Drawing.Point(137, 103);
            this.pintxtBox.Name = "pintxtBox";
            this.pintxtBox.Size = new System.Drawing.Size(202, 25);
            this.pintxtBox.TabIndex = 4;
            // 
            // accttypeLbl
            // 
            this.accttypeLbl.AutoSize = true;
            this.accttypeLbl.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accttypeLbl.Location = new System.Drawing.Point(9, 149);
            this.accttypeLbl.Name = "accttypeLbl";
            this.accttypeLbl.Size = new System.Drawing.Size(96, 18);
            this.accttypeLbl.TabIndex = 5;
            this.accttypeLbl.Text = "Account Type";
            this.accttypeLbl.Click += new System.EventHandler(this.label4_Click);
            // 
            // acctnotxtBox
            // 
            this.acctnotxtBox.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acctnotxtBox.Location = new System.Drawing.Point(137, 250);
            this.acctnotxtBox.Name = "acctnotxtBox";
            this.acctnotxtBox.ReadOnly = true;
            this.acctnotxtBox.Size = new System.Drawing.Size(202, 25);
            this.acctnotxtBox.TabIndex = 6;
            this.acctnotxtBox.Visible = false;
            // 
            // acctnoLbl
            // 
            this.acctnoLbl.AutoSize = true;
            this.acctnoLbl.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acctnoLbl.Location = new System.Drawing.Point(9, 253);
            this.acctnoLbl.Name = "acctnoLbl";
            this.acctnoLbl.Size = new System.Drawing.Size(118, 18);
            this.acctnoLbl.TabIndex = 7;
            this.acctnoLbl.Text = "Account Number";
            this.acctnoLbl.Visible = false;
            // 
            // depositBtn
            // 
            this.depositBtn.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositBtn.Location = new System.Drawing.Point(153, 199);
            this.depositBtn.Name = "depositBtn";
            this.depositBtn.Size = new System.Drawing.Size(78, 28);
            this.depositBtn.TabIndex = 9;
            this.depositBtn.Text = "Deposit";
            this.depositBtn.UseVisualStyleBackColor = true;
            this.depositBtn.Click += new System.EventHandler(this.depositBtn_Click);
            // 
            // amttxtBox
            // 
            this.amttxtBox.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amttxtBox.Location = new System.Drawing.Point(137, 196);
            this.amttxtBox.Name = "amttxtBox";
            this.amttxtBox.Size = new System.Drawing.Size(202, 25);
            this.amttxtBox.TabIndex = 10;
            this.amttxtBox.Text = "0";
            this.amttxtBox.Visible = false;
            // 
            // createBtn
            // 
            this.createBtn.BackColor = System.Drawing.Color.Orchid;
            this.createBtn.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBtn.Location = new System.Drawing.Point(137, 309);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(85, 34);
            this.createBtn.TabIndex = 11;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = false;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Orchid;
            this.backBtn.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(12, 311);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(95, 32);
            this.backBtn.TabIndex = 12;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // amtLbl
            // 
            this.amtLbl.AutoSize = true;
            this.amtLbl.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amtLbl.Location = new System.Drawing.Point(9, 199);
            this.amtLbl.Name = "amtLbl";
            this.amtLbl.Size = new System.Drawing.Size(61, 18);
            this.amtLbl.TabIndex = 13;
            this.amtLbl.Text = "Amount";
            this.amtLbl.Visible = false;
            // 
            // doneBtn
            // 
            this.doneBtn.BackColor = System.Drawing.Color.Orchid;
            this.doneBtn.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneBtn.Location = new System.Drawing.Point(264, 311);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Size = new System.Drawing.Size(75, 34);
            this.doneBtn.TabIndex = 14;
            this.doneBtn.Text = "Exit";
            this.doneBtn.UseVisualStyleBackColor = false;
            this.doneBtn.Click += new System.EventHandler(this.doneBtn_Click);
            // 
            // accttypeBox
            // 
            this.accttypeBox.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accttypeBox.FormattingEnabled = true;
            this.accttypeBox.Items.AddRange(new object[] {
            "Current Account",
            "Savings Account"});
            this.accttypeBox.Location = new System.Drawing.Point(137, 146);
            this.accttypeBox.Name = "accttypeBox";
            this.accttypeBox.Size = new System.Drawing.Size(202, 25);
            this.accttypeBox.Sorted = true;
            this.accttypeBox.TabIndex = 15;
            this.accttypeBox.Text = "Type";
            this.accttypeBox.SelectedIndexChanged += new System.EventHandler(this.accttypeBox_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orchid;
            this.ClientSize = new System.Drawing.Size(351, 349);
            this.Controls.Add(this.accttypeBox);
            this.Controls.Add(this.doneBtn);
            this.Controls.Add(this.amtLbl);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.amttxtBox);
            this.Controls.Add(this.depositBtn);
            this.Controls.Add(this.acctnoLbl);
            this.Controls.Add(this.acctnotxtBox);
            this.Controls.Add(this.accttypeLbl);
            this.Controls.Add(this.pintxtBox);
            this.Controls.Add(this.pinLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.nametxtBox);
            this.Controls.Add(this.createLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createLbl;
        private System.Windows.Forms.TextBox nametxtBox;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label pinLbl;
        private System.Windows.Forms.TextBox pintxtBox;
        private System.Windows.Forms.Label accttypeLbl;
        private System.Windows.Forms.TextBox acctnotxtBox;
        private System.Windows.Forms.Label acctnoLbl;
        private System.Windows.Forms.Button depositBtn;
        private System.Windows.Forms.TextBox amttxtBox;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label amtLbl;
        private System.Windows.Forms.Button doneBtn;
        private System.Windows.Forms.ComboBox accttypeBox;
    }
}