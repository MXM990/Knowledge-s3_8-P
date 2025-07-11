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
    public partial class RegsterStunent : Form
    {
        MainUI m_Main;
        GetData m_Get_data;
        List<model> m_Class_choes;
        Insert m_add;
        CheackData Ch_D;
        public RegsterStunent()
        {
            InitializeComponent();
            FillComboBoxUi();
        }
        private void FillComboBoxUi()
        {
            m_Class_choes = new List<model>();
            m_Get_data = new GetData();
            m_Get_data.GetClass(m_Class_choes);
            foreach (var item in m_Class_choes)
            {
                Class_Select.Items.Add(item.Name);
            }
        }
        private void ADD_bt_Click(object sender, EventArgs e)
        {
            if (name_stu.Text != string.Empty && !string.IsNullOrEmpty(Class_Select.Text))
            {
                Ch_D = new CheackData();
                if (Ch_D.IsNameExist(name_stu.Text))
                {
                    Guid Class_Guid = new Guid();
                    int max_stu = 0;
                    for (int i = 0; i < m_Class_choes.Count; i++)
                    {
                        if (m_Class_choes[i].Name == Class_Select.Text)
                        {
                            Class_Guid = m_Class_choes[i].ID;
                            max_stu = Convert.ToInt32(m_Class_choes[i].maxsize_stu);
                        }
                    }
                    if (Ch_D.cheack_max_stu_in_class(max_stu))
                    {
                        m_add = new Insert();
                        if (m_add.InsertStudentInClass(Class_Guid, Ch_D.m_model.ID))
                        {
                            MessageBox.Show("add is done", "notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            name_stu.Text = string.Empty;
                            Class_Select.SelectedIndex = -1;

                        }
                        else
                        {
                            MessageBox.Show("You Can't ADD", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("This class cannot be booked because it is full.", "notice!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("the user " + name_stu.Text + " is not Exist", "not Found User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Empty Fild", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BACK_BT_Click(object sender, EventArgs e)
        {
            Regster_UI REg_UI = new Regster_UI();
            REg_UI.Show();
            this.Close();
        }
    }
}
