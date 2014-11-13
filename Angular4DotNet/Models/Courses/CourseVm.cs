using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Angular4DotNet.Models.Courses
{
	public class CourseVm
	{
		public string Number { get; set; }
		public string Name { get; set; }
		public string Instructor { get; set; }
	}
}

