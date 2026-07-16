namespace FInal_IUIS.Forms
{
    partial class MedicalRecordForm
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvMedicalRecords = new System.Windows.Forms.DataGridView();
            
            // Panel Header - WinUI 3 style
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Height = 80;
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(23, 164, 107);
            
            // Title Label
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Text = "Medical Records Management";
            
            // Panel Content
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Padding = new System.Windows.Forms.Padding(20);
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            
            // DataGridView - Modern styled
            this.dgvMedicalRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMedicalRecords.BackgroundColor = System.Drawing.Color.White;
            this.dgvMedicalRecords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMedicalRecords.RowHeadersVisible = false;
            this.dgvMedicalRecords.AllowUserToAddRows = false;
            this.dgvMedicalRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicalRecords.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvMedicalRecords.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvMedicalRecords.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.dgvMedicalRecords.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.dgvMedicalRecords.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(23, 164, 107);
            this.dgvMedicalRecords.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMedicalRecords.ColumnHeadersHeight = 40;
            this.dgvMedicalRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            
            // Panel Footer
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Height = 70;
            this.panelFooter.BackColor = System.Drawing.Color.White;
            this.panelFooter.Padding = new System.Windows.Forms.Padding(20);
            
            // Button - New
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(34, 197, 94);
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnNew.Size = new System.Drawing.Size(120, 40);
            this.btnNew.Location = new System.Drawing.Point(20, 15);
            this.btnNew.Text = "+ New";
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            
            // Button - Save
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(23, 164, 107);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSave.Size = new System.Drawing.Size(120, 40);
            this.btnSave.Location = new System.Drawing.Point(150, 15);
            this.btnSave.Text = "Save";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            
            // Button - Delete
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Size = new System.Drawing.Size(120, 40);
            this.btnDelete.Location = new System.Drawing.Point(280, 15);
            this.btnDelete.Text = "Delete";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            
            // Form settings
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelHeader);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelContent.Controls.Add(this.dgvMedicalRecords);
            this.panelFooter.Controls.Add(this.btnNew);
            this.panelFooter.Controls.Add(this.btnSave);
            this.panelFooter.Controls.Add(this.btnDelete);
            
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvMedicalRecords;
    }
}
