using KN_MAX_3.SQL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace KN_MAX_3
{
    public partial class View_Data : Form
    {
        Connection_SQL_MXM Conne_Plus;
        SqlCommand Command_plus;
        SqlDataReader Reader;
        GetData m_Get_data;
        List<model> m_Class_choes;
        string query_all,query_View = "", Q_v="", query_Delete = "", query_Update = "";
        public View_Data(string Q_all, string Query_v , string Query_d, string Query_u)
        {
            InitializeComponent();
            Conne_Plus = new Connection_SQL_MXM();
            query_all = Q_all;
            query_View=Q_v = Query_v;
            query_Delete = Query_d;
            query_Update = Query_u;
            FillComboBoxClass();
            FillComboBoxGender();
            view();
        }
        private void view()
        {
            lv_Data.Items.Clear();
            Conne_Plus.OpenConn();
            Command_plus = new SqlCommand(query_View, Conne_Plus.Conne);
            Reader = Command_plus.ExecuteReader();
            int counter = 0;
            ListViewItem item;
            while (Reader.Read())
            {
                counter++;
                item = new ListViewItem(counter.ToString());
                item.SubItems.Add(Reader.GetSqlValue(0).ToString());
                item.SubItems.Add(Reader.GetSqlValue(1).ToString());
                item.SubItems.Add(Reader.GetSqlValue(2).ToString());
                item.SubItems.Add(Reader.GetSqlValue(3).ToString());
                lv_Data.Items.Add(item);
            }
            Conne_Plus.CloesConn();
        }
        private void FillComboBoxClass()
        {
            m_Class_choes = new List<model>();
            m_Get_data = new GetData();
            m_Get_data.GetClass(m_Class_choes);
            foreach (var item in m_Class_choes)
            {
                comb_class.Items.Add(item.Name);
            }
        }
        private void FillComboBoxGender()
        {
            m_Class_choes = new List<model>();
            m_Get_data = new GetData();
            m_Get_data.GetGender(m_Class_choes);
            foreach (var item in m_Class_choes)
            {
                if (item.type != "")
                {
                    comb_gender.Items.Add(item.type);
                }
            }
        }
        private void BACK_BT_Click(object sender, EventArgs e)
        {
            Disply disply = new Disply();
            disply.Show();
            this.Close();
        }
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked)
            {
                query_View = query_all;
            }
            else
            {
                query_View = Q_v;
            }
            tx_name.Text = tx_phone.Text = string.Empty;
            comb_class.SelectedIndex= comb_gender.SelectedIndex =-1;
            view();
        }
        private void bt_modify_Click(object sender, EventArgs e)
        {
            if (lv_Data.SelectedItems.Count > 0)
            {
                DialogResult ok = MessageBox.Show("The data will be modified", "Notice", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (ok == DialogResult.OK)
                {
                    if (lv_Data.SelectedItems[0].SubItems[3].Text == "Null")
                    {
                        MessageBox.Show("Please go to the booking interface", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tx_name.Text = tx_phone.Text = string.Empty;
                        comb_class.SelectedIndex = comb_gender.SelectedIndex = -1;
                        return;
                    }
                    Conne_Plus.OpenConn();
                    Command_plus = new SqlCommand(query_Update, Conne_Plus.Conne);
                    Command_plus.Parameters.AddWithValue("@new_name", tx_name.Text);
                    Command_plus.Parameters.AddWithValue("@new_phone", tx_phone.Text);
                    Command_plus.Parameters.AddWithValue("@newCLASS", comb_class.Text);
                    Command_plus.Parameters.AddWithValue("@new_gender", comb_gender.Text);
                    Command_plus.Parameters.AddWithValue("@name", lv_Data.SelectedItems[0].SubItems[1].Text);
                    Command_plus.Parameters.AddWithValue("@phone", lv_Data.SelectedItems[0].SubItems[2].Text);
                    Command_plus.Parameters.AddWithValue("@gender", lv_Data.SelectedItems[0].SubItems[4].Text);
                    int row = Command_plus.ExecuteNonQuery();
                    Conne_Plus.CloesConn();
                    if (row == -1)
                    {
                        MessageBox.Show("Modify not successful", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Modify successfully", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tx_name.Text = tx_phone.Text = string.Empty;
                        comb_class.SelectedIndex = comb_gender.SelectedIndex = -1;
                        view();
                    }
                }
            }
            else
            {
                MessageBox.Show("Select the item you want to edit.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void bt_remove_Click(object sender, EventArgs e)
        {
            if (lv_Data.SelectedItems.Count >0)
            {
                DialogResult ok = MessageBox.Show("Are you sure you want to delete the selected line?", "Notice", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (ok == DialogResult.OK)
                {
                    Conne_Plus.OpenConn();
                    Command_plus = new SqlCommand(query_Delete, Conne_Plus.Conne);
                    Command_plus.Parameters.AddWithValue("@name", tx_name.Text);
                    Command_plus.Parameters.AddWithValue("@phone", tx_phone.Text);
                    Command_plus.Parameters.AddWithValue("@class", comb_class.Text);
                    Command_plus.Parameters.AddWithValue("@gender", comb_gender.Text);
                    int row = Command_plus.ExecuteNonQuery();
                    Conne_Plus.CloesConn();
                    if (row == -1)
                    {
                        MessageBox.Show("Deletion not successful", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Deleted successfully", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tx_name.Text = tx_phone.Text = string.Empty;
                        comb_class.SelectedIndex = comb_gender.SelectedIndex = -1;
                        view();
                    }
                }
            }
            else
            {
                MessageBox.Show("Select the item to be deleted.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void lv_Data_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_Data.SelectedItems.Count > 0)
            {
                tx_name.Text = lv_Data.SelectedItems[0].SubItems[1].Text;
                tx_phone.Text = lv_Data.SelectedItems[0].SubItems[2].Text;
                comb_class.Text = lv_Data.SelectedItems[0].SubItems[3].Text;
                comb_gender.Text = lv_Data.SelectedItems[0].SubItems[4].Text;
            }
        }
    }
}
