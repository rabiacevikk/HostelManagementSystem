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
    public partial class FrmAddNewRoom : Form
    {
        function fn = new function();
        String query;
        public FrmAddNewRoom()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();  //closing
        }

        private void FrmAddNewRoom_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 110);
            lblRoom.Visible = false;  //hiding
            lblRoomExist.Visible = false;
            query = "select * from rooms";  //a query to show room information
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            query = "select * from rooms where roomNo=" + txtRoomNo1.Text + "";    //a query that returns information about the room entered in the textbox
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count==0)
            {
                String status;
                if (true)
                {
                    status = "Yes";
                }
                else
                {
                    status = "No";
                }
                lblRoomExist.Visible = false;
                query = "insert into rooms (roomNo,roomStatus) values ("+txtRoomNo1.Text+",'"+status+"')";  //if there is no room belonging to this room number, we are adding
                fn.setData(query,"Room Added.");
                FrmAddNewRoom_Load(this, null);  //refresh
                checkBox1.Checked = false;
                txtRoomNo1.Clear();

            }
            else
            {
                lblRoomExist.Text = "Room All Ready Exist.";  //if there is a room, we print a label that gives this information
                lblRoomExist.Visible = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            query = "select * from rooms where roomNo=" + txtRoomNo2.Text + "";   //selection query
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count==0)
            {
                lblRoom.Text = "No Room Exist.";
                lblRoom.Visible = true;
                checkBox2.Checked = false;
            }
            else
            {
                lblRoom.Text = "Room Found.";
                lblRoom.Visible = true;
                if (ds.Tables[0].Rows[0][1].ToString()=="Yes")
                {
                    checkBox2.Checked = true;
                }
                else
                {
                    checkBox2.Checked = false;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String status;
            if (checkBox2.Checked)  //if the checkbox is checked
            {
                status = "Yes";
            }
            else   //else situation
            {
                status = "No";
            }
            query = "update rooms set roomStatus='" + status + "'  where roomNo="+txtRoomNo2.Text+"";  //updation 
            fn.setData(query, "Details updated.");
            checkBox2.Checked = false;
            txtRoomNo2.Clear();
            FrmAddNewRoom_Load(this, null);  //refresh
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lblRoom.Text=="Room Found.")
            {
                query = "delete from rooms where roomNo=" + txtRoomNo2.Text + "";  //deletion query
                fn.setData(query, "Room Details Deleated.");
                txtRoomNo2.Clear();
                checkBox2.Checked = false;
                FrmAddNewRoom_Load(this, null);  //refresh
            }
            else
            {
                MessageBox.Show("trying to delete which doesn't Exist","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);  //error message
            }
        }
    }
}
