using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//CODE WRITER:RABİA ÇEVİK 26.04.2021 

namespace HostelManagementSystem
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

      

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FrmLogin fr = new FrmLogin();  //close the form and open the login form
            this.Hide();
            fr.ShowDialog();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();  //program termination
        }
        Boolean labelVisible = true;  //boolean declaration 
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (labelVisible==true)
            {
                lblHMS.Visible = true;
                labelVisible = false;        //hides andd shows label through timer
            }
            else
            {
                lblHMS.Visible = false;
                labelVisible = true;
            }
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;   
            timer1.Start();
        }

        private void btnManageRooms_Click(object sender, EventArgs e)
        {
            FrmAddNewRoom fr = new FrmAddNewRoom();
            fr.Show();
        }

        private void btnNewStudent_Click(object sender, EventArgs e)
        {
            FrmNewStudent fr = new FrmNewStudent();
            fr.Show();
        }

        private void btnUpdateDeleteStudent_Click(object sender, EventArgs e)
        {
            FrmUpdateDeleteStudent fr = new FrmUpdateDeleteStudent();
            fr.Show();
        }

        private void btnStudentFees_Click(object sender, EventArgs e)
        {
            FrmStudentFees fr = new FrmStudentFees();
            fr.Show();
        }

        private void btnAllStudentLiving_Click(object sender, EventArgs e)    //the corresponding form opens according to the button clicked
        {
            FrmAllStudentLiving fr = new FrmAllStudentLiving();
            fr.Show();
        }

        private void btnLeavedStudents_Click(object sender, EventArgs e)
        {
            FrmLeaveStudents fr = new FrmLeaveStudents();
            fr.Show();
        }

        private void btnNewEmployee_Click(object sender, EventArgs e)
        {
            FrmNewEmployee fr = new FrmNewEmployee();
            fr.Show();
        }

        private void btnUpdateDeleteEmployee_Click(object sender, EventArgs e)
        {
            FrmUpdateDeleteEmployee fr = new FrmUpdateDeleteEmployee();
            fr.Show();
        }

        private void btnEmployeePayment_Click(object sender, EventArgs e)
        {
            FrmEmployeePayment fr = new FrmEmployeePayment();
            fr.Show();
        }

        private void btnAllEmployeeWorking_Click(object sender, EventArgs e)
        {
            FrmAllEmployeeWorking fr = new FrmAllEmployeeWorking();
            fr.Show();
        }

     

        private void btnLeavedEmployee_Click(object sender, EventArgs e)
        {
            FrmLeavedEmployee fr = new FrmLeavedEmployee();
            fr.Show();
        }
    }
}
