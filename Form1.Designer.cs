
namespace MyContacts
{
    partial class MyContactsForm
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
            this.Contacts_GV = new System.Windows.Forms.DataGridView();
            this.ContactId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactFamily = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddContact_BTN = new System.Windows.Forms.Button();
            this.RemoveContact_BTN = new System.Windows.Forms.Button();
            this.EditContact_BTN = new System.Windows.Forms.Button();
            this.Search_INP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Refresh_BTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Contacts_GV)).BeginInit();
            this.SuspendLayout();
            // 
            // Contacts_GV
            // 
            this.Contacts_GV.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.Contacts_GV.AllowUserToAddRows = false;
            this.Contacts_GV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Contacts_GV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Contacts_GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Contacts_GV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ContactId,
            this.ContactName,
            this.ContactFamily,
            this.ContactPhone,
            this.ContactEmail,
            this.ContactAddress});
            this.Contacts_GV.Location = new System.Drawing.Point(12, 134);
            this.Contacts_GV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Contacts_GV.Name = "Contacts_GV";
            this.Contacts_GV.ReadOnly = true;
            this.Contacts_GV.Size = new System.Drawing.Size(760, 397);
            this.Contacts_GV.TabIndex = 0;
            // 
            // ContactId
            // 
            this.ContactId.DataPropertyName = "Id";
            this.ContactId.HeaderText = "Id";
            this.ContactId.Name = "ContactId";
            this.ContactId.ReadOnly = true;
            this.ContactId.Visible = false;
            // 
            // ContactName
            // 
            this.ContactName.DataPropertyName = "Name";
            this.ContactName.HeaderText = "Name";
            this.ContactName.Name = "ContactName";
            this.ContactName.ReadOnly = true;
            // 
            // ContactFamily
            // 
            this.ContactFamily.DataPropertyName = "Family";
            this.ContactFamily.HeaderText = "Family";
            this.ContactFamily.Name = "ContactFamily";
            this.ContactFamily.ReadOnly = true;
            // 
            // ContactPhone
            // 
            this.ContactPhone.DataPropertyName = "Phone";
            this.ContactPhone.HeaderText = "Phone";
            this.ContactPhone.Name = "ContactPhone";
            this.ContactPhone.ReadOnly = true;
            // 
            // ContactEmail
            // 
            this.ContactEmail.DataPropertyName = "Email";
            this.ContactEmail.HeaderText = "Email";
            this.ContactEmail.Name = "ContactEmail";
            this.ContactEmail.ReadOnly = true;
            // 
            // ContactAddress
            // 
            this.ContactAddress.DataPropertyName = "Address";
            this.ContactAddress.HeaderText = "Address";
            this.ContactAddress.Name = "ContactAddress";
            this.ContactAddress.ReadOnly = true;
            // 
            // AddContact_BTN
            // 
            this.AddContact_BTN.BackColor = System.Drawing.Color.SeaGreen;
            this.AddContact_BTN.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.AddContact_BTN.ForeColor = System.Drawing.Color.White;
            this.AddContact_BTN.Location = new System.Drawing.Point(12, 12);
            this.AddContact_BTN.Name = "AddContact_BTN";
            this.AddContact_BTN.Size = new System.Drawing.Size(150, 37);
            this.AddContact_BTN.TabIndex = 1;
            this.AddContact_BTN.Text = "Add contact";
            this.AddContact_BTN.UseVisualStyleBackColor = false;
            this.AddContact_BTN.Click += new System.EventHandler(this.AddContact_BTN_Click);
            // 
            // RemoveContact_BTN
            // 
            this.RemoveContact_BTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.RemoveContact_BTN.Location = new System.Drawing.Point(544, 96);
            this.RemoveContact_BTN.Name = "RemoveContact_BTN";
            this.RemoveContact_BTN.Size = new System.Drawing.Size(72, 30);
            this.RemoveContact_BTN.TabIndex = 4;
            this.RemoveContact_BTN.Text = "Remove";
            this.RemoveContact_BTN.UseVisualStyleBackColor = true;
            this.RemoveContact_BTN.Click += new System.EventHandler(this.RemoveContact_BTN_Click);
            // 
            // EditContact_BTN
            // 
            this.EditContact_BTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.EditContact_BTN.Location = new System.Drawing.Point(622, 96);
            this.EditContact_BTN.Name = "EditContact_BTN";
            this.EditContact_BTN.Size = new System.Drawing.Size(72, 30);
            this.EditContact_BTN.TabIndex = 4;
            this.EditContact_BTN.Text = "Edit";
            this.EditContact_BTN.UseVisualStyleBackColor = true;
            this.EditContact_BTN.Click += new System.EventHandler(this.EditContact_BTN_Click);
            // 
            // Search_INP
            // 
            this.Search_INP.Location = new System.Drawing.Point(12, 100);
            this.Search_INP.Name = "Search_INP";
            this.Search_INP.Size = new System.Drawing.Size(228, 26);
            this.Search_INP.TabIndex = 5;
            this.Search_INP.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Search_INP_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search";
            // 
            // Refresh_BTN
            // 
            this.Refresh_BTN.Location = new System.Drawing.Point(700, 96);
            this.Refresh_BTN.Name = "Refresh_BTN";
            this.Refresh_BTN.Size = new System.Drawing.Size(72, 30);
            this.Refresh_BTN.TabIndex = 7;
            this.Refresh_BTN.Text = "Refresh";
            this.Refresh_BTN.UseVisualStyleBackColor = true;
            this.Refresh_BTN.Click += new System.EventHandler(this.Refresh_BTN_Click);
            // 
            // MyContactsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 545);
            this.Controls.Add(this.Refresh_BTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Search_INP);
            this.Controls.Add(this.EditContact_BTN);
            this.Controls.Add(this.RemoveContact_BTN);
            this.Controls.Add(this.AddContact_BTN);
            this.Controls.Add(this.Contacts_GV);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MyContactsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyContacts";
            this.Load += new System.EventHandler(this.MyContactsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Contacts_GV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Contacts_GV;
        private System.Windows.Forms.Button AddContact_BTN;
        private System.Windows.Forms.Button Refresh_BTN;
        private System.Windows.Forms.Button RemoveContact_BTN;
        private System.Windows.Forms.Button EditContact_BTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactFamily;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactAddress;
        private System.Windows.Forms.TextBox Search_INP;
        private System.Windows.Forms.Label label1;
    }
}

