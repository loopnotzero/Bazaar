﻿using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Advert.Managers;
using Advert.Models.Post;
using Advert.Models.Profiles;
using Advert.MongoDbStorage.Posts;
using Advert.MongoDbStorage.Profiles;
using Humanizer;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MongoDB.Bson;

namespace Advert.Controllers
{
    public class ProfilesController : Controller
    {
        private readonly ILogger _logger;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly ProfilesManager<MongoDbProfile> _profilesManager;
        private readonly ProfilesImagesManager<MongoDbProfileImage> _profilesImagesManager;
        private readonly PostsManager<MongoDbPost> _postsManager;
        
        private const string NoProfileImage = "/images/no-image.png";

        public ProfilesController(ILoggerFactory loggerFactory, IHostingEnvironment hostingEnvironment, 
            ProfilesManager<MongoDbProfile> profilesManager,
            ProfilesImagesManager<MongoDbProfileImage> profilesImagesManager,
            PostsManager<MongoDbPost> postsManager)
        {
            _logger = loggerFactory.CreateLogger<ProfilesController>();
            _hostingEnvironment = hostingEnvironment;
            _profilesManager = profilesManager;
            _profilesImagesManager = profilesImagesManager;
            _postsManager = postsManager;
        }

        [HttpGet]
        [Route("/{profileName}")]
        public async Task<IActionResult> GetProfile(string profileName)
        {
            try
            {
                var profile = await _profilesManager.FindProfileByNormalizedNameAsync(profileName);

                return View(new PostsAggregatorViewModel
                {
                    Profile = new ProfileModel
                    {
                        Id = profile.Id.ToString(),
                        ProfileName = profile.Name,
                        ProfileDescription = profile.Description,
                        ImagePath = profile.ImagePath,
                        PostsCount = ((double) 0).ToMetric(),
                    }
                });
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, e);
                return new StatusCodeResult((int) HttpStatusCode.InternalServerError);
            }
        }

        [HttpGet]
        [Route("/{profileName}/Posts")]
        public async Task<IActionResult> GetProfilePosts(string profileName)
        {
            try
            {
                var profile = await _profilesManager.FindProfileByNormalizedNameAsync(profileName);

                var posts = await _postsManager.FindPostsByProfileIdAsync(profile.Id);

                return View(new PostsAggregatorViewModel
                {
                    Profile = new ProfileModel
                    {
                        Id = profile.Id.ToString(),
                        ProfileName = profile.Name,
                        ProfileDescription = profile.Description,
                        ImagePath = profile.ImagePath,
                        PostsCount = ((double) 0).ToMetric(),
                    },
                    
                    Posts = posts.Select(post => new PostViewModel
                    {
                        PostId = post.Id.ToString(),
                        ProfileId = post.ProfileId.ToString(),
                        ProfileName = post.ProfileName,
                        ProfileImagePath = post.ProfileImagePath ?? NoProfileImage,
                        Text = post.Text.Length > 1000 ? post.Text.Substring(0, 1000) + "..." : post.Text,
                        Title = post.Title,
                        Price = post.Price,
                        Currency = post.Currency,
                        Location = post.Location,
                        Tags = post.Tags,
                        LikesCount = ((double) post.LikesCount).ToMetric(),
                        SharesCount = ((double) 0).ToMetric(),
                        ViewsCount = ((double) post.ViewsCount).ToMetric(),
                        CommentsCount = ((double) post.CommentsCount).ToMetric(),
                        CreatedAt = post.CreatedAt.Humanize(),
//                        IsPostVoted = postsVotes.Any(x => x.PostId.Equals(post.Id) && x.ProfileId.Equals(profile.Id)),
                        IsTopicOwner = post.ProfileId.Equals(profile.Id)
                    }),
                });
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, e);
                return new StatusCodeResult((int) HttpStatusCode.InternalServerError);
            }
        }
    }
}