using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FInal_IUIS.Forms
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            // TODO: Implement search functionality
            string searchTerm = txtSearch.Text.Trim().ToLower();
            // Filter dgvStudents based on searchTerm
        }

        private void CmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO: Implement filter functionality
            string selectedFilter = cmbFilter.SelectedItem?.ToString() ?? "All Students";
            // Filter dgvStudents based on selectedFilter
        }
    }
}
