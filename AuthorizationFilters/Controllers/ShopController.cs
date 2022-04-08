using Microsoft.AspNetCore.Mvc;

namespace AuthorizationFilters.Controllers;

[ApiController]
[Route("[controller]")]
public class ShopController : ControllerBase
{

    [Authorize] //Default 
    public IActionResult GetAll()
    {
        return Ok();
    }
}
