using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KN_MAX_3.SQL;

namespace KN_MAX_3
{
    public partial class MainUI : Form
    {
        Connection_SQL_MXM Conne_test;
        AddStudnt m_studnet_add;
        AddGender m_Gen;
        add_Class m_CLass;
        ADD_Tech m_tech;
        public MainUI()
        {
            InitializeComponent();
        }
        private void ADD_ST_bt_Click(object sender, EventArgs e)
        {
            m_studnet_add = new AddStudnt();
            m_studnet_add.Show();
            this.Hide();
        }
        private void ADD_GR_BT_Click(object sender, EventArgs e)
        {
            m_Gen = new AddGender();
            m_Gen.Show();
            this.Hide();
        }
        private void ADD_CL_BT_Click(object sender, EventArgs e)
        {
            m_CLass = new add_Class();
            m_CLass.Show();
            this.Hide();
        }
        private void ADD_TECH_BT_Click(object sender, EventArgs e)
        {
            m_tech = new ADD_Tech();
            m_tech.Show();
            this.Hide();
        }
        private void disply_data_Click(object sender, EventArgs e)
        {
            Disply disply = new Disply();
            disply.Show();
            this.Hide();
        }
        private void Reg_bt_Click(object sender, EventArgs e)
        {
            Regster_UI reg = new Regster_UI();
            reg.Show();
            this.Hide();
        }
        private void EXIT_BT_Click(object sender, EventArgs e)
        {
            DialogResult end = MessageBox.Show("Make Suer", "You Want Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (end == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        private void Test_bt_Click(object sender, EventArgs e)
        {
            Conne_test = new Connection_SQL_MXM();
            Conne_test.OpenConn();
            MessageBox.Show(Conne_test.Conne.State.ToString());
            Conne_test.CloesConn();
        }
    }
}
