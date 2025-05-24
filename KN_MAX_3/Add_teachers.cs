using KN_MAX_3.SQL;
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
    public partial class Add_teachers : Form
    {
        Insert m_add;
        MainUI m_Main;
        public Add_teachers()
        {
            InitializeComponent();
        }

        private void ADD_bt_Click(object sender, EventArgs e)
        {
            if (name_teach.Text == String.Empty || name_class.Text == string.Empty )
            {
                MessageBox.Show("Error!!!", "Empty Filed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<object> TE_list = new List<object>();
            GetData getData = new GetData();
            getData.GetTeacher(TE_list);
            for (int i = 0; i < TE_list.Count; i++)
            {
                if (TE_list[i].ToString() == name_class.Text)
                {
                    m_add = new Insert();
                    if (m_add.InsertTeacher(name_teach.Text, name_class.Text))
                    {
                        MessageBox.Show("ADD Done");
                        name_teach.Text= name_class.Text=string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Error!!!", "You Can't ADD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return;
                }
                else if (i==TE_list.Count-1)
                {
                    MessageBox.Show("Error!!!", "name class not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BACK_BT_Click(object sender, EventArgs e)
        {
            m_Main = new MainUI();
            m_Main.Show();
            this.Close();
        }

        private void Add_teachers_Load(object sender, EventArgs e)
        {

        }

        private void Add_teachers_Load_1(object sender, EventArgs e)
        {

        }
    }
}
