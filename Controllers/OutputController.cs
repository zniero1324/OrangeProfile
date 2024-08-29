using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace OKProfile.Controllers
{
    public class OutputController : Controller
    {
        public IActionResult DownloadFile()
        {
            // Path to the file to download
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "lib", "CV.pdf");

            // Ensure the file exists
            if (!System.IO.File.Exists(filePath))
            {
                return NotFound();
            }

            // Return the file directly as a PhysicalFileResult
            var fileName = "CV.pdf";
            return PhysicalFile(filePath, "application/pdf", fileName);
        }
    }
}
