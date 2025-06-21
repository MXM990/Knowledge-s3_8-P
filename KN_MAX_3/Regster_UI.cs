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
        NewRegsterStunent new_reg;
        public Regster_UI()
        {
            InitializeComponent();
        }

        private void Re_stu_Click(object sender, EventArgs e)
        {
            new_reg = new NewRegsterStunent();
            new_reg.Show();
        }

        private void re_th_Click(object sender, EventArgs e)
        {

        }

        private void BACK_BT_Click(object sender, EventArgs e)
        {
            m_Main = new MainUI();
            m_Main.Show();
            this.Close();
        }
    }
}
