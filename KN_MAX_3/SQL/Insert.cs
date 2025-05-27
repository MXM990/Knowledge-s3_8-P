using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Forms;

namespace KN_MAX_3.SQL
{
    internal class Insert
    {
        Connection_SQL_MXM Conne_Plus;
        SqlCommand Command_plus;

        public Insert()
        {
            Conne_Plus = new Connection_SQL_MXM();
        }
        public bool InsertGender(string Name_Of_Type)
        {
            try
            {
                if (Name_Of_Type != "")
                {
                    Conne_Plus.OpenConn();
                    string Qur_Insert_Gr = "INSERT INTO GENDER VALUES ('" + Guid.NewGuid() + "' , '" + Name_Of_Type + "')";
                    Command_plus = new SqlCommand(Qur_Insert_Gr, Conne_Plus.Conne);
                    Command_plus.ExecuteNonQuery();
                    Conne_Plus.CloesConn();
                
                }
                else
                {
                    MessageBox.Show("Yuo must add type","Erorr",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    return false;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool InsertClass(string Name_Class, int max_size)
        {
            try
            {
                if (Name_Class != "" && max_size >= 0)
                {
                    Conne_Plus.OpenConn();
                    string Qur_Insert_Gr = "INSERT INTO CLASS VALUES ('" + Guid.NewGuid() + "','" + Name_Class + "' , " + max_size + ")";
                    Command_plus = new SqlCommand(Qur_Insert_Gr, Conne_Plus.Conne);
                    Command_plus.ExecuteNonQuery();
                    Conne_Plus.CloesConn();
                }
                else
                {
                    MessageBox.Show("Yuo must add type", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
               
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Insertstu(string Name_Stu, string phone, Guid Gr_Guid)
        {
            try
            {
                if(Name_Stu!= "" && phone != "" && Gr_Guid.ToString() != "")
                {
                    Conne_Plus.OpenConn();
                    string Qur_Insert_stu = "INSERT INTO STUDENT VALUES ('" + Guid.NewGuid() + "','" + Name_Stu + "' , '" + phone + "' , '" + Gr_Guid + "' )";
                    Command_plus = new SqlCommand(Qur_Insert_stu, Conne_Plus.Conne);
                    Command_plus.ExecuteNonQuery();
                    Conne_Plus.CloesConn();
                }
                else
                {
                    MessageBox.Show("Yuo must add type", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Insertth(string Name_Th , string phone , Guid Gr_Guid)
        {
            try
            {
                if (Name_Th != "" && phone != "" && Gr_Guid.ToString() != "")
                {
                    Conne_Plus.OpenConn();
                    string Qur_Insert_stu = "INSERT INTO TESH VALUES ('" + Guid.NewGuid() + "','" + Name_Th + "' , '" + phone + "' , '" + Gr_Guid + "' )";
                    Command_plus = new SqlCommand(Qur_Insert_stu, Conne_Plus.Conne);
                    Command_plus.ExecuteNonQuery();
                    Conne_Plus.CloesConn();
                }
                else
                {
                    MessageBox.Show("Yuo must add type", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
