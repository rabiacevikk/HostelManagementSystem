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
    public partial class FrmNewStudent : Form
    {
        function fn = new function();
        String query;
        public FrmNewStudent()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();  //closing 
        }

        private void FrmNewStudent_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 100);
            query = "select roomNo from rooms where roomStatus='Yes' and Booked ='No'";  //show rooms that are empty and not reserved
            DataSet ds = fn.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                Int64 room = Int64.Parse(ds.Tables[0].Rows[i][0].ToString());
                cmbRoomNo.Items.Add(room);  //bringing empty rooms to combobox
            }
        }
        public void clearAll()
        {
            txtMobileNumber.Clear();
            txtName.Clear();
            txtFatherName.Clear();
            txtMotherName.Clear();    //cleaning items
            txtEmail.Clear();
            txtPermanentAddress.Clear();
            txtCollegeName.Clear();
            txtIdProof.Clear();
            cmbRoomNo.SelectedIndex = -1;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMobileNumber.Text!="" && txtName.Text!="" && txtFatherName.Text!="" &&txtMotherName.Text!="" && txtEmail.Text!="" && txtPermanentAddress.Text!="" && txtCollegeName.Text!="" && txtIdProof.Text!="" && cmbRoomNo.SelectedIndex!=-1)
            {
                string mobile = txtMobileNumber.Text;
                string name = txtName.Text;
                string fname = txtFatherName.Text;
                string mname = txtMotherName.Text;
                string email = txtEmail.Text;
                string paddress = txtPermanentAddress.Text;                                 //recording student
                string college = txtCollegeName.Text;
                string idproof = txtIdProof.Text;
                Int64 roomNo = Int64.Parse(cmbRoomNo.Text);
                query = "insert into newStudent (mobile,name,fname,mname,email,paddress,college,idproof,roomNo) values (" + mobile + ",'" + name + "','" + fname + "','" + mname + "','" + email + "','" + paddress + "','" + college + "','" + idproof + "'," + roomNo + ") update rooms set Booked = 'Yes' where roomNo=" + roomNo + "";
                fn.setData(query, "Student Registration Successful.");  //insertion query
                clearAll();
            }
            else
            {
                MessageBox.Show("Fill all empty space.","Information!!",MessageBoxButtons.OK,MessageBoxIcon.Warning); //error message
            }

        }
    } 
    }

