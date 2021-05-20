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
            // var userProfile = _mapper.Map<UserProfile>(userProfileDTO);
             //var user = _userManager.Users.Include(x => x.UserProfile).SingleOrDefault(u => u.UserName == userEmail);
            // userProfile.User = user;
            //var userCategories = new List<UserCategory>();
            var userProfile = _mapper.Map<UserProfile>(userProfileDTO);
            //var userProfileInDb = _profileRepository.ListAsync().Result.Where(x => x.User.UserName == userEmail).Single();
            var spec = new UserWithCategoriesSpecification(userProfileDTO.Id);
            

            var userProfileInDb = _profileRepository.GetBySpecification(spec).Result;

            userProfileInDb.FacebookURL = userProfile.FacebookURL;
            userProfileInDb.InstagramURL = userProfile.InstagramURL;
            userProfileInDb.Gender = userProfile.Gender;
            userProfileInDb.WorkDescription = userProfile.WorkDescription;
            userProfileInDb.UserCategories.Clear();

            var userSelectedCategories = userCategories.Where(x => x.Selected == true);
            //await _userCategoryRepository.DeleteRangeAsync(userProfileInDb.UserCategories);
            if (userSelectedCategories.Count() > 0)
            {
                foreach (var cat in userSelectedCategories)
                {
                    var categoryFromDbDTO = _categoryRepository.GetByIdAsync(cat.CategoryId).Result;
                    var categoryFromDb = _mapper.Map<Category>(categoryFromDbDTO);
                    if (categoryFromDb != null)
                    {
                        //await _userCategoryRepository.AddAsync(new UserCategory { UserId = userProfileInDb.Id, CategoryId = categoryFromDb.Id });
                        userProfileInDb.UserCategories.Add(new UserCategory { User = userProfileInDb, Category = categoryFromDb });
                    }
                }

            }

            if (userProfileDTO.ActualImage != null)
            {
                if(userProfileInDb.Image != null)
                {
                    var OldfilePath = Path.Combine(_env.WebRootPath,  userProfileInDb.Image.Replace("/", "\\").Remove(0, 1));
                    File.Delete(OldfilePath);
                }

                //var a = "http://catalogbaseurltobereplaced/";
                var fileName = Path.GetFileName(userProfileDTO.ActualImage.FileName);
                var newName = Guid.NewGuid().ToString("n").Substring(0, 8) + Path.GetExtension(userProfileDTO.ActualImage.FileName);
                var filePath = Path.Combine(_env.WebRootPath, "images\\profile", newName);


                userProfileInDb.Image = "/images/profile/" + newName;



                using (var fileSteam = new FileStream(filePath, FileMode.Create))
                {
                    await userProfileDTO.ActualImage.CopyToAsync(fileSteam);
                }
            }
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

        public UserProfileDTO GetUserProfileDTO(string userName)
        {
            //var userProfile = _profileRepository.GetByIdAsync(5);
            var user = _userManager.Users
                .Include(u => u.UserProfile)
                .ThenInclude(u => u.UserCategories)
                .ThenInclude(u => u.Category)
                .SingleOrDefault(u => u.UserName == userName);
            // var user = _userManager.FindByEmailAsync(userEmail).Result;
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