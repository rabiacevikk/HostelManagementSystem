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
    public partial class FrmUpdateDeleteStudent : Form
    {
        function fn = new function();
        string query;
        public FrmUpdateDeleteStudent()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();  //closing form
        }

        private void FrmUpdateDeleteStudent_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 79);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        private void clearAll()
        {
            txtMobileNumber.Clear();
            txtName.Clear();
            txtFatherName.Clear();
            txtMotherName.Clear();   //cleaning items
            txtEmail.Clear();
            txtPermanentAddress.Clear();
            txtCollegeName.Clear();
            txtIdProof.Clear();
            txtRoomNo.Clear();
            cmbLivingStatus.ResetText();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtMobileNumber.Text!="")
            {

            
            query = "select * from newStudent where mobile=" + txtMobileNumber.Text + "";  
            DataSet ds = fn.getData(query);//print information about the number entered in the txtmobileNumber to items
                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtName.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtFatherName.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtMotherName.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtEmail.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtPermanentAddress.Text = ds.Tables[0].Rows[0][6].ToString();
                    txtCollegeName.Text = ds.Tables[0].Rows[0][7].ToString();
                    txtIdProof.Text = ds.Tables[0].Rows[0][8].ToString();
                    txtRoomNo.Text = ds.Tables[0].Rows[0][9].ToString();
                    cmbLivingStatus.Text = ds.Tables[0].Rows[0][10].ToString();
                }
                else
                {
                    MessageBox.Show("No Record with this Mobile No Exists.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); //error message
                    clearAll();

                }
            }
            else
            {
                MessageBox.Show("Fill empty places!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string mobile = txtMobileNumber.Text;
            string name = txtName.Text;
            string fname = txtFatherName.Text;
            string mname = txtMotherName.Text;
            string email = txtEmail.Text;
            string paddress = txtPermanentAddress.Text;
            string college = txtCollegeName.Text;
            string idproof = txtIdProof.Text;
            Int64 roomNo = Int64.Parse(txtRoomNo.Text);
            string livingStatus = cmbLivingStatus.Text;
            query = "update newStudent set name='" + name + "',fname='" + fname + "',mname='" + mname + "',email='" + email + "',paddress='" + paddress + "',college='" + college + "',idproof='" + idproof + "',roomNo=" + roomNo + ",living='" + livingStatus + "' where mobile="+mobile+" update rooms set Booked='"+livingStatus+"' where roomNo="+roomNo+"";
            fn.setData(query, "Data Updation Succesful");  //updation query


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)  //confirmation
            {
                query = "delete from newStudent where mobile=" + txtMobileNumber.Text + "";  //deletion query
                fn.setData(query, "Student Record Deleated.");
                clearAll();
            }
        }
    }
}
