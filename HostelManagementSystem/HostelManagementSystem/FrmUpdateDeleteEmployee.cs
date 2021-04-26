using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelManagementSystem
{
    public partial class FrmUpdateDeleteEmployee : Form
    {
        function fn = new function();
        string query;
        public FrmUpdateDeleteEmployee()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();  //closing
        }

        private void FrmUpdateDeleteEmployee_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 150); //set the location of the form

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            query = "select * from newEmployee where emobile=" + txtMobileNumber.Text + ""; //print information about the searched mobile number in textboxes
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count!=0)
            {
                txtName.Text = ds.Tables[0].Rows[0][2].ToString();
                txtFatherName.Text = ds.Tables[0].Rows[0][3].ToString();
                txtMotherName.Text = ds.Tables[0].Rows[0][4].ToString();
                txtEmailID.Text = ds.Tables[0].Rows[0][5].ToString();
                txtPermanentAddress.Text = ds.Tables[0].Rows[0][6].ToString();
                txtUniqueID.Text = ds.Tables[0].Rows[0][7].ToString();
                cmbDesignation.Text = ds.Tables[0].Rows[0][8].ToString();
                cmbWorkingStatus.Text = ds.Tables[0].Rows[0][9].ToString();
            }
            else
            {
                MessageBox.Show("No Record Exist.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);  //error message
                clearAll();

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String mobile = txtMobileNumber.Text;
            string name = txtName.Text;
            String fname = txtFatherName.Text;
            string mname = txtMotherName.Text;
            string email = txtEmailID.Text;
            string paddress = txtPermanentAddress.Text;
            string id = txtUniqueID.Text;
            string designation = cmbDesignation.Text;
            string working = cmbWorkingStatus.Text;
            query = "update newEmployee set ename='" + name + "',efname='" + fname + "',emname='" + mname + "',eemail='" + email + "',epaddress='" + paddress + "',eidproof='" + id + "', edesignation='" + designation + "',working='" + working + "' where emobile="+mobile+"";
            fn.setData(query, "Data Updation Successful.");  //updation query
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure?","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes) //confirmation 
            {
                query = "delete from newEmployee where emobile=" + txtMobileNumber.Text + "";  //deletion
                fn.setData(query, "Employee Recorde Deleated.");
                clearAll();
            }
        }
        public void clearAll()
        {
            txtMobileNumber.Clear();
            txtName.Clear();
            txtFatherName.Clear();  //cleaning items
            txtMotherName.Clear();
            txtEmailID.Clear();
            txtPermanentAddress.Clear();
            txtUniqueID.Clear();
            cmbDesignation.ResetText();
            cmbWorkingStatus.ResetText();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
