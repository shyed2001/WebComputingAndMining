using Microsoft.AspNetCore.Mvc;


namespace BookExam.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult information()
        {
            var books = new List<Models.Book>
            {
                new Models.Book() { BookID = 1001,  BookName = "Computer Architecture",  BookAddress = "Banglabazar, Dhaka"},
                new Models.Book() { BookID = 1002,  BookName = "Web Computing",  BookAddress = "Banglabazar, Dhaka"},
                new Models.Book() {BookID = 1003,  BookName = "Data Sturcture",  BookAddress = "Banglabazar, Dhaka"}
        };

            //Models.Student st = new Models.Student() { studentID = 1,  studentName = "Rahim",  studentAddress = "Uttara, Dhaka"};

            return View(books);
        }
    }
}
