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
    public partial class frm_PA_Test20240807 : PointFormBase

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
            if (!string.IsNullOrEmpty(uttxtSearch.Text))
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
