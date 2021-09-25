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

        private void MyContactsForm_Load(object sender, EventArgs e)
        {
            Contacts_GV.AutoGenerateColumns = false;
            Contacts_GV.DataSource = contactsOperations.SelectAll();
        }
    }
}
