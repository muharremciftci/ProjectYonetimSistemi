using _00_Entity;
using _03_BusineesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Presentation
{
    public partial class ProjectManagement : Form
    {
        Project _project;
        ProjectBusiness _proBLL;
        Employee emp;
        EmployeeBusiness _empBll;
        Customer cus;
        CustomerBusiness _cusBLL;
        TeamBusiness _teamBll;
        Position pos;
        PositionBusiness _poziBll;
        public ProjectManagement(Employee b)
        {
            InitializeComponent();
            _cusBLL = new CustomerBusiness();
            cus = new Customer();
            _proBLL = new ProjectBusiness();
            _project = new Project();
            _teamBll = new TeamBusiness();
            _empBll = new EmployeeBusiness();
            pos = new Position();
            _poziBll = new PositionBusiness();
        }

    

        private void ProjectManagement_Load(object sender, EventArgs e)
        {
            Rectangle rect = new Rectangle(
tbcNewProject.Left,
tbcNewProject.Top,
tbcNewProject.Width,
tbcNewProject.Height);

            tbcProjectManagement.Region = new Region(rect);



            dtgEmployeeAdd.DataSource = _empBll.GetAll();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            cus.CompanyName = txtCustomerName.Text;
            cus.Address = txtAdress.Text;
            cus.Phone = txtPhone.Text;
            cus.Region = txtRegion.Text;

            bool result = _cusBLL.AddCustomer(cus);
            if (result)
            {
                MessageBox.Show("Müsteri Kaydedildi");
            }
            else MessageBox.Show("Hata Müsteri Kaydı Yapılamadı");






        }



        private void btnEmpAdd_Click(object sender, EventArgs e)
        {
            Employee empl = new Employee();
            empl.FirstName = txtFirstName.Text;
            empl.LastName = txtLastName.Text;
            empl.Email = txtEmail.Text;
            empl.Password = txtPassword.Text;
            empl.Address = txtAddress.Text;
            empl.Phone = txtPhone.Text;
            empl.TeamID = (int)cmbTeam.SelectedValue;

            bool result = _empBll.AddEmployee(empl);
            if (result)
            {
                MessageBox.Show("Çalışan eklendi");
            }
            else
            {
                MessageBox.Show("Çalışan Eklenemedi");
            }
        }



        private void btnProjectSave_Click(object sender, EventArgs e)
        {
            _project.CompanyID = (int)cmbCustomerName.SelectedValue;
            _project.Description = txtDescription.Text;
            _project.DeadLine = dtpDeadline.Value;
            _project.StartDate = dtpStart.Value;
            _project.TeamID = (int)cmbTeamName.SelectedValue;
            _project.ProjectName = txtProjectName.Text;

            bool result = _proBLL.OpenProject(_project);
            if (result)
            {
                MessageBox.Show("Proje eklendi");
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }


        }



        private void btnTeams_Click(object sender, EventArgs e)
        {
            tbcProjectManagement.SelectedTab = Teams;
            cmbPosition.DisplayMember = "PositionName";
            cmbPosition.ValueMember = "ID";

            cmbPosition.DataSource = _poziBll.GetAll();

            cmbTeams.DisplayMember = "TeamName";
            cmbTeams.ValueMember = "ID";
            cmbTeams.DataSource = _teamBll.GetAll();


        }

        private void btnProject_Click(object sender, EventArgs e)
        {
            tbcProjectManagement.SelectedTab = tbcNewProject;



            cmbTeamName.DataSource = _teamBll.GetAll();
            cmbTeamName.DisplayMember = "TeamName";
            cmbTeamName.ValueMember = "ID";
            cmbCustomerName.DataSource = _cusBLL.GetAllCustomer();
            cmbCustomerName.DisplayMember = "CompanyName";
            cmbCustomerName.ValueMember = "CompanyID";

        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            tbcProjectManagement.SelectedTab = tbcNewCustomer;
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            tbcProjectManagement.SelectedTab = tbcEmployees;

            cmbTeam.DataSource = _teamBll.GetAll();
            cmbTeam.DisplayMember = "TeamName";
            cmbTeam.ValueMember = "ID";
        }

        private void cmbTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillTeamList();
           
        }

        private void FillTeamList()
        {
            listBox2.DataSource = null;
            var result = (from emp in _empBll.GetAll()
                          where emp.TeamID == (int)cmbTeams.SelectedValue
                          select new { ID = emp.ID, FullName = emp.FirstName + "" + emp.LastName }
                ).ToList();

            listBox2.ValueMember = "ID";
            listBox2.DisplayMember = "FullName";
            listBox2.DataSource = result;
        }

        private void cmbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillPozitionEmployee();
            
        }

        private void FillPozitionEmployee()
        {
            listBox1.DataSource = null;
            var positionemp = (from poz in _poziBll.GetAll()
                               join emp in _empBll.GetAll() on poz.ID equals emp.PositionID
                               where poz.ID == (int)cmbPosition.SelectedValue && emp.TeamID==null
                               select new { Id = emp.ID, AdıSoyadı = emp.FirstName + " " + emp.LastName }
                                ).ToList();

            listBox1.ValueMember = "ID";
            listBox1.DisplayMember = "AdıSoyadı";
            listBox1.DataSource = positionemp;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count>0)
            {
                Employee guncellenecek = _empBll.Get((int)listBox1.SelectedValue);
                guncellenecek.TeamID = (int)cmbTeams.SelectedValue;
                bool result = _empBll.UpdateEmployee(guncellenecek);
                if (!result)
                {
                    MessageBox.Show("Takıma Eklenemedi");
                }
                else
                {
                    FillPozitionEmployee();
                    FillTeamList();
                }
            }
            else
            {
                MessageBox.Show("Lütfen Takıma Eklenecek kişiyi seçiniz");
            }
          

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItems.Count>0)
            {
                Employee guncellenecek = _empBll.Get((int)listBox2.SelectedValue);
                guncellenecek.TeamID = null;
                bool result = _empBll.UpdateEmployee(guncellenecek);
                if (!result)
                {
                    MessageBox.Show("Takıma Eklenemedi :");
                }
                else
                {
                    FillPozitionEmployee();
                    FillTeamList();
                }
            }
            else
            {
                MessageBox.Show("Lütfen Takımdan Çıkarılacak kişiyi Seçiniz");
            }
           
        }
    }
}
