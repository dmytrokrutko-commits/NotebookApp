using System;
using System.Windows.Forms;

namespace NotebookApp
{
  
  
    public partial class ContactForm : Form
    {
        public Contact Contact { get; private set; }

       

        public ContactForm()
        {
            InitializeComponent();
            Contact   = new Contact();
            Text      = "Новий контакт";
        }

      

        public ContactForm(Contact contact)
        {
            InitializeComponent();
            Contact = CloneContact(contact);
            Text    = $"Редагування — {contact.FullName}";
            LoadContactData();
        }

        

        private void LoadContactData()
        {
           
            txtLastName.Text   = Contact.LastName;
            txtFirstName.Text  = Contact.FirstName;
            txtMiddleName.Text = Contact.MiddleName;

            if (Contact.BirthDate.HasValue)
            {
                dtpBirthDate.Checked = true;
                dtpBirthDate.Value   = Contact.BirthDate.Value;
            }
            else
            {
                dtpBirthDate.Checked = false;
            }

            
            txtPhone.Text   = Contact.Phone;
            txtEmail.Text   = Contact.Email;
            txtAddress.Text = Contact.Address;

            
            txtWorkPlace.Text = Contact.WorkPlace;
            txtPosition.Text  = Contact.Position;

            
            cmbRelationType.SelectedIndex = (int)Contact.RelationType;
            txtBusinessQualities.Text     = Contact.BusinessQualities;
            txtNotes.Text                 = Contact.Notes;
        }

        

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text) &&
                string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show(
                    "Будь ласка, введіть принаймні ім'я або прізвище контакту.",
                    "Перевірка даних",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                tabControl.SelectedIndex = 0;
                txtLastName.Focus();
                return;
            }
            if (dtpBirthDate.Checked && dtpBirthDate.Value.Date > DateTime.Today)
            {
                MessageBox.Show(

                    "Дата народження не може бути в майбутньому.",
                    "Перевірка даних",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                tabControl.SelectedIndex = 0;
                dtpBirthDate.Focus();
                return;
            }


            
            Contact.LastName   = txtLastName.Text.Trim();
            Contact.FirstName  = txtFirstName.Text.Trim();
            Contact.MiddleName = txtMiddleName.Text.Trim();
            Contact.BirthDate  = dtpBirthDate.Checked
                ? dtpBirthDate.Value.Date
                : (DateTime?)null;

            
            Contact.Phone   = txtPhone.Text.Trim();
            Contact.Email   = txtEmail.Text.Trim();
            Contact.Address = txtAddress.Text.Trim();

            
            Contact.WorkPlace = txtWorkPlace.Text.Trim();
            Contact.Position  = txtPosition.Text.Trim();

            
            Contact.RelationType      = (RelationType)cmbRelationType.SelectedIndex;
            Contact.BusinessQualities = txtBusinessQualities.Text.Trim();
            Contact.Notes             = txtNotes.Text.Trim();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        

        private static Contact CloneContact(Contact src) => new Contact
        {
            Id                = src.Id,
            LastName          = src.LastName,
            FirstName         = src.FirstName,
            MiddleName        = src.MiddleName,
            BirthDate         = src.BirthDate,
            Phone             = src.Phone,
            Email             = src.Email,
            Address           = src.Address,
            WorkPlace         = src.WorkPlace,
            Position          = src.Position,
            RelationType      = src.RelationType,
            BusinessQualities = src.BusinessQualities,
            Notes             = src.Notes,
            CreatedAt         = src.CreatedAt,
            LastModified      = src.LastModified
        };
    }
}
