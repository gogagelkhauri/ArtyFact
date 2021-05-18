using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.DTO;
using Domain.Entities;
using Domain.Entities.User;
using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using WebApi.Helpers;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserProfileController : ControllerBase
    {
        private readonly IUserProfileService _userProfileService;
        public UserProfileController(IUserProfileService userProfileService)
        {
            _userProfileService = userProfileService;
        }

        [HttpGet("GetUserProfile")]
        public IActionResult GetUserProfile(string userEmail)
        {
            var userProfile = _userProfileService.GetUserProfile(userEmail);
            return Ok(userProfile);
        }

        [HttpPost("UpdateUserProfile")]
        public async Task<IActionResult> UpdateUserProfile(int id,[FromBody] UserProfileDTO userProfile)
        {
            if(ModelState.IsValid)
            {
                await _userProfileService.UpdateUserProfile(userProfile);
                return Ok();
            }

            return BadRequest(ModelState.GetModelStateErrors());
        }
    }
}