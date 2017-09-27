using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyAPI.Controllers
{
    [Route("controller")]
    public class NumbersController : Controller
    {
        // Responsible to get HTTP request
        [HttpGet] // Attribute
        public IActionResult Get()
        {
            // Get list of num's
            var numbers = new List<int> { 1, 2 };
            // return num's collection
            return Json(numbers); 
        }

        [HttpGet("{number}")]   // in the web url //numbers/5
        public IActionResult GetNumbers(int number)
        {
            return Content(number.ToString());
        }

        [HttpPost] 
        public IActionResult Post(int number) 
        {
            return Accepted($"/numbers{number}");
        }

        [HttpDelete]
        public IActionResult Delete(int number)
        {
            return NoContent();
        }
    }

    
}
