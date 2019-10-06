using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using KworkPracticeTask.Controllers;

namespace KworkPracticeTask.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : KworkPracticeTaskControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
