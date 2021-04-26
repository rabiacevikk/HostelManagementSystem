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
    public partial class FrmLeavedEmployee : Form
    {
        function fn = new function();
        string query;
        public FrmLeavedEmployee()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); //closing
        }

        private void FrmLeavedEmployee_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 150);
            query = "select * from  newEmployee where working='No'";  //select employees who have left their jobs
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];  //showing in datagridView
        }
    }
}
