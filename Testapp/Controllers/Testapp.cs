using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Testapp.Controllers{
    public class TestappController:Controller{
        [HttpGet]
        [Route("")]
        public IActionResult Index(){
            return View("Index");
        }
    }
}
