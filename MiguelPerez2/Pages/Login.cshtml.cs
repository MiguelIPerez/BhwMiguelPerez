using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MiguelPerez2.ViewModel;
using System;
using System.Threading.Tasks;

namespace MiguelPerez2.Pages
{
    public class LoginModel : PageModel
    {
        private SignInManager<IdentityUser> _signInManager;

        [BindProperty]
        public Login Model { get; set; }

        public LoginModel(SignInManager<IdentityUser> signInManager)
        {
            this._signInManager = signInManager;
        }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            if (ModelState.IsValid)
            {
                var identityResult = await _signInManager.PasswordSignInAsync(Model.Email, Model.Password, Model.RememberMe, false);
                if (identityResult.Succeeded)
                {
                    return RedirectToPage("Index");
                }
                else 
                {
                    return RedirectToPage(returnUrl);
                }
            }
            else
            {
                ModelState.AddModelError(String.Empty, "UserName or Password incorrect");
            }

            return Page();
        }
    }
}
