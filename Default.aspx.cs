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
	  string onlinePDF="D:\\IIS\\northwest_RPT\\workOrders\\";
	
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
            string randomId=Request["randomId"];
            string billno=Request["billno"];
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
                 
                 case 7:
                    rptFile = this.Server.MapPath("rpt/productSUM.rpt");
                    report.Load(rptFile);                    
                    report.SetDatabaseLogon(UserID, UserPassword, DBIP, "northwest");
                    report.SetParameterValue("billNo", Request["billNo"] );                   
                 break;     
                 
                 case 8:
                    rptFile = this.Server.MapPath("rpt/productSUMBatch_NotFinish.rpt");
                    report.Load(rptFile);                    
                    report.SetDatabaseLogon(UserID, UserPassword, DBIP, "northwest");      
                 break;
                 
                 case 9:
                    rptFile = this.Server.MapPath("rpt/productSUMBatch_Finish.rpt");
                    report.Load(rptFile);                    
                    report.SetDatabaseLogon(UserID, UserPassword, DBIP, "northwest");      
                 break;
                    
                 case 10:
                    rptFile = this.Server.MapPath("rpt/product_report.rpt");
                    report.Load(rptFile);                    
                    report.SetDatabaseLogon(UserID, UserPassword, DBIP, "northwest");      
                 break;     
                
                 case 11:
                    rptFile = this.Server.MapPath("rpt/product_report2.rpt");
                    report.Load(rptFile);                    
                    report.SetDatabaseLogon(UserID, UserPassword, DBIP, "northwest");      
                 break;
                 
                  case 12:
                    rptFile = this.Server.MapPath("rpt/Report3.rpt");
                    report.Load(rptFile);                    
                    report.SetDatabaseLogon(UserID, UserPassword, DBIP, "northwest");
                    report.SetParameterValue("saleNo", Request["saleNo"] );
                    report.SetParameterValue("startDate", Request["startDate"] );
                    report.SetParameterValue("endDate", Request["endDate"] );        
                 break;   
                 
                  case 13:
                    rptFile = this.Server.MapPath("rpt/workOrder.rpt");
                    report.Load(rptFile);                    
                    report.SetDatabaseLogon(UserID, UserPassword, DBIP, "northwest");
                    report.SetParameterValue("id", Request["id"] );                        
                 break; 
                 
                  case 14:
                    rptFile = this.Server.MapPath("rpt/Logistics.rpt");
                    report.Load(rptFile);                    
                    report.SetDatabaseLogon(UserID, UserPassword, DBIP, "northwest");
                    report.SetParameterValue("id", Request["id"] ); 
                    saveDisk1(report, billno);                           
                 break; 
                 
                  case 16:
                    rptFile = this.Server.MapPath("rpt/product_report2_daily.rpt");
                    report.Load(rptFile);                    
                    report.SetDatabaseLogon(UserID, UserPassword, DBIP, "northwest"); 
                    report.SetParameterValue("date", Request["date"] );        
                 break;
                 
                 
                  case 17:
                    rptFile = this.Server.MapPath("rpt/Logistics1.rpt");
                    report.Load(rptFile);                    
                    report.SetDatabaseLogon(UserID, UserPassword, DBIP, "northwest");
                    report.SetParameterValue("id", Request["id"] ); 
                    saveDisk1(report, billno);                       
                 break; 
                 
                  case 18:
                    rptFile = this.Server.MapPath("rpt/Logistics2.rpt");
                    report.Load(rptFile);                    
                    report.SetDatabaseLogon(UserID, UserPassword, DBIP, "northwest");
                    report.SetParameterValue("id", Request["id"] );    
                    saveDisk1(report, billno);                    
                 break; 
                 
                  case 19:
                    rptFile = this.Server.MapPath("rpt/Report5.rpt");
                    report.Load(rptFile);                    
                    report.SetDatabaseLogon(UserID, UserPassword, DBIP, "northwest"); 
                    report.SetParameterValue("start", Request["start"] );     
                    report.SetParameterValue("end", Request["end"] );      
                 break;
                 
                 case 20:
                    rptFile = this.Server.MapPath("rpt/CIPCR001.rpt");
                    report.Load(rptFile);                    
                    report.SetDatabaseLogon(UserID, UserPassword, DBIP, "northwest");                      
                 break;
                 
                  case 21:
                    rptFile = this.Server.MapPath("rpt/OutputEquipment.rpt");
                    report.Load(rptFile);                    
                    report.SetDatabaseLogon(UserID, UserPassword, DBIP, "northwest");                      
                 break;
                 
                 case 22:
                    rptFile = this.Server.MapPath("rpt/turnoverBySalesMen.rpt");
                    report.Load(rptFile);                    
                    report.SetDatabaseLogon(UserID, UserPassword, DBIP, "northwest");
                    report.SetParameterValue("startDate", Request["startDate"] );
                    report.SetParameterValue("endDate", Request["endDate"] );
                 break; 
                 
                 case 23:
                    rptFile = this.Server.MapPath("rpt/Report6.rpt");
                    report.Load(rptFile);                    
                    report.SetDatabaseLogon(UserID, UserPassword, DBIP, "northwest");
                    report.SetParameterValue("date", Request["date"] );
                 break;
                 
                 case 24:
                    rptFile = this.Server.MapPath("rpt/Report7.rpt");
                    report.Load(rptFile);                    
                    report.SetDatabaseLogon(UserID, UserPassword, DBIP, "northwest");
                    report.SetParameterValue("date", Request["date"] );
                 break;
                 
                 case 25:
                    rptFile = this.Server.MapPath("rpt/Report8.rpt");
                    report.Load(rptFile);                    
                    report.SetDatabaseLogon(UserID, UserPassword, DBIP, "northwest");
                    report.SetParameterValue("date", Request["date"] );
                 break;
                 
                  case 26:
                    rptFile = this.Server.MapPath("rpt/Report9.rpt");
                    report.Load(rptFile);                    
                    report.SetDatabaseLogon(UserID, UserPassword, DBIP, "northwest");
                    report.SetParameterValue("startDate", Request["startDate"] );
                    report.SetParameterValue("endDate", Request["endDate"] );
                 break; 
                 
                 case 27:
                    rptFile = this.Server.MapPath("rpt/Report10.rpt");
                    report.Load(rptFile);                    
                    report.SetDatabaseLogon(UserID, UserPassword, DBIP, "northwest");
                    report.SetParameterValue("sdate", Request["sdate"] );
                    report.SetParameterValue("edate", Request["edate"] );
                    report.SetParameterValue("products", "'"+ Request["products"] + "'" );
                    report.SetParameterValue("customerIds", "'"+ Request["customerIds"] + "'" );
                 break; 
                 
                 
                  case 28:
                    rptFile = this.Server.MapPath("rpt/Freight.rpt");
                    report.Load(rptFile);                    
                    report.SetDatabaseLogon(UserID, UserPassword, DBIP, "northwest");                      
                 break;
                 
                   case 29:
                    rptFile = this.Server.MapPath("rpt/Report8_1.rpt");
                    report.Load(rptFile);                    
                    report.SetDatabaseLogon(UserID, UserPassword, DBIP, "northwest");
                    report.SetParameterValue("date", Request["date"] );
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
    
     public void saveDisk1(ReportDocument report, String fileName)
    {       
                    
                System.IO.Stream stream1 = report.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
                //byte[] bytes1 = new byte[stream1.Length];
                //stream1.Read(bytes1, 0, bytes1.Length);
                //stream1.Seek(0, System.IO.SeekOrigin.Begin);                
                SaveStreamToFile(onlinePDF+"\\"+fileName+".pdf", stream1);
    }
    
      public void SaveStreamToFile(string fileFullPath, System.IO.Stream stream)
   {
    if (stream.Length == 0) return;
    // Create a FileStream object to write a stream to a file
    using (System.IO.FileStream fileStream = System.IO.File.Create(fileFullPath, (int)stream.Length))
    {
        // Fill the bytes[] array with the stream data
        byte[] bytesInStream = new byte[stream.Length];
        stream.Read(bytesInStream, 0, (int)bytesInStream.Length);
        // Use FileStream object to write to the specified file
        fileStream.Write(bytesInStream, 0, bytesInStream.Length);
     }
   }
        
   
    
}