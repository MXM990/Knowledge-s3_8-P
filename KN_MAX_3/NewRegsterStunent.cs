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
    public partial class NewRegsterStunent : Form
    {
        MainUI m_Main;
        GetData m_Get_data;
        List<model> m_Class_choes;
        Insert m_add;
        CheackData Ch_D;
        public NewRegsterStunent()
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
             Ch_D.IsNameExist(name_stu.Text);
                MessageBox.Show(Ch_D.m_model.ID.ToString());
            }
            else
            {
               
            }
        }

        private void BACK_BT_Click(object sender, EventArgs e)
        {
            Regster_UI REg_UI = new Regster_UI();
            REg_UI.Show();
            this.Close();
        }

        private void Class_Select_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
