using DemoAzureStorage.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace DemoAzureStorage.Api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly FileUploud _fileUpload;

        public HomeController(FileUploud fileUpload)
        {
            _fileUpload = fileUpload;
        }

        [HttpPost]
        public IActionResult Post([FromBody] UploadImageCommand command)
        {
            return Ok(_fileUpload.UploadBase64Image(command.Image, "demo"));
        }
    }

    public class UploadImageCommand 
    {
        public string Image { get; set; }
    }
}