namespace Parcial2EOGJ
{
    partial class FrmContact
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
            this.lblId = new System.Windows.Forms.Label();
            this.grpBoxContact = new System.Windows.Forms.GroupBox();
            this.grpBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxCountry = new System.Windows.Forms.TextBox();
            this.txtBoxCity = new System.Windows.Forms.TextBox();
            this.txtBoxAddress = new System.Windows.Forms.TextBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.grpBoxContact.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(6, 31);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id";
            this.lblId.Click += new System.EventHandler(this.label1_Click);
            // 
            // grpBoxContact
            // 
            this.grpBoxContact.Controls.Add(this.grpBoxEmail);
            this.grpBoxContact.Controls.Add(this.txtBoxCountry);
            this.grpBoxContact.Controls.Add(this.txtBoxCity);
            this.grpBoxContact.Controls.Add(this.txtBoxAddress);
            this.grpBoxContact.Controls.Add(this.txtBoxName);
            this.grpBoxContact.Controls.Add(this.txtBoxId);
            this.grpBoxContact.Controls.Add(this.lblEmail);
            this.grpBoxContact.Controls.Add(this.lblCountry);
            this.grpBoxContact.Controls.Add(this.lblCity);
            this.grpBoxContact.Controls.Add(this.lblAddress);
            this.grpBoxContact.Controls.Add(this.lblName);
            this.grpBoxContact.Controls.Add(this.lblId);
            this.grpBoxContact.Location = new System.Drawing.Point(380, 40);
            this.grpBoxContact.Name = "grpBoxContact";
            this.grpBoxContact.Size = new System.Drawing.Size(321, 370);
            this.grpBoxContact.TabIndex = 1;
            this.grpBoxContact.TabStop = false;
            this.grpBoxContact.Text = "Contact";
            this.grpBoxContact.Enter += new System.EventHandler(this.grpBoxContact_Enter);
            // 
            // grpBoxEmail
            // 
            this.grpBoxEmail.Location = new System.Drawing.Point(68, 228);
            this.grpBoxEmail.Name = "grpBoxEmail";
            this.grpBoxEmail.Size = new System.Drawing.Size(100, 20);
            this.grpBoxEmail.TabIndex = 1;
            this.grpBoxEmail.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtBoxCountry
            // 
            this.txtBoxCountry.Location = new System.Drawing.Point(68, 191);
            this.txtBoxCountry.Name = "txtBoxCountry";
            this.txtBoxCountry.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCountry.TabIndex = 1;
            this.txtBoxCountry.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtBoxCity
            // 
            this.txtBoxCity.Location = new System.Drawing.Point(68, 158);
            this.txtBoxCity.Name = "txtBoxCity";
            this.txtBoxCity.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCity.TabIndex = 1;
            this.txtBoxCity.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtBoxAddress
            // 
            this.txtBoxAddress.Location = new System.Drawing.Point(68, 112);
            this.txtBoxAddress.Name = "txtBoxAddress";
            this.txtBoxAddress.Size = new System.Drawing.Size(100, 20);
            this.txtBoxAddress.TabIndex = 1;
            this.txtBoxAddress.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(49, 73);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxName.TabIndex = 1;
            // 
            // txtBoxId
            // 
            this.txtBoxId.Location = new System.Drawing.Point(49, 31);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.Size = new System.Drawing.Size(100, 20);
            this.txtBoxId.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 231);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(31, 13);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "email";
            this.lblEmail.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(6, 198);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(43, 13);
            this.lblCountry.TabIndex = 0;
            this.lblCountry.Text = "Country";
            this.lblCountry.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(6, 158);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 0;
            this.lblCity.Text = "City";
            this.lblCity.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(6, 119);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Address";
            this.lblAddress.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 76);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            this.lblName.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 588);
            this.Controls.Add(this.grpBoxContact);
            this.Name = "FrmContact";
            this.Text = "FrmProyecto";
            this.grpBoxContact.ResumeLayout(false);
            this.grpBoxContact.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpBoxContact;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtBoxAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtBoxCity;
        private System.Windows.Forms.TextBox txtBoxCountry;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox grpBoxEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblId;
    }
}