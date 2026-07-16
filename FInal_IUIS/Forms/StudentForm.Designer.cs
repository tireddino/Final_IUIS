namespace FInal_IUIS.Forms
{
    partial class StudentForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearchIcon = new System.Windows.Forms.Label();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.panelContent = new System.Windows.Forms.Panel();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.flowLayoutPanelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            
            // ============================================
            // PANEL HEADER - WinUI 3 Style with Accent Color
            // ============================================
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Height = 100;
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(47, 109, 245); // WinUI Blue accent
            this.panelHeader.Padding = new System.Windows.Forms.Padding(30, 20, 30, 0);
            
            // Title Label - Large, bold, modern typography
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Variable", 26F, System.Drawing.FontStyle.SemiBold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(30, 18);
            this.lblTitle.Text = "Student Management";
            this.lblTitle.TabIndex = 0;
            
            // Subtitle Label - Smaller, lighter text for context
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI Variable", 11F, System.Drawing.FontStyle.Regular);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(200, 220, 255);
            this.lblSubtitle.Location = new System.Drawing.Point(32, 52);
            this.lblSubtitle.Text = "Manage student records, enrollment status, and personal information";
            this.lblSubtitle.TabIndex = 1;
            
            // ============================================
            // SEARCH PANEL - Modern rounded search bar
            // ============================================
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Height = 60;
            this.panelSearch.BackColor = System.Drawing.Color.White;
            this.panelSearch.Padding = new System.Windows.Forms.Padding(30, 10, 30, 10);
            
            // Search Icon Label (simulated with text)
            this.lblSearchIcon.AutoSize = true;
            this.lblSearchIcon.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14F);
            this.lblSearchIcon.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
            this.lblSearchIcon.Text = "\uE721"; // Search icon from Segoe MDL2 Assets
            this.lblSearchIcon.Location = new System.Drawing.Point(45, 20);
            this.lblSearchIcon.Size = new System.Drawing.Size(20, 20);
            this.lblSearchIcon.TabIndex = 2;
            
            // Search TextBox - Rounded corners simulation with padding
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI Variable", 12F, System.Drawing.FontStyle.Regular);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(243, 243, 243);
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Location = new System.Drawing.Point(75, 18);
            this.txtSearch.Size = new System.Drawing.Size(350, 27);
            this.txtSearch.Padding = new System.Windows.Forms.Padding(15, 8, 15, 8);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.PlaceholderText = "Search by name, ID, or course...";
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            
            // Filter ComboBox
            this.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilter.Font = new System.Drawing.Font("Segoe UI Variable", 11F, System.Drawing.FontStyle.Regular);
            this.cmbFilter.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.cmbFilter.BackColor = System.Drawing.Color.FromArgb(243, 243, 243);
            this.cmbFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFilter.Location = new System.Drawing.Point(450, 18);
            this.cmbFilter.Size = new System.Drawing.Size(200, 30);
            this.cmbFilter.TabIndex = 4;
            this.cmbFilter.Items.AddRange(new object[] { "All Students", "Active", "Inactive", "Graduated" });
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.CmbFilter_SelectedIndexChanged);
            
            // ============================================
            // CONTENT PANEL - Light background for content area
            // ============================================
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(249, 249, 249); // WinUI light gray
            this.panelContent.Padding = new System.Windows.Forms.Padding(30, 0, 30, 30);
            
            // ============================================
            // DATA GRID VIEW - WinUI 3 styled table
            // ============================================
            this.dgvStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudents.BackgroundColor = System.Drawing.Color.White;
            this.dgvStudents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStudents.RowHeadersVisible = false;
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.AllowUserToResizeRows = false;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.MultiSelect = false;
            this.dgvStudents.ReadOnly = true;
            
            // Default cell style
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Variable", 11F, System.Drawing.FontStyle.Regular);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(220, 235, 255);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.dgvStudents.DefaultCellStyle = dataGridViewCellStyle1;
            
            // Alternating row style
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(220, 235, 255);
            this.dgvStudents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            
            // Column header style - Modern flat appearance
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Variable", 11F, System.Drawing.FontStyle.SemiBold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(47, 109, 245);
            dataGridViewCellStyle3.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dgvStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            
            this.dgvStudents.ColumnHeadersHeight = 45;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStudents.EnableHeadersVisualStyles = false;
            this.dgvStudents.GridColor = System.Drawing.Color.FromArgb(235, 235, 235);
            
            // Row height for better readability
            this.dgvStudents.RowTemplate.Height = 45;
            
            // Selection visual
            this.dgvStudents.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(220, 235, 255);
            this.dgvStudents.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            
            // ============================================
            // FOOTER PANEL - Action buttons area
            // ============================================
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Height = 80;
            this.panelFooter.BackColor = System.Drawing.Color.White;
            this.panelFooter.Padding = new System.Windows.Forms.Padding(30, 15, 30, 15);
            
            // Flow Layout Panel for buttons
            this.flowLayoutPanelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelButtons.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.flowLayoutPanelButtons.WrapContents = false;
            this.flowLayoutPanelButtons.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.flowLayoutPanelButtons.BackColor = System.Drawing.Color.Transparent;
            
            // Button Base Style Helper
            Action<System.Windows.Forms.Button, System.Drawing.Color, string> configureButton = (btn, color, text) =>
            {
                btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatAppearance.MouseOverBackColor = ControlPaint.Light(color, 0.1f);
                btn.BackColor = color;
                btn.ForeColor = System.Drawing.Color.White;
                btn.Font = new System.Drawing.Font("Segoe UI Variable", 11F, System.Drawing.FontStyle.SemiBold);
                btn.Size = new System.Drawing.Size(130, 42);
                btn.Cursor = System.Windows.Forms.Cursors.Hand;
                btn.Text = text;
                btn.UseVisualStyleBackColor = false;
            };
            
            // Button - New (Green)
            configureButton(this.btnNew, System.Drawing.Color.FromArgb(16, 185, 129), "+ New Student");
            this.btnNew.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.btnNew.TabIndex = 5;
            
            // Button - Save (Blue)
            configureButton(this.btnSave, System.Drawing.Color.FromArgb(47, 109, 245), "💾 Save");
            this.btnSave.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.btnSave.TabIndex = 6;
            
            // Button - Edit (Purple)
            configureButton(this.btnEdit, System.Drawing.Color.FromArgb(139, 92, 246), "✏️ Edit");
            this.btnEdit.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.btnEdit.TabIndex = 7;
            
            // Button - Delete (Red)
            configureButton(this.btnDelete, System.Drawing.Color.FromArgb(239, 68, 68), "🗑️ Delete");
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.btnDelete.TabIndex = 8;
            
            // Button - Refresh (Gray)
            configureButton(this.btnRefresh, System.Drawing.Color.FromArgb(100, 100, 100), "🔄 Refresh");
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.btnRefresh.TabIndex = 9;
            
            // Button - Export (Teal)
            configureButton(this.btnExport, System.Drawing.Color.FromArgb(20, 184, 166), "📊 Export");
            this.btnExport.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.btnExport.TabIndex = 10;
            
            // Add buttons to flow layout
            this.flowLayoutPanelButtons.Controls.Add(this.btnNew);
            this.flowLayoutPanelButtons.Controls.Add(this.btnSave);
            this.flowLayoutPanelButtons.Controls.Add(this.btnEdit);
            this.flowLayoutPanelButtons.Controls.Add(this.btnDelete);
            this.flowLayoutPanelButtons.Controls.Add(this.btnRefresh);
            this.flowLayoutPanelButtons.Controls.Add(this.btnExport);
            
            // ============================================
            // FORM SETTINGS
            // ============================================
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelHeader);
            
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.lblSubtitle);
            this.panelSearch.Controls.Add(this.lblSearchIcon);
            this.panelSearch.Controls.Add(this.txtSearch);
            this.panelSearch.Controls.Add(this.cmbFilter);
            this.panelContent.Controls.Add(this.dgvStudents);
            this.panelFooter.Controls.Add(this.flowLayoutPanelButtons);
            
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "StudentForm";
            this.Text = "Student Management - IUIS";
            this.Icon = null; // Set appropriate icon if available
        }

        // Controls
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearchIcon;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtons;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnExport;
    }
}
