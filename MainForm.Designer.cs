using System.Drawing;
using System.Windows.Forms;

namespace NotebookApp
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();

         
            panelTop         = new Panel();
            panelBottom      = new Panel();
            dataGridView     = new DataGridView();

            lblSearch        = new Label();
            txtSearch        = new TextBox();
            btnClearSearch   = new Button();
            btnSortName      = new Button();
            btnSortDate      = new Button();
            btnBirthdays     = new Button();

            btnAdd           = new Button();
            btnEdit          = new Button();
            btnDelete        = new Button();
            lblStatus        = new Label();

         
            colName          = new DataGridViewTextBoxColumn();
            colPhone         = new DataGridViewTextBoxColumn();
            colEmail         = new DataGridViewTextBoxColumn();
            colBirthDate     = new DataGridViewTextBoxColumn();
            colWorkPlace     = new DataGridViewTextBoxColumn();
            colPosition      = new DataGridViewTextBoxColumn();
            colRelationType  = new DataGridViewTextBoxColumn();
            colLastModified  = new DataGridViewTextBoxColumn();

          
            contextMenu      = new ContextMenuStrip(components);
            tsmiAdd          = new ToolStripMenuItem();
            tsmiEdit         = new ToolStripMenuItem();
            tsmiDelete       = new ToolStripMenuItem();

            panelTop.SuspendLayout();
            panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();

           
            panelTop.BackColor = Color.FromArgb(245, 245, 245);
            panelTop.Dock      = DockStyle.Top;
            panelTop.Height    = 56;
            panelTop.Padding   = new Padding(8, 0, 8, 0);
            panelTop.Controls.AddRange(new Control[] {
                lblSearch, txtSearch, btnClearSearch,
                btnSortName, btnSortDate, btnBirthdays
            });

           
            lblSearch.Text      = "🔍  Пошук:";
            lblSearch.Font      = new Font("Segoe UI", 9.5f);
            lblSearch.Location  = new Point(12, 18);
            lblSearch.AutoSize  = true;

           
            txtSearch.Font      = new Font("Segoe UI", 10f);
            txtSearch.Location  = new Point(100, 14);
            txtSearch.Size      = new Size(260, 26);
            txtSearch.TextChanged += new System.EventHandler(txtSearch_TextChanged);

            
            btnClearSearch.Text      = "✕";
            btnClearSearch.Font      = new Font("Segoe UI", 9f);
            btnClearSearch.Location  = new Point(368, 14);
            btnClearSearch.Size      = new Size(26, 26);
            btnClearSearch.FlatStyle = FlatStyle.Flat;
            btnClearSearch.FlatAppearance.BorderColor = Color.Silver;
            btnClearSearch.Click += new System.EventHandler(btnClearSearch_Click);

           
            btnSortName.Text      = "↑ А–Я  (за алфавітом)";
            btnSortName.Font      = new Font("Segoe UI", 9f);
            btnSortName.Location  = new Point(410, 13);
            btnSortName.Size      = new Size(175, 30);
            btnSortName.FlatStyle = FlatStyle.Flat;
            btnSortName.BackColor = Color.FromArgb(33, 150, 243);
            btnSortName.ForeColor = Color.White;
            btnSortName.FlatAppearance.BorderSize = 0;
            btnSortName.Click += new System.EventHandler(btnSortName_Click);

          
            btnSortDate.Text      = "🕑  За датою змін";
            btnSortDate.Font      = new Font("Segoe UI", 9f);
            btnSortDate.Location  = new Point(594, 13);
            btnSortDate.Size      = new Size(155, 30);
            btnSortDate.FlatStyle = FlatStyle.Flat;
            btnSortDate.FlatAppearance.BorderColor = Color.Silver;
            btnSortDate.Click += new System.EventHandler(btnSortDate_Click);

           
            btnBirthdays.Text      = "🎂  Дні народження";
            btnBirthdays.Font      = new Font("Segoe UI", 9f);
            btnBirthdays.Location  = new Point(758, 13);
            btnBirthdays.Size      = new Size(165, 30);
            btnBirthdays.FlatStyle = FlatStyle.Flat;
            btnBirthdays.BackColor = Color.FromArgb(255, 193, 7);
            btnBirthdays.ForeColor = Color.FromArgb(50, 50, 50);
            btnBirthdays.FlatAppearance.BorderSize = 0;
            btnBirthdays.Click += new System.EventHandler(btnBirthdays_Click);

            
            dataGridView.AllowUserToAddRows          = false;
            dataGridView.AllowUserToDeleteRows       = false;
            dataGridView.AllowUserToResizeRows       = false;
            dataGridView.ReadOnly                    = true;
            dataGridView.SelectionMode               = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.MultiSelect                 = false;
            dataGridView.RowHeadersVisible           = false;
            dataGridView.AutoSizeColumnsMode         = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.BorderStyle                 = BorderStyle.None;
            dataGridView.Dock                        = DockStyle.Fill;
            dataGridView.Font                        = new Font("Segoe UI", 9.5f);
            dataGridView.ContextMenuStrip            = contextMenu;
            dataGridView.CellDoubleClick += new DataGridViewCellEventHandler(dataGridView_CellDoubleClick);

            
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor  = Color.FromArgb(55, 71, 79);
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor  = Color.White;
            dataGridView.ColumnHeadersDefaultCellStyle.Font       = new Font("Segoe UI", 9.5f, FontStyle.Bold);
            dataGridView.EnableHeadersVisualStyles                 = false;

            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250);

            
            colName.HeaderText   = "ПІБ";             colName.FillWeight  = 20;
            colPhone.HeaderText  = "Телефон";          colPhone.FillWeight = 12;
            colEmail.HeaderText  = "Email";            colEmail.FillWeight = 14;
            colBirthDate.HeaderText = "Дата народж."; colBirthDate.FillWeight = 10;
            colWorkPlace.HeaderText = "Місце роботи/навч."; colWorkPlace.FillWeight = 16;
            colPosition.HeaderText  = "Посада";        colPosition.FillWeight  = 12;
            colRelationType.HeaderText = "Статус"; colRelationType.FillWeight = 9;
            colLastModified.HeaderText = "Змінено";    colLastModified.FillWeight = 12;

            dataGridView.Columns.AddRange(
                colName, colPhone, colEmail, colBirthDate,
                colWorkPlace, colPosition, colRelationType, colLastModified
            );

            
            tsmiAdd.Text    = "➕  Додати контакт";
            tsmiEdit.Text   = "✎  Редагувати";
            tsmiDelete.Text = "🗑  Видалити";
            tsmiAdd.Click    += new System.EventHandler(tsmiAdd_Click);
            tsmiEdit.Click   += new System.EventHandler(tsmiEdit_Click);
            tsmiDelete.Click += new System.EventHandler(tsmiDelete_Click);
            contextMenu.Items.AddRange(new ToolStripItem[] { tsmiAdd, tsmiEdit, tsmiDelete });

            
            panelBottom.BackColor = Color.FromArgb(245, 245, 245);
            panelBottom.Dock      = DockStyle.Bottom;
            panelBottom.Height    = 54;
            panelBottom.Controls.AddRange(new Control[] { btnAdd, btnEdit, btnDelete, lblStatus });

           
            btnAdd.Text      = "➕  Додати";
            btnAdd.Font      = new Font("Segoe UI", 9.5f);
            btnAdd.Location  = new Point(12, 12);
            btnAdd.Size      = new Size(110, 32);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.BackColor = Color.FromArgb(76, 175, 80);
            btnAdd.ForeColor = Color.White;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.Click += new System.EventHandler(btnAdd_Click);

            
            btnEdit.Text      = "✎  Редагувати";
            btnEdit.Font      = new Font("Segoe UI", 9.5f);
            btnEdit.Location  = new Point(132, 12);
            btnEdit.Size      = new Size(130, 32);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.BackColor = Color.FromArgb(33, 150, 243);
            btnEdit.ForeColor = Color.White;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.Click += new System.EventHandler(btnEdit_Click);

            
            btnDelete.Text      = "🗑  Видалити";
            btnDelete.Font      = new Font("Segoe UI", 9.5f);
            btnDelete.Location  = new Point(272, 12);
            btnDelete.Size      = new Size(115, 32);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.BackColor = Color.FromArgb(244, 67, 54);
            btnDelete.ForeColor = Color.White;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.Click += new System.EventHandler(btnDelete_Click);

            
            lblStatus.Text      = "Контактів: 0";
            lblStatus.Font      = new Font("Segoe UI", 9f);
            lblStatus.ForeColor = Color.Gray;
            lblStatus.Location  = new Point(400, 20);
            lblStatus.AutoSize  = true;

            
            Text            = "📒  Записна книжка";
            Size            = new Size(1050, 640);
            MinimumSize     = new Size(800, 480);
            StartPosition   = FormStartPosition.CenterScreen;
            Font            = new Font("Segoe UI", 9f);

            Controls.Add(dataGridView);
            Controls.Add(panelTop);
            Controls.Add(panelBottom);

            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelBottom.ResumeLayout(false);
            panelBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        
        private Panel               panelTop;
        private Panel               panelBottom;
        private DataGridView        dataGridView;

        private Label               lblSearch;
        private TextBox             txtSearch;
        private Button              btnClearSearch;
        private Button              btnSortName;
        private Button              btnSortDate;
        private Button              btnBirthdays;

        private Button              btnAdd;
        private Button              btnEdit;
        private Button              btnDelete;
        private Label               lblStatus;

        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colBirthDate;
        private DataGridViewTextBoxColumn colWorkPlace;
        private DataGridViewTextBoxColumn colPosition;
        private DataGridViewTextBoxColumn colRelationType;
        private DataGridViewTextBoxColumn colLastModified;

        private ContextMenuStrip    contextMenu;
        private ToolStripMenuItem   tsmiAdd;
        private ToolStripMenuItem   tsmiEdit;
        private ToolStripMenuItem   tsmiDelete;
    }
}
