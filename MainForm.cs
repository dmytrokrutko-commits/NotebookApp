using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace NotebookApp
{
    public partial class MainForm : Form
    {
        private readonly ContactRepository _repository;
        private List<Contact>              _currentContacts = new();
        private string                     _currentSearch   = "";
        private SortMode                   _sortMode        = SortMode.Name;

        private enum SortMode { Name, LastModified }

       

        public MainForm()
        {
            InitializeComponent();
            _repository = new ContactRepository();
            LoadContacts();
            CheckBirthdays();
        }

        

        private void LoadContacts()
        {
            List<Contact> found = _repository.Search(_currentSearch);

            _currentContacts = _sortMode == SortMode.Name
                ? _repository.SortByName(found)
                : _repository.SortByLastModified(found);

            RefreshGrid();
        }

        private void RefreshGrid()
        {
            dataGridView.SuspendLayout();
            dataGridView.Rows.Clear();

            foreach (Contact c in _currentContacts)
            {
                string birthday = c.BirthDate.HasValue
                    ? c.BirthDate.Value.ToString("dd.MM.yyyy")
                    : "—";

                string name = c.FullName + (c.HasBirthdayToday() ? "  🎂" : "");

                int idx = dataGridView.Rows.Add(
                    name,
                    c.Phone,
                    c.Email,
                    birthday,
                    c.WorkPlace,
                    c.Position,
                    c.RelationTypeDisplay(),
                    c.LastModified.ToString("dd.MM.yyyy HH:mm")
                );

                if (c.HasBirthdayToday())
                    dataGridView.Rows[idx].DefaultCellStyle.BackColor
                        = Color.FromArgb(255, 253, 225);
            }

            dataGridView.ResumeLayout();
            lblStatus.Text = $"Контактів: {_currentContacts.Count}";
        }



        private void CheckBirthdays()
        {
            List<Contact> today = _repository.GetBirthdaysToday();
            if (today.Count == 0) return;

            string names = string.Join("\n", today.Select(c =>
            {
                string age = c.Age.HasValue ? $" — виповнюється {c.Age} р." : "";
                return $"   • {c.FullName}{age}";
            }));

            MessageBox.Show(
                $"Сьогодні, {DateTime.Today:d MMMM}, день народження у:\n\n{names}\n\n" +
                "Не забудьте привітати!",
                "🎂 День народження",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

    

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using ContactForm form = new ContactForm();
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                _repository.Add(form.Contact);
                LoadContacts();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Contact contact = GetSelectedContact();
            if (contact == null) return;

            using ContactForm form = new ContactForm(contact);
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                _repository.Update(form.Contact);
                LoadContacts();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Contact contact = GetSelectedContact();
            if (contact == null) return;

            DialogResult res = MessageBox.Show(
                $"Видалити контакт «{contact.FullName}»?\nЦю дію не можна скасувати.",
                "Підтвердження видалення",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2
            );

            if (res == DialogResult.Yes)
            {
                _repository.Delete(contact.Id);
                LoadContacts();
            }
        }

        private void btnBirthdays_Click(object sender, EventArgs e)
        {
            CheckBirthdays();
            if (_repository.GetBirthdaysToday().Count == 0)
                MessageBox.Show(
                    $"Сьогодні ({DateTime.Today:dd.MM.yyyy}) ні в кого з контактів немає дня народження.",
                    "Дні народження",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
        }

      

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            _currentSearch = txtSearch.Text.Trim();
            LoadContacts();
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

   

        private void btnSortName_Click(object sender, EventArgs e)
        {
            _sortMode = SortMode.Name;
            UpdateSortButtons();
            LoadContacts();
        }

        private void btnSortDate_Click(object sender, EventArgs e)
        {
            _sortMode = SortMode.LastModified;
            UpdateSortButtons();
            LoadContacts();
        }

        private void UpdateSortButtons()
        {
        
            btnSortName.BackColor = _sortMode == SortMode.Name
                ? Color.FromArgb(33, 150, 243)
                : SystemColors.Control;
            btnSortName.ForeColor = _sortMode == SortMode.Name
                ? Color.White
                : SystemColors.ControlText;

            btnSortDate.BackColor = _sortMode == SortMode.LastModified
                ? Color.FromArgb(33, 150, 243)
                : SystemColors.Control;
            btnSortDate.ForeColor = _sortMode == SortMode.LastModified
                ? Color.White
                : SystemColors.ControlText;
        }

       

        private void dataGridView_CellDoubleClick(object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) btnEdit_Click(sender, e);
        }

      

        private void tsmiEdit_Click(object sender, EventArgs e)   => btnEdit_Click(sender, e);
        private void tsmiDelete_Click(object sender, EventArgs e)  => btnDelete_Click(sender, e);
        private void tsmiAdd_Click(object sender, EventArgs e)     => btnAdd_Click(sender, e);

      

        private Contact GetSelectedContact()
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Спочатку оберіть контакт у списку.",
                    "Немає вибору",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return null;
            }

            int idx = dataGridView.SelectedRows[0].Index;
            if (idx >= 0 && idx < _currentContacts.Count)
                return _currentContacts[idx];

            return null;
        }
    }
}
