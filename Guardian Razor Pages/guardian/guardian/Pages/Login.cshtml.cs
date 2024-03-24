using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using guardian.Data;
using guardian.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.General;

namespace guardian.Pages
{
    public class Login : PageModel
    {
        private readonly guardian.Data.GuardianDbContext _context;
        private readonly UserManager<IdentityApplicationUser> _userManager;
        private readonly SignInManager<IdentityApplicationUser> _signInManager;

        public Login(guardian.Data.GuardianDbContext context, UserManager<IdentityApplicationUser> userManager, SignInManager<IdentityApplicationUser> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public string Username { get; set; }
        public string Password { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(Username);
                if (user != null)
                {
                    var result = await _signInManager.PasswordSignInAsync(Username, Password, false, lockoutOnFailure: false);
                    if (result.Succeeded)
                    {
                        // Redirect to the home page or the intended page after successful login
                        return RedirectToPage("./Index");
                    }
                }

                // Invalid username or password, display error message
                ModelState.AddModelError(string.Empty, "Invalid username or password");
                return Page();
            }

            // Model validation failed, redisplay the login page with validation errors
            return Page();
        }
    }
}
