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
    public partial class FrmAllStudentLiving : Form
    {
        function fn = new function();
        String query;
        public FrmAllStudentLiving()
        {
            InitializeComponent();
        }

        private void FrmAllStudentLiving_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 170);
            query = "select * from newStudent where living='Yes'";   //printing students  who living in a dormitory in datagritte
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); //closing
        }
    }
}
