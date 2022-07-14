using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MiguelPerez2.Interfaces;
using MiguelPerez2.ViewModel;
using System.Threading.Tasks;

namespace MiguelPerez2.Pages
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private IElectrodomesticManager _manager;

        [BindProperty]
        public Electrodomestic Model { get; set; }

        public CreateModel(IElectrodomesticManager manager)
        {
            this._manager = manager;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                await this._manager.PostAsync(new Models.Electrodomestic
                {
                    Description = this.Model.Description,
                    Name = this.Model.Name,
                    Quantity = this.Model.Quantity
                });

                return RedirectToPage("Index");
            }

            return Page();
        }
    }
}
