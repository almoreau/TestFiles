using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace CheckFiles.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {
        [HttpGet("{directory?}")]
        public IActionResult GetDirectories(string? directory = null)
        {
            var basePath = directory != null ? Path.Combine("\\\\srv-smi-adm-jp1\\c$\\archives", directory) : "\\\\srv-smi-adm-jp1\\c$\\archives";
            var directories = Directory.GetDirectories(basePath);
            var files = Directory.GetFiles(basePath);

            return Ok(new { Directories = directories, Files = files });
        }
    }

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
