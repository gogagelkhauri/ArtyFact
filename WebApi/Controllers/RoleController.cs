using System.Linq;
using System.Threading.Tasks;
using Domain.Entities.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using WebApi.Helpers;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoleController : ControllerBase
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;
        public RoleController(RoleManager<IdentityRole> roleManager,UserManager<ApplicationUser> userManager)
        {
            _roleManager = roleManager;
             _userManager = userManager;
        }
        
        [HttpGet("GetRoles")]
        public async Task<IActionResult> GetRoles()
        {
            var roles = await _roleManager.Roles.ToListAsync();
            return Ok(roles);
        }

        [HttpPost("CreateRole")]
        public async Task<IActionResult> CreateRole([BindRequired] string roleName)
        {
            if(string.IsNullOrWhiteSpace(roleName))
            {
                return BadRequest("Role name should be provided.");
            }

            var newRole = new IdentityRole
            {
                Name = roleName
            };

            var roleResult = await _roleManager.CreateAsync(newRole);
            

            if (roleResult.Succeeded)
            {
                return Ok();
            }

            return Problem(roleResult.Errors.First().Description, null, 500);
        }

        [HttpDelete("DeleteRole")]
        public async Task<IActionResult> DeleteRole([BindRequired] string id)
        {
            if(ModelState.IsValid)
            {
                var role = await _roleManager.FindByIdAsync(id);
                await _roleManager.DeleteAsync(role);
                return Ok("success");
            }
            return BadRequest(ModelState.GetModelStateErrors());
        }

        [HttpPut("UpdateRole")]
        public async Task<IActionResult> UpdateRole([BindRequired] string id,[BindRequired] string name)
        {
            if(ModelState.IsValid)
            {
                var role = await _roleManager.FindByIdAsync(id);
                role.Name = name;
                
                await _roleManager.UpdateAsync(role);

                return Ok(role);
            }
            return BadRequest(ModelState.GetModelStateErrors());
        }

        [HttpPost("User/{userEmail}/AddRole")]
        public async Task<IActionResult> AddUserToRole(string userEmail, /*[FromBody]*/[BindRequired] string roleName)
        {
            var user = _userManager.Users.SingleOrDefault(u => u.UserName == userEmail);

            var result = await _userManager.AddToRoleAsync(user, roleName);

            if (result.Succeeded)
            {
                return Ok();
            }

            return Problem(result.Errors.First().Description, null, 500);
        }
    }
}