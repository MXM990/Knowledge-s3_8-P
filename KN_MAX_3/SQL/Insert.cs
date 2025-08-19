using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

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
                Conne_Plus.OpenConn();
                string Qur_Insert_Gr = "INSERT INTO GENDER VALUES ('" + Guid.NewGuid() + "' , '" + Name_Of_Type + "')";
                Command_plus = new SqlCommand(Qur_Insert_Gr, Conne_Plus.Conne);
                Command_plus.ExecuteNonQuery();
                Conne_Plus.CloesConn();
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
                Conne_Plus.OpenConn();
                string Qur_Insert_Gr = "INSERT INTO CLASS VALUES ('" + Guid.NewGuid() + "','" + Name_Class + "' , " + max_size + ")";
                Command_plus = new SqlCommand(Qur_Insert_Gr, Conne_Plus.Conne);
                Command_plus.ExecuteNonQuery();
                Conne_Plus.CloesConn();
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
                Conne_Plus.OpenConn();
                string Qur_Insert_stu = "INSERT INTO STUDENT VALUES ('" + Guid.NewGuid() + "','" + Name_Stu + "' , '" + phone + "' , '" + Gr_Guid + "' )";
                Command_plus = new SqlCommand(Qur_Insert_stu, Conne_Plus.Conne);
                Command_plus.ExecuteNonQuery();
                Conne_Plus.CloesConn();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool InsertTech(string Name_th, string phone, Guid Gr_Guid)
        {
            try
            {
                Conne_Plus.OpenConn();
                string Qur_Insert_stu = "INSERT INTO TECH VALUES ('" + Guid.NewGuid() + "','" + Name_th + "' , '" + phone + "' , '" + Gr_Guid + "' )";
                Command_plus = new SqlCommand(Qur_Insert_stu, Conne_Plus.Conne);
                Command_plus.ExecuteNonQuery();
                Conne_Plus.CloesConn();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool InsertStudentInClass(Guid Class_guid, Guid stu_guid)
        {
            try
            {
                Conne_Plus.OpenConn();
                string Qur_Insert_stu_CLASS = "INSERT INTO STU_CLASS VALUES (NEWID() , @CLASS_GUID_SENDER , @STU_GUID_SENDER)";
                Command_plus = new SqlCommand(Qur_Insert_stu_CLASS, Conne_Plus.Conne);
                Command_plus.Parameters.AddWithValue("@CLASS_GUID_SENDER", Class_guid);
                Command_plus.Parameters.AddWithValue("@STU_GUID_SENDER", stu_guid);
                Command_plus.ExecuteNonQuery();
                Conne_Plus.CloesConn();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool insertTehcNew(Guid id_class, string name_th)
        {
            try
            {
                Conne_Plus.OpenConn();
                string Quray = @"DECLARE @GUID UNIQUEIDENTIFIER
                                 SET @GUID = ( SELECT TOP 1 ID FROM TECH 
                                 WHERE NAME_TECH = @nameTH)
                                 
								 IF	@GUID IS NOT NULL
								 BEGIN 
								 INSERT INTO TECH_CLASS VALUES 
                                 (NEWID() , @GUIDCLASS , @GUID)
								 END ";
                Command_plus = new SqlCommand(Quray, Conne_Plus.Conne);
                Command_plus.Parameters.AddWithValue("@nameTH", name_th);
                Command_plus.Parameters.AddWithValue("@GUIDCLASS", id_class);
                int row = Command_plus.ExecuteNonQuery();
                Conne_Plus.CloesConn();
                if (row == -1)
                {
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
