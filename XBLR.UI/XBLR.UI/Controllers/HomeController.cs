using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XBLR.Data.DataModel;
using XBLR.Logic.ViewModel;

namespace XBLR.UI.Controllers
{
    public class HomeController : Controller
    {
        string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\\MS Access DB\\xblr_db.mdb";
        public ActionResult Index()
        {
            //dummy code to fetch data from MS Access
                List<xblrVM> xbl = new List<xblrVM>();
                OleDbConnection conn = new OleDbConnection(connectionString);
                string sql = "select * from tbl_xblr";
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                conn.Open();
                OleDbDataReader reader;
                reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                xblrVM xb = new xblrVM();
                Console.WriteLine(reader);
                Response.Write("reader: " + reader[0]);
                xb.element_name = (string)reader["element_name"] ?? "";
                xb.assessment_year = reader["assessment_year"] != DBNull.Value ? reader["assessment_year"].ToString().Substring(0, 10) : "";
                xb.financial_year = reader["financial_year"] != DBNull.Value ? reader["financial_year"].ToString().Substring(0, 10) : "";
                xb.foot_notes = (string)reader["foot_notes"] ?? "";
                xb.specific_business_rule = (string)reader["specific_business_rule"] ?? "";
                xbl.Add(xb);
            }
                reader.Close();
                conn.Close();

            //dummy data for xblr
            //List < xblrVM > xblr = new List<xblrVM>()
            //{
            //    new xblrVM { element_name="Disclosure of general information about company [Abstract]",assessment_year="05/10/2018",financial_year="",foot_notes="",specific_business_rule="" },
            //    new xblrVM { element_name="Disclosure of company information [Abstract]",assessment_year="",financial_year="",foot_notes="",specific_business_rule="" },
            //    new xblrVM { element_name="Name of company",assessment_year="",financial_year="",foot_notes="",specific_business_rule="" },
            //    new xblrVM { element_name="Corporate identity number",assessment_year="",financial_year="",foot_notes="",specific_business_rule="" },
            //    new xblrVM { element_name="Permanent account number of entity",assessment_year="",financial_year="",foot_notes="",specific_business_rule="" },
            //    new xblrVM { element_name="Address of registered office of company",assessment_year="",financial_year="",foot_notes="",specific_business_rule="" },
            //    new xblrVM { element_name="Type of industry",assessment_year="",financial_year="11/04/2018",foot_notes="",specific_business_rule="" },
            //    new xblrVM { element_name="Registration date",assessment_year="",financial_year="",foot_notes="",specific_business_rule="" },
            //    new xblrVM { element_name="Category/sub-category of company",assessment_year="",financial_year="",foot_notes="",specific_business_rule="" },
            //    new xblrVM { element_name="whether company is listed company",assessment_year="",financial_year="",foot_notes="",specific_business_rule="" },
            //    new xblrVM { element_name="Disclosure of document information [Abstract]",assessment_year="",financial_year="",foot_notes="",specific_business_rule="" },
            //    new xblrVM { element_name="Date of board meeting when final accounts were approved",assessment_year="",financial_year="",foot_notes="",specific_business_rule="" },
            //    new xblrVM { element_name="Period covered by financial statements",assessment_year="",financial_year="",foot_notes="",specific_business_rule="" },
            //    new xblrVM { element_name="Date of start of reporting",assessment_year="",financial_year="",foot_notes="",specific_business_rule="" },
            //    new xblrVM { element_name="Date of end of reporting period",assessment_year="",financial_year="",foot_notes="",specific_business_rule="" },
            //    new xblrVM { element_name="Nature of report standalone consolidated",assessment_year="",financial_year="",foot_notes="",specific_business_rule="" },
            //    new xblrVM { element_name="Content of report",assessment_year="",financial_year="",foot_notes="",specific_business_rule="" }
            //};
            return View(xbl);
        }
    }
}