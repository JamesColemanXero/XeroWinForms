using System;
using System.Windows.Forms;
using Xero.Api.Core.Model;

namespace XeroWinForm
{
    public partial class XeroWinForm : Form
    {
        public XeroWinForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /// first create an instance of the Xero API
            var api = new Xero.Api.Example.Applications.Private.Core(false);

            // create an instance of contact
            Contact newContact = new Contact();
            newContact.Name = "Metal Fencing"; // company name
            newContact.FirstName = "John"; // first name
            newContact.LastName = "Smith"; // last name
            newContact.EmailAddress = "john@metalfencing.com"; // email

            // call the API to create the contact
            api.Contacts.Create(newContact);
        }
    }


}
