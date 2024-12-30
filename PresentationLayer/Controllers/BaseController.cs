namespace PresentationLayer.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BaseController : ControllerBase
{
    #region Content

    protected IActionResult Content(object? obj) 
    {
        return StatusCode(200, JsonConvert.SerializeObject(obj));
    }

    #endregion

    #region Created

    protected IActionResult Created()
    {
        return StatusCode(201, MessageResource.SaveSuccess);
    }

    #endregion


    protected IActionResult Updated()
    {
        return StatusCode(202, MessageResource.SaveSuccess);
    }
    protected IActionResult Deleted()
    {
        return StatusCode(202, MessageResource.DeleteSuccess);
    }
}
