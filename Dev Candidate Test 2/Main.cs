namespace Dev_Candidate_Test_2
{
    public partial class Main : Form
    {
        ManageEmployeesClass mec { get;set; }
        public Main()
        {
            InitializeComponent();
            mec = new();
            mec.LoadEmployees();
        }

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmpForm empForm = new(this, mec);
            empForm.Show();
        }
        private void bttnEdit_Click(object sender, EventArgs e)
        {
           if(dgvEmps.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvEmps.SelectedCells[0].RowIndex;
                DataGridViewRow dgvr = dgvEmps.Rows[selectedRowIndex];
                int GetID = Convert.ToInt32(dgvr.Cells["ID"].Value);

                this.Hide();
                EmpForm empForm = new(this, mec, GetID);
                empForm.Show();
            }
        }
        private void Main_Shown(object sender, EventArgs e)
        {
            bttnDateAsc.Checked = true;
            SortList(true);
        }
        private void bttnFilter_Click(object sender, EventArgs e)
        {
            dgvEmps.DataSource = null;
            dgvEmps.DataSource = mec.FilteredList(txtName.Text);
            txtName.Text = "";
        }
        private void SortList(bool IsAscending)
        {
            mec.SortListByBornDate(IsAscending);
            dgvEmps.DataSource = null;
            dgvEmps.DataSource = mec.EmployeesList;
        }
        private void bttnDateAsc_Click(object sender, EventArgs e)
        {
            bttnDateDesc.Checked = false;
            SortList(true);
        }
        private void bttnDateDesc_Click(object sender, EventArgs e)
        {
            bttnDateAsc.Checked = false;
            SortList(false);
        }
        private void Main_Activated(object sender, EventArgs e)
        {
            bttnDateAsc.Checked = true;
            SortList(true);
        }
    }
}