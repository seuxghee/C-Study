using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PointNet
{
    /// <summary>
    /// 설명: 환자 조회 test 폼
    /// 작성자: 양승희
    /// 작성일 :2024/08/07
    /// </summary>
    public partial class frm_PA_Test20240807 : PointFormBase  //PointFormBase로 바꿔주기

    {
        public frm_PA_Test20240807()
        {
            InitializeComponent();
        }
        
        private void utbtnSearch_Click(object sender, EventArgs e)
        {
            string query = "";
            Hashtable hParams = new Hashtable();
            DataSet ds = new DataSet();
            int idx = 0;

            query = @"SELECT PATID,PATNAME,CENT || PRSNIDPRE BIRTHDATE, SEX,HOMEADDR,HANDPHONENO
                      FROM   PATMST ";
            if (!string.IsNullOrEmpty(uttxtSearch.Text)) //검색칸이 비어있지 않을때 적용
            {
                string cond = "%" + uttxtSearch.Text + "%";
                query += "WHERE    (PATID LIKE ? OR PATNAME LIKE ?)"; 

                hParams.Add(idx++, cond);
                hParams.Add(idx++, cond);

                
            }
            QryMgr.ExecuteReader(out ds, query, hParams);

            utgrdPatList.SetDataBinding(ds.Tables[0], "", true);
        }
    }
}
