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
    public partial class FrmNewEmployee : Form
    {
        function fn = new function();
        string query;
        public FrmNewEmployee()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();  //closing 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text!="" && txtMobileNumber.Text!="" && txtFatherName.Text!="" && txtMotherName.Text!="" && txtEmailID.Text!="" && txtPermanentAddress.Text!="" && txtUniqueID.Text!="" && cmbDesignation.SelectedIndex!=-1)  //if items are not empty, runs if contents
            {
                string mobile = txtMobileNumber.Text;
                string name = txtName.Text;
                string fname = txtFatherName.Text;
                string mname = txtMotherName.Text;
                string email = txtEmailID.Text;
                string address = txtPermanentAddress.Text;
                string id = txtUniqueID.Text;
                string designation = cmbDesignation.Text;
                query = "insert into newEmployee( emobile,ename,efname,emname,eemail,epaddress,eidproof,edesignation) values ('" + mobile + "','" + name + "','" + fname + "','" + mname + "','" + email + "','" + address + "','" + id + "','" + designation + "')";
                fn.setData(query, "Employee Registration Successful.");  //insertion query
                clearAll();
            }
            else
            {
                MessageBox.Show("Fill all Required Data.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);  //error message
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        private void clearAll()
        {
            txtName.Clear();
            txtMobileNumber.Clear();  //cleaning all items
            txtFatherName.Clear();
            txtMotherName.Clear();
            txtEmailID.Clear();
            txtPermanentAddress.Clear();
            txtUniqueID.Clear();
            cmbDesignation.SelectedIndex = -1;
        }
    }
}
