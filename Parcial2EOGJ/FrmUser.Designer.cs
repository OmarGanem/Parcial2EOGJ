namespace Parcial2EOGJ
{
    partial class FrmUser
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
            this.grpBoxUser = new System.Windows.Forms.GroupBox();
            this.txtBoxAddress = new System.Windows.Forms.TextBox();
            this.txtBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.txtBoxUserName = new System.Windows.Forms.TextBox();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.lblAddres = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.grpBoxUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxUser
            // 
            this.grpBoxUser.Controls.Add(this.txtBoxAddress);
            this.grpBoxUser.Controls.Add(this.txtBoxPhoneNumber);
            this.grpBoxUser.Controls.Add(this.txtBoxEmail);
            this.grpBoxUser.Controls.Add(this.txtBoxPassword);
            this.grpBoxUser.Controls.Add(this.txtBoxUserName);
            this.grpBoxUser.Controls.Add(this.txtBoxId);
            this.grpBoxUser.Controls.Add(this.lblAddres);
            this.grpBoxUser.Controls.Add(this.lblPhoneNumber);
            this.grpBoxUser.Controls.Add(this.lblEmail);
            this.grpBoxUser.Controls.Add(this.lblPassword);
            this.grpBoxUser.Controls.Add(this.lblUserName);
            this.grpBoxUser.Controls.Add(this.lblId);
            this.grpBoxUser.Location = new System.Drawing.Point(475, 101);
            this.grpBoxUser.Name = "grpBoxUser";
            this.grpBoxUser.Size = new System.Drawing.Size(321, 370);
            this.grpBoxUser.TabIndex = 5;
            this.grpBoxUser.TabStop = false;
            this.grpBoxUser.Text = "User";
            this.grpBoxUser.Enter += new System.EventHandler(this.grpBoxUser_Enter);
            // 
            // txtBoxAddress
            // 
            this.txtBoxAddress.Location = new System.Drawing.Point(111, 228);
            this.txtBoxAddress.Name = "txtBoxAddress";
            this.txtBoxAddress.Size = new System.Drawing.Size(100, 20);
            this.txtBoxAddress.TabIndex = 1;
            // 
            // txtBoxPhoneNumber
            // 
            this.txtBoxPhoneNumber.Location = new System.Drawing.Point(111, 195);
            this.txtBoxPhoneNumber.Name = "txtBoxPhoneNumber";
            this.txtBoxPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPhoneNumber.TabIndex = 1;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(111, 155);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(100, 20);
            this.txtBoxEmail.TabIndex = 1;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(111, 116);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPassword.TabIndex = 1;
            // 
            // txtBoxUserName
            // 
            this.txtBoxUserName.Location = new System.Drawing.Point(111, 69);
            this.txtBoxUserName.Name = "txtBoxUserName";
            this.txtBoxUserName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxUserName.TabIndex = 1;
            // 
            // txtBoxId
            // 
            this.txtBoxId.Location = new System.Drawing.Point(111, 28);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.Size = new System.Drawing.Size(100, 20);
            this.txtBoxId.TabIndex = 1;
            // 
            // lblAddres
            // 
            this.lblAddres.AutoSize = true;
            this.lblAddres.Location = new System.Drawing.Point(6, 231);
            this.lblAddres.Name = "lblAddres";
            this.lblAddres.Size = new System.Drawing.Size(45, 13);
            this.lblAddres.TabIndex = 0;
            this.lblAddres.Text = "Address";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(6, 198);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.lblPhoneNumber.TabIndex = 0;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 158);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(6, 119);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Password";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(6, 76);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(60, 13);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "User Name";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(6, 31);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id";
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 661);
            this.Controls.Add(this.grpBoxUser);
            this.Name = "FrmUser";
            this.Text = "FrmUser";
            this.grpBoxUser.ResumeLayout(false);
            this.grpBoxUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxUser;
        private System.Windows.Forms.TextBox txtBoxAddress;
        private System.Windows.Forms.TextBox txtBoxPhoneNumber;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.TextBox txtBoxUserName;
        private System.Windows.Forms.TextBox txtBoxId;
        private System.Windows.Forms.Label lblAddres;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblId;
    }
}