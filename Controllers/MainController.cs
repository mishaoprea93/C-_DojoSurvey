		using Microsoft.AspNetCore.Http;
		using Microsoft.AspNetCore.Mvc;
		using System;
		namespace dojoSurvey.Controllers {
			
		    public class MainController : Controller {
				public int count=0;

		        [Route ("")]
		        [HttpGet]

		        public IActionResult Index () {
		            return View ("Index");
		        }

                [Route("/result")]
                [HttpPost]

                public IActionResult Result(string Name,string Location,string Language,string Comment ){
					count++;					
                    ViewBag.name=Name;
					ViewBag.location=Location;
					ViewBag.language=Language;
					ViewBag.comment=Comment;
					ViewBag.count=count;
                    return View("Result");
                }
		    }
		}