using DNTFrameworkCore.ForexToolsWebApp.Models;
using DNTFrameworkCore.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace DNTFrameworkCore.ForexToolsWebApp.Controllers
{
    public class SharedController : Controller
    {
        [HttpGet, AjaxOnly]
        public IActionResult RenderDeleteConfirmation(DeleteConfirmationModel model)
        {
            return PartialView("_DeleteConfirmation", model);
        }
    }
}