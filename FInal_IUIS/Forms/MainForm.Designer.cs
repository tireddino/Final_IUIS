namespace FInal_IUIS.Forms
{
    partial class MainForm
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
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.flowLayoutPanelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnCourses = new System.Windows.Forms.Button();
            this.btnInstructors = new System.Windows.Forms.Button();
            this.btnEnrollments = new System.Windows.Forms.Button();
            this.lblAppName = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelSidebar.SuspendLayout();
            this.flowLayoutPanelMenu.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.panelSidebar.Controls.Add(this.flowLayoutPanelMenu);
            this.panelSidebar.Controls.Add(this.lblAppName);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.panelSidebar.Size = new System.Drawing.Size(250, 720);
            this.panelSidebar.TabIndex = 2;
            // 
            // flowLayoutPanelMenu
            // 
            this.flowLayoutPanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.flowLayoutPanelMenu.Controls.Add(this.btnStudents);
            this.flowLayoutPanelMenu.Controls.Add(this.btnCourses);
            this.flowLayoutPanelMenu.Controls.Add(this.btnInstructors);
            this.flowLayoutPanelMenu.Controls.Add(this.btnEnrollments);
            this.flowLayoutPanelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelMenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelMenu.Location = new System.Drawing.Point(0, 20);
            this.flowLayoutPanelMenu.Name = "flowLayoutPanelMenu";
            this.flowLayoutPanelMenu.Padding = new System.Windows.Forms.Padding(15, 80, 15, 0);
            this.flowLayoutPanelMenu.Size = new System.Drawing.Size(250, 700);
            this.flowLayoutPanelMenu.TabIndex = 0;
            this.flowLayoutPanelMenu.WrapContents = false;
            // 
            // btnStudents
            // 
            this.btnStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.btnStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudents.FlatAppearance.BorderSize = 0;
            this.btnStudents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudents.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnStudents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.btnStudents.Location = new System.Drawing.Point(18, 83);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnStudents.Size = new System.Drawing.Size(220, 50);
            this.btnStudents.TabIndex = 0;
            this.btnStudents.Text = "📚 Students";
            this.btnStudents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudents.UseVisualStyleBackColor = false;
            // 
            // btnCourses
            // 
            this.btnCourses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.btnCourses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCourses.FlatAppearance.BorderSize = 0;
            this.btnCourses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourses.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCourses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.btnCourses.Location = new System.Drawing.Point(18, 139);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnCourses.Size = new System.Drawing.Size(220, 50);
            this.btnCourses.TabIndex = 1;
            this.btnCourses.Text = "📖 Courses";
            this.btnCourses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCourses.UseVisualStyleBackColor = false;
            // 
            // btnInstructors
            // 
            this.btnInstructors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.btnInstructors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInstructors.FlatAppearance.BorderSize = 0;
            this.btnInstructors.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnInstructors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstructors.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnInstructors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.btnInstructors.Location = new System.Drawing.Point(18, 195);
            this.btnInstructors.Name = "btnInstructors";
            this.btnInstructors.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnInstructors.Size = new System.Drawing.Size(220, 50);
            this.btnInstructors.TabIndex = 2;
            this.btnInstructors.Text = "👨‍🏫 Instructors";
            this.btnInstructors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInstructors.UseVisualStyleBackColor = false;
            // 
            // btnEnrollments
            // 
            this.btnEnrollments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.btnEnrollments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnrollments.FlatAppearance.BorderSize = 0;
            this.btnEnrollments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnEnrollments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnrollments.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnEnrollments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.btnEnrollments.Location = new System.Drawing.Point(18, 251);
            this.btnEnrollments.Name = "btnEnrollments";
            this.btnEnrollments.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnEnrollments.Size = new System.Drawing.Size(220, 50);
            this.btnEnrollments.TabIndex = 3;
            this.btnEnrollments.Text = "📝 Enrollments";
            this.btnEnrollments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnrollments.UseVisualStyleBackColor = false;
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblAppName.ForeColor = System.Drawing.Color.White;
            this.lblAppName.Location = new System.Drawing.Point(30, 30);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(70, 37);
            this.lblAppName.TabIndex = 1;
            this.lblAppName.Text = "IUIS";
            this.lblAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.lblWelcome);
            this.panelHeader.Controls.Add(this.lblSubtitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(250, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.panelHeader.Size = new System.Drawing.Size(1030, 83);
            this.panelHeader.TabIndex = 1;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblWelcome.Location = new System.Drawing.Point(30, 10);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(252, 41);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to IUIS";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblSubtitle.Location = new System.Drawing.Point(33, 51);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(279, 20);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Integrated University Information System";
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(250, 83);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(30);
            this.panelContent.Size = new System.Drawing.Size(1030, 637);
            this.panelContent.TabIndex = 0;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSidebar);
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IUIS - Integrated University Information System";
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.flowLayoutPanelMenu.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Button btnInstructors;
        private System.Windows.Forms.Button btnEnrollments;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMenu;
    }
}
