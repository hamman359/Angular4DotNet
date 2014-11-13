using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Angular4DotNet.Models.Registration;

namespace Angular4DotNet.Controllers
{
    public class RegistrationController : Controller
    {
		private RegistrationVmBuilder _registrationVmBuilder = new RegistrationVmBuilder();

        // GET: Registration
        public ActionResult Index()
        {
            return View(_registrationVmBuilder.BuildRegistrationVm());
        }
    }
}