using System.Drawing;
using System.Windows.Forms;

namespace NotebookApp
{
    partial class ContactForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
           
            tabControl    = new TabControl();
            tabPersonal   = new TabPage();
            tabContacts   = new TabPage();
            tabWork       = new TabPage();
            tabExtra      = new TabPage();
            panelButtons  = new Panel();
            btnOk         = new Button();
            btnCancel     = new Button();

           
            lblLastName   = new Label();   txtLastName   = new TextBox();
            lblFirstName  = new Label();   txtFirstName  = new TextBox();
            lblMiddleName = new Label();   txtMiddleName = new TextBox();
            lblBirthDate  = new Label();   dtpBirthDate  = new DateTimePicker();
            lblBirthHint  = new Label();

            
            lblPhone   = new Label();  txtPhone   = new TextBox();
            lblEmail   = new Label();  txtEmail   = new TextBox();
            lblAddress = new Label();  txtAddress = new TextBox();

           
            lblWorkPlace = new Label();  txtWorkPlace = new TextBox();
            lblPosition  = new Label();  txtPosition  = new TextBox();

            lblRelationType      = new Label();
            cmbRelationType      = new ComboBox();
            lblBusinessQualities = new Label();
            txtBusinessQualities = new TextBox();
            lblNotes             = new Label();
            txtNotes             = new TextBox();

            tabControl.SuspendLayout();
            panelButtons.SuspendLayout();
            SuspendLayout();

            
            int lx = 16, ix = 215, iw = 290, rh = 36, sy = 16;
            Font uiFont = new Font("Segoe UI", 9.5f);

            
            tabPersonal.Text    = "👤  Особисті дані";
            tabPersonal.Padding = new Padding(6);

           
            lblLastName.Text      = "Прізвище:";
            lblLastName.Font      = uiFont;
            lblLastName.Location  = new Point(lx, sy + 7);
            lblLastName.AutoSize  = true;
            txtLastName.Font      = uiFont;
            txtLastName.Location  = new Point(ix, sy);
            txtLastName.Size      = new Size(iw, 26);

            lblFirstName.Text     = "Ім'я:";
            lblFirstName.Font     = uiFont;
            lblFirstName.Location = new Point(lx, sy + rh + 7);
            lblFirstName.AutoSize = true;
            txtFirstName.Font     = uiFont;
            txtFirstName.Location = new Point(ix, sy + rh);
            txtFirstName.Size     = new Size(iw, 26);

           
            lblMiddleName.Text     = "По батькові:";
            lblMiddleName.Font     = uiFont;
            lblMiddleName.Location = new Point(lx, sy + rh * 2 + 7);
            lblMiddleName.AutoSize = true;
            txtMiddleName.Font     = uiFont;
            txtMiddleName.Location = new Point(ix, sy + rh * 2);
            txtMiddleName.Size     = new Size(iw, 26);

           
            lblBirthDate.Text     = "Дата народження:";
            lblBirthDate.Font     = uiFont;
            lblBirthDate.Location = new Point(lx, sy + rh * 3 + 7);
            lblBirthDate.AutoSize = true;
            dtpBirthDate.Font     = uiFont;
            dtpBirthDate.Location = new Point(ix, sy + rh * 3);
            dtpBirthDate.Size     = new Size(200, 26);
            dtpBirthDate.Format   = DateTimePickerFormat.Short;
            dtpBirthDate.ShowCheckBox = true;
            dtpBirthDate.Checked  = false;

            lblBirthHint.Text      = "Поставте галочку, щоб задати дату";
            lblBirthHint.Font      = new Font("Segoe UI", 8f, FontStyle.Italic);
            lblBirthHint.ForeColor = Color.Gray;
            lblBirthHint.Location  = new Point(ix, sy + rh * 3 + 28);
            lblBirthHint.AutoSize  = true;

            tabPersonal.Controls.AddRange(new Control[] {
                lblLastName,   txtLastName,
                lblFirstName,  txtFirstName,
                lblMiddleName, txtMiddleName,
                lblBirthDate,  dtpBirthDate, lblBirthHint
            });

            
            tabContacts.Text    = "📞  Контакти";
            tabContacts.Padding = new Padding(6);

            lblPhone.Text     = "Телефон:";
            lblPhone.Font     = uiFont;
            lblPhone.Location = new Point(lx, sy + 7);
            lblPhone.AutoSize = true;
            txtPhone.Font     = uiFont;
            txtPhone.Location = new Point(ix, sy);
            txtPhone.Size     = new Size(iw, 26);

            lblEmail.Text     = "Email:";
            lblEmail.Font     = uiFont;
            lblEmail.Location = new Point(lx, sy + rh + 7);
            lblEmail.AutoSize = true;
            txtEmail.Font     = uiFont;
            txtEmail.Location = new Point(ix, sy + rh);
            txtEmail.Size     = new Size(iw, 26);

            lblAddress.Text      = "Адреса:";
            lblAddress.Font      = uiFont;
            lblAddress.Location  = new Point(lx, sy + rh * 2 + 7);
            lblAddress.AutoSize  = true;
            txtAddress.Font      = uiFont;
            txtAddress.Location  = new Point(ix, sy + rh * 2);
            txtAddress.Size      = new Size(iw, 72);
            txtAddress.Multiline = true;
            txtAddress.ScrollBars = ScrollBars.Vertical;

            tabContacts.Controls.AddRange(new Control[] {
                lblPhone,   txtPhone,
                lblEmail,   txtEmail,
                lblAddress, txtAddress
            });

           
            tabWork.Text    = "🏢  Робота / Навчання";
            tabWork.Padding = new Padding(6);

            lblWorkPlace.Text     = "Місце роботи / навчання:";
            lblWorkPlace.Font     = uiFont;
            lblWorkPlace.Location = new Point(lx, sy + 7);
            lblWorkPlace.AutoSize = true;
            txtWorkPlace.Font     = uiFont;
            txtWorkPlace.Location = new Point(ix, sy);
            txtWorkPlace.Size     = new Size(iw, 26);

            lblPosition.Text     = "Посада / спеціальність:";
            lblPosition.Font     = uiFont;
            lblPosition.Location = new Point(lx, sy + rh + 7);
            lblPosition.AutoSize = true;
            txtPosition.Font     = uiFont;
            txtPosition.Location = new Point(ix, sy + rh);
            txtPosition.Size     = new Size(iw, 26);

            tabWork.Controls.AddRange(new Control[] {
                lblWorkPlace, txtWorkPlace,
                lblPosition,  txtPosition
            });

           
            tabExtra.Text    = "ℹ  Додатково";
            tabExtra.Padding = new Padding(6);

            lblRelationType.Text     = "Статус:";
            lblRelationType.Font     = uiFont;
            lblRelationType.Location = new Point(lx, sy + 7);
            lblRelationType.AutoSize = true;
            cmbRelationType.Font     = uiFont;
            cmbRelationType.Location = new Point(ix, sy);
            cmbRelationType.Size     = new Size(200, 26);
            cmbRelationType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRelationType.Items.AddRange(new object[] {
                "Друг", "Колега", "Родич", "Знайомий", "Інший"
            });
            cmbRelationType.SelectedIndex = 3;

            lblBusinessQualities.Text     = "Ділові якості:";
            lblBusinessQualities.Font     = uiFont;
            lblBusinessQualities.Location = new Point(lx, sy + rh + 7);
            lblBusinessQualities.AutoSize = true;
            txtBusinessQualities.Font     = uiFont;
            txtBusinessQualities.Location = new Point(ix, sy + rh);
            txtBusinessQualities.Size     = new Size(iw, 72);
            txtBusinessQualities.Multiline   = true;
            txtBusinessQualities.ScrollBars  = ScrollBars.Vertical;

            lblNotes.Text     = "Нотатки:";
            lblNotes.Font     = uiFont;
            lblNotes.Location = new Point(lx, sy + rh * 4 + 7);
            lblNotes.AutoSize = true;
            txtNotes.Font     = uiFont;
            txtNotes.Location = new Point(ix, sy + rh * 4);
            txtNotes.Size     = new Size(iw, 80);
            txtNotes.Multiline   = true;
            txtNotes.ScrollBars  = ScrollBars.Vertical;

            tabExtra.Controls.AddRange(new Control[] {
                lblRelationType,      cmbRelationType,
                lblBusinessQualities, txtBusinessQualities,
                lblNotes,             txtNotes
            });

            
            tabControl.Controls.Add(tabPersonal);
            tabControl.Controls.Add(tabContacts);
            tabControl.Controls.Add(tabWork);
            tabControl.Controls.Add(tabExtra);
            tabControl.Dock          = DockStyle.Fill;
            tabControl.Font          = new Font("Segoe UI", 9.5f);
            tabControl.SelectedIndex = 0;
            tabControl.ItemSize      = new Size(155, 28);

           
            panelButtons.BackColor = Color.FromArgb(245, 245, 245);
            panelButtons.Dock      = DockStyle.Bottom;
            panelButtons.Height    = 52;

            
            btnOk.Text      = "💾  Зберегти";
            btnOk.Font      = new Font("Segoe UI", 9.5f);
            btnOk.Location  = new Point(310, 10);
            btnOk.Size      = new Size(130, 32);
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.BackColor = Color.FromArgb(76, 175, 80);
            btnOk.ForeColor = Color.White;
            btnOk.FlatAppearance.BorderSize = 0;
            btnOk.Click += new System.EventHandler(btnOk_Click);

            
            btnCancel.Text      = "Скасувати";
            btnCancel.Font      = new Font("Segoe UI", 9.5f);
            btnCancel.Location  = new Point(450, 10);
            btnCancel.Size      = new Size(110, 32);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.FlatAppearance.BorderColor = Color.Silver;
            btnCancel.Click += new System.EventHandler(btnCancel_Click);

            panelButtons.Controls.AddRange(new Control[] { btnOk, btnCancel });

            
            Text            = "Контакт";
            Size            = new Size(580, 460);
            MinimumSize     = new Size(540, 420);
            StartPosition   = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.Sizable;
            MaximizeBox     = false;
            Font            = new Font("Segoe UI", 9f);

            Controls.Add(tabControl);
            Controls.Add(panelButtons);

            tabControl.ResumeLayout(false);
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

       
        private TabControl   tabControl;
        private TabPage      tabPersonal, tabContacts, tabWork, tabExtra;
        private Panel        panelButtons;
        private Button       btnOk, btnCancel;

        
        private Label         lblLastName,   lblFirstName,  lblMiddleName;
        private Label         lblBirthDate,  lblBirthHint;
        private TextBox       txtLastName,   txtFirstName,  txtMiddleName;
        private DateTimePicker dtpBirthDate;

        
        private Label    lblPhone,   lblEmail,   lblAddress;
        private TextBox  txtPhone,   txtEmail,   txtAddress;

        
        private Label    lblWorkPlace,  lblPosition;
        private TextBox  txtWorkPlace,  txtPosition;

        
        private Label    lblRelationType, lblBusinessQualities, lblNotes;
        private ComboBox cmbRelationType;
        private TextBox  txtBusinessQualities, txtNotes;
    }
}
