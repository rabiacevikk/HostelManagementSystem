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
    public partial class FrmAllEmployeeWorking : Form
    {
        function fn = new function();
        string query;
        public FrmAllEmployeeWorking()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();  //closing
        }

        private void FrmAllEmployeeWorking_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 150); //we've set the location of the form
            query = "select  * from newEmployee where working ='Yes'";  //print employees whose working='Yes' in datagritView1
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
