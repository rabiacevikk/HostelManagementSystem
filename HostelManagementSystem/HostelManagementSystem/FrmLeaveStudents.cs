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
    public partial class FrmLeaveStudents : Form
    {
        function fn = new function();
        string query;
        public FrmLeaveStudents()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();  //closing 
        }

        private void FrmLeaveStudents_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 170);
            query = "select * from newStudent where living='No'";//printing students who no longer stay in the dorm in datagritte
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];


        }
    }
}
