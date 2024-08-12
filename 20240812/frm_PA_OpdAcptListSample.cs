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
    public partial class frm_PA_OpdAcptListSample : PointFormBase
    {
        public frm_PA_OpdAcptListSample()
        {
            InitializeComponent();
        }

        private void uttxtSearch_EditorButtonClick(object sender, Infragistics.Win.UltraWinEditors.EditorButtonEventArgs e)
        {
            string query = "";
            Hashtable hParams = new Hashtable();
            DataSet ds = new DataSet();
            int idx = 0;

            query = @"SELECT O.PATID '환자명' , P.PATNAME , TO_CHAR(TO_DATE(O.OPDDATE, 'YYYYMMDD'), 'YYYY/MM/DD') , O.DEPTCODE , D.DEPTKORNAME , O.CHRGDRID , U.USRKORNAME 
                      FROM OPDACPT O, PATMST P, DEPTCODES D, USRMST U
                      WHERE O.PATID = P.PATID
		               AND O.DEPTCODE = D.DEPTCODE   
		               AND O.CHRGDRID = U.USRID
		               AND O.ACPTCANCELFLAG = 0
		               AND O.IPDFLAG = 0
                       ORDER BY O.OPDDATE, O.PATID ";

            if(!string.IsNullOrEmpty(uttxtSearch.Text))
            {
                string cond = "%" + uttxtSearch.Text + "%";
                query += "WHERE    (O.PATID LIKE ? OR P.PATNAME LIKE ?)";

                hParams.Add(idx++, cond);
                hParams.Add(idx++, cond);
            }
             QryMgr.ExecuteReader(out ds, query, hParams);

            utgrdPatList.SetDataBinding(ds.Tables[0], "", true);

        }

    }
}
