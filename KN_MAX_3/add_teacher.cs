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
    public partial class add_teacher : Form
    {
        MainUI mainUI;
        GetData m_Get_data;
        List<model> m_Gender;
        Insert m_add;
        public add_teacher()
        {
            InitializeComponent();
            FillComboBoxUi();
        }

        private void BACK_BT_Click(object sender, EventArgs e)
        {
            mainUI = new MainUI();
            mainUI.Show();
            this.Close();
        }
        private void FillComboBoxUi()
        {
            m_Gender = new List<model>();
            m_Get_data = new GetData();
            m_Get_data.GetGender(m_Gender);
            foreach (var item in m_Gender)
            {
                Gender_Select.Items.Add(item.type);
            }
        }

        private void ADD_bt_Click(object sender, EventArgs e)
        {
            Guid Gender_guid = new Guid();
            if (Gender_Select.Text == String.Empty || name_teac.Text == string.Empty || phone_teac.Text == string.Empty)
            {
                MessageBox.Show("Error!!!", "Empty Filed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < m_Gender.Count; i++)
            {
                if (m_Gender[i].type == Gender_Select.Text)
                {
                    Gender_guid = m_Gender[i].ID;
                }
            }
            m_add = new Insert();
            if (m_add.Insert_teac(name_teac.Text, phone_teac.Text,spec_teac.Text, Gender_guid))
            {
                MessageBox.Show("ADD Done");
            }
            else
            {
                MessageBox.Show("Error!!!", "You Can't ADD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
