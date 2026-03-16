using System.Diagnostics;
using GerenciamentoFinanceiroCurso.Models;
using Microsoft.AspNetCore.Mvc;

namespace GerenciamentoFinanceiroCurso.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
