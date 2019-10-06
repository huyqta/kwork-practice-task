using Microsoft.AspNetCore.Antiforgery;
using KworkPracticeTask.Controllers;

namespace KworkPracticeTask.Web.Host.Controllers
{
    public class AntiForgeryController : KworkPracticeTaskControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
