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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)    
        {
            if (txtUsername.Text=="rabiacevikk" && txtPass.Text=="pass")
            {
                FrmDashboard fr = new FrmDashboard();  //if the user enter the correct username and password, the dashboard opens
                this.Hide();
                fr.ShowDialog();
            }
            else
            {
                txtPass.Clear();  //otherwise, it deletes the entered password
            }
        }
    }
}
