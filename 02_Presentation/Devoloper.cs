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
    
    public partial class Devoloper : Form
    {
        Employee emp;
        HistoryTask _hTask;
        HistoryTaskBusiness _hisBll;
        public Devoloper(Employee employe)
        {
            emp = employe;
            InitializeComponent();
            _hTask = new HistoryTask();
            _hisBll = new HistoryTaskBusiness();
        }

    

        private void Devoloper_Load(object sender, EventArgs e)
        {
            Rectangle rect = new Rectangle(
tabPage1.Left,
tabPage1.Top,
tabPage1.Width,
tabPage1.Height);

            tabControl1.Region = new Region(rect);
            dgvTask.DataSource = _hisBll.GetMyTask(emp.ID);
        }

        private void btnTask_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
            dgvTask.DataSource = _hisBll.GetMyTask(emp.ID);
        }

        private void btnMyTask_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
            dataGridView2.DataSource = (from his in _hisBll.GetMyTask(emp.ID)
                                        where his.DeadLine == null
                                        select his
                                          ).ToList();
        }

        private void btnTakeOn_Click(object sender, EventArgs e)
        {
            int secili = (int)dgvTask.CurrentRow.Cells["ID"].Value;
            _hTask = _hisBll.Get(secili);
            _hTask.StartDate = DateTime.Now;
            bool result =_hisBll.Update(_hTask);
            if (result)
            {
                MessageBox.Show("İş üzerine alındı");
            }
            else
            {
                MessageBox.Show("İs alınamadı");
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int secili = (int)dataGridView2.CurrentRow.Cells["ID"].Value;
            _hTask = _hisBll.Get(secili);
            _hTask.DeadLine = DateTime.Now;
            bool result = _hisBll.Update(_hTask);
            if (result)
            {
                MessageBox.Show("İŞ bitti");
            }
            else
            {
                MessageBox.Show("İs bitirilemedi");
            }
        }

       
    }
}
