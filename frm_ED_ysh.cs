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

                if (dt.Rows.Count > 1)
                {
                   DialogResult result= MessageBox.Show("동명이인환자가 있습니다.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        
       

        private void btnAcptSave_Click(object sender, EventArgs e)
        {
            DataTable dt = GetPatMst(txtPatId.Text.NtoE(), txtPatName.Text.NtoE());

            try
            {
                Hashtable hParam = new Hashtable();
                string query = string.Empty;
                int idx = 0;

                query = (@"INSERT INTO PATMST P
                                 ( P.PATID, P.PATNAME, P.PRSNIDPRE, P.PRSNIDPOST,
                                   P.SEX, P.HOMEADDR, P.HANDPHONENO,P.BIRTHDATE )
                           VALUES( ?,?,?,?,  
                                   ?,?,?,SYSDATE 
                                   )");

                hParam.Add(idx++, txtPatId.Text);
                hParam.Add(idx++, txtPatName.Text);
                hParam.Add(idx++, txtPrsnIdPre.Text);
                hParam.Add(idx++, txtPrsnIdPost.Text);
                hParam.Add(idx++, txtSex.Text);
                hParam.Add(idx++, txtAddress.Text);
                hParam.Add(idx++, txtHandPhoneNo.Text);
                hParam.Add(idx++, txtBirthDay.Text);

                MessageBox.Show("등록되었습니다.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (QryMgr.ExecuteNonQuery(query, hParam) < 0) throw new Exception();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

    }
}
