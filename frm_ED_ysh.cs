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

namespace Education
{
    public partial class frm_ED_ysh : PointFormBase
    {
        public frm_ED_ysh()
        {
            InitializeComponent();
        }
        private DataTable GetPatMst(string pPatID)
        {
            try
            {
                string query = string.Empty;
                DataSet ds = new DataSet();
                int idx = 0;
                Hashtable hParams = new Hashtable();

                query = @"SELECT    P.PATID,              P.PATNAME,        P.CENT,           P.PRSNIDPRE,     P.PRSNIDPOST, 
                                    P.SEX,                P.HOMEZIPCODE,    P.HOMEADDR,       P.HOMETEL,       P.HANDPHONENO, 
                                    P.JOBZIPCODE,         P.JOBADDR,        P.JOBTEL,         P.JOBNAME,       P.STAFFDRID, 
                                    P.CLSSCODE,           P.CLSSSUBCODE,    P.FIRSTDATE,      P.LASTDATE,      P.LASTDEPTCODE, 
                                    P.POSITIONFLAG,       P.NONUSEFLAG,     P.SCANFLAG0,      P.SCANFLAG1,     P.SCANFLAG2, 
                                    P.OLDPATID,           P.REDUFLAG,       P.EMPNO,          P.PATRELATION,   P.WRTDATE, 
                                    P.WRTUSRID,           P.REDUCMMT,       P.EMAILADDR,      P.LUNARFLAG,     P.BIRTHDATE, 
                                    P.MOTHERID,           P.DMFLAG,         P.FOREIGNFLAG,    P.HANGREANO,     P.HANGREAFLAG, 
                                    P.REDUCODE,           P.PRSNINFO,       P.OWNFLAG,        P.BHFLAG,        P.VOUCHERFLAG, 
                                    P.ENCFLAG,            P.PRSNIDPOST_BAK, P.BEDSIDERFIDNO,  P.FTAX,          P.NATIONALCODE, 
                                    P.PATMEMO,            P.CARNO,          P.NEWHOMEZIPCODE, P.BUILDINGMGRNO, P.PATENGNAME, 
                                    P.CARINSTYPE,         P.FOREIGNFEEFLAG, P.SECURITY,       P.PATCMMT,       P.WMCMMT, 
                                    P.PROTECTPRIVATEFLAG, P.SMSFLAG,        P.NATIONCODE,     P.NATIONNAME,    P.VIPFLAG, 
                                    P.PASSPORTNO,         P.PATNAME2,       P.IDENTITYVERIFY, P.CARTYPE,       P.FOREGINCARFLAG, 
                                    P.FOREIGNCARFLAG,     P.PATGRADE,       P.PIFLAG,         P.PICMMT,        P.RECUSRID, 
                                    P.RELATEDGROUP,       P.SPORTCMMT,      P.CLAIMCMMT,      P.CLAIMFLAG,     P.BSTFLAG, 
                                    P.HBPFLAG,            P.PREGNANTFLAG,   P.CLAIMUSRID,     P.BCMEMO,        P.NAMETAG, 
                                    P.EVENTAPPLYFLAG,     P.EVENTAPPLYDATE, P.FALLDOWNFLAG,   P.CHKAD,         P.CHKCHART, 
                                    P.IDENTITYDATE,       P.DNR
                          FROM      PATMST P
                          WHERE     P.PATID = ? ";

                hParams.Add(idx++, pPatID);

                if (QryMgr.ExecuteReader(out ds, query, hParams) < 0) throw new Exception();

                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void btnResult_Click(object sender, EventArgs e) //조회버튼 클릭시 정보 불러오기
        {
            string query = "";
            Hashtable hParams = new Hashtable();
            DataSet ds = new DataSet();
            int idx = 0;


            query = @"SELECT PATID, PATNAME, PRSNIDPRE, PRSNIDPOST, SEX, HOMEADDR, HANDPHONENO, BIRTHDATE 
                      FROM   PATMST ";

          
            if (!string.IsNullOrEmpty(txtPatId.Text))
            {
                string cond = "%" + txtPatId.Text + "%";
                query += "WHERE    (PATID LIKE ?)";

                hParams.Add(idx++, cond);
              
               

            }
            QryMgr.ExecuteReader(out ds, query, hParams);

            txtPatName.DataBindings.Add("Text", ds.Tables[0], "PATNAME");
            txtPrsnIdPre.DataBindings.Add("Text", ds.Tables[0], "PRSNIDPRE");
            txtPrsnIdPost.DataBindings.Add("Text", ds.Tables[0], "PRSNIDPOST");
            txtSex.DataBindings.Add("Text", ds.Tables[0], "SEX");
            txtAddress.DataBindings.Add("Text", ds.Tables[0], "HOMEADDR");
            txtHandPhoneNo.DataBindings.Add("Text", ds.Tables[0], "HANDPHONENO");
            txtBirthDay.DataBindings.Add("Text", ds.Tables[0], "BIRTHDATE");
        }

      
    }
}
