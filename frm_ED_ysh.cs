using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PointNet.Global;



namespace Education
{
    public partial class frm_ED_ysh : PointFormBase
    {
        int W_PD_PATID_RULE_STATE = 1;

        public frm_ED_ysh()
        {
            InitializeComponent();
        }
        private DataTable GetPatMst(string pPatID, string pPatName)
        {
            try
            {
                string query = string.Empty;
                DataSet ds = new DataSet();
                int idx = 0;
                Hashtable hParams = new Hashtable();

                query = @"SELECT    P.PATID, P.PATNAME, P.PRSNIDPRE, P.PRSNIDPOST,
                                    P.SEX, P.HOMEADDR, P.HANDPHONENO,P.BIRTHDATE
                          FROM      PATMST P
                          WHERE     P.PATID = ? 
                             OR     P.PATNAME = ? ";


                hParams.Add(idx++, txtPatId.Text);
                hParams.Add(idx++, txtPatName.Text);

                if (QryMgr.ExecuteReader(out ds, query, hParams) < 0) throw new Exception();

                return ds.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        //접수등록 버튼
        private void btnResult_Click(object sender, EventArgs e)
        {

            try
            {
                DataTable dt = GetPatMst(txtPatId.Text.NtoE(), txtPatName.Text.NtoE());


                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("환자데이터가 존재하지 않습니다.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                //동명이인환자가 있을때 
                if (dt.Rows.Count > 1)
                {
                    DialogResult result = MessageBox.Show("동명이인환자가 있습니다.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = dt;
                    if (result == DialogResult.OK)
                    {
                        dataGridView1.Visible = true; // DataGridView를 표시
                    }
                    return;
                }

                DataRow drow = dt.Rows[0];


                if (!string.IsNullOrEmpty(txtPatId.Text) || !string.IsNullOrEmpty(txtPatName.Text))
                {
                    // PATID가 비어 있으면 DataRow에서 가져옴 (이름으로 검색된 경우)
                    if (string.IsNullOrEmpty(txtPatId.Text))
                    {
                        txtPatId.Text = drow["PATID"].NtoE();
                    }

                    // PATNAME가 비어 있으면 DataRow에서 가져옴 (ID로 검색된 경우)
                    if (string.IsNullOrEmpty(txtPatName.Text))
                    {
                        txtPatName.Text = drow["PATNAME"].NtoE();

                    }

                    // 공통 데이터 설정
                    txtPrsnIdPre.Text = drow["PRSNIDPRE"].NtoE();
                    txtPrsnIdPost.Text = drow["PRSNIDPOST"].NtoE();
                    txtSex.Text = drow["SEX"].NtoE();
                    txtAddress.Text = drow["HOMEADDR"].NtoE();
                    txtHandPhoneNo.Text = drow["HANDPHONENO"].NtoE();
                    txtBirthDay.Text = drow["BIRTHDATE"].NtoE();
                }
                else
                {
                    MessageBox.Show("ID 또는 이름을 입력하세요.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        //그리드 창에서 선택하고자하는 환자 더블클릭시 선택됨
        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // 클릭한 셀의 행 인덱스를 확인
                if (e.RowIndex >= 0)
                {
                    // 선택된 행의 DataRow 가져오기
                    DataRow selectedRow = ((DataRowView)dataGridView1.Rows[e.RowIndex].DataBoundItem).Row;

                    // 선택된 환자 정보를 텍스트박스에 표시
                    txtPatId.Text = selectedRow["PATID"].ToString();
                    txtPatName.Text = selectedRow["PATNAME"].ToString();
                    txtPrsnIdPre.Text = selectedRow["PRSNIDPRE"].ToString();
                    txtPrsnIdPost.Text = selectedRow["PRSNIDPOST"].ToString();
                    txtSex.Text = selectedRow["SEX"].ToString();
                    txtAddress.Text = selectedRow["HOMEADDR"].ToString();
                    txtHandPhoneNo.Text = selectedRow["HANDPHONENO"].ToString();
                    txtBirthDay.Text = selectedRow["BIRTHDATE"].ToString();

                    dataGridView1.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //초기화
        private void btnNew_Click(object sender, EventArgs e)
        {
            txtPatId.Text = "";
            txtPatName.Text = "";
            txtPrsnIdPre.Text = "";
            txtPrsnIdPost.Text = "";
            txtSex.Text = "";
            txtAddress.Text = "";
            txtHandPhoneNo.Text = "";
            txtBirthDay.Text = "";

        }

        //신규환자 정보 생성 코드
        private void InsertPatient()
        {

            try
            {

                Hashtable hParams = new Hashtable();
                string query = string.Empty;
                int idx = 0;

                query = (@"INSERT INTO PATMST  
		                          (PATID,              PATNAME,       CENT,           PRSNIDPRE,         PRSNIDPOST, 
                                   SEX,                HOMEADDR,      HANDPHONENO,    BIRTHDATE,         NONUSEFLAG,        
                                   WRTDATE,            WRTUSRID,      CARINSTYPE,     FOREIGNFEEFLAG,    PROTECTPRIVATEFLAG)  
		                   VALUES ( ?, ?, ?, ?, ?,  
		                            ?, ?, ?, ?, 0,
                                    SYSDATE, 'ysh', '0', 0, 0)");

                string newPatId = GetPatIDCreate();

                hParams.Add(idx++, newPatId);
                hParams.Add(idx++, txtPatName.Text);
                hParams.Add(idx++, "20");
                hParams.Add(idx++, txtPrsnIdPre.Text);
                hParams.Add(idx++, txtPrsnIdPost.Text);

                hParams.Add(idx++, txtSex.Text);
                hParams.Add(idx++, txtAddress.Text);
                hParams.Add(idx++, txtHandPhoneNo.Text);
                hParams.Add(idx++, txtBirthDay.Text);


                if (QryMgr.ExecuteNonQuery(query, hParams) < 0) throw new Exception();

                MessageBox.Show(newPatId + " 생성되었습니다.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string GetPatIDCreate()
        {
            try
            {
                string pPatID = string.Empty;
                DataSet ds;
                string query = string.Empty;
                DataRowCollection dRC;
                Hashtable hParam = new Hashtable();


                DataTable dt = null;

                switch (W_PD_PATID_RULE_STATE)
                {
                    case 0:
                        query = @" SELECT CREATEDATE, TO_CHAR(LPAD(LASTPATID + 1, 8, 0)) LASTPATID
                                   FROM PATIDCREATE 
                                   WHERE CREATEDATE = '0000' ";
                        break;

                    case 1:

                        query = @" SELECT CREATEDATE, TO_CHAR(LPAD(LASTPATID + 1, 8, 0)) LASTPATID
                                   FROM PATIDCREATE 
                                   WHERE CREATEDATE = TO_CHAR(SYSDATE, 'YYYY') ";
                        break;

                    case 2:
                      
                        query = @" SELECT CREATEDATE, TO_CHAR(SUBSTR(LASTPATID + 1, 5)) LASTPATID
                                   FROM PATIDCREATE 
                                   WHERE CREATEDATE = SUBSTR(TO_CHAR(SYSDATE, 'YYYY'), 3, 2 ) || TO_CHAR(SYSDATE,'MM') ";
                        break;

                   
                    case 4:
                        query = @" SELECT CREATEDATE, TO_CHAR(LPAD(LASTPATID + 1, 6, 0)) LASTPATID
                                   FROM PATIDCREATE 
                                   WHERE CREATEDATE = TO_CHAR(SYSDATE, 'YYYY') ";
                        break;
                   
                    case 5:
                        query = dt.Rows[0]["CMDSELECT"].NtoE();

                        break;

                    default:
                        query = @" SELECT CREATEDATE, TO_CHAR(LPAD(LASTPATID + 1, 8, 0)) LASTPATID
                                   FROM PATIDCREATE 
                                   WHERE CREATEDATE = '0000' ";
                        break;
                }

                QryMgr.ExecuteReader(out ds, query);
                dRC = ds.Tables[0].Rows;

                foreach (DataRow dRow in dRC)
                {
                    switch (W_PD_PATID_RULE_STATE)
                    {
                        case 0:
                            pPatID = dRow["LASTPATID"].ToString();
                            break;

                        case 1:
                            pPatID = dRow["CREATEDATE"].ToString().Substring(2, 2) + dRow["LASTPATID"].ToString().Substring(2, 6);
                            break;

                        case 2:
                            pPatID = dRow["CREATEDATE"].ToString() + dRow["LASTPATID"].ToString();
                            break;

                        case 4:
                            pPatID = dRow["LASTPATID"].ToString();
                            break;

                        case 5:
                            pPatID = dRow["LASTPATID"].ToString();
                            break;

                        default:
                            pPatID = dRow["LASTPATID"].ToString();
                            break;
                    }
                }

                ds.Dispose();

                if (string.IsNullOrEmpty(pPatID))
                {
                    switch (W_PD_PATID_RULE_STATE)
                    {
                        case 0:
                            query = @" INSERT INTO PATIDCREATE
                                       (CREATEDATE, LASTPATID) 
                                       VALUES ('0000', 1) ";

                            pPatID = "00000001";
                            break;

                        case 1:
                            query = @" INSERT INTO PATIDCREATE
                                       (CREATEDATE, LASTPATID) 
                                       VALUES (TO_CHAR(SYSDATE, 'YYYY'), 1) ";

                            pPatID = DateUtil.ParseDate(DateUtil.GetDateToText(), 1) + "000001";
                            break;

                        case 2:
                          
                            query = @" INSERT INTO PATIDCREATE
                                                    (CREATEDATE, LASTPATID) 
                                                    VALUES (TO_CHAR(SYSDATE, 'YYMM'), TO_CHAR(SYSDATE, 'YYMM')||'0001') ";
                        

                            pPatID = DateUtil.ParseDate(DateUtil.GetDateToText(), 1) + DateUtil.ParseDate(DateUtil.GetDateToText(), 2) + "0001";
                            break;

                        case 4:
                            query = @" INSERT INTO PATIDCREATE
                                       (CREATEDATE, LASTPATID) 
                                       VALUES (TO_CHAR(SYSDATE, 'YYYY'), 1) ";

                            pPatID = "000001";
                            break;
                      

                        case 5:
                            query = dt.Rows[0]["CMDINSERT"].NtoE();
                            pPatID = "0001";
                            break;

                        default:
                            query = @" INSERT INTO PATIDCREATE
                                       (CREATEDATE, LASTPATID) 
                                       VALUES ('0000', 1) ";

                            pPatID = "00000001";
                            break;
                    }
                }
                else
                {
                    switch (W_PD_PATID_RULE_STATE)
                    {
                        case 0:
                            query = @" UPDATE PATIDCREATE
                                       SET LASTPATID = ?
                                       WHERE CREATEDATE = '0000' ";

                            break;

                        case 1:
                        case 4:

                            query = @" UPDATE PATIDCREATE
                                       SET LASTPATID = ?
                                       WHERE CREATEDATE = TO_CHAR(SYSDATE, 'YYYY') ";

                            break;

                        case 2:
                            query = @" UPDATE PATIDCREATE
                                       SET LASTPATID = ?
                                       WHERE CREATEDATE = SUBSTR(TO_CHAR(SYSDATE, 'YYYY'), 3, 2 ) || TO_CHAR(SYSDATE,'MM') ";


                            break;

                        case 5:
                            query = dt.Rows[0]["CMDFORUPDATE"].NtoE();
                            pPatID = (pPatID.NtoI() + 1).NtoE();
                            break;

                        default:
                            query = @" UPDATE PATIDCREATE
                                       SET LASTPATID = ?
                                       WHERE CREATEDATE = '0000' ";

                            break;
                    }
                    hParam.Add(1, pPatID);
                }

                QryMgr.ExecuteNonQuery(query, hParam);

                if (W_PD_PATID_RULE_STATE == 4)
                {
                    return GetBaseCodesPTID() + pPatID;
                }
                else if (W_PD_PATID_RULE_STATE == 5)
                {
                    query = dt.Rows[0]["CMDSELECT"].NtoE();
                    QryMgr.ExecuteReader(out ds, query);
                    return ds.Tables[0].Rows[0][0].NtoE() + ds.Tables[0].Rows[0][1].NtoE().PadLeft(4, '0');

                }
                else
                {
                    return pPatID;
                }
                //
            }
            catch (Exception ex)
            {
                return string.Empty;
            }
        }

        private string GetBaseCodesPTID()
        {
            try
            {
                Hashtable hParams = new Hashtable();
                DataSet ds;

                string query = @" SELECT TO_CHAR(SYSDATE, 'YY') NOWYEAR FROM DUAL";

                QryMgr.ExecuteReader(out ds, query);

                string nowyear = ds.Tables[0].Rows[0]["NOWYEAR"].NtoE();
                ds = null;

                query = @" SELECT CODEVALUE 
                           FROM BASECODES
                           WHERE BASECODESTATE = ?
                                 AND BASECODE = ? ";

                hParams.Add(1, "PTID");
                hParams.Add(2, nowyear);

                if (QryMgr.ExecuteReader(out ds, query, hParams) < 0) throw new Exception();

                if (ds.Tables[0].Rows.Count == 0)
                {
                    return nowyear;
                }
                else
                {
                    return ds.Tables[0].Rows[0]["CODEVALUE"].NtoE();
                }
            }
            catch (Exception ex)
            {
                return "00";
            }
        }
       
        //신규환자 정보 수정 코드
        private void UpdatePatient() 
        {
            try
            {
               
                Hashtable hParams = new Hashtable();
                string query = string.Empty;
                int idx = 1;
               
                query = (@" UPDATE PATMST 
                            SET PATNAME = ?,    PRSNIDPRE = ?,      PRSNIDPOST = ?,
                                  SEX = ?,   HOMEADDR = ?,   HANDPHONENO = ?,    BIRTHDATE = ?
                            WHERE PATID = ?");

               
                hParams.Add(idx++, txtPatName.Text);  
                hParams.Add(idx++, txtPrsnIdPre.Text);       
                hParams.Add(idx++, txtPrsnIdPost.Text); 
    
                hParams.Add(idx++, txtSex.Text);            
                hParams.Add(idx++, txtAddress.Text);       
                hParams.Add(idx++, txtHandPhoneNo.Text);    
                hParams.Add(idx++, txtBirthDay.Text);    
   
                hParams.Add(idx++, txtPatId.Text);           
            

                if (QryMgr.ExecuteNonQuery(query, hParams) < 0) throw new Exception();

                MessageBox.Show( "수정되었습니다.");
             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //환자정보 삭제 코드
        private void DeletePatient()
        {
            try
            {
                Hashtable hParams = new Hashtable();
                string query = string.Empty;
                int idx = 1;
               
                query = (@" DELETE FROM PATMST WHERE PATID = ? "); 
   
                hParams.Add(idx++, txtPatId.Text);           
            

                if (QryMgr.ExecuteNonQuery(query, hParams) < 0) throw new Exception();

                MessageBox.Show( "삭제되었습니다.");
             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //등록버튼
        private void btnAcptSave_Click(object sender, EventArgs e)
        {

            try
            {
                InsertPatient();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //수정버튼
        private void btnUpd_Click(object sender, EventArgs e)
        {
            try
            {
                UpdatePatient();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //삭제버튼
        private void btnDel_Click(object sender, EventArgs e)
        {
            DeletePatient();
        }

    }
}
