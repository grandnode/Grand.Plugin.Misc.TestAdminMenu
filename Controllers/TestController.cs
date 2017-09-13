using Grand.Framework.Controllers;
using Grand.Framework.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Grand.Plugin.Misc.TestAdminMenu.Controllers
{
    [AuthorizeAdmin]
    public class TestAdminMenuController : BasePluginController
    {
        public TestAdminMenuController() { }

        public IActionResult Configure()
        {
            return Content("TestAdminMenu " + DateTime.Now.ToLongDateString());
        }
    }
}