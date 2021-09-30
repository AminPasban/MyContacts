using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyContacts
{
    public partial class AddAndEditContact_FORM : Form
    {
        IMyContactsOperations contactsOperations;

        public int UpdatingContactId = 0;

        public AddAndEditContact_FORM()
        {
            InitializeComponent();
            contactsOperations = new MyContactOperations();
        }

        private void AddAndEditContact_FORM_Load(object sender, EventArgs e)
        {
            if (UpdatingContactId != 0)
            {
                DataTable updatingContact = contactsOperations.Select(UpdatingContactId);
                Name_INP.Text = Convert.ToString(updatingContact.Rows[0][1]);
                Family_INP.Text = Convert.ToString(updatingContact.Rows[0][2]);
                Phone_INP.Text = Convert.ToString(updatingContact.Rows[0][3]);
                Email_INP.Text = Convert.ToString(updatingContact.Rows[0][4]);
                Address_INP.Text = Convert.ToString(updatingContact.Rows[0][5]);

                AddAndEdit_BTN.Text = "Save Changes";
            }
        }

        private bool validation()
        {
            if (Name_INP.Text == "")
            {
                MessageBox.Show("Please enter contact name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (Family_INP.Text == "")
            {
                MessageBox.Show("Please enter contact family!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (Phone_INP.Text == "")
            {
                MessageBox.Show("Please enter contact phone!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }


        private void AddAndEdit_BTN_Click(object sender, EventArgs e)
        {
            if (validation())
            {
                bool isSuccess = UpdatingContactId != 0 
                    ?
                    contactsOperations.Update(UpdatingContactId, Name_INP.Text, Family_INP.Text, Phone_INP.Text, Email_INP.Text, Address_INP.Text) 
                    :
                    contactsOperations.Insert(Name_INP.Text, Family_INP.Text, Phone_INP.Text, Email_INP.Text, Address_INP.Text);

                if (isSuccess && UpdatingContactId != 0)
                {
                    MessageBox.Show("The changes was saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                else if (isSuccess && UpdatingContactId == 0)
                {
                    MessageBox.Show("The contact was saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("The operation failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
