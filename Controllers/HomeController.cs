using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using moment2.Models;
using Microsoft.AspNetCore.Http; // For more help in the session-code
using Newtonsoft.Json;

namespace moment2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // PostModel, Guestbook
        public IActionResult SendData(PostModel model)
        {
            if (ModelState.IsValid)
            {
                // Get
                var JsonStr = System.IO.File.ReadAllText("post.json");
                var JsonObj = JsonConvert.DeserializeObject<List<PostModel>>(JsonStr);
                JsonObj.Add(model);

                // Serialize
                System.IO.File.WriteAllText("post.json", JsonConvert.SerializeObject(JsonObj, Formatting.Indented));

                // Clear
                ModelState.Clear();

                // ViewBag message when sucess
                ViewBag.postMessage = "Inlägget publicerades!";

            }
            return View();
        }

        // Read
        public IActionResult ReadData()
        {
            // Deserialize 
            var JsonStr = System.IO.File.ReadAllText("post.json");
            var JsonObj = JsonConvert.DeserializeObject<IEnumerable<PostModel>>(JsonStr);

            return View(JsonObj);
        }

        // The information page 
        public IActionResult Information()
        {

            // Send with ViewBag
            ViewBag.text = "Hoppas att du har en bra dag!";

            // Sessionsvariabel
            string s = "Här är en länk till programmet: ";
            HttpContext.Session.SetString("test", s); // Läggs i användarunikt ställe på servern, kaka skapas för att hålla reda på utrymmet

            return View();
        }

        public IActionResult Index()
        {
            // Send with ViewData
            ViewData["Message"] = "Min mail är: malin_s@live.se";

            // Read back text
            string s2 = HttpContext.Session.GetString("test");

            // To get it
            ViewBag.text = s2;
            return View();

            
        }

        // Page to show courses i have red
        public IActionResult Courses()
        {

            var JsonStr = System.IO.File.ReadAllText("courses.json");
            var JsonObj = JsonConvert.DeserializeObject<IEnumerable<Courses>>(JsonStr);

            return View(JsonObj);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
