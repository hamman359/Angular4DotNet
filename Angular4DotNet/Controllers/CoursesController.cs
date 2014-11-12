using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Angular4DotNet.Controllers
{
    public class CoursesController : Controller
    {
        // GET: Courses
        public ActionResult Index()
        {
            return View("Index", "", GetSerializedCourseVms());
        }

		private string GetSerializedCourseVms()
		{
			var courses = new [] {
				new CourseVm {Number = "CREA101", Name = "Care of Magical Creatures", Instructor = "Rubeus Hagrid"},
				new CourseVm {Number = "DARK502", Name = "Defence Against the Dark Arts", Instructor = "Severus Snape"},
				new CourseVm {Number = "TRAN201", Name= "Transfiguration", Instructor = "Minerva McGonagall"}
			};

			var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
			return JsonConvert.SerializeObject(courses, Formatting.None, settings);
		}
    }

	public class CourseVm
	{
		public string Number { get; set; }
		public string Name { get; set; }
		public string Instructor { get; set; }
	}
}