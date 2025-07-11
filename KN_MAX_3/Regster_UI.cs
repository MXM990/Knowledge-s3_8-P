using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KN_MAX_3
{
    public partial class Regster_UI : Form
    {
        MainUI m_Main;
        RegsterStunent new_reg;
        Regster_techer h;
        public Regster_UI()
        {
            InitializeComponent();
        }
        private void Re_stu_Click(object sender, EventArgs e)
        {
            new_reg = new RegsterStunent();
            new_reg.Show();
            this.Hide();
        }
        private void re_th_Click(object sender, EventArgs e)
        {
            h = new Regster_techer();
            h.Show();
            this.Hide();
        }
        private void BACK_BT_Click(object sender, EventArgs e)
        {
            m_Main = new MainUI();
            m_Main.Show();
            this.Close();
        }
    }
}
