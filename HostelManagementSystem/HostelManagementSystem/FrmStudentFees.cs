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
    public partial class FrmStudentFees : Form
    {
        function fn = new function();
        string query;
        public FrmStudentFees()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();  //closing
        }

        private void FrmStudentFees_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 125);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MMMM yyyy";  //setting dateTimePicker
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtMobileNumber.Text!="")
            {
                query = "select name,email,roomNo  from newStudent where mobile=" + txtMobileNumber.Text + "";  //import data for the number entered in the textbox
                DataSet ds=fn.getData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtName.Text = ds.Tables[0].Rows[0][0].ToString();  //print information about this number on items
                    txtEmailID.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtRoomNumber.Text = ds.Tables[0].Rows[0][2].ToString();
                    query = "select * from  fees where mobileNo=" + txtMobileNumber.Text + "";
                    DataSet ds2 = fn.getData(query);
                    dataGridView1.DataSource = ds2.Tables[0];
                    setDataGrid(txtMobileNumber.Text);
                }
                else
                {
                    MessageBox.Show("No Record Exist.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);  //warning message

                }
            }
        }
        public void setDataGrid(string mobile)
        {
            query = "select * from fees where mobileNo=" + mobile + "";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (txtMobileNumber.Text!="" && txtDuesAmount.Text!="")
            {
                query = "select * from fees where mobileNo=" + txtMobileNumber.Text + "and fmonth='" + dateTimePicker1.Text + "'";
                DataSet ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count==0)
                {
                    String mobile = txtMobileNumber.Text;
                    string month = dateTimePicker1.Text;
                    Int64 amount = Int64.Parse(txtDuesAmount.Text);
                    query = "insert into fees values (" + mobile + ",'" + month + "'," + amount + ")";  
                    fn.setData(query, " Fees Paid.");
                    clearAll();
                }
                else
                {
                    MessageBox.Show("No dues of " + dateTimePicker1.Text + " Left.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        public void clearAll()
        {
            txtMobileNumber.Clear();  //cleaning items
            txtName.Clear();
            txtDuesAmount.Clear();
            txtRoomNumber.Clear();
            txtEmailID.Clear();
            dataGridView1.DataSource = 0;
        }
    }
}
