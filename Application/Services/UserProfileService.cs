using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain.DTO;
using Domain.Entities;
using Domain.Entities.User;
using Domain.Interfaces;
using Domain.Interfaces.Services;
using Domain.Specifications;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Application.Services
{
    public class UserProfileService : IUserProfileService
    {
        private readonly IRepository<UserProfile> _profileRepository;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IRepository<Category> _categoryRepository;
        //private readonly IRepository<UserCategory> _userCategoryRepository;
        private readonly IMapper _mapper;
        private readonly IHostingEnvironment _env;

        public UserProfileService(IRepository<UserProfile> profileRepository,
        UserManager<ApplicationUser> userManager,
        IRepository<Category> categoryRepository,
        //IRepository<UserCategory> userCategoryRepository,
        IHostingEnvironment env,
        IMapper mapper)
        {
            _profileRepository = profileRepository;
            _userManager = userManager;
            _mapper = mapper;
            _categoryRepository = categoryRepository;
            //_userCategoryRepository = userCategoryRepository;
            _env = env;
        }

        public async Task UpdateUserProfile(UserProfileDTO userProfileDTO,List<ManageUserCategories> userCategories)
        {
            var userProfile = _mapper.Map<UserProfile>(userProfileDTO);
            var spec = new UserWithCategoriesSpecification(userProfileDTO.Id);
            var userProfileInDb = _profileRepository.GetBySpecification(spec).Result;

            userProfileInDb.FacebookURL = userProfile.FacebookURL;
            userProfileInDb.InstagramURL = userProfile.InstagramURL;
            userProfileInDb.Gender = userProfile.Gender;
            userProfileInDb.WorkDescription = userProfile.WorkDescription;

            //clear and assign user to categories
            userProfileInDb.UserCategories.Clear();
            var userSelectedCategories = userCategories.Where(x => x.Selected == true);
            if (userSelectedCategories.Count() > 0)
            {
                foreach (var cat in userSelectedCategories)
                {
                    var categoryFromDbDTO = _categoryRepository.GetByIdAsync(cat.CategoryId).Result;
                    var categoryFromDb = _mapper.Map<Category>(categoryFromDbDTO);
                    if (categoryFromDb != null)
                    {
                        userProfileInDb.UserCategories.Add(new UserCategory { User = userProfileInDb, Category = categoryFromDb });
                    }
                }
            }

            //upload profile image
            if (userProfileDTO.ActualImage != null)
            {
                if(userProfileInDb.Image != null)
                {
                    var OldfilePath = Path.Combine(_env.WebRootPath,  userProfileInDb.Image.Replace("/", "\\").Remove(0, 1));
                    File.Delete(OldfilePath);
                }

                var fileName = Path.GetFileName(userProfileDTO.ActualImage.FileName);
                var newName = Guid.NewGuid().ToString("n").Substring(0, 8) + Path.GetExtension(userProfileDTO.ActualImage.FileName);
                var filePath = Path.Combine(_env.WebRootPath, "images\\profile", newName);
                userProfileInDb.Image = "/images/profile/" + newName;


                using (var fileSteam = new FileStream(filePath, FileMode.Create))
                {
                    await userProfileDTO.ActualImage.CopyToAsync(fileSteam);
                }
            }

            await _profileRepository.UpdateAsync(userProfileInDb);
        }

        public UserProfileDTO GetUserProfileDTO(string userName)
        {
            var user = _userManager.Users
                .Include(u => u.UserProfile)
                .ThenInclude(u => u.UserCategories)
                .ThenInclude(u => u.Category)
                .SingleOrDefault(u => u.UserName == userName);
            var userProfile = user.UserProfile;

            var userProfileDTO = _mapper.Map<UserProfileDTO>(userProfile);
            return userProfileDTO;
        }

        public ApplicationUser GetUserProfile(string userEmail)
        {
            var user = _userManager.Users.Include(u => u.UserProfile)
                                        .ThenInclude(u => u.UserCategories)
                                        .ThenInclude(u => u.Category)
                                        .SingleOrDefault(u => u.UserName == userEmail);

            return user;
        }

    }
}