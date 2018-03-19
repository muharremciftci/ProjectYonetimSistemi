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
    public partial class TeamLeader : Form
    {
        EmployeeBusiness _empbll;
        Employee _emp;
        HistoryTask _hTask;
        HistoryTaskBusiness _hTaskBll;
        ProjectBusiness _proBll;
        Tassk tsk;
        TaskBusiness _taskBll;
        CustomerDemandBusiness _cusdemandBll;
        CustomerDemand cusDemand;

        CustomerBusiness _cusbll;
        
        public TeamLeader(Employee emp)
        {

            InitializeComponent();
            _hTask = new HistoryTask();
            _hTaskBll = new HistoryTaskBusiness();
            _emp = emp;

            _cusbll = new CustomerBusiness();
            _cusdemandBll = new CustomerDemandBusiness();
            cusDemand = new CustomerDemand();
            tsk = new Tassk();
            _taskBll = new TaskBusiness();
            _proBll = new ProjectBusiness();
            _empbll = new EmployeeBusiness();
        }

        private void TeamLeader_Load(object sender, EventArgs e)
        {
            Rectangle rect = new Rectangle(
tabPage1.Left,
tabPage1.Top,
tabPage1.Width,
tabPage1.Height);

            tabControl1.Region = new Region(rect);



            dgwTask.DataSource = _proBll.GetAll().Where(x=>x.TeamID==_emp.TeamID).ToList();
            gridTask.DataSource = _taskBll.GetAll();



        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtProjectId.Text == "")
            {
                MessageBox.Show("Projeyi seçiniz");
            }
            else
            {
                tsk.ProjectID = int.Parse(txtProjectId.Text);
                tsk.Subject = txtSubject.Text;
                tsk.Description = txtDescription.Text;
                if (txtStartDate.Text == "  .  ." && txtFinishDate.Text == "  .  .")
                {
                    MessageBox.Show("Tarihleri doldurmanız gerekmekte");
                }
                else
                {
                    tsk.StartDate = DateTime.Parse(txtStartDate.Text);
                    tsk.DeadLine = DateTime.Parse(txtFinishDate.Text);
                }
                if (cmbTaskState.SelectedIndex>-1)
                {
                    tsk.State = cmbTaskState.SelectedItem.ToString();    
                }else {
                    tsk.State = "Başlanmadı";
                }
                bool result = _taskBll.AddTask(tsk);
                if (result)
                {
                    MessageBox.Show("Kaydedildi");
                }
                else
                {
                    MessageBox.Show("Kaydedilmedi");
                }
            }
        }

        private void dgwTask_Click(object sender, EventArgs e)
        {
            txtProjectId.Text = dgwTask.CurrentRow.Cells["ID"].Value.ToString();
        }

        private void btnHistoryTAskAdd_Click(object sender, EventArgs e)
        {
            _hTask.Description = txtTaskDescription.Text;
            _hTask.EmployeeID = (int)cmbEmployee.SelectedValue;
         
            _hTask.TasskID = int.Parse(txtTaskId.Text);
            bool result = _hTaskBll.AddHistoryTask(_hTask);
            if (result)
            {
                MessageBox.Show("Kaydedildi");
            }
            else
            {
                MessageBox.Show("Kaydedilmedi");
            }


        }

        private void gridTask_Click(object sender, EventArgs e)
        {
            txtTaskId.Text = gridTask.CurrentRow.Cells["ID"].Value.ToString();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
            GridFillDEmand();
            cmbCompany.DisplayMember = "CompanyName";
            cmbCompany.ValueMember = "CompanyID";
            cmbCompany.DataSource = (from cus in _cusbll.GetAllCustomer()
                                     join pro in _proBll.GetAll() on cus.CompanyID equals pro.CompanyID
                                     where pro.TeamID==_emp.TeamID
                                     select cus).ToList();


            btnTaskCreate.Visible = false;
            btnDemand.Enabled = true;
        }

        private void btnDemand_Click(object sender, EventArgs e)
        {
            cusDemand.CompanyID = (int)cmbCompany.SelectedValue;
       
            cusDemand.Subject = txtDemandSubject.Text;
            cusDemand.State = cmbState.SelectedItem.ToString();
            bool result=_cusdemandBll.AddCustomerDemand(cusDemand);
            if (result)
            {
                MessageBox.Show("istek oluşturuldu");
                GridFillDEmand();
            }
            else
            {
                MessageBox.Show("İStek oluşturulamadı.");
            }
        }

        private void GridFillDEmand()
        {
            gridDemand.DataSource = (from dem in _cusdemandBll.GetAll()
                                     join pro in _proBll.GetAll() on dem.CompanyID equals pro.CompanyID
                                     where pro.TeamID == _emp.TeamID
                                     select dem
                                         ).ToList();
        }

        private void gridDemand_Click(object sender, EventArgs e)
        {
           
            btnDemand.Enabled = false;
        }

        private void btnTaskCreate_Click(object sender, EventArgs e)
        {

        }

        private void btnTaskPlanning_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void btnTeamEmployees_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;

            var result = (from emp in _empbll.GetAll()
                          where emp.PositionID != 1 && emp.PositionID != 2 && emp.TeamID == _emp.TeamID

                          select emp
                            ).ToList();
            
            cmbEmployee.DisplayMember = "FirstName";
            cmbEmployee.ValueMember = "ID";
            cmbEmployee.DataSource = result;
        }


        private void cmbProject_Click(object sender, EventArgs e)
        {
            cmbProject.DisplayMember = "ProjectName";
            cmbProject.ValueMember = "ID";
            cmbProject.DataSource = _proBll.GetAll().Where(x => x.CompanyID == (int)cmbCompany.SelectedValue).ToList();
           
        }

        private void cmbCompany_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gridDemand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
