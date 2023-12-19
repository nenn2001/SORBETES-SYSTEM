using Dbsys.AppData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dbsys.Forms
{
    public partial class Frm_Admin : Form
    {
        private  db;
        private UserRepository userRepo;
        public Frm_Admin()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            db = new DBSYSEntities();
            dgv_admin.DataSource = db.vw_addrole.ToList();
        }

        private void Frm_Admin_Load(object sender, EventArgs e)
        {
            dgv_admin.DataSource = userRepo.AllUserRole();

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
