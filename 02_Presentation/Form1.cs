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
    public partial class Form1 : Form
    {
        EmployeeBusiness _empBll;
       
        Employee emp;
        public Form1()
        {
            InitializeComponent();
            _empBll = new EmployeeBusiness();
        }

     

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            try
            {

               emp=_empBll.Login(txtEmail.Text, txtPassword.Text);
                if (emp!=null)
                {
                    switch (emp.PositionID)
                    {
                        case 1:
                           
                           ProjectManagement frm = new ProjectManagement(emp);
                            frm.Show();
                            break;
                        case 2:
                             BusinessAnalyst ee = new BusinessAnalyst(emp);
                            ee.Show();
                            
                            break;
                        case 3:
                           TeamLeader asd = new TeamLeader(emp);
                            asd.Show();
                            break;
                        case 4: 
                            Devoloper dsa = new Devoloper(emp);
                            dsa.Show();
                            break;
                        case 5:
                            Tester rr = new Tester(emp);
                            rr.Show();
                            break;


                        default:
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Böyle kullanıcı bulunamadı");
                }
               
               
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);
                txtEmail.Clear();
                txtPassword.Clear();
                
            }
             

        }
    }
}
