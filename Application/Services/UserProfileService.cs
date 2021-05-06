using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain.DTO;
using Domain.Entities;
using Domain.Entities.User;
using Domain.Interfaces;
using Domain.Interfaces.Services;
using Domain.Specifications;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Application.Services
{
    public class UserProfileService : IUserProfileService
    {
        private readonly IRepository<UserProfile> _profileRepository;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IRepository<Category> _categoryRepository;
        private readonly IMapper _mapper;
        public UserProfileService(IRepository<UserProfile> profileRepository,
        UserManager<ApplicationUser> userManager,
        IRepository<Category> categoryRepository,        
        IMapper mapper)
        {
            _profileRepository = profileRepository;
            _userManager = userManager;
            _mapper = mapper;
            _categoryRepository = categoryRepository;
        }

        public async Task UpdateUserProfile(int id, UserProfileDTO userProfileDTO)
        {
            // var userProfile = _mapper.Map<UserProfile>(userProfileDTO);
             //var user = _userManager.Users.Include(x => x.UserProfile).SingleOrDefault(u => u.UserName == userEmail);
            // userProfile.User = user;
            var userCategories = new List<UserCategory>();
            var userProfile = _mapper.Map<UserProfile>(userProfileDTO);
            //var userProfileInDb = _profileRepository.ListAsync().Result.Where(x => x.User.UserName == userEmail).Single();
            var spec = new BasketWithItemsSpecification(id);
            

            var userProfileInDb = _profileRepository.GetBySpecification(spec).Result;

            userProfileInDb.FacebookURL = userProfile.FacebookURL;
            userProfileInDb.InstagramURL = userProfile.InstagramURL;
            userProfileInDb.Gender = userProfile.Gender;
            userProfileInDb.Image = userProfile.Image;
            userProfileInDb.WorkDescription = userProfile.WorkDescription;
            // _profileRepository.TryUpdateManyToMany(userProfileInDb.UserCategories, userProfile.UserCategories)
            // .Select(x => new UserCategory
            // {
            //     UserId = userProfileInDb.UserId,
            //     CategoryId = x.CategoryId
            // }), x => x.CategoryId);
            
            // if(userProfileDTO.UserCategories.Count > 0)
            // {
                
            //     foreach(var cat in userProfileDTO.UserCategories)
            //     {
            //         var category = _categoryRepository.GetByIdAsync(cat.CategoryId).Result; //_mapper.Map<Category>(cat);
                   
            //         var usercat = new UserCategory
            //         {
            //             User = userProfileInDb,
            //             Category = category
            //         };
            //         // if(!userProfileInDb.UserCategories.Contains(usercat))
            //         // {
            //             userCategories.Add(usercat);
            //        // }
            //     }
            //     userProfileInDb.UserCategories.AddRange(userCategories);
            // }
            //var user = _userManager.FindByEmailAsync(userEmail).Result;
             //var user = _userManager.Users.Include(x => x.UserProfile).SingleOrDefault(u => u.UserName == userEmail);
            
            //userProfile.Id = userProfileInDb.Id;
            await _profileRepository.UpdateAsync(userProfileInDb);
           
            //user.UserProfile = userProfile;
            //await _userManager.UpdateAsync(user);

            //await _profileRepository.AddAsync(userProfile);
        }

        public UserProfileDTO GetUserProfile(string userEmail)
        {
            //var userProfile = _profileRepository.GetByIdAsync(5);
            var user = _userManager.Users.Include(u => u.UserProfile).Include(u => u.UserProfile.UserCategories).SingleOrDefault(u => u.UserName == userEmail);
           // var user = _userManager.FindByEmailAsync(userEmail).Result;
            var userProfile = user.UserProfile;
           

            
            var userProfileDTO = _mapper.Map<UserProfileDTO>(userProfile);
            return userProfileDTO;
        }

    }
}