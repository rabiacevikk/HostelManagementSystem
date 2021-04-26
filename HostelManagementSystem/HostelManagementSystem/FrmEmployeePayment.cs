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
    public partial class FrmEmployeePayment : Form
    {
        function fn = new function();
        string query;
        public FrmEmployeePayment()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); //closing
        }

        private void FrmEmployeePayment_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 140);
            monthDateTime.Format = DateTimePickerFormat.Custom;
            monthDateTime.CustomFormat = "MMMMM yyyyy"; //setting datetime
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtMobileNumber.Text!="") //if the textbox is not empty
            {
                query = "select ename,eemail,edesignation from newEmployee where emobile=" + txtMobileNumber.Text + "";  //selection query
         DataSet ds= fn.getData(query);
                if (ds.Tables[0].Rows.Count!=0)
                {
                    txtName.Text = ds.Tables[0].Rows[0][0].ToString();  //print information from a table in a database to textboxes
                    txtEmailID.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtDesignation.Text = ds.Tables[0].Rows[0][2].ToString();
                    setDataGrid(txtMobileNumber.Text);
                }
                else
                {
                    MessageBox.Show("No Record Exist.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);  //error message
                }
            }
            else
            {
                MessageBox.Show("Enter some data.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);  //error message
                clearAll();  //cleaning after process
            }
        }
        public void setDataGrid(string mobile)
        {
            query = "select * from employeeSalary where mobileNo=" + mobile + ""; //a query to select data for the mobile number entered in the employesalary table
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnPaySalary_Click(object sender, EventArgs e)
        {
            if (txtMobileNumber.Text != "" && txtPaymentAmount.Text != "")
            {
                query = "select * from employeeSalary where mobileNo= " + txtMobileNumber.Text + " and fmonth = '" + monthDateTime.Text + "'";
                DataSet ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    String mobile = txtMobileNumber.Text;
                    string month = monthDateTime.Text;
                    Int64 amount = Int64.Parse(txtPaymentAmount.Text);
                    query = "insert into employeeSalary values (" + mobile + ",'" + month + "'," + amount + ")";  //insertion query
                    fn.setData(query, "Salary for month  " + monthDateTime.Text + " Paid");
                    setDataGrid(mobile);
                }
                else
                {
                    MessageBox.Show("Payment of " + monthDateTime.Text + " Done.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Fill!!");
            }

            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        public void clearAll()
        {
            txtMobileNumber.Clear();
            txtName.Clear();                        //Cleaning items
            txtPaymentAmount.Clear();
            txtDesignation.Clear();
            txtEmailID.Clear();
            dataGridView1.DataSource = 0;
            monthDateTime.ResetText();
        }
    }
    
}
