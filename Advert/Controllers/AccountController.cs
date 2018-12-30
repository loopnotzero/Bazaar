﻿using System;
using System.Net;
using System.Threading.Tasks;
using Advert.Managers;
using Advert.Models.Users;
using Advert.MongoDbStorage.Profiles;
using Advert.MongoDbStorage.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Advert.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILogger _logger;
        private readonly UserManager<MongoDbUser> _userManager;
        private readonly SignInManager<MongoDbUser> _signInManager;
        private readonly ProfilesManager<MongoDbProfile> _profilesManager;
        
        public AccountController(ILoggerFactory loggerFactory, ILookupNormalizer keyNormalizer, IConfiguration configuration, UserManager<MongoDbUser> userManager, SignInManager<MongoDbUser> signInManager, ProfilesManager<MongoDbProfile> profilesManager)
        {
            _logger = loggerFactory.CreateLogger<AccountController>();
            _userManager = userManager;
            _signInManager = signInManager;
            _profilesManager = profilesManager;
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("/Account/LogIn")]
        public IActionResult LogIn([FromQuery(Name = "returnUrl")] string returnUrl = null)
        {
            ViewData["returnUrl"] = returnUrl;
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("/Account/SignUp")]
        public IActionResult SignUp([FromQuery(Name = "returnUrl")] string returnUrl = null)
        {
            ViewData["returnUrl"] = returnUrl;
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("/Account/SignOut")]
        public async Task<IActionResult> SignOut([FromQuery(Name = "returnUrl")] string returnUrl = null)
        {
            try
            {
                ViewData["returnUrl"] = returnUrl;
                
                await _signInManager.SignOutAsync();

                returnUrl = Uri.UnescapeDataString(returnUrl);
                
                return Ok(new
                {
                    returnUrl
                });
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, e);
                return new StatusCodeResult((int) HttpStatusCode.InternalServerError);
            }
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        [Route("/Account/LogIn")]
        public async Task<IActionResult> LogIn(LogInModel model, [FromQuery(Name = "returnUrl")] string returnUrl = null)
        {
            try
            {
                ViewData["returnUrl"] = returnUrl;

                if (!ModelState.IsValid)
                {
                    return View(model);
                }

                await _signInManager.PasswordSignInAsync(model.Email, model.Password, false, false);

                returnUrl = Uri.UnescapeDataString(returnUrl);
                
                return RedirectToLocal(returnUrl);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, e);
                return new StatusCodeResult((int) HttpStatusCode.InternalServerError);
            }           
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        [Route("/Account/SignUp/{returnUrl?}")]
        public async Task<IActionResult> SignUp([FromBody] SignUpModel model, [FromQuery(Name = "returnUrl")] string returnUrl = null)
        {
            try
            {
                ViewData["returnUrl"] = returnUrl;

                var user = new MongoDbUser
                {
                    Email = model.Email,
                    UserName = model.Email,
                };

                await _userManager.CreateAsync(user, model.Password);

                await _signInManager.SignInAsync(user, false);

                await _profilesManager.CreateProfileAsync(new MongoDbProfile
                {
                    Name = model.Name,
                    Email = model.Email,
                    Culture = model.Culture,
                    CreatedAt = DateTime.UtcNow,
                });

                returnUrl = Uri.UnescapeDataString(returnUrl);

                return Ok(new
                {
                    returnUrl
                });
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, e);
                return new StatusCodeResult((int) HttpStatusCode.InternalServerError);
            }
        }


        private IActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }

            return RedirectToAction(nameof(AdsTopicsController.GetAdsTopics), "AdsTopics");       
        }
    }
}