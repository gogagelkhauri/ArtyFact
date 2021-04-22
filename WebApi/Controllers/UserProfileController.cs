using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.DTOs;
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
        public UserProfile GetUserProfile(string userEmail)
        {
            var userProfile = _userProfileService.GetUserProfile(userEmail);
            return userProfile;
        }

        [HttpPost("AddUserProfile")]
        public async Task<IActionResult> AddUserProfile(string userEmail,[FromBody] UserProfile userProfile)
        {
            if(ModelState.IsValid)
            {
                await _userProfileService.AddUserProfile(userEmail,userProfile);
                return Ok();
            }

            return BadRequest(ModelState.GetModelStateErrors());
        }
    }
}