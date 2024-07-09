using System;
using System.Windows.Forms;

namespace AddressBookApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string contact = $"Name: {name}, Email: {email}, Phone: {phone}";
            lstContacts.Items.Add(contact);

            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
        }
    }
}
