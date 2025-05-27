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

namespace KN_MAX_3.SQL
{
    public partial class AddTeacher : Form
    {
        Insert in_th;
        MainUI mainUI;
        GetData m_get;
        List<model> m_models;

        public AddTeacher()
        {
            InitializeComponent();
            FillComboBoxUi();
        }
        private void FillComboBoxUi()
        {
            m_get = new GetData();  
            m_models = new List<model>();
            m_get.GetGender(m_models);
            foreach ( var set_gender in m_models)
            {
                Gender_Select_th.Items.Add(set_gender.type);
            }
        }


        private void ADD_bt_Click(object sender, EventArgs e)
        {
            Guid Gender_guid = new Guid();
            for (int i = 0; i < m_models.Count; i++)
            {
                if (m_models[i].type == Gender_Select_th.Text)
                {
                    Gender_guid = m_models[i].ID;
                }
            }
            in_th = new Insert();
            if (in_th.Insertth(name_th.Text, phone_th.Text, Gender_guid))
            {
                MessageBox.Show("ADD Done");
            }
            else
            {
                MessageBox.Show("Error!!!", "You Can't ADD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BACK_BT_Click(object sender, EventArgs e)
        {
            mainUI = new MainUI();
            mainUI.Show();
            this.Close();
        }
    }
}
