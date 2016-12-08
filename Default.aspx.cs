using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Configuration;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string DBIP = ConfigurationSettings.AppSettings.Get("CrystalReport-DB-IP");
        string UserID = ConfigurationSettings.AppSettings.Get("CrystalReport-DB-UserID");
        string UserPassword = ConfigurationSettings.AppSettings.Get("CrystalReport-DB-UserPassword");   
        
        try
        {                     
            string rptFile = "";
            ReportDocument report = new ReportDocument();
            int i = Convert.ToInt16(Request["rpt"]);
            switch (i)
            {
                case 0:
                    rptFile = this.Server.MapPath("rpt/barcode.rpt");
                    report.Load(rptFile);                    
                    report.SetDatabaseLogon(UserID, UserPassword, DBIP, "northwest");
                    report.SetParameterValue("id", Request["id"] );
                break; 
                
                case 1:
                    rptFile = this.Server.MapPath("rpt/memberList.rpt");
                    report.Load(rptFile);   
                    report.SetDatabaseLogon(UserID, UserPassword, DBIP, "northwest");    
                break;  
                
                case 2:
                    rptFile = this.Server.MapPath("rpt/form1.rpt");
                    report.Load(rptFile);                    
                    report.SetDatabaseLogon(UserID, UserPassword, DBIP, "northwest");
                    report.SetParameterValue("id", Request["id"] );
                break;    
                
                case 3:
                    rptFile = this.Server.MapPath("rpt/form2.rpt");
                    report.Load(rptFile);                    
                    report.SetDatabaseLogon(UserID, UserPassword, DBIP, "northwest");
                    report.SetParameterValue("id", Request["id"] );
                 break;   
                 
                 case 4:
                    rptFile = this.Server.MapPath("rpt/form3.rpt");
                    report.Load(rptFile);                    
                    report.SetDatabaseLogon(UserID, UserPassword, DBIP, "northwest");
                    report.SetParameterValue("id", Request["id"] );
                 break;   
                 
                 
                 case 5:
                    rptFile = this.Server.MapPath("rpt/turnover.rpt");
                    report.Load(rptFile);                    
                    report.SetDatabaseLogon(UserID, UserPassword, DBIP, "northwest");
                    report.SetParameterValue("startDate", Request["startDate"] );
                    report.SetParameterValue("endDate", Request["endDate"] );
                 break;     
                 
                 case 6:
                    rptFile = this.Server.MapPath("rpt/form4.rpt");
                    report.Load(rptFile);                    
                    report.SetDatabaseLogon(UserID, UserPassword, DBIP, "northwest");
                    report.SetParameterValue("billNo", Request["billNo"] );
                   
                 break;           
                      
                
            }
           
            CrystalReportViewer1.ReportSource = report;
            CrystalReportViewer1.DataBind();            
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine("printReport=" + ex.Message);
        }
        
    }
}