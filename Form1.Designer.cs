
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
            ((System.ComponentModel.ISupportInitialize)(this.Contacts_GV)).BeginInit();
            this.SuspendLayout();
            // 
            // Contacts_GV
            // 
            this.Contacts_GV.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.Contacts_GV.AllowUserToAddRows = false;
            this.Contacts_GV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Contacts_GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Contacts_GV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ContactId,
            this.ContactName,
            this.ContactFamily,
            this.ContactPhone,
            this.ContactEmail,
            this.ContactAddress});
            this.Contacts_GV.Location = new System.Drawing.Point(13, 152);
            this.Contacts_GV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Contacts_GV.Name = "Contacts_GV";
            this.Contacts_GV.ReadOnly = true;
            this.Contacts_GV.Size = new System.Drawing.Size(758, 395);
            this.Contacts_GV.TabIndex = 0;
            // 
            // ContactId
            // 
            this.ContactId.DataPropertyName = "Id";
            this.ContactId.HeaderText = "Id";
            this.ContactId.Name = "ContactId";
            this.ContactId.ReadOnly = true;
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
            // MyContactsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
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

        }

        #endregion

        private System.Windows.Forms.DataGridView Contacts_GV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactFamily;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactAddress;
    }
}

