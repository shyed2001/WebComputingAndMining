using Microsoft.AspNetCore.Mvc;


namespace BookExam.Controllers
{
    public class ResearchController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ResearchDetails()
        {
            var rs = new List<Models.Research>
            {
                new Models.Research() { ResearchID = 1,  ResearchTitle = "Reduce Water pollution in Turag river ",  PrincipleInvestigator = "Prof. Dr Rahmat Ullah", Fund= "200000.00 Taka"},
                new Models.Research() { ResearchID = 2,  ResearchTitle = "Reduce Sound pollution in Dhaka City",   PrincipleInvestigator = "Prof. Dr Aman Ullah", Fund= "300000.00 Taka"},
                new Models.Research() {ResearchID = 3,  ResearchTitle = "Reduce Air polutioin in Dhaka City",   PrincipleInvestigator = "Prof. Dr Wali Ullah", Fund= "400000.00 Taka"}
        };

            //Models.Student st = new Models.Student() { studentID = 1,  studentName = "Rahim",  studentAddress = "Uttara, Dhaka"};

            return View(rs);
        }
    }
}
