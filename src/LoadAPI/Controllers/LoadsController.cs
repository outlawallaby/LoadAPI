using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace LoadAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController] // provide Automatic 400 Error response, problem details and binding sourse 
    public class LoadsController:ControllerBase //Can inherit from Controller if View needed, othervise ControllerBase used for inheritance 
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] {"this","is","hard","coded"};
        }
    }
}