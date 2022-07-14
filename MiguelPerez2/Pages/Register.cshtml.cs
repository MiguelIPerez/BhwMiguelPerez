using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MiguelPerez2.ViewModel;
using System.Threading.Tasks;

namespace MiguelPerez2.Pages
{
    public class RegisterModel : PageModel
    {
        private UserManager<IdentityUser> _userManager;
        private SignInManager<IdentityUser> _signInManager;

        [BindProperty]
        public Register Model { get; set; }

        public RegisterModel(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
        }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser();
                user.Email = Model.Email;
                user.UserName = Model.Email;

                var result = await this._userManager.CreateAsync(user, Model.Password);

                if (result.Succeeded)
                {
                    await this._signInManager.SignInAsync(user, false);
                    return RedirectToPage("Index");
                }
                else
                {
                    foreach (var errorItem in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, errorItem.Description);
                    }
                }
            }

            return Page();
        }
    }
}
