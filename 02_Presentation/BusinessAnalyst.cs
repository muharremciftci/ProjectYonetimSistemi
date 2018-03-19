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
    public partial class BusinessAnalyst : Form
    {
        Employee _emp;
        TaskBusiness _taskBll;
        Tassk _hTask;
        HistoryTask _hisTask;
        HistoryTaskBusiness _hisTaskBll;
        ProjectBusiness _proBll;
        EmployeeBusiness _empBll;
        CustomerBusiness _cusBll;
        CustomerDemand cusDemand;
        CustomerDemandBusiness _cusdemandBll;
      
      
        public BusinessAnalyst(Employee emp)
        {
            InitializeComponent();
            _emp = emp;
            _taskBll = new TaskBusiness();
            _hTask = new Tassk();
            _hisTask = new HistoryTask();
            _hisTaskBll = new HistoryTaskBusiness();
            _proBll = new ProjectBusiness();
            _empBll = new EmployeeBusiness();
            _cusBll = new CustomerBusiness();
            cusDemand = new CustomerDemand();
            _cusdemandBll = new CustomerDemandBusiness();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _hTask.Subject = txtSubject.Text;
            _hTask.StartDate =DateTime.Parse (txtStartDate.Text);
            _hTask.DeadLine = DateTime.Parse(txtFinishDate.Text);
            _hTask.Description = txtDescription.Text;
            _hTask.ProjectID = int.Parse(txtProjectId.Text);

            bool result = _taskBll.AddTask(_hTask);
            if (result)
            {
                MessageBox.Show("Kaydedildi");
            }
            else
            {
                MessageBox.Show("Kaydedilmedi");
            }

        }

        private void dgwBusiness_Click(object sender, EventArgs e)
        {
            txtProjectId.Text = dgwBusiness.CurrentRow.Cells["ID"].Value.ToString();
        }

        private void BusinessAnalyst_Load(object sender, EventArgs e)
        {
            Rectangle rect = new Rectangle(
tabPage1.Left,
tabPage1.Top,
tabPage1.Width,
tabPage1.Height);

            tabControl1.Region = new Region(rect);

            
            
            
            var result = (from emp in _empBll.GetAll()
                          where emp.PositionID != 1 && emp.PositionID != 2
                          select emp
                           ).ToList();

            cmbEmployee.DisplayMember = "FirstName";
            cmbEmployee.ValueMember = "ID";
            cmbEmployee.DataSource = result;
            

            dgwBusiness.DataSource = _proBll.GetAll();
            gridTaskBusiness.DataSource = _taskBll.GetAll();
        }

        private void btnHistoryTAskAdd_Click(object sender, EventArgs e)
        {
            _hisTask.TasskID = int.Parse(txtTaskId.Text);
            if (txttaskStart.Text != "  .  ." && txtTaskDeadline.Text != "  .  .")
            {
                _hisTask.StartDate = DateTime.Parse(txttaskStart.Text);
                _hisTask.DeadLine = DateTime.Parse(txtTaskDeadline.Text);
            }
           
           
            _hisTask.Description = txtDescription.Text;
            _hisTask.EmployeeID = (int)cmbEmployee.SelectedValue;

            bool result = _hisTaskBll.AddHistoryTask(_hisTask);
            if (result)
            {
                MessageBox.Show("Kaydedildi");
            }
            else
            {
                MessageBox.Show("Kaydedilmedi");
            }
        }

        private void gridTaskBusiness_Click(object sender, EventArgs e)
        {
            txtTaskId.Text = gridTaskBusiness.CurrentRow.Cells["ID"].Value.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTaskPlanning_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void btnMyTask_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
            GridFillDEmand();
            cmbCompany.DisplayMember = "CompanyName";
            cmbCompany.ValueMember = "CompanyID";
            cmbCompany.DataSource = (from cus in _cusBll.GetAllCustomer()
                                     join pro in _proBll.GetAll() on cus.CompanyID equals pro.CompanyID
                                     where pro.TeamID == _emp.TeamID
                                     select cus).ToList();
           
            btnDemand.Enabled = true;
        }

        private void gridDemand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridDemand_Click(object sender, EventArgs e)
        {
            btnDemand.Enabled = false;
        }

        private void btnDemand_Click(object sender, EventArgs e)
        {
            cusDemand.CompanyID = (int)cmbCompany.SelectedValue;

            cusDemand.Subject = txtDemandSubject.Text;
            cusDemand.State = cmbState.SelectedItem.ToString();
            bool result = _cusdemandBll.AddCustomerDemand(cusDemand);
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

        private void cmbProject_Click(object sender, EventArgs e)
        {
            cmbProject.DisplayMember = "ProjectName";
            cmbProject.ValueMember = "ID";
            cmbProject.DataSource = _proBll.GetAll().Where(x => x.CompanyID == (int)cmbCompany.SelectedValue).ToList();
        }
    }
}
