using KN_MAX_3.SQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KN_MAX_3
{
    public partial class Disply : Form
    {
        MainUI m_Main;
        string query_v = "", query_viewall="", query_d="",query_u="";
        public Disply()
        {
            InitializeComponent();
        }
        private void BACK_BT_Click(object sender, EventArgs e)
        {
            m_Main = new MainUI();
            m_Main.Show();
            this.Close();
        }
        private void di_stu_Click(object sender, EventArgs e)
        {
            query_viewall = @"select ST.NAME_STU,ST.PHONE,cl.NAME_CLASS,GR.KIND from STUDENT ST
                            INNER JOIN GENDER GR ON ST.GUID_GEN=GR.ID
                            left join STU_CLASS stcl on st.ID=stcl.GUID_STU
                            left join CLASS cl on stcl.GUID_CLASS=cl.ID";

            query_v = @"select STU.NAME_STU,STU.PHONE,CL.NAME_CLASS, GR.KIND from STUDENT STU 
                        INNER JOIN  STU_CLASS STCL ON STU.ID=STCL.GUID_STU
                        INNER JOIN CLASS CL ON STCL.GUID_CLASS = CL.ID
                        INNER JOIN GENDER GR ON STU.GUID_GEN=GR.ID";
          
            query_d = @"DECLARE @GUID UNIQUEIDENTIFIER;
                        SET @GUID = (SELECT ST.ID from STUDENT ST
						INNER JOIN GENDER GR ON ST.GUID_GEN=GR.ID
						left JOIN STU_CLASS stcl on st.ID=stcl.GUID_STU
						left JOIN CLASS cl on stcl.GUID_CLASS=cl.ID
						WHERE ST.NAME_STU=@name and ST.PHONE=@phone and GR.KIND=@gender and  (cl.NAME_CLASS=@class or cl.NAME_CLASS  is NULL ) )
                        IF @GUID IS NOT NULL
                        BEGIN
                        DELETE STU_CLASS WHERE GUID_STU = @GUID;
                        DELETE STUDENT WHERE ID = @GUID;
                        END;";

            query_u = @"DECLARE @GUIDGR UNIQUEIDENTIFIER
						SET @GUIDGR=(SELECT ID FROM GENDER WHERE KIND=@new_gender)

						UPDATE STUDENT 
                        SET 
                         NAME_STU=@new_name,
                         PHONE=@new_phone,
                         GUID_GEN=@GUIDGR
                        WHERE NAME_STU=@name and PHONE=@phone AND GUID_GEN=(SELECT ID FROM GENDER WHERE KIND=@gender)

						update STU_CLASS
						SET GUID_CLASS=(SELECT ID FROM CLASS WHERE NAME_CLASS=@newCLASS)
						WHERE GUID_STU=(SELECT ID FROM STUDENT WHERE NAME_STU=@new_name AND PHONE=@new_phone AND GUID_GEN=@GUIDGR)";

            View_Data view=new View_Data(query_viewall, query_v, query_d, query_u);
            view.ShowDialog();
        }
        private void di_tech_Click(object sender, EventArgs e)
        {
            query_viewall = @"select TE.NAME_TECH,TE.PHONE,CL.NAME_CLASS ,GR.KIND from TECH TE 
                        INNER JOIN GENDER GR ON TE.GUID_GEN=GR.ID
                        left JOIN  TECH_CLASS TECL ON TE.ID=TECL.GUID_TECH
                        left JOIN CLASS CL ON TECL.GUID_CLASS = CL.ID";

            query_v = @"select TE.NAME_TECH,TE.PHONE,CL.NAME_CLASS ,GR.KIND from TECH TE 
                        INNER JOIN  TECH_CLASS TECL ON TE.ID=TECL.GUID_TECH
                        INNER JOIN CLASS CL ON TECL.GUID_CLASS = CL.ID
                        INNER JOIN GENDER GR ON TE.GUID_GEN=GR.ID
                        ";
            query_d = @"
                        DECLARE @GUID UNIQUEIDENTIFIER
                        SET @GUID= (select TE.ID from TECH TE 
						INNER JOIN GENDER GR ON TE.GUID_GEN=GR.ID
						left JOIN  TECH_CLASS TECL ON TE.ID=TECL.GUID_TECH
						left JOIN CLASS CL ON TECL.GUID_CLASS = CL.ID
						WHERE TE.NAME_TECH=@name and TE.PHONE=@phone  and GR.KIND=@gender and (cl.NAME_CLASS=@class or cl.NAME_CLASS  is NULL ) )

                        IF @GUID IS NOT NULL
                        BEGIN

		                        DELETE TECH_CLASS WHERE GUID_TECH =@GUID	
		                        DELETE TECH    WHERE ID=@GUID
                        END";
  
            query_u = @"DECLARE @GUIDGR UNIQUEIDENTIFIER
						SET @GUIDGR=(SELECT ID FROM GENDER WHERE KIND=@new_gender)
                         UPDATE TECH 
                        SET 
                         NAME_TECH=@new_name,
                         PHONE=@new_phone,
                         GUID_GEN=@GUIDGR
                        WHERE NAME_TECH=@name and PHONE=@phone AND GUID_GEN=(SELECT ID FROM GENDER WHERE KIND=@gender)

						update TECH_CLASS
						SET GUID_CLASS=(SELECT ID FROM CLASS WHERE NAME_CLASS=@newCLASS)
						WHERE GUID_TECH=(SELECT ID FROM STUDENT WHERE NAME_STU=@new_name AND PHONE=@new_phone AND GUID_GEN=@GUIDGR)";

            View_Data view = new View_Data(query_viewall, query_v, query_d, query_u);
            view.ShowDialog();
        }
    }
}
