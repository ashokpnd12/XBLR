using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XBLR.Logic.ViewModel;

namespace XBLR.UI.Controllers
{
    public class HomeController : Controller
    {
        string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\SampleDb.mdb";
        public ActionResult Index()
        {
            //dummy code to fetch data from MS Access
            try
            {
                OleDbConnection conn = new OleDbConnection(connectionString);
                string sql = "select * from tbl_xblr";
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                conn.Open();
                OleDbDataReader reader;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader);
                }
                reader.Close();
                conn.Close();
            }
            catch(Exception ex)
            {
                Console.Write(ex.Message);
            }

            //dummy data for xblr
            List<xblrVM> xblr = new List<xblrVM>()
            {
                new xblrVM { element_name="Disclosure of general information about company [Abstract]",assessment_year="05/10/2018",financial_year="",foot_notes="",specific_business_rule="" },
                new xblrVM { element_name="Disclosure of company information [Abstract]",assessment_year="",financial_year="",foot_notes="",specific_business_rule="" },
                new xblrVM { element_name="Name of company",assessment_year="",financial_year="",foot_notes="",specific_business_rule="" },
                new xblrVM { element_name="Corporate identity number",assessment_year="",financial_year="",foot_notes="",specific_business_rule="" },
                new xblrVM { element_name="Permanent account number of entity",assessment_year="",financial_year="",foot_notes="",specific_business_rule="" },
                new xblrVM { element_name="Address of registered office of company",assessment_year="",financial_year="",foot_notes="",specific_business_rule="" },
                new xblrVM { element_name="Type of industry",assessment_year="",financial_year="11/04/2018",foot_notes="",specific_business_rule="" },
                new xblrVM { element_name="Registration date",assessment_year="",financial_year="",foot_notes="",specific_business_rule="" },
                new xblrVM { element_name="Category/sub-category of company",assessment_year="",financial_year="",foot_notes="",specific_business_rule="" },
                new xblrVM { element_name="whether company is listed company",assessment_year="",financial_year="",foot_notes="",specific_business_rule="" },
                new xblrVM { element_name="Disclosure of document information [Abstract]",assessment_year="",financial_year="",foot_notes="",specific_business_rule="" },
                new xblrVM { element_name="Date of board meeting when final accounts were approved",assessment_year="",financial_year="",foot_notes="",specific_business_rule="" },
                new xblrVM { element_name="Period covered by financial statements",assessment_year="",financial_year="",foot_notes="",specific_business_rule="" },
                new xblrVM { element_name="Date of start of reporting",assessment_year="",financial_year="",foot_notes="",specific_business_rule="" },
                new xblrVM { element_name="Date of end of reporting period",assessment_year="",financial_year="",foot_notes="",specific_business_rule="" },
                new xblrVM { element_name="Nature of report standalone consolidated",assessment_year="",financial_year="",foot_notes="",specific_business_rule="" },
                new xblrVM { element_name="Content of report",assessment_year="",financial_year="",foot_notes="",specific_business_rule="" }
            };
            return View(xblr);
        }
    }
}