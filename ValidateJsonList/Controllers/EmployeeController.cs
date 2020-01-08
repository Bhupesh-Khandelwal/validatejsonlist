namespace ValidateJsonList.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using ValidateJsonList.Models;

    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpPost]
        [Route("PostData")]
        public ActionResult PostData(Employees employee)
        {
            return Ok();
        }
    }
}