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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.lblAppName = new System.Windows.Forms.Label();
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnCourses = new System.Windows.Forms.Button();
            this.btnInstructors = new System.Windows.Forms.Button();
            this.btnEnrollments = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.flowLayoutPanelMenu = new System.Windows.Forms.FlowLayoutPanel();
            
            // Panel Sidebar - Modern dark theme
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Width = 250;
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.panelSidebar.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            
            // App Name Label in Sidebar
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblAppName.ForeColor = System.Drawing.Color.White;
            this.lblAppName.Location = new System.Drawing.Point(30, 30);
            this.lblAppName.Text = "IUIS";
            this.lblAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            // FlowLayoutPanel for menu buttons
            this.flowLayoutPanelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelMenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelMenu.WrapContents = false;
            this.flowLayoutPanelMenu.Padding = new System.Windows.Forms.Padding(15, 80, 15, 0);
            this.flowLayoutPanelMenu.BackColor = System.Drawing.Color.FromArgb(17, 24, 39);
            
            // Button - Students
            this.btnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudents.FlatAppearance.BorderSize = 0;
            this.btnStudents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(55, 65, 81);
            this.btnStudents.BackColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.btnStudents.ForeColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.btnStudents.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnStudents.Size = new System.Drawing.Size(220, 50);
            this.btnStudents.Text = "📚 Students";
            this.btnStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudents.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            
            // Button - Courses
            this.btnCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourses.FlatAppearance.BorderSize = 0;
            this.btnCourses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(55, 65, 81);
            this.btnCourses.BackColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.btnCourses.ForeColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.btnCourses.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCourses.Size = new System.Drawing.Size(220, 50);
            this.btnCourses.Text = "📖 Courses";
            this.btnCourses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCourses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCourses.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            
            // Button - Instructors
            this.btnInstructors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstructors.FlatAppearance.BorderSize = 0;
            this.btnInstructors.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(55, 65, 81);
            this.btnInstructors.BackColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.btnInstructors.ForeColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.btnInstructors.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnInstructors.Size = new System.Drawing.Size(220, 50);
            this.btnInstructors.Text = "👨‍🏫 Instructors";
            this.btnInstructors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInstructors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInstructors.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            
            // Button - Enrollments
            this.btnEnrollments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnrollments.FlatAppearance.BorderSize = 0;
            this.btnEnrollments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(55, 65, 81);
            this.btnEnrollments.BackColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.btnEnrollments.ForeColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.btnEnrollments.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnEnrollments.Size = new System.Drawing.Size(220, 50);
            this.btnEnrollments.Text = "📝 Enrollments";
            this.btnEnrollments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnrollments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnrollments.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            
            // Add buttons to flow layout
            this.flowLayoutPanelMenu.Controls.Add(this.btnStudents);
            this.flowLayoutPanelMenu.Controls.Add(this.btnCourses);
            this.flowLayoutPanelMenu.Controls.Add(this.btnInstructors);
            this.flowLayoutPanelMenu.Controls.Add(this.btnEnrollments);
            
            this.panelSidebar.Controls.Add(this.flowLayoutPanelMenu);
            this.panelSidebar.Controls.Add(this.lblAppName);
            
            // Panel Header - Modern light theme
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Height = 70;
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            
            // Welcome Label
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.lblWelcome.Location = new System.Drawing.Point(30, 10);
            this.lblWelcome.Text = "Welcome to IUIS";
            
            // Subtitle Label
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblSubtitle.Location = new System.Drawing.Point(30, 42);
            this.lblSubtitle.Text = "Integrated University Information System";
            
            this.panelHeader.Controls.Add(this.lblWelcome);
            this.panelHeader.Controls.Add(this.lblSubtitle);
            
            // Panel Content - Main area
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
            this.panelContent.Padding = new System.Windows.Forms.Padding(30);
            
            // Form settings
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSidebar);
            
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IUIS - Integrated University Information System";
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
