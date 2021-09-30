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
    public partial class MyContactsForm : Form
    {
        IMyContactsOperations contactsOperations;
        public MyContactsForm()
        {
            InitializeComponent();
            contactsOperations = new MyContactOperations();
        }

        private void RefreshContacts_GV()
        {
            Contacts_GV.AutoGenerateColumns = false;
            Contacts_GV.DataSource = contactsOperations.SelectAll();
        }

        private void MyContactsForm_Load(object sender, EventArgs e)
        {
            RefreshContacts_GV();
        }

        private void Refresh_BTN_Click(object sender, EventArgs e)
        {
            RefreshContacts_GV();
        }

        private void AddContact_BTN_Click(object sender, EventArgs e)
        {
            AddAndEditContact_FORM form = new AddAndEditContact_FORM();
            form.Text = "Add contact";
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                RefreshContacts_GV();
            }
        }

        private void Search_INP_KeyUp(object sender, KeyEventArgs e)
        {
            Contacts_GV.DataSource = contactsOperations.Search(Search_INP.Text);
        }

        private void EditContact_BTN_Click(object sender, EventArgs e)
        {
            if (Contacts_GV.CurrentRow != null)
            {
                int id = Convert.ToInt32(Contacts_GV.CurrentRow.Cells[0].Value);

                AddAndEditContact_FORM form = new AddAndEditContact_FORM();
                form.UpdatingContactId = id;
                form.Text = "Edit contact";
                form.ShowDialog();

                if (form.DialogResult == DialogResult.OK)
                {
                    RefreshContacts_GV();
                }
            }
        }

        private void RemoveContact_BTN_Click(object sender, EventArgs e)
        {
            if (Contacts_GV.CurrentRow != null)
            {
                string name = Convert.ToString(Contacts_GV.CurrentRow.Cells[1].Value);
                string family = Convert.ToString(Contacts_GV.CurrentRow.Cells[2].Value);

                if (MessageBox.Show($"Are you sure you want to delete {name} {family}?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(Contacts_GV.CurrentRow.Cells[0].Value);
                    bool isContactDeleted = contactsOperations.Delete(id);
                    if (isContactDeleted)
                    {
                        MessageBox.Show("The contact was deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshContacts_GV();
                    }
                    else
                    {
                        MessageBox.Show("The operation failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a contact!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
