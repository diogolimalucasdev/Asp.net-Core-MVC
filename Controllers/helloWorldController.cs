using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;


namespace SixDevMovie.Controllers
{
    public class helloWorld : Controller
    {

        //GET: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }


        //GET: /HelloWorld/Welcome/

        public  IActionResult Welcome( string name, int numTimes = 1)
        {
           // return HtmlEncoder.Default.Encode($"Ola {name} camisa {id}");
           ViewData["Message"] = "Ola" + name;
           ViewData["NumTimes"] = numTimes;
           return View();
        }


    }
}