using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XBLR.Logic.ViewModel;

namespace XBLR.UI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<xblrVM> xblr = new List<xblrVM>()
            {
                new xblrVM { element_name="Disclosure of general information about company [Abstract]",assessment_year="",financial_year="",foot_notes="",specific_business_rule="" },
                new xblrVM { element_name="Disclosure of company information [Abstract]",assessment_year="",financial_year="",foot_notes="",specific_business_rule="" },
                new xblrVM { element_name="Name of company",assessment_year="",financial_year="",foot_notes="",specific_business_rule="" },
                new xblrVM { element_name="Corporate identity number",assessment_year="",financial_year="",foot_notes="",specific_business_rule="" },
                new xblrVM { element_name="Permanent account number of entity",assessment_year="",financial_year="",foot_notes="",specific_business_rule="" },
                new xblrVM { element_name="Address of registered office of company",assessment_year="",financial_year="",foot_notes="",specific_business_rule="" },
                new xblrVM { element_name="Type of industry",assessment_year="",financial_year="",foot_notes="",specific_business_rule="" },
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