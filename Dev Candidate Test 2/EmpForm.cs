using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dev_Candidate_Test_2
{
    public partial class EmpForm : Form
    {
        private bool IsEdit { get; set; } //Property to check if is editing or adding an employee
        ManageEmployeesClass mec { get; set; } //Business class dependency
        Main main { get; set; } //Main form dependency

        public EmpForm(Main mainForm, ManageEmployeesClass Mec)
        {
            InitializeComponent();
            cmbStatus.DataSource = Enum.GetValues(typeof(EmployeeStatus));
            IsEdit = false;
            mec = Mec;
            main = mainForm;
            dtpBornDate.Value = DateTime.Today;
        } //Builder to add new employee
        public EmpForm(Main mainForm, ManageEmployeesClass Mec, int EmpSelectedID)
        {
            InitializeComponent();
            cmbStatus.DataSource = Enum.GetValues(typeof(EmployeeStatus));
            IsEdit = true;
            mec = Mec;
            main = mainForm;

            Employee emp = mec.GetEditEmployee(EmpSelectedID);

            txtID.Text = emp.ID.ToString();
            txtName.Text = emp.Name;
            txtLastName.Text = emp.LastName;
            txtRFC.Text = emp.RFC;
            dtpBornDate.Value = emp.BornDate;
            cmbStatus.SelectedItem = emp.Status;
        } //Builder to edit an employee
        private void ClearForm()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtLastName.Text = "";
            txtRFC.Text = "";
            dtpBornDate.Value = DateTime.Today;
            cmbStatus.SelectedItem = EmployeeStatus.NotSet;
        }
        private void AddEmp(Employee emp)
        {
            mec.AddEmployee(emp);
            ClearForm();
        }
        private void EditEmp(Employee emp)
        {
            mec.UpdateEditEmployee(emp);
            ClearForm();
        }
        private void bttnPersist_Click(object sender, EventArgs e)
        {
            EmployeeStatus es = (EmployeeStatus)cmbStatus.SelectedItem;
            string id = txtID.Text;
            if (id == "")
                id = "0";
            Employee emp = new Employee
            {
                ID = Convert.ToInt32(id),
                Name = txtName.Text,
                LastName = txtLastName.Text,
                RFC = txtRFC.Text,
                BornDate = dtpBornDate.Value,
                Status = es
            };
            try
            {
                switch (IsEdit) //Check if the Form is to Edit or to Add Employee
                {
                    case true:
                        EditEmp(emp);
                        break;
                    default:
                        AddEmp(emp);
                        break;
                }
            }
            catch
            {
                MessageBox.Show("RFC inválido");
                txtRFC.Focus();
            }
            mec.SaveEmployeesChanges();
            MessageBox.Show("Se han almacenado los cambios");
            this.Close();
        }
        private void EmpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            main.Show();
        }
        private void bttnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
