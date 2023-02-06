using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceBasedRabbit.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RestServiceController : ControllerBase
    {
       


        public RestServiceController()
        {
            
        }




        [HttpPost()]
        public async Task<IActionResult> PostUserItemAsync()
        {
            // Validation

            //var result = await _userItemService.PostUserItemAsync(userItem);

            //if (!result.Success)
            //    return BadRequest(result.Message);

            //var categoryResource = _mapper.Map<Category, CategoryResource>(result.Category);
            // return Ok(categoryResource);

            return null;
        }



        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserItemAsync(int id)
        {
            // Validation

            //var result = await _userItemService.DeleteUserItemAsync(id);

            //if (!result.Success)
            //    return BadRequest(result.Message);

            //var categoryResource = _mapper.Map<Category, CategoryResource>(result.Category);
            // return Ok(categoryResource);

            return null;
        }
    }
}
