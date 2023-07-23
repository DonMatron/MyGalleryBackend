using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GalleryController : ControllerBase
    {

        private readonly ILogger<GalleryController> _logger;

        public GalleryController(ILogger<GalleryController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetPreviewPhotos()
        {
            return Ok();
        }
    }
}