﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationMVC.Controllers
{
    public class IdentityController : Controller
    {
        private readonly SignInManager<IdentityUser> _signInManager; 
        private readonly UserManager<IdentityUser> _userManager;
        public IdentityController(
            SignInManager<IdentityUser> signInManager, 
            UserManager<IdentityUser> userManager) 
        { 
            _signInManager = signInManager;
            _userManager = userManager; 
        }

        public async Task<IActionResult> AddAdminClaim(string email) 
        { 
            var user = await _userManager.FindByEmailAsync(email); 
            await _userManager.AddClaimAsync(user, new Claim("AdminClaim", string.Empty)); 
            await _signInManager.RefreshSignInAsync(user);
            return RedirectToAction("Create", "Profile"); 
        }

    }
}